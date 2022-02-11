using System;
using System.Text;

namespace ScantelRoofingPrototype
{
    public class Hash
    {
        private static int[] Primes = {269, 277, 283, 307, 313, 331, 347, 353, 367, 379};

        public static string HashString(string data)
        {
            if(data.Length > 0)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);
                long[] values = new long[byteData.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = byteData[i];
                }

                long total = 0;
                long PrevNumb = 1;
                for (int i = 0; i < values.Length; i++)
                {
                    if (PrevNumb + values[i] > 111)
                    {
                        PrevNumb = (long)Math.Ceiling((decimal)PrevNumb + (decimal)((values[i] + 1) * Primes[(values[i] + 1) % 10]) / 10);
                    }
                    else
                    {
                        PrevNumb = (PrevNumb + values[i]) % 10;
                    }
                    total += (values[i] + 1) * Primes[values[i] % 10] * Primes[(PrevNumb + 3) % 10];
                }
                double hashcode = Math.Acosh(total);
                string HashedTotal = hashcode.ToString().Replace(".", "");
                return HashedTotal.Substring(4, HashedTotal.Length - 7);
                /**
                 * for the size of the program and the amunt of users who will be using it, this hashing algorithum will be enough to encrypt there passwords without clashes
                 * 
                 * 
                 * 
                 * 
                 */
            }
            else
            {
                return data;
            }
        }
    }
}