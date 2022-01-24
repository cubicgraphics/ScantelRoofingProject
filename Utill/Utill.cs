using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    class Utill
    {
        public static bool VerifyIntInput(string text)
        {
            bool verif = true;
            char[] c = text.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                MessageBox.Show("char is " + c[i]);
                if (!char.IsDigit(c[i]) && c[i] != '.')
                {
                    verif = false;
                    i = c.Length;
                }
            }
            return verif;
        }


    }
}
