using System.Collections.Generic;

namespace ScantelRoofingPrototype
{
    class Stocks : DefaultData
    {
        public string Name { get; }
        public int TOM { get; } //measure in tonnes, per one, or in meters
        public float CurrentAmount { get; set; }
        public float Cost { get; set; }
        public bool IsATypeOfSlate { get; }
        public bool IsATypeOfWood { get; }
        public float LengthIfSlate { get; }
        public float WidthIfSlate { get; }
        public bool UseableInScantle { get; }

        public Stocks(int id, string name, int tom, float currentamount, float cost, bool isatypeofslate, bool isatypeofwood, bool useableinscantle)
        {
            ID = id;
            Name = name;
            TOM = tom;
            CurrentAmount = currentamount;
            Cost = cost;
            IsATypeOfSlate = isatypeofslate;
            IsATypeOfWood = isatypeofwood;
            LengthIfSlate = 0;
            WidthIfSlate = 0;
            UseableInScantle = useableinscantle;
        }


        public Stocks(int id, string name, int tom, float currentamount, float cost, bool isatypeofslate, bool isatypeofwood, float length, float width, bool useableinscantle)
        {
            ID = id;
            Name = name;
            TOM = tom;
            CurrentAmount = currentamount;
            Cost = cost;
            IsATypeOfSlate = isatypeofslate;
            IsATypeOfWood = isatypeofwood;
            LengthIfSlate = length;
            WidthIfSlate = width;
            UseableInScantle = useableinscantle;
        }


        public static int GetStockIDFromName(string name, List<Stocks> stock)
        {
            int ID = -1;
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].Name == name)
                {
                    ID = stock[i].ID;
                }
            }
            return ID;
        }

        public static Stocks GetStockFromID(List<Stocks> stocks, int ID)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                if (ID == stocks[i].ID)
                {
                    return stocks[i];
                }
            }
            return null;
        }
    }
}
