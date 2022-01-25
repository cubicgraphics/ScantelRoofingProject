using System.Collections.Generic;

namespace ScantelRoofingPrototype
{
    class DefaultData
    {
        public int ID { get; set; }
        public static int GetHighestID<T>(List<T> data) where T : DefaultData
        {
            int highest = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID > highest)
                {
                    highest = data[i].ID;
                }
            }
            return highest;
        }
    }
}
