using System;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeAccessPage());
        }

        //TODO impliment search features for all list boxes by setting the index of the datagridview / listbox to the name closest to the search term. this will preserve list indexes so a big re-write is not needed
    }
}
