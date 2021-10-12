using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class CustomerToWorkplace
    {
        public int ID { get; }
        public int CustomerID { get; }
        public int WorkplaceID { get; }

        public CustomerToWorkplace(int id, int customerid, int workplaceid)
        {
            ID = id;
            CustomerID = customerid;
            WorkplaceID = workplaceid;
        }

        public static int GetHighestID(List<CustomerToWorkplace> customerToWorkplaces)
        {
            int highest = 0;
            for (int i = 0; i < customerToWorkplaces.Count; i++)
            {
                if (customerToWorkplaces[i].ID > highest)
                {
                    highest = customerToWorkplaces[i].ID;
                }
            }
            return highest;
        }
    }
}
