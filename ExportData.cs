using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScantelRoofingPrototype
{
    class ExportData
    {
        static string OutputPath = Directory.GetCurrentDirectory() + @"\Export";
        static string EmployeeWagesPath = OutputPath + @"\EmployeeWages";
        static string RoofExportPath = OutputPath + @"\RoofExports";

        private const string Seperator = "\t";


        public static void OutputEmployeeWages(DateTime SelectedMonth)
        {
            List<EmployeePeople> employeePeople = EmployeePeople.CombineEmployeePeopleList(Employees.ReadFromFile(), People.ReadFromFile());
            float[] HoursWorked = new float[employeePeople.Count];
            int[] reclaimedSlates = new int[employeePeople.Count];
            string[] Exportstrings = new string[employeePeople.Count];
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
            for (int i = 0; i < employeePeople.Count; i++)
            {
                Exportstrings[i] = employeePeople[i].Name + Seperator + HoursWorked[i] + Seperator + reclaimedSlates[i] + Seperator + employeePeople[i].Wages + (HoursWorked[i] * employeePeople[i].Wages);
            }
            File.WriteAllLines(EmployeeWagesPath, Exportstrings);
        }
    }
}
