using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    public partial class LowAccessLevelEmployeeInterface : Form
    {
        public Form PrevFrom;
        public EmployeeWorkInputPage employeeWorkInputPage;
        public int UserID;

        public LowAccessLevelEmployeeInterface(LoginPage loginPage)
        {
            employeeWorkInputPage = new EmployeeWorkInputPage(this);
            PrevFrom = loginPage;
            InitializeComponent();
        }

        private void WorkInputButton_Click(object sender, EventArgs e)
        {
            employeeWorkInputPage.EmployeeID = UserID;
            this.Hide();
            employeeWorkInputPage.Show();
        }




        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            //low level employee account management not being implemented into prototype
        }





        private void LogoutButton_VisibleChanged(object sender, EventArgs e)
        {
            UsernameLabel.Text = Employees.GetUserNameFromID(FileReader.ReadFromEmployeeFile(), UserID);
        }

        private void LowAccessLevelEmployeeInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrevFrom.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            PrevFrom.Show();
            this.Hide();
        }
    }
}
