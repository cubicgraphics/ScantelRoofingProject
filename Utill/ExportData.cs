using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace ScantelRoofingPrototype
{
    class ExportData
    {
        static string OutputPath = Directory.GetCurrentDirectory() + @"\Export";
        static string EmployeeWagesPath = OutputPath + @"\EmployeeWages";
        static string RoofExportPath = OutputPath + @"\RoofExports";
        static float PayPerSlate = 0.25F;

        private const string Seperator = "\t";


        public static void OutputEmployeeWages(DateTime SelectedMonth, bool OpenFile)
        {
            List<EmployeePeople> employeePeople = EmployeePeople.CombineEmployeePeopleList(Employees.ReadFromFile(), People.ReadFromFile());
            float[] HoursWorked = new float[employeePeople.Count];
            int[] reclaimedSlates = new int[employeePeople.Count];
            string[] Exportstrings = new string[employeePeople.Count + 1];
            List<ReclaimedSlates> EmployeeWork = ReclaimedSlates.ReadFromFile();
            for (int i = 0; i < EmployeeWork.Count; i++)
            {
                if ((EmployeeWork[i].Date.Month == SelectedMonth.Month) && (EmployeeWork[i].Date.Year == SelectedMonth.Year))
                {
                    int index = EmployeePeople.GetListIndexFromID(employeePeople, EmployeeWork[i].EmployeeID);
                    HoursWorked[index] = HoursWorked[index] + (float)EmployeeWork[i].HoursWorked.TotalHours;
                    reclaimedSlates[index] = reclaimedSlates[index] + EmployeeWork[i].Reclaimedslates;
                }
            }
            Exportstrings[0] = "Name" + Seperator + "Hours worked" + Seperator + "Reclaimed slates" + Seperator + "Hourly wage" + Seperator + "Pay total";
            for (int i = 0; i < employeePeople.Count; i++)
            {
                Exportstrings[i+1] = employeePeople[i].Name + Seperator + HoursWorked[i] + Seperator + reclaimedSlates[i] + Seperator + "£" + employeePeople[i].Wages + Seperator + "£" + (HoursWorked[i] * employeePeople[i].Wages + reclaimedSlates[i] * PayPerSlate);
            }
            File.WriteAllLines(EmployeeWagesPath + @"\Wages" + SelectedMonth.Month.ToString() + "_" + SelectedMonth.Year.ToString() + ".txt", Exportstrings);
            string openPath = EmployeeWagesPath;
            if (OpenFile)
            {
                openPath = openPath + @"\Wages" + SelectedMonth.Month.ToString() + "_" + SelectedMonth.Year.ToString() + ".txt";
            }
            Process.Start("explorer.exe", openPath);
        }

        public static void ExportRoof(RoofElevation roof, string[] outputstring, bool OpenFile)
        {
            DateTime now = DateTime.Now;

            File.WriteAllLines(RoofExportPath + @"\Roof" + "_" + roof.Name + "_" + now.Month.ToString() + "_" + now.Year.ToString() + ".txt", outputstring);

            string openPath = RoofExportPath;
            if (OpenFile)
            {
                openPath = openPath + @"\Roof" + "_" + roof.Name + "_" + now.Month.ToString() + "_" + now.Year.ToString() + ".txt";
            }
            Process.Start("explorer.exe", openPath);
        }
        public static string[] CalculateRoof(RoofElevation roof, List<Stocks> stocks)
        {
            if(roof.Scantle == true)
            {
                return CalculateScantleRoof(roof, stocks);
            }
            else
            {
                return CalculatePlainRoof(roof, stocks);
            }
        }

        static float[] Pitches =
        {
            22.5f,
            25f,
            27.5f,
            30f,
            35f,
            40f,
            45f,
            75f,
        };
        static float[] SlateOverlaps =
        {
            0.128f,0.115f,0.110f,0.100f,0.088f,0.075f,0.070f,0.069f
        };


        public static string[] CalculatePlainRoof(RoofElevation roof, List<Stocks> stocks)
        {
            float Overlap = -1;
            for (int i = 0; i < Pitches.Length; i++)
            {
                if (Pitches[i] <= roof.SlantAngle) {
                    Overlap = SlateOverlaps[i];
                    
                }
            }
            Stocks tilemat = Stocks.GetStockFromID(stocks, roof.TileMaterialID);
            Stocks woodmat = Stocks.GetStockFromID(stocks, roof.WoodMaterialID);
            if (Overlap < 0)
            {
                return new string[] { "Not enough overlap"};
            }
            float layerlength = tilemat.LengthIfSlate - Overlap; //the overlap on tiles
            int amountdown = (int)(roof.Length / layerlength); //the amount of tiles going down the roof
            int amountacross = (int)(roof.Width / tilemat.WidthIfSlate); //the amount going across the roof
            int EstimatedTiles = amountdown * amountacross; //estimated amount of tiles
            int EstimatedTilesOverflow = (int)(EstimatedTiles * 1.05); //estimated amount of tiles + overflow
            float EstimatedTileCost = EstimatedTiles * tilemat.Cost; //estimated overall cost of tiles
            float RaftersAmountEstimate = (amountdown * roof.Width) + (float)(roof.Width)*roof.Length; // estimated amount of rafter (a line per course + a line down per M of roof across)
            float RaftersAmountOverflow = (float)(RaftersAmountEstimate * 1.05); //estimated amout of rafter + overflow
            float RaftersCostEstimate = RaftersAmountOverflow * woodmat.Cost;//estimated overall cost of rafter
            int currentAmountOfTileMaterial = (int)tilemat.CurrentAmount;//Current amount of tiles in stock
            int requiredAmountOfTileMaterialToBuy = (int)Math.Max(0, EstimatedTilesOverflow - tilemat.CurrentAmount); //Amount of tiles needed to be bought
            float TileMaterialToBuyEstimatedCost = requiredAmountOfTileMaterialToBuy * tilemat.Cost; //cost of the tiles needed to be bought
            float currentAmountOfWoodMaterial = (int)woodmat.CurrentAmount;//Current amount of rafter in stock
            float requiredAmountOfWoodMaterialToBuy = (int)Math.Max(0, RaftersAmountOverflow - woodmat.CurrentAmount);//Amount of the rafter needed to be bought
            float WoodMaterialToBuyEstimatedCost = requiredAmountOfWoodMaterialToBuy * woodmat.Cost; //cost of the rafter needed to be bought

            float TotalMaterialCost = EstimatedTileCost + RaftersCostEstimate;
            float RequiredMaterialCost = TileMaterialToBuyEstimatedCost + WoodMaterialToBuyEstimatedCost;

            string[] output =
            {
                "Roof: " + roof.Name,
                "Dimensions ",
                "Height: " + roof.Length * Math.Sin((Math.PI / 180) * roof.SlantAngle) + " M",
                "Width:  " + roof.Width + " M",
                "Hypotenuse(Length from top to bottom of the tiles): " + roof.Length + " M",
                "Inclination: " + roof.SlantAngle + " degrees",
                "",
                "Tile Name: " + tilemat.Name,
                "Estimated Courses: " + amountdown,
                "Estimated Tiles per course: " + amountacross,
                "Estimated tiles needed (plus 5%): " + EstimatedTilesOverflow,
                "Estimated cost of all tiles: £" + EstimatedTileCost,
                "Tiles currently in stock: " + currentAmountOfTileMaterial ,
                "Amount needed to purchase: " + requiredAmountOfTileMaterialToBuy,
                "Cost: £" + TileMaterialToBuyEstimatedCost,

                "",
                "Rafter Type: " + woodmat.Name,
                "Estimated length of rafter required (plus 5%): " + RaftersAmountOverflow,
                "Estimated cost of rafters: £" + RaftersCostEstimate,
                "rafter currently in stock: " + currentAmountOfWoodMaterial,
                "Amount needed to purchase: " + requiredAmountOfWoodMaterialToBuy,
                "Cost: £" + WoodMaterialToBuyEstimatedCost,
                "",
                "Estimated material cost of roof: £" + TotalMaterialCost,
                "Estimated cost of materials that need purchasing for roof: £" + RequiredMaterialCost
            };
            return output;
        }
        public static string[] CalculateScantleRoof(RoofElevation roof, List<Stocks> stocks)
        {
            float Overlap = -1;
            for (int i = 0; i < Pitches.Length; i++)
            {
                if (Pitches[i] <= roof.SlantAngle)
                {
                    Overlap = SlateOverlaps[i];
                }
            }
            Stocks woodmat = Stocks.GetStockFromID(stocks, roof.WoodMaterialID);
            if (Overlap < 0)
            {
                return new string[] { "Not enough overlap"};
            }

            List<Stocks> ScantleTiles = new List<Stocks>();

            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].UseableInScantle && stocks[i].IsATypeOfSlate)
                {
                    if (ScantleTiles.Count == 0)
                    {
                        ScantleTiles.Add(stocks[i]);
                    }
                    else
                    {
                        bool Sorted = true;
                        int index = 0;
                        while (Sorted)
                        {
                            if(index >= ScantleTiles.Count)
                            {
                                ScantleTiles.Add(stocks[i]);
                                Sorted = false;
                            }
                            else if (stocks[i].LengthIfSlate < ScantleTiles[index].LengthIfSlate)
                            {
                                ScantleTiles.Insert(index, stocks[i]);
                                Sorted = false;
                            }
                            else
                            {
                                index ++;
                            }
                        }
                    }
                }
            }// ScantleTiles list is now a list of scantle roof slates in order of size

            int[] SlateLayers = new int[ScantleTiles.Count];
            int SlateTypeIndex = 0;
            bool LastLayer = false;
            bool loop = true;
            while (loop)
            {
                SlateLayers[SlateTypeIndex]++;

                if (CalculatetRoofLength(Overlap, SlateLayers, ScantleTiles) < roof.Length)
                {
                    SlateTypeIndex++;
                    if (SlateTypeIndex >= SlateLayers.Length)
                    {
                        SlateTypeIndex = 0;
                    }
                }
                else if (CalculatetRoofLength(Overlap, SlateLayers, ScantleTiles) > roof.Length && !LastLayer)
                {
                    SlateLayers[SlateTypeIndex]--;
                    SlateTypeIndex = 0;
                    LastLayer = true;
                }
                else
                {
                    loop = false;
                }
            }
            //SlateLayers now contains a list of how many layers each size of tile should occupy, from the top(estimated of course)
            
            float RaftersAmount = roof.Width * roof.Length;
            for (int i = 0; i < SlateLayers.Length; i++)
            {
                RaftersAmount += SlateLayers[i] * roof.Width;
            }
            float RaftersAmountOverflow = RaftersAmount * 1.05f;
            float RaftersCostEstimate = RaftersAmountOverflow * woodmat.Cost;
            float requiredAmountOfRafterToBuy = (int)Math.Max(0, RaftersAmountOverflow - woodmat.CurrentAmount);
            float requiredAmountOfRafterCost = requiredAmountOfRafterToBuy * woodmat.Cost;

            string[] startText =
{
                "Roof: " + roof.Name,
                "Dimensions ",
                "Height: " + roof.Length * Math.Sin((Math.PI / 180) * roof.SlantAngle) + " M",
                "Width:  " + roof.Width + " M",
                "Hypotenuse(Length from top to bottom of the tiles): " + roof.Length + " M",
                "Inclination: " + roof.SlantAngle + " degrees",
                "",
                "Rafter Type: " + woodmat.Name,
                "Estimated length of rafter required (plus 5%): " + RaftersAmountOverflow,
                "Estimated cost of rafters: £" + RaftersCostEstimate,
                "rafter currently in stock: " + woodmat.CurrentAmount,
                "Amount needed to purchase: " + requiredAmountOfRafterToBuy,
                "Cost: £" + requiredAmountOfRafterCost,
                ""
            };

            List<string> RoofOutput = new List<string>();

            RoofOutput.AddRange(startText);

            float SlateCost = 0;
            float TotalSlateAmount = 0;
            float RequiredSlatesCost = 0;
            for (int i = 0; i < SlateLayers.Length; i++)
            {
                float SlateAmount = (roof.Width / ScantleTiles[i].WidthIfSlate) * SlateLayers[i];
                SlateCost += SlateAmount * ScantleTiles[i].Cost;
                TotalSlateAmount += SlateAmount;
                int RequiredToBuy = (int)Math.Max(0, SlateAmount - ScantleTiles[i].CurrentAmount);
                float CostOfRequired = RequiredToBuy * ScantleTiles[i].Cost;
                RequiredSlatesCost += CostOfRequired;
                RoofOutput.Add(SlateLayers[i].ToString() + " courses of " + ScantleTiles[i].Name);
                RoofOutput.Add("At: " + SlateAmount + " estimated slates per course");
                RoofOutput.Add(ScantleTiles[i].CurrentAmount + " In stock, " + RequiredToBuy + " Needed to buy. Cost: £" + CostOfRequired);
                RoofOutput.Add("");
            }

            string[] endbit =
            {
                "Estimated number of slates: " + TotalSlateAmount,
                "Estimated cost of slate: £" + SlateCost,
                "",
                "Estimated material cost of roof: £" + (SlateCost+requiredAmountOfRafterCost),
                "Estimated cost of materials that need purchasing for roof: £" + (RequiredSlatesCost + requiredAmountOfRafterCost)
            };

            RoofOutput.AddRange(endbit);
            string[] output = RoofOutput.ToArray();
            return output;
        }

        static float CalculatetRoofLength(float Overlap,  int[] SlateLayers, List<Stocks> slates)
        {
            float totalLength = 0;
            for (int i = 0; i < SlateLayers.Length; i++)
            {
                if(slates[i].LengthIfSlate - Overlap > 0)
                {
                    totalLength = totalLength + SlateLayers[i] * (slates[i].LengthIfSlate - Overlap);
                }
            }
            return totalLength;
        }

    }
}
