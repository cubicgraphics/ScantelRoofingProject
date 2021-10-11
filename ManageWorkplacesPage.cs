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
        List<Roof> roofs;
        List<Roof> roofsSetToWorkplace;

        public ManageWorkplacesPage(Form Interface)
        {
            createNewWorkplacePage = new CreateNewWorkplacePage(this);
            simpleRoofEditingPage = new SimpleRoofEditingPage(this);
            employeesSetToWorkplace = new List<EmployeePeople>();
            PrevInterface = Interface;
            InitializeComponent();

            WorkplaceDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkplaceDataTable.MultiSelect = false;



            UpdateWorkplaceAndRefreshTable();

            UpdateEmployeeAtWorksiteList();

        }

        private void RefeshDataTable()
        {
            WorkplaceDataTable.DataSource = workplaces;
        }
        private void UpdateWorkplaceList()
        {
            workplaces = FileReader.ReadFromWorkplacesFile();
        }
        public void UpdateWorkplaceAndRefreshTable()
        {
            UpdateWorkplaceList();
            RefeshDataTable();
        }

        private void UpdateEmployeeAtWorksiteList()
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
                EmployeesAtWorksitelistBox.ValueMember = "ID";
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
            EmployeesListBox.ValueMember = "ID";
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
        }

        private void CreateRoofButton_Click(object sender, EventArgs e)
        {
            simpleRoofEditingPage.Show();
        }

        private void WorkplaceDataTable_Click(object sender, EventArgs e)
        {
            UpdateEmployeeAtWorksiteList();
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

            UpdateEmployeeAtWorksiteList();
        }

        private void AddEmployeeToWorkplaceButton_Click(object sender, EventArgs e)
        {
            List<EmployeeToWorkplace> employeeToWorkplace = FileReader.ReadFromEmployeeToWorkplaceFile();
            employeeToWorkplace.Add(new EmployeeToWorkplace(EmployeeToWorkplace.GetHighestID(employeeToWorkplace) + 1, employees[EmployeesListBox.SelectedIndex].ID, workplaces[WorkplaceDataTable.SelectedCells[0].RowIndex].ID));
            FileReader.WriteToEmployeeToWorkplaceFile(employeeToWorkplace);

            UpdateEmployeeAtWorksiteList();
        }
    }
}
