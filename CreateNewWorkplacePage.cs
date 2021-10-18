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
    public partial class CreateNewWorkplacePage : Form
    {
        Form PrevInterface;
        NewCustomerPage newCustomerPage;
        List<People> customers;
        List<People> customerstoworkplace;
        List<Roof> SelectedRoofs;
        List<Roof> Roofs;

        public CreateNewWorkplacePage(Form Interface)
        {
            PrevInterface = Interface;
            newCustomerPage = new NewCustomerPage(this);
            customerstoworkplace = new List<People>();
            InitializeComponent();
        }

        private void CreateNewWorkplacePage_FormClosing(object sender, FormClosingEventArgs e)
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

        public void UpdateCustomerLists()
        {
            customers = Customers.OnlyCustomers(FileReader.ReadFromPeopleFile(), FileReader.ReadFromCustomerFile());
            CustomerListBox.DataSource = null;
            CustomerListBox.DataSource = customers;
            CustomerListBox.DisplayMember = "Name";

            CustomersToWorkplaceListBox.DataSource = null;
            CustomersToWorkplaceListBox.DataSource = customerstoworkplace;
            CustomersToWorkplaceListBox.DisplayMember = "Name";
        }

        public void UpdateRoofsList()
        {
            //Read from roofs file// Roofs = FileReader.readfromroofing  
            RoofListBox.DataSource = null;
            RoofListBox.DataSource = Roofs;
            RoofListBox.DisplayMember = "Name";

            SelectedRoofsListBox.DataSource = null;
            SelectedRoofsListBox.DataSource = SelectedRoofs;
            SelectedRoofsListBox.DisplayMember = "Name";
        }



        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            newCustomerPage.Show();
        }

        private void CreateWorkplaceButton_Click(object sender, EventArgs e)
        {





            this.Hide();
            PrevInterface.Show();
        }

        private void CreateNewWorkplacePage_VisibleChanged(object sender, EventArgs e)
        {
            UpdateCustomerLists();
        }

        private void AddCustomerToWorkplaceButton_Click(object sender, EventArgs e)
        {
            customerstoworkplace.Add(customers[CustomerListBox.SelectedIndex]);
            UpdateCustomerLists();
        }

        private void RemoveCustomerFromWorkplaceButton_Click(object sender, EventArgs e)
        {
            if (CustomersToWorkplaceListBox.SelectedIndex >= 0)
            {
                customerstoworkplace.RemoveAt(CustomersToWorkplaceListBox.SelectedIndex);     //could loop to delete the selected customer ID instead of the customers place in the list - use if sorting by ID instead of list order.
                UpdateCustomerLists();
            }
        }

        private void RemoveCustomerFromWorkplaceButton_VisibleChanged(object sender, EventArgs e)
        {
            UpdateCustomerLists();
        }

        private void AddRoofButton_Click(object sender, EventArgs e)
        {
            SelectedRoofs.Add(Roofs[RoofListBox.SelectedIndex]);    //       Also add a check to make sure something is selected so no crash
            UpdateRoofsList();

        }

        private void RemoveRoofButton_Click(object sender, EventArgs e)
        {
            if (SelectedRoofsListBox.SelectedIndex >= 0)
            {
                SelectedRoofs.RemoveAt(SelectedRoofsListBox.SelectedIndex);   //could loop to delete the selected customer ID instead of the customers place in the list - use if sorting by ID instead of list order.
            }
            UpdateRoofsList();
        }
    }
}
