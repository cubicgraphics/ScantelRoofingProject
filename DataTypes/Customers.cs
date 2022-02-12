using System.Collections.Generic;

namespace ScantelRoofingPrototype
{
    class Customers : DefaultData
    {
        public int PersonID { get; set; }

        public Customers(int id, int personid)
        {
            this.ID = id;
            this.PersonID = personid;
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
