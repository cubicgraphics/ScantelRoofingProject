﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class EmployeePeople
    {
        public int ID { get;}
        public string Name { get;}
        public string PhoneNumber { get;}
        public string EmailAddress { get; }
        public string Address { get; }

        public int PersonID { get; }
        public int AccessLevel { get; }
        public float Wages { get; }
        public string Username { get; }
        public string Password { get; }
        public string AccessCode { get; }

        public EmployeePeople(People person, Employees employee)
        {
            ID = employee.ID;
            Name = person.Name;
            PhoneNumber = person.PhoneNumber;
            EmailAddress = person.EmailAddress;
            Address = person.Address;
            PersonID = employee.PersonID;
            AccessLevel = employee.AccessLevel;
            Wages = employee.Wages;
            Username = employee.Username;
            Password = employee.Password;
            AccessCode = employee.AccessCode;
        }

        public static List<EmployeePeople>  CombineEmployeePeopleList(List<Employees> employeelist, List<People> peoplelist)
        {
            List<EmployeePeople> Employeepeoplelist = new List<EmployeePeople>();
            for (int i = 0; i < employeelist.Count; i++)
            {
                bool found = false;
                int loop = 0;
                while (found == false)
                {
                    if (employeelist[i].PersonID == peoplelist[loop].ID)
                    {

                        Employeepeoplelist.Add(new EmployeePeople(peoplelist[loop], employeelist[i]));
                        found = true;
                    }

                    loop += 1;
                }
            }
            return Employeepeoplelist;
        }

    }
}