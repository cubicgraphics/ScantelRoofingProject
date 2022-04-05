namespace ScantelRoofingPrototype
{
    class Utill
    {
        public static bool VerifyIntInput(string text) //checks that all the char's are numbers and that there is only up to 1 full stop(decimal place)
        {
            bool verif = true;
            char[] c = text.ToCharArray();
            int DecimalCheck = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (DecimalCheck < 1 && c[i] == '.')
                {
                    DecimalCheck++;
                }
                else if (!char.IsDigit(c[i]))
                {
                    verif = false;
                    break;
                }
            }
            return verif;
        }
    }
}
