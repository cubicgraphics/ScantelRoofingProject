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
        public int RoofID { get; }
        public int WorkplaceID { get; }

        public WorkplaceToRoof(int id, int roofid, int workplaceid)
        {
            ID = id;
            RoofID = roofid;
            WorkplaceID = workplaceid;
        }

        public static int GetHighestID(List<WorkplaceToRoof> workplaceToRoof)
        {
            int highest = 0;
            for (int i = 0; i < workplaceToRoof.Count; i++)
            {
                if (workplaceToRoof[i].ID > highest)
                {
                    highest = workplaceToRoof[i].ID;
                }
            }
            return highest;
        }
    }
}
