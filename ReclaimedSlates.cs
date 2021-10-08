using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class ReclaimedSlates
    {
        public int ID { get; }
        public int EmployeeID { get; }
        public int Reclaimedslates { get; }
        public DateTime Date { get; }
        public TimeSpan HoursWorked { get; }

        public ReclaimedSlates(int id, int employeeid, int reclaimedslates, DateTime date, TimeSpan hoursworked)
        {
            ID = id;
            EmployeeID = employeeid;
            Reclaimedslates = reclaimedslates;
            Date = date;
            HoursWorked = hoursworked;
        }
    }
}
