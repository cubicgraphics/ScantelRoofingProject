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
    public partial class HighAccessLevelEmployeeInterface : Form
    {
        LoginPage loginPage;
        CreateNewWorkplacePage createNewWorkplacePage;
        ManageEmployeesPage manageEmployeesPage;
        StockManagementPage stockManagementPage;
        ManageCustomersPage manageCustomersPage;
        SimpleRoofEditingPage simpleRoofEditingPage;
        ManageWorkplacesPage manageWorkplacesPage;



        public HighAccessLevelEmployeeInterface(LoginPage login)
        {
            createNewWorkplacePage = new CreateNewWorkplacePage(this);
            manageEmployeesPage = new ManageEmployeesPage(this);
            stockManagementPage = new StockManagementPage(this);
            manageCustomersPage = new ManageCustomersPage(this);
            simpleRoofEditingPage = new SimpleRoofEditingPage(this);
            manageWorkplacesPage = new ManageWorkplacesPage(this);
            loginPage = login;
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage.Show();
        }

        private void HighAccessLevelEmployeeInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginPage.Show();
            e.Cancel = true;
        }

        private void CreateWorkplaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            createNewWorkplacePage.Show();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageEmployeesPage.Show();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            stockManagementPage.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageCustomersPage.Show();
        }

        private void RoofEditorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            simpleRoofEditingPage.Show();
        }

        private void WorkplacesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageWorkplacesPage.Show();
        }
    }
}
