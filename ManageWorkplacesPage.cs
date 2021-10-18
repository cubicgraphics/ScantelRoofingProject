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
        List<Roof> roofs;
        List<Roof> roofsSetToWorkplace;

        public ManageWorkplacesPage(Form Interface)
        {
            createNewWorkplacePage = new CreateNewWorkplacePage(this);
            simpleRoofEditingPage = new SimpleRoofEditingPage(this);
            employeesSetToWorkplace = new List<EmployeePeople>();
            CustomersSetToWorkplace = new List<People>();
            PrevInterface = Interface;
            InitializeComponent();

            WorkplaceDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkplaceDataTable.MultiSelect = false;


        }

        private void RefeshDataTable()
        {
            WorkplaceDataTable.DataSource = workplaces;
        }
        private void UpdateWorkplaceList()
        {
            workplaces = FileReader.ReadFromWorkplacesFile();
        }
        public  void UpdateWorkplaceAndRefreshTable()
        {
            UpdateWorkplaceList();
            RefeshDataTable();
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

        private void UpdateEmployeeList()
        {
            employees = EmployeePeople.CombineEmployeePeopleList(FileReader.ReadFromEmployeeFile(), FileReader.ReadFromPeopleFile());
            EmployeesListBox.DataSource = null;
            EmployeesListBox.DataSource = employees;
            EmployeesListBox.DisplayMember = "Name";
        }
        private void UpdateWorkplaceText()
        {
            int index = WorkplaceDataTable.SelectedCells[0].RowIndex;
            WorkplaceNameBox.Text = workplaces[index].PlaceName;
            StartDateTimePicker.Value = workplaces[index].StartDate;
            PredictedEndDateTimePicker.Value = workplaces[index].PredictedEndDate;
            EndDateTimePicker.Value = workplaces[index].RealEndDate;
            WorkplaceAddressBox.Text = workplaces[index].Address;
            BeingWorkedAtCheckBox.Checked = workplaces[index].BeingWorkedAt;
        }

        private void UpdateCustomerList()
        {
            customers = Customers.OnlyCustomers(FileReader.ReadFromPeopleFile(), FileReader.ReadFromCustomerFile());
            CustomerListBox.DataSource = null;
            CustomerListBox.DataSource = customers;
            CustomerListBox.DisplayMember = "Name";
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
        private void AddEmployeeToWorkplaceButton_Click(object sender, EventArgs e)
        {
            List<EmployeeToWorkplace> employeeToWorkplace = FileReader.ReadFromEmployeeToWorkplaceFile();
            employeeToWorkplace.Add(new EmployeeToWorkplace(EmployeeToWorkplace.GetHighestID(employeeToWorkplace) + 1, employees[EmployeesListBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
            FileReader.WriteToEmployeeToWorkplaceFile(employeeToWorkplace);
            UpdateEmployeeAndEmployeeAtWorksiteList();
        }
        private void AddCustomerToWorkplace_Click(object sender, EventArgs e)
        {
            List<CustomerToWorkplace> customerToWorkplaces = FileReader.ReadFromCustomerToWorkplaceFile();
            customerToWorkplaces.Add(new CustomerToWorkplace(CustomerToWorkplace.GetHighestID(customerToWorkplaces) + 1, customers[CustomerListBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
            FileReader.WriteToCustomerToWorkplaceFile(customerToWorkplaces);
            UpdateCustomersAndCustomersAtWorksiteList();
        }
        private void RemoveCustomerFromWorkplace_Click(object sender, EventArgs e)
        {
            List<CustomerToWorkplace> customerToWorkplaces = FileReader.ReadFromCustomerToWorkplaceFile();
            for (int i = 0; i < customerToWorkplaces.Count; i++)
            {
                if ((customerToWorkplaces[i].WorkplaceID == workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID) && (customerToWorkplaces[i].CustomerID == customers[CustomerAtWorkplaceListBox.SelectedIndex].ID))  //wierd errors happening
                {
                    customerToWorkplaces.RemoveAt(i);
                }
            }
            FileReader.WriteToCustomerToWorkplaceFile(customerToWorkplaces);
            UpdateCustomersAndCustomersAtWorksiteList();
        }

        private void ManageWorkplacesPage_VisibleChanged(object sender, EventArgs e)
        {
            UpdateWorkplaceAndRefreshTable();
            UpdateEmployeeAndEmployeeAtWorksiteList();
            UpdateCustomersAndCustomersAtWorksiteList();
            UpdateWorkplaceText();
        }

        private void SaveWorkplaceChangesButton_Click(object sender, EventArgs e)
        {

            workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex] = new Workplaces(workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID, WorkplaceNameBox.Text, WorkplaceAddressBox.Text, BeingWorkedAtCheckBox.Checked, StartDateTimePicker.Value, PredictedEndDateTimePicker.Value, EndDateTimePicker.Value);
            FileReader.WriteToWorkplaceFile(workplaces);
            UpdateWorkplaceAndRefreshTable();
        }

        private void DeleteSelectedWorkplaceButton_Click(object sender, EventArgs e)
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
}
