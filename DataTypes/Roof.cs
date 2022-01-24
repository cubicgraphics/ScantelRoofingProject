using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class RoofElevation : DefaultData
    {
        public string Name { get; }
        public float Length { get; }
        public float Width { get; }
        public float SlantAngle { get; }
        public int TileMaterialID { get; }
        public int WoodMaterialID { get; }
        public bool Scantle { get; }


        public RoofElevation(int id, string name, float length, float width, float slantangle, int tilematerialid, int woodmaterialid, bool scantle)
        {
            ID = id;
            Name = name;
            Length = length;
            Width = width;
            SlantAngle = slantangle;
            TileMaterialID = tilematerialid;
            WoodMaterialID = woodmaterialid;
            Scantle = scantle;
        }
    }

}
