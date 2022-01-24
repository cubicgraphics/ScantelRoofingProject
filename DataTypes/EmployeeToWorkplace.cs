using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class EmployeeToWorkplace : DefaultData
    {
        public int EmployeeID { get; }
        public int WorkplaceID { get; }

        public EmployeeToWorkplace(int id, int employeeid, int workplaceid)
        {
            ID = id;
            EmployeeID = employeeid;
            WorkplaceID = workplaceid;
        }
    }
}
