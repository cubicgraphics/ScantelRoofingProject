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
        public int UserID = -1;

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
            List<Employees> employees = Employees.ReadFromFile();
            int index = Employees.GetListIndexFromID(employees, UserID);
            Employees employee = new Employees(employees[index].ID, employees[index].PersonID, employees[index].AccessLevel, employees[index].Wages, employees[index].Username, Hash.HashString(ChangePasswordTextBox.Text), employees[index].HashAccessCode);
            employees[index] = employee;
            FileReader.WriteToEmployeeFile(employees);
            MessageBox.Show("Password changed");
        }





        private void LogoutButton_VisibleChanged(object sender, EventArgs e)
        {
            if (UserID != -1)
            {
                UsernameLabel.Text = Employees.GetUserNameFromID(Employees.ReadFromFile(), UserID);
            }
        }

        private void LowAccessLevelEmployeeInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrevFrom.Show();
            ChangePasswordTextBox.Text = "";
            UserID = -1;
            this.Hide();
            e.Cancel = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            PrevFrom.Show();
            ChangePasswordTextBox.Text = "";
            UserID = -1;
            this.Hide();
        }
    }
}
