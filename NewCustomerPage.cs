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
    public partial class NewCustomerPage : Form
    {
        Form PrevPage;

        public NewCustomerPage(ManageCustomersPage CustomersPage)
        {
            PrevPage = CustomersPage;
            InitializeComponent();
        }
        public NewCustomerPage(CreateNewWorkplacePage CustomersPage)
        {
            PrevPage = CustomersPage;
            InitializeComponent();
        }

        private void CreateNewCustomerButton_Click(object sender, EventArgs e)
        {
            List<People> people = FileReader.ReadFromPeopleFile();
            List<Customers> customers = FileReader.ReadFromCustomerFile();
            customers.Add(new Customers(Customers.GetHighestID(customers)+1, People.GetHighestID(people)+1));
            people.Add(new People(People.GetHighestID(people)+1, CustomerNameInputBox.Text, CustomerPhoneInputBox.Text, CustomerEmailInputBox.Text, CustomerAddressInputBox.Text));
            FileReader.WriteToCustomerFile(customers);
            FileReader.WriteToPeopleFile(people);
            PrevPage.Hide();
            PrevPage.Show();
            this.Hide();
            MessageBox.Show("Created new customer:  Name: " + CustomerNameInputBox.Text + " Phone: " + CustomerPhoneInputBox.Text + " Email: " + CustomerEmailInputBox.Text + " Address: " + CustomerAddressInputBox.Text);
        }

        private void NewCustomerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrevPage.Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}
