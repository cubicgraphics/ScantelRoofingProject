using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class CustomerToWorkplace : DefaultData
    {
        public int CustomerID { get; }
        public int WorkplaceID { get; }

        public CustomerToWorkplace(int id, int customerid, int workplaceid)
        {
            this.ID = id;
            this.CustomerID = customerid;
            this.WorkplaceID = workplaceid;
        }
    }
}
