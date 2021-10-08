using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    class FileReader
    {

        public static string[][] ReadFileToArray(string path)
        {
            string[] text = File.ReadAllLines(path);
            string[][] array = new string[text.Length][];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i].Split(",");
            }
            return array;
        }



        public static List<People> ReadFromPeopleFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\People.txt");
            List<People> persons = new List<People>();
            for (int i = 0; i < Data.Length; i++)
            {
                //uses string because first digit could be a 0
                persons.Add(new People(int.Parse(Data[i][0]), Data[i][1], Data[i][2],Data[i][3],Data[i][4]));
            }
            return persons;
        }

        public static void WriteToPeopleFile(List<People> people)
        {
            string[] texttowrite = new string[people.Count()];
            for (int i = 0; i < people.Count; i++)
            {
                texttowrite[i] = people[i].ID.ToString() + "," + people[i].Name + "," + people[i].PhoneNumber.ToString() + "," + people[i].EmailAddress + "," + people[i].Address;
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\People.txt", texttowrite);
        }



        public static List<Employees> ReadFromEmployeeFile()
        {
            List<Employees> employeeslist = new List<Employees>();
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\Employees.txt");
            for (int i = 0; i < Data.Length; i++)
            {
                employeeslist.Add(new Employees(int.Parse(Data[i][0]), int.Parse(Data[i][1]), int.Parse(Data[i][2]), float.Parse(Data[i][3]), Data[i][4], Data[i][5], Data[i][6]));
            }
            return employeeslist;
        }

        public static void WriteToEmployeeFile(List<Employees> employees)
        {
            string[] texttowrite = new string[employees.Count()];
            for (int i = 0; i < employees.Count; i++)
            {
                texttowrite[i] = employees[i].ID.ToString() + "," + employees[i].PersonID.ToString() + "," + employees[i].AccessLevel.ToString() + "," + employees[i].Wages.ToString() + "," + employees[i].Username + "," + employees[i].Password + "," + employees[i].AccessCode;
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\Employees.txt", texttowrite);
        }



        public static List<Customers> ReadFromCustomerFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\Customers.txt");
            List<Customers> customers = new List<Customers>();
            for (int i = 0; i < Data.Length; i++)
            {
                customers.Add(new Customers(int.Parse(Data[i][0]), int.Parse(Data[i][1])));
            }
            return customers;
        }

        public static void WriteToCustomerFile(List<Customers> customers)
        {
            string[] texttowrite = new string[customers.Count()];
            for (int i = 0; i < customers.Count; i++)
            {
                texttowrite[i] = customers[i].ID.ToString() + "," + customers[i].PersonID.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\Customers.txt", texttowrite);
        }



        public static List<Stocks> ReadFromStocksFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\Stocks.txt");
            List<Stocks> stocks = new List<Stocks>();
            for (int i = 0; i < Data.Length; i++)
            {
                stocks.Add(new Stocks(int.Parse(Data[i][0]), Data[i][1], int.Parse(Data[i][2]), float.Parse(Data[i][3]),float.Parse(Data[i][4]),float.Parse(Data[i][5]),bool.Parse(Data[i][6]),bool.Parse(Data[i][7]),float.Parse(Data[i][8]), float.Parse(Data[i][9])));
            }
            return stocks;
        }

        public static void WriteToStockFile(List<Stocks> stocks)
        {
            string[] texttowrite = new string[stocks.Count()];
            for (int i = 0; i < stocks.Count; i++)
            {
                texttowrite[i] = stocks[i].ID.ToString() + "," +stocks[i].Name + ","+ stocks[i].TOM.ToString() + "," + stocks[i].CurrentAmount.ToString() + "," + stocks[i].ReservedForWorkplaces.ToString() + "," + stocks[i].Cost.ToString() + "," + stocks[i].IsATypeOfSlate.ToString() + "," + stocks[i].IsATypeOfWood.ToString() + "," + stocks[i].WidthIfSlate.ToString() + "," + stocks[i].LengthIfSlate.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\Stocks.txt", texttowrite);
        }



        public static List<ReclaimedSlates> ReadFromReclaimedSlatesFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\ReclaimedSlates.txt");
            List<ReclaimedSlates> reclaimedslates = new List<ReclaimedSlates>();
            for (int i = 0; i < Data.Length; i++)
            {
                reclaimedslates.Add(new ReclaimedSlates(int.Parse(Data[i][0]), int.Parse(Data[i][1]), int.Parse(Data[i][2]), DateTime.Parse(Data[i][3]), TimeSpan.Parse(Data[i][4])));
            }
            return reclaimedslates;
        }

        public static void WriteToReclaimedSlatesFile(List<ReclaimedSlates> reclaimedslates)
        {
            string[] texttowrite = new string[reclaimedslates.Count()];
            for (int i = 0; i < reclaimedslates.Count; i++)
            {
                texttowrite[i] = reclaimedslates[i].ID.ToString() + "," + reclaimedslates[i].EmployeeID.ToString() + "," + reclaimedslates[i].Reclaimedslates.ToString() + "," + reclaimedslates[i].Date.ToString() + "," + reclaimedslates[i].HoursWorked.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\ReclaimedSlates.txt", texttowrite);
        }



        public static List<Workplaces> ReadFromWorkplacesFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\Workplaces.txt");
            List<Workplaces> workplaces = new List<Workplaces>();
            for (int i = 0; i < Data.Length; i++)
            {
                workplaces.Add(new Workplaces(int.Parse(Data[i][0]),Data[i][1],Data[i][2],bool.Parse(Data[i][3]),DateTime.Parse(Data[i][4]),DateTime.Parse(Data[i][5]),DateTime.Parse(Data[i][6])));
            }
            return workplaces;
        }

        public static void WriteToWorkplaceFile(List<Workplaces> workplaces)
        {
            string[] texttowrite = new string[workplaces.Count()];
            for (int i = 0; i < workplaces.Count; i++)
            {
                texttowrite[i] = workplaces[i].ID.ToString() + "," + workplaces[i].PlaceName + "," + workplaces[i].Address + "," + workplaces[i].BeingWorkedAt.ToString() + "," + workplaces[i].StartDate.ToString() + "," + workplaces[i].PredictedEndDate.ToString() + "," + workplaces[i].RealEndDate.ToString(); 
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\Workplaces.txt", texttowrite);
        }



        public static List<EmployeeToWorkplace> ReadFromEmployeeToWorkplaceFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\EmployeeToWorkplace.txt");
            List<EmployeeToWorkplace> employeeToWorkplace = new List<EmployeeToWorkplace>();
            for (int i = 0; i < Data.Length; i++)
            {
                employeeToWorkplace.Add(new EmployeeToWorkplace(int.Parse(Data[i][0]), int.Parse(Data[i][1]), int.Parse(Data[i][2])));
            }
            return employeeToWorkplace;
        }

        public static void WriteToEmployeeToWorkplaceFile(List<EmployeeToWorkplace> employeetoworkplace)
        {
            string[] texttowrite = new string[employeetoworkplace.Count()];
            for (int i = 0; i < employeetoworkplace.Count; i++)
            {
                texttowrite[i] = employeetoworkplace[i].ID.ToString() + "," + employeetoworkplace[i].EmployeeID.ToString() + "," + employeetoworkplace[i].WorkplaceID.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\EmployeeToWorkplace.txt", texttowrite);
        }



        public static List<CustomerToWorkplace> ReadFromCustomerToWorkplaceFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\CustomerToWorkplace.txt");
            List<CustomerToWorkplace> customerToWorkplace = new List<CustomerToWorkplace>();
            for (int i = 0; i < Data.Length; i++)
            {
                customerToWorkplace.Add(new CustomerToWorkplace(int.Parse(Data[i][0]), int.Parse(Data[i][1]), int.Parse(Data[i][2])));
            }
            return customerToWorkplace;
        }

        public static void WriteToCustomerToWorkplaceFile(List<CustomerToWorkplace> customertoworkplace)
        {
            string[] texttowrite = new string[customertoworkplace.Count()];
            for (int i = 0; i < customertoworkplace.Count; i++)
            {
                texttowrite[i] = customertoworkplace[i].ID.ToString() + "," + customertoworkplace[i].CustomerID.ToString() + "," + customertoworkplace[i].WorkplaceID.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\CustomerToWorkplace.txt", texttowrite);
        }



        public static List<WorkplaceToRoof> ReadFromWorkplaceToRoofFile()
        {
            string[][] Data = ReadFileToArray(Directory.GetCurrentDirectory() + @"\Data\WorkplaceToRoof.txt");
            List<WorkplaceToRoof> workplaceToRoof = new List<WorkplaceToRoof>();
            for (int i = 0; i < Data.Length; i++)
            {
                workplaceToRoof.Add(new WorkplaceToRoof(int.Parse(Data[i][0]), Data[i][1], int.Parse(Data[i][2])));
            }
            return workplaceToRoof;
        }

        public static void WriteToWorkplaceToRoofFile(List<WorkplaceToRoof> workplacetoroofs)
        {
            string[] texttowrite = new string[workplacetoroofs.Count()];
            for (int i = 0; i < workplacetoroofs.Count; i++)
            {
                texttowrite[i] = workplacetoroofs[i].ID.ToString() + "," + workplacetoroofs[i].RoofName + "," + workplacetoroofs[i].WorkplaceID.ToString();
            }

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\Data\WorkplaceToRoof.txt", texttowrite);
        }
    }
}
