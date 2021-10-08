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

        List<Employees> employees;
        List<Employees> employeesSetToWorkplace;
        List<Roof> roofs;
        List<Roof> roofsSetToWorkplace;

        public ManageWorkplacesPage(Form Interface)
        {
            createNewWorkplacePage = new CreateNewWorkplacePage(this);
            simpleRoofEditingPage = new SimpleRoofEditingPage(this);
            PrevInterface = Interface;
            InitializeComponent();

            WorkplaceDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkplaceDataTable.MultiSelect = false;

            UpdateWorkplaceAndRefreshTable();
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

        private void UpdateEmployeeListBox()
        {
            employees = FileReader.ReadFromEmployeeFile();
            List<EmployeeToWorkplace> employeetoworkplacelink = FileReader.ReadFromEmployeeToWorkplaceFile();
            for (int i = 0; i < employeetoworkplacelink.Count; i++)
            {
                if (employeetoworkplacelink[i].WorkplaceID == WorkplaceDataTable.SelectedCells[0].RowIndex)
                {

                }
            }
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
    }
}
