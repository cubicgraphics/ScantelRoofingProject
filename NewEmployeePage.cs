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
    public partial class NewEmployeePage : Form
    {
        ManageEmployeesPage manageEmployeesPage;
        List<People> people;
        List<Employees> employees;

        public NewEmployeePage(ManageEmployeesPage employeesPage)
        {
            manageEmployeesPage = employeesPage;
            InitializeComponent();
        }

        private void CreateNewEmployeeButton_Click(object sender, EventArgs e)
        {
            employees = FileReader.ReadFromEmployeeFile();
            people = FileReader.ReadFromPeopleFile();
            People newperson = new People((People.GetHighestID(people) + 1), EmployeeNameBox.Text, EmployeePhoneBox.Text, EmployeeEmailBox.Text,EmployeeAddressBox.Text);
            
            string accesscode = "12345";///make this random and not the same as any before it///

            Employees newemployee = new Employees((Employees.GetHighestID(employees) + 1), (People.GetHighestID(people) + 1), int.Parse(EmployeeAccessLevelBox.Text), float.Parse(EmployeeWagesBox.Text), EmployeeUsernameInputBox.Text, EmployeePasswordInputBox.Text, accesscode);

            MessageBox.Show("Adding the employee: " + newperson.Name + " " + newperson.PhoneNumber.ToString() + " " + newperson.Address.ToString() + "  Username: " + newemployee.Username + " Password: " + newemployee.Password + " Wages: " + newemployee.Wages.ToString() + " AccessLevel: " + newemployee.AccessLevel.ToString() + " AccessCode: " + newemployee.AccessCode);
            people.Add(newperson);
            employees.Add(newemployee);
            FileReader.WriteToEmployeeFile(employees);
            FileReader.WriteToPeopleFile(people);
            manageEmployeesPage.LoadAndRefreshEmployeesPeople();
            manageEmployeesPage.Show();
            this.Hide();
        }

        private void NewEmployeePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageEmployeesPage.Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}
