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

        //TODO impliment search features for all list boxes
    }
}
