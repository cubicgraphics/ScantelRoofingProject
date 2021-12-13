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
        List<RoofElevation> SelectedRoofs;
        List<RoofElevation> Roofs;

        public CreateNewWorkplacePage(Form Interface)
        {
            PrevInterface = Interface;
            newCustomerPage = new NewCustomerPage(this);
            customerstoworkplace = new List<People>();
            SelectedRoofs = new List<RoofElevation>();
            Roofs = new List<RoofElevation>();
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
            Roofs = FileReader.ReadFromRoofFile(); 
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
            List<Workplaces> workplaces = FileReader.ReadFromWorkplacesFile();
            List<CustomerToWorkplace> CustomersToWorkplaces = FileReader.ReadFromCustomerToWorkplaceFile();
            bool beingworkedat = false;
            if (StartDatePicker.Value <= DateTime.Now)
            {
                beingworkedat = true;
            }
            int newworkplaceID = Workplaces.GetHighestID(workplaces);
            workplaces.Add(new Workplaces(
                newworkplaceID + 1, 
                WorkplaceNameInputBox.Text, 
                AddressInputBox.Text, 
                beingworkedat, 
                StartDatePicker.Value, 
                PredictedEndDatePicker.Value, 
                PredictedEndDatePicker.Value
                ));
            for (int i = 0; i < customerstoworkplace.Count; i++)
            {
                CustomersToWorkplaces.Add(new CustomerToWorkplace(CustomerToWorkplace.GetHighestID(CustomersToWorkplaces) + 1, customerstoworkplace[i].ID, newworkplaceID));
            }
            FileReader.WriteToCustomerToWorkplaceFile(CustomersToWorkplaces);
            FileReader.WriteToWorkplaceFile(workplaces);

            WorkplaceNameInputBox.Text = "";
            AddressInputBox.Text = "";

            this.Hide();
            PrevInterface.Show();
        }

        private void CreateNewWorkplacePage_VisibleChanged(object sender, EventArgs e)
        {
            UpdateCustomerLists();
        }

        private void AddCustomerToWorkplaceButton_Click(object sender, EventArgs e)
        {
            if ((customers != null) && (customers.Count >= 1))
            {
                customerstoworkplace.Add(customers[CustomerListBox.SelectedIndex]);
                UpdateCustomerLists();
            }
        }

        private void RemoveCustomerFromWorkplaceButton_Click(object sender, EventArgs e)
        {
            if (CustomersToWorkplaceListBox.SelectedIndex >= 0)
            {
                customerstoworkplace.RemoveAt(CustomersToWorkplaceListBox.SelectedIndex);
                UpdateCustomerLists();
            }
        }

        private void RemoveCustomerFromWorkplaceButton_VisibleChanged(object sender, EventArgs e)
        {
            UpdateCustomerLists();
        }

        private void AddRoofButton_Click(object sender, EventArgs e)
        {
            if ((Roofs != null) && (Roofs.Count >= 1))
            {
                SelectedRoofs.Add(Roofs[RoofListBox.SelectedIndex]);    //       Also add a check to make sure something is selected so no crash
                UpdateRoofsList();
            }
        }

        private void RemoveRoofButton_Click(object sender, EventArgs e)
        {
            if ((Roofs != null) && (Roofs.Count >= 1))
            {
                if (SelectedRoofsListBox.SelectedIndex >= 0)
                {
                    SelectedRoofs.RemoveAt(SelectedRoofsListBox.SelectedIndex);   //could loop to delete the selected customer ID instead of the customers place in the list - use if sorting by ID instead of list order.
                }
                UpdateRoofsList();
            }
        }
    }
}
