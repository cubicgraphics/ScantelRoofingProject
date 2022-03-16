using System;

namespace ScantelRoofingPrototype
{
    class Workplaces : DefaultData
    {
        public string PlaceName { get; }
        public string Address { get; }
        public bool BeingWorkedAt { get; }
        public DateTime StartDate { get; }
        public DateTime PredictedEndDate { get; }
        public DateTime RealEndDate { get; }

        public Workplaces(int id, string placename, string address, bool beingworkedat, DateTime startdate, DateTime predictedenddate, DateTime realenddate)
        {
            ID = id;
            PlaceName = placename;
            Address = address;
            BeingWorkedAt = beingworkedat;
            StartDate = startdate;
            PredictedEndDate = predictedenddate;
            RealEndDate = realenddate;
        }
    }
}
