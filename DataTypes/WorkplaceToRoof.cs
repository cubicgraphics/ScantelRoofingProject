using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class WorkplaceToRoof : DefaultData
    {
        public int RoofID { get; }
        public int WorkplaceID { get; }

        public WorkplaceToRoof(int id, int roofid, int workplaceid)
        {
            ID = id;
            RoofID = roofid;
            WorkplaceID = workplaceid;
        }
    }
}
