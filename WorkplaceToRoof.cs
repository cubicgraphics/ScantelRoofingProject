using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class WorkplaceToRoof
    {
        public int ID { get; }
        public string RoofName { get; }
        public int WorkplaceID { get; }

        public WorkplaceToRoof(int id, string roofname, int workplaceid)
        {
            ID = id;
            RoofName = roofname;
            WorkplaceID = workplaceid;
        }
    }
}
