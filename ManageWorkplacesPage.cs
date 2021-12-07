﻿using System;
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
    public partial class ManageWorkplacesPage : Form
    {
        Form PrevInterface;
        CreateNewWorkplacePage createNewWorkplacePage;
        SimpleRoofEditingPage simpleRoofEditingPage;

        List<Workplaces> workplaces;

        List<EmployeePeople> employees;
        List<EmployeePeople> employeesSetToWorkplace;
        List<People> customers;
        List<People> CustomersSetToWorkplace;
        List<RoofElevation> roofs;
        List<RoofElevation> roofsSetToWorkplace;

        public ManageWorkplacesPage(Form Interface)
        {
            createNewWorkplacePage = new CreateNewWorkplacePage(this);
            simpleRoofEditingPage = new SimpleRoofEditingPage(this);
            employeesSetToWorkplace = new List<EmployeePeople>();
            CustomersSetToWorkplace = new List<People>();
            roofsSetToWorkplace = new List<RoofElevation>();
            PrevInterface = Interface;
            InitializeComponent();

            WorkplaceDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkplaceDataTable.MultiSelect = false;


        }

        private void RefeshDataTable()
        {
            WorkplaceDataTable.DataSource = workplaces;
            //table editing here

        }
        private void UpdateWorkplaceList()
        {
            workplaces = FileReader.ReadFromWorkplacesFile();
        }
        public  void UpdateWorkplaceAndRefreshTable()
        {
            UpdateWorkplaceList();
            RefeshDataTable();
            UpdateRoofsAndRoofsAtWorksiteList();
            UpdateEmployeeAndEmployeeAtWorksiteList();
            UpdateCustomersAndCustomersAtWorksiteList();
        }

        private void UpdateEmployeeAndEmployeeAtWorksiteList()
        {
            UpdateEmployeeList();
            try
            {
                List<EmployeeToWorkplace> employeetoworkplacelink = FileReader.ReadFromEmployeeToWorkplaceFile();

                employeesSetToWorkplace.Clear();
                for (int i = 0; i < employeetoworkplacelink.Count; i++)
                {
                    if (employeetoworkplacelink[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID)
                    {
                        for (int x = 0; x < employees.Count; x++)
                        {
                            if (employeetoworkplacelink[i].EmployeeID == employees[x].ID)
                            {
                                employeesSetToWorkplace.Add(employees[x]);
                                //add validation to fix duplicate employees in the list
                            
                            }
                        }
                    }
                }


                //also populate the roof lists in another function
                EmployeesAtWorksitelistBox.DataSource = null;
                EmployeesAtWorksitelistBox.DataSource = employeesSetToWorkplace;
                EmployeesAtWorksitelistBox.DisplayMember = "Name";
            }
            catch
            {
            }
        }
        private void UpdateCustomersAndCustomersAtWorksiteList()
        {
            UpdateCustomerList();
            try
            {
                List<CustomerToWorkplace> customerToWorkplaceslink = FileReader.ReadFromCustomerToWorkplaceFile();

                CustomersSetToWorkplace.Clear();
                for (int i = 0; i < customerToWorkplaceslink.Count; i++)
                {
                    if (customerToWorkplaceslink[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID)
                    {
                        for (int x = 0; x < customers.Count; x++)
                        {
                            if (customerToWorkplaceslink[i].CustomerID == customers[x].ID)
                            {
                                CustomersSetToWorkplace.Add(customers[x]);
                                //add validation to fix duplicate customers in the list from being created

                            }
                        }
                    }
                }
                CustomerAtWorkplaceListBox.DataSource = null;
                CustomerAtWorkplaceListBox.DataSource = CustomersSetToWorkplace;
                CustomerAtWorkplaceListBox.DisplayMember = "Name";
            }
            catch
            {
            }
        }

        private void UpdateRoofsAndRoofsAtWorksiteList()
        {
            UpdateRoofList();
            try
            {
                List<WorkplaceToRoof> workplaceToRoofs = FileReader.ReadFromWorkplaceToRoofFile();

                roofsSetToWorkplace.Clear();
                for (int i = 0; i < workplaceToRoofs.Count; i++)
                {
                    if (workplaceToRoofs[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID)
                    {
                        for (int x = 0; x < roofs.Count; x++)
                        {
                            if (workplaceToRoofs[i].RoofID == roofs[x].ID)
                            {
                                roofsSetToWorkplace.Add(roofs[x]);
                                //add validation to fix duplicate customers in the list from being created

                            }
                        }
                    }
                }
                RoofsAtWorksiteListBox.DataSource = null;
                RoofsAtWorksiteListBox.DataSource = roofsSetToWorkplace;
                RoofsAtWorksiteListBox.DisplayMember = "Name";
            }
            catch
            {
            }
        }

        private void UpdateEmployeeList()
        {
            employees = EmployeePeople.CombineEmployeePeopleList(FileReader.ReadFromEmployeeFile(), FileReader.ReadFromPeopleFile());
            EmployeesListBox.DataSource = null;
            EmployeesListBox.DataSource = employees;
            EmployeesListBox.DisplayMember = "Name";
        }
        private void UpdateWorkplaceText()
        {
            if (workplaces.Count != 0)
            {
                int index = WorkplaceDataTable.SelectedCells[0].RowIndex;
                WorkplaceNameBox.Text = workplaces[index].PlaceName;
                StartDateTimePicker.Value = workplaces[index].StartDate;
                PredictedEndDateTimePicker.Value = workplaces[index].PredictedEndDate;
                EndDateTimePicker.Value = workplaces[index].RealEndDate;
                WorkplaceAddressBox.Text = workplaces[index].Address;
                BeingWorkedAtCheckBox.Checked = workplaces[index].BeingWorkedAt;
            }
        }

        private void UpdateCustomerList()
        {
            customers = Customers.OnlyCustomers(FileReader.ReadFromPeopleFile(), FileReader.ReadFromCustomerFile());
            CustomerListBox.DataSource = null;
            CustomerListBox.DataSource = customers;
            CustomerListBox.DisplayMember = "Name";
        }
        private void UpdateRoofList()
        {
            roofs = FileReader.ReadFromRoofFile();
            RoofslistBox.DataSource = null;
            RoofslistBox.DataSource = roofs;
            RoofslistBox.DisplayMember = "Name";
        }


        private void ManageWorkplacesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            PrevInterface.Show();
            e.Cancel = true;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrevInterface.Show();
        }
        private void NewWorkplaceButton_Click(object sender, EventArgs e)
        {
            createNewWorkplacePage.Show();
            this.Hide();
        }
        private void CreateRoofButton_Click(object sender, EventArgs e)
        {
            simpleRoofEditingPage.Show();
        }
        private void WorkplaceDataTable_Click(object sender, EventArgs e)
        {
            UpdateEmployeeAndEmployeeAtWorksiteList();
            UpdateCustomersAndCustomersAtWorksiteList();
            UpdateWorkplaceText();
        }


        private void RemoveEmployeeFromWorkplaceButton_Click(object sender, EventArgs e)
        {
            if (((employees != null) && (employees.Count >= 1)) && ((workplaces != null) && (workplaces.Count >= 1)))
            {
                List<EmployeeToWorkplace> employeeToWorkplace = FileReader.ReadFromEmployeeToWorkplaceFile();
                for (int i = 0; i < employeeToWorkplace.Count; i++)
                {
                    if ((employeeToWorkplace[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID) && (employeeToWorkplace[i].EmployeeID == employeesSetToWorkplace[EmployeesAtWorksitelistBox.SelectedIndex].ID))
                    {
                        employeeToWorkplace.RemoveAt(i);
                    }
                }
                FileReader.WriteToEmployeeToWorkplaceFile(employeeToWorkplace);
                UpdateEmployeeAndEmployeeAtWorksiteList();
            }
        }
        private void AddEmployeeToWorkplaceButton_Click(object sender, EventArgs e)
        {
            if (((employees != null) && (employees.Count >= 1)) && ((workplaces != null) && (workplaces.Count >= 1)))
            {
                List<EmployeeToWorkplace> employeeToWorkplace = FileReader.ReadFromEmployeeToWorkplaceFile();
                employeeToWorkplace.Add(new EmployeeToWorkplace(EmployeeToWorkplace.GetHighestID(employeeToWorkplace) + 1, employees[EmployeesListBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
                FileReader.WriteToEmployeeToWorkplaceFile(employeeToWorkplace);
                UpdateEmployeeAndEmployeeAtWorksiteList();
            }
        }
        private void AddCustomerToWorkplace_Click(object sender, EventArgs e)
        {
            if (((customers != null) && (customers.Count >= 1)) && ((workplaces != null) && (workplaces.Count >= 1)))
            {
                List<CustomerToWorkplace> customerToWorkplaces = FileReader.ReadFromCustomerToWorkplaceFile();
                customerToWorkplaces.Add(new CustomerToWorkplace(CustomerToWorkplace.GetHighestID(customerToWorkplaces) + 1, customers[CustomerListBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
                FileReader.WriteToCustomerToWorkplaceFile(customerToWorkplaces);
                UpdateCustomersAndCustomersAtWorksiteList();
            }

        }
        private void RemoveCustomerFromWorkplace_Click(object sender, EventArgs e)
        {
            if (((customers != null) && (customers.Count >= 1)) && ((workplaces != null) && (workplaces.Count >= 1)))
            {
                List<CustomerToWorkplace> customerToWorkplaces = FileReader.ReadFromCustomerToWorkplaceFile();
                for (int i = 0; i < customerToWorkplaces.Count; i++)
                {
                    if ((customerToWorkplaces[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID) && (customerToWorkplaces[i].CustomerID == customers[CustomerAtWorkplaceListBox.SelectedIndex].ID))
                    {
                        customerToWorkplaces.RemoveAt(i);
                    }
                }
                FileReader.WriteToCustomerToWorkplaceFile(customerToWorkplaces);
                UpdateCustomersAndCustomersAtWorksiteList();
            }
        }

        private void ManageWorkplacesPage_VisibleChanged(object sender, EventArgs e)
        {
            UpdateWorkplaceAndRefreshTable();
            UpdateEmployeeAndEmployeeAtWorksiteList();
            UpdateCustomersAndCustomersAtWorksiteList();
            UpdateRoofsAndRoofsAtWorksiteList();
            UpdateWorkplaceText();
        }

        private void SaveWorkplaceChangesButton_Click(object sender, EventArgs e)
        {
                workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex] = new Workplaces(
                    workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID,
                    WorkplaceNameBox.Text,
                    WorkplaceAddressBox.Text,
                    BeingWorkedAtCheckBox.Checked,
                    StartDateTimePicker.Value,
                    PredictedEndDateTimePicker.Value,
                    EndDateTimePicker.Value
                );
                FileReader.WriteToWorkplaceFile(workplaces);
                UpdateWorkplaceAndRefreshTable();
        }

        private void DeleteSelectedWorkplaceButton_Click(object sender, EventArgs e)
        {
            if ((workplaces != null) && (workplaces.Count >= 1))
            {
                int selectedworkplaceID = workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID;
                int removeat = -1;
                for (int i = 0; i < workplaces.Count; i++)
                {
                    if (selectedworkplaceID == workplaces[i].ID)
                    {
                        removeat = i;
                    }
                }
                workplaces.RemoveAt(removeat);
                FileReader.WriteToWorkplaceFile(workplaces);
                UpdateWorkplaceAndRefreshTable();
            }
        }

        private void AddRoofToWorkplaceButton_Click(object sender, EventArgs e)
        {
            if (((roofs != null) && (roofs.Count >= 1))&&((workplaces != null)&&(workplaces.Count >= 1)))
            {
                List<WorkplaceToRoof> workplacetoroof = FileReader.ReadFromWorkplaceToRoofFile();
                workplacetoroof.Add(new WorkplaceToRoof(WorkplaceToRoof.GetHighestID(workplacetoroof) + 1, roofs[RoofslistBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
                FileReader.WriteToWorkplaceToRoofFile(workplacetoroof);
                UpdateRoofsAndRoofsAtWorksiteList();
            }

        }
        private void RemoveRoofFromWorkplaceButton_Click(object sender, EventArgs e)
        {
            if ((workplaces != null) && (workplaces.Count >= 1))
            {
                List<WorkplaceToRoof> workplacetoroof = FileReader.ReadFromWorkplaceToRoofFile();
                for (int i = 0; i < workplacetoroof.Count; i++)
                {
                    if (workplacetoroof.Count >= 1)
                    {
                        if ((workplacetoroof[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID) && (workplacetoroof[i].RoofID == roofs[RoofsAtWorksiteListBox.SelectedIndex].ID))
                        {
                            workplacetoroof.RemoveAt(i);
                        }
                    }

                }
                FileReader.WriteToWorkplaceToRoofFile(workplacetoroof);
                UpdateRoofsAndRoofsAtWorksiteList();
            }
        }
    }
}
