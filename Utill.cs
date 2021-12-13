using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class Utill
    {
        public static bool VerifyIntInput(string text) { return text.All(char.IsDigit); }
    }
}
