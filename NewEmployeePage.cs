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
            if (AccessCodeTextInput.Text != "" && EmployeePasswordInputBox.Text != "" && EmployeeNameBox.Text != "" && EmployeeUsernameInputBox.Text != "" && Utill.VerifyIntInput(EmployeeWagesBox.Text) && Utill.VerifyIntInput(EmployeeAccessLevelBox.Text))
            {
                People newperson = new People((People.GetHighestID(people) + 1), EmployeeNameBox.Text, EmployeePhoneBox.Text, EmployeeEmailBox.Text, EmployeeAddressBox.Text);

                Employees newemployee = new Employees((Employees.GetHighestID(employees) + 1), (People.GetHighestID(people) + 1), int.Parse(EmployeeAccessLevelBox.Text), float.Parse(EmployeeWagesBox.Text), EmployeeUsernameInputBox.Text, Hash.HashString(EmployeePasswordInputBox.Text), Hash.HashString(AccessCodeTextInput.Text));

                MessageBox.Show("Adding the employee: " + newperson.Name + " Phone number: " + newperson.PhoneNumber.ToString() + " Address: " + newperson.Address.ToString() + " Email: " + newperson.EmailAddress.ToString() + "  Username: " + newemployee.Username + " Password: " + EmployeePasswordInputBox.Text + " Wages: " + newemployee.Wages.ToString() + " AccessLevel: " + newemployee.AccessLevel.ToString() + " AccessCode: " + AccessCodeTextInput.Text);
                people.Add(newperson);
                employees.Add(newemployee);
                FileReader.WriteToEmployeeFile(employees);
                FileReader.WriteToPeopleFile(people);
                manageEmployeesPage.LoadAndRefreshEmployeesPeople();
                manageEmployeesPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill in the empty boxes and/or enter correct data");
            }
        }

        private void NewEmployeePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageEmployeesPage.Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}
