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
    }
}
