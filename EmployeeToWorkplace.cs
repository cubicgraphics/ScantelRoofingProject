using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class EmployeeToWorkplace
    {
        public int ID { get; }
        public int EmployeeID { get; }
        public int WorkplaceID { get; }

        public EmployeeToWorkplace(int id, int employeeid, int workplaceid)
        {
            ID = id;
            EmployeeID = employeeid;
            WorkplaceID = workplaceid;
        }
        public static int GetHighestID(List<EmployeeToWorkplace> employeeToWorkplaces)
        {
            int highest = 0;
            for (int i = 0; i < employeeToWorkplaces.Count; i++)
            {
                if (employeeToWorkplaces[i].ID > highest)
                {
                    highest = employeeToWorkplaces[i].ID;
                }
            }
            return highest;
        }
    }
}
