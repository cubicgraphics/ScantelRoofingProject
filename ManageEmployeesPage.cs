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
    public partial class ManageEmployeesPage : Form
    {
        HighAccessLevelEmployeeInterface employeeInterface;
        List<People> people;
        List<Employees> employees;
        List<EmployeePeople> employeePeopleLinked;
        NewEmployeePage newEmployeePage;


        public ManageEmployeesPage(HighAccessLevelEmployeeInterface Interface)
        {
            newEmployeePage = new NewEmployeePage(this);
            employeeInterface = Interface;
            InitializeComponent();
            EmployeesDataBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesDataBox.MultiSelect = false;
            
            LoadAndRefreshEmployeesPeople();


        }

        public void LoadAndRefreshEmployeesPeople()
        {
            LoadEmployeesPeopleFromFile();
            refreshEmployeesPeopleList();
        }

        public void LoadEmployeesPeopleFromFile()
        {
            people = FileReader.ReadFromPeopleFile();
            employees = FileReader.ReadFromEmployeeFile();
        }

        public void refreshEmployeesPeopleList()
        {

            employeePeopleLinked = EmployeePeople.CombineEmployeePeopleList(employees, people);
            EmployeesDataBox.DataSource = employeePeopleLinked;
            RefreshEditPanel();
            EmployeesDataBox.Columns.RemoveAt(5);
        }


        private void ManageEmployeesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            employeeInterface.Show();
            e.Cancel = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeInterface.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            newEmployeePage.Show();
        }


        public void RemoveEmployee(int index)
        {
            if (employees.Count > index)
            {
                employees.RemoveAt(index);
            }
            FileReader.WriteToEmployeeFile(employees);
            FileReader.WriteToPeopleFile(people);
        }

        private void DeleteSelectedCustomerButton_Click(object sender, EventArgs e)
        {
            int index = EmployeesDataBox.SelectedCells[0].RowIndex;
            DialogResult dialog = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                RemoveEmployee(index);
                LoadAndRefreshEmployeesPeople();
            }

        }

        private void EmployeesDataBox_Click(object sender, EventArgs e)
        {
            RefreshEditPanel();
        }

        private void RefreshEditPanel()
        {
            if (employees.Count != 0)
            {
                int index = EmployeesDataBox.SelectedCells[0].RowIndex;
                EmployeeNameBox.Text = employeePeopleLinked[index].Name;
                EmployeePhoneBox.Text = employeePeopleLinked[index].PhoneNumber.ToString();
                EmployeeEmailBox.Text = employeePeopleLinked[index].EmailAddress;
                EmployeeAddressBox.Text = employeePeopleLinked[index].Address;
                EmployeeAccessLevelBox.Text = employeePeopleLinked[index].AccessLevel.ToString();
                EmployeeWagesBox.Text = employeePeopleLinked[index].Wages.ToString();
                EmployeeUsernameTextBox.Text = employeePeopleLinked[index].Username;
                EmployeeAccessCodeBox.Text = employeePeopleLinked[index].AccessCode;
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if ((EmployeeAccessLevelBox.Text != "") && (EmployeeWagesBox.Text != "") && (EmployeeUsernameTextBox.Text != "") && (EmployeeAccessCodeBox.Text != ""))
            {


                int index = EmployeesDataBox.SelectedCells[0].RowIndex;
                People editperson = new People(employeePeopleLinked[index].PersonID, EmployeeNameBox.Text, EmployeePhoneBox.Text, EmployeeEmailBox.Text, EmployeeAddressBox.Text);
                string newpassword = employeePeopleLinked[index].Password;
                if (EmployeeNewPasswordTextBox.Text != "")
                {
                    newpassword = EmployeeNewPasswordTextBox.Text;
                }
                Employees editemployee = new Employees(employeePeopleLinked[index].ID, employeePeopleLinked[index].PersonID, int.Parse(EmployeeAccessLevelBox.Text), float.Parse(EmployeeWagesBox.Text), EmployeeUsernameTextBox.Text, newpassword, EmployeeAccessCodeBox.Text);
                people[employeePeopleLinked[index].PersonID] = editperson;
                employees[index] = editemployee;

                FileReader.WriteToEmployeeFile(employees);
                FileReader.WriteToPeopleFile(people);

                
                refreshEmployeesPeopleList();

            }
        }

        private void ManageEmployeesPage_VisibleChanged(object sender, EventArgs e)
        {
            LoadAndRefreshEmployeesPeople();
        }
    }
}
