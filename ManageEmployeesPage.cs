﻿using System;
using System.Collections.Generic;
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
            this.Hide();
            newEmployeePage.Show();
        }


        public void RemoveEmployee(int index)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == employeePeopleLinked[index].ID)
                {
                    employees.RemoveAt(index);
                    break;
                }
            }
            FileReader.WriteToEmployeeFile(employees);
        }

        private void DeleteSelectedCustomerButton_Click(object sender, EventArgs e)
        {
            if(employees.Count > 0)
            {
                int index = EmployeesDataBox.SelectedCells[0].RowIndex;
                DialogResult dialog = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    RemoveEmployee(index);
                    LoadAndRefreshEmployeesPeople();
                }
            }
        }

        private void EmployeesDataBox_Click(object sender, EventArgs e)
        {
            RefreshEditPanel();
        }

        private void RefreshEditPanel()
        {
            if ((employees.Count != 0) && (EmployeesDataBox.SelectedCells.Count >= 1))
            {
                int index = EmployeesDataBox.SelectedCells[0].RowIndex;
                EmployeeNameBox.Text = employeePeopleLinked[index].Name;
                EmployeePhoneBox.Text = employeePeopleLinked[index].PhoneNumber.ToString();
                EmployeeEmailBox.Text = employeePeopleLinked[index].EmailAddress;
                EmployeeAddressBox.Text = employeePeopleLinked[index].Address;
                EmployeeAccessLevelBox.Text = employeePeopleLinked[index].AccessLevel.ToString();
                EmployeeWagesBox.Text = employeePeopleLinked[index].Wages.ToString();
                EmployeeUsernameTextBox.Text = employeePeopleLinked[index].Username;
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if ((EmployeeAccessLevelBox.Text != "") && (EmployeeWagesBox.Text != "") && (EmployeeUsernameTextBox.Text != "")&& (Utill.VerifyIntInput(EmployeePhoneBox.Text)) && (Utill.VerifyIntInput(EmployeeAccessLevelBox.Text)) && (Utill.VerifyIntInput(EmployeeWagesBox.Text)))
            {
                LoadEmployeesPeopleFromFile();
                int index = EmployeesDataBox.SelectedCells[0].RowIndex;
                People editperson = new People(employeePeopleLinked[index].PersonID, EmployeeNameBox.Text, EmployeePhoneBox.Text, EmployeeEmailBox.Text, EmployeeAddressBox.Text);
                string Hashpassword = employeePeopleLinked[index].HashPassword;
                if (EmployeeNewPasswordTextBox.Text != "")
                {
                    Hashpassword = Hash.HashString(EmployeeNewPasswordTextBox.Text);
                }
                string Hashcode = employeePeopleLinked[index].HashAccessCode;
                if (EmployeeAccessCodeBox.Text != "")
                {
                    Hashcode = Hash.HashString(EmployeeAccessCodeBox.Text);
                }
                Employees editemployee = new Employees(employeePeopleLinked[index].ID, employeePeopleLinked[index].PersonID, int.Parse(EmployeeAccessLevelBox.Text), float.Parse(EmployeeWagesBox.Text), EmployeeUsernameTextBox.Text, Hashpassword, Hashcode);
                for (int i = 0; i < people.Count; i++)
                {
                    if(people[i].ID == employeePeopleLinked[index].PersonID)
                    {
                        people[i] = editperson;
                    }
                }

                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].ID == employeePeopleLinked[index].ID)
                    {
                        employees[i] = editemployee;
                    }
                }

                FileReader.WriteToEmployeeFile(employees);
                FileReader.WriteToPeopleFile(people);
                refreshEmployeesPeopleList();

            }
            else
            {
                MessageBox.Show("you have entered incorrect data");
            }
        }

        private void ManageEmployeesPage_VisibleChanged(object sender, EventArgs e)
        {
            LoadAndRefreshEmployeesPeople();
        }

        private void EmployeeOutputButton_Click(object sender, EventArgs e)
        {
            ExportData.OutputEmployeeWages(EmployeeWorkDateTimePicker.Value,OpenFileCheckBox.Checked);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            employeePeopleLinked = OrderListBySearch(employeePeopleLinked, SearchBox.Text);
            EmployeesDataBox.DataSource = employeePeopleLinked;
            RefreshEditPanel();
            EmployeesDataBox.Columns.RemoveAt(5);
        }

        private List<EmployeePeople> OrderListBySearch(List<EmployeePeople> people, string search)
        {
            List<EmployeePeople> newList = new List<EmployeePeople>();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name.Contains(search))
                {
                    newList.Insert(0, people[i]);
                }
                else
                {
                    newList.Add(people[i]);
                }
            }
            return newList;
        }
    }
}
