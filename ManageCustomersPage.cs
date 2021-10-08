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
    public partial class ManageCustomersPage : Form
    {
        HighAccessLevelEmployeeInterface employeeInterface;
        public NewCustomerPage newCustomerPage;

        List<People> customers;


        public ManageCustomersPage(HighAccessLevelEmployeeInterface Interface)
        {
            customers = new List<People>();
            newCustomerPage = new NewCustomerPage(this);
            employeeInterface = Interface;
            InitializeComponent();
            CustomerDataBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataBox.MultiSelect = false;
        }


        private void UpdateCustomersList()
        {
            customers = Customers.OnlyCustomers(FileReader.ReadFromPeopleFile(), FileReader.ReadFromCustomerFile());
        }
        private void updateCustomerDataBox()
        {
            UpdateCustomersList();
            CustomerDataBox.DataSource = customers;
        }

        private void refreshcustomerinfoboxes()
        {
            int index = CustomerDataBox.SelectedCells[0].RowIndex;
            CustomerNameInputBox.Text = customers[index].Name;
            CustomerPhoneInputBox.Text = customers[index].PhoneNumber;
            CustomerEmailInputBox.Text = customers[index].EmailAddress;
            CustomerAddressInputBox.Text = customers[index].Address;

        }


        private void ManageCustomersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            employeeInterface.Show();
            e.Cancel = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeInterface.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            newCustomerPage.Show();
            this.Hide();
        }

        private void ManageCustomersPage_VisibleChanged(object sender, EventArgs e)
        {
            updateCustomerDataBox();
            refreshcustomerinfoboxes();
        }

        private void CustomerDataBox_Click(object sender, EventArgs e)
        {
            refreshcustomerinfoboxes();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int index = CustomerDataBox.SelectedCells[0].RowIndex;
            List<People> people = FileReader.ReadFromPeopleFile();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].ID == customers[index].ID)
                {
                    people[i] = new People(customers[index].ID, CustomerNameInputBox.Text, CustomerPhoneInputBox.Text, CustomerEmailInputBox.Text, CustomerAddressInputBox.Text);
                }
            }
            FileReader.WriteToPeopleFile(people);
            updateCustomerDataBox();
            refreshcustomerinfoboxes();
        }

        private void DeleteSelectedCustomerButton_Click(object sender, EventArgs e)
        {
            int index = CustomerDataBox.SelectedCells[0].RowIndex;
            List<Customers> customersList = FileReader.ReadFromCustomerFile();
            for (int i = 0; i < customersList.Count; i++)
            {
                if (customers[index].ID == customersList[i].PersonID)
                {
                    customersList.RemoveAt(i);
                }
            }
            FileReader.WriteToCustomerFile(customersList);
            updateCustomerDataBox();
            refreshcustomerinfoboxes();
        }
    }
}
