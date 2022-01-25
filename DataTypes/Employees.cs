using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    class Employees : DefaultData
    {
        public int PersonID { get; }
        public int AccessLevel { get; }
        public float Wages { get; }
        public string Username { get; }
        public string Password { get; }
        public string AccessCode { get; }

        public Employees(int id, int personid, int accesslevel, float wages, string username, string password, string accesscode )
        {
            ID = id;
            PersonID = personid;
            AccessLevel = accesslevel;
            Wages = wages;
            Username = username;
            Password = password;
            AccessCode = accesscode;
        }

        public static int GetIDFromCode(List<Employees> employees, string accesscode)
        {
            int ID = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].AccessCode == accesscode)
                {
                    ID = employees[i].ID;
                }
            }
            return ID;
        }
        public static int GetIDFromUserPassword(List<Employees> employees, string username, string password)
        {
            int ID = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if ((employees[i].Username == username) && (employees[i].Password == password))
                {
                    ID = employees[i].ID;
                }
            }
            return ID;
        }
        public static string GetUserNameFromID(List<Employees> employees, int ID)
        {
            string name = "";
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == ID)
                {
                    name = employees[i].Username;
                }
            }
            return name;
        }
        public static int GetListIndexFromID(List<Employees> employees, int ID)
        {
            int Index = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == ID)
                {
                    Index = i;
                }
            }
            return Index;
        }
        public static bool IsEmployeeAccessLevel(List<Employees> employees, int AccessLevelToCheck, int EmployeeID)
        {
            bool A = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == EmployeeID)
                {
                    if (employees[i].AccessLevel == AccessLevelToCheck)
                    {
                        A = true;
                    }
                }
            }
            return A;

        }
        public static List<Employees> ReadFromFile()
        {
            return FileReader.ReadFromEmployeeFile();
        }
    }
}
