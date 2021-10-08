using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    class Customers
    {
        public int ID { get; }
        public int PersonID { get; }

        public Customers(int id, int personid)
        {
            ID = id;
            PersonID = personid;
        }

        public static int GetHighestID(List<Customers> employees)
        {
            int highest = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID > highest)
                {
                    highest = employees[i].ID;
                }
            }
            return highest;
        }

        public static List<People> OnlyCustomers(List<People> people, List<Customers> customers)
        {
            List<People> confirmedcustomers = new List<People>();
            for (int i = 0; i < customers.Count; i++)
            {
                for (int x = 0; x < people.Count; x++)
                {
                    if (customers[i].PersonID == people[x].ID)
                    {
                        confirmedcustomers.Add(people[x]);
                    }
                }
                
            }
            return confirmedcustomers;
        }
    }
}
