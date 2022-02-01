using System;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    public partial class EmployeeAccessPage : Form
    {
        public LoginPage loginPage;
        public EmployeeWorkInputPage employeeWorkInputPage;
        public EmployeeAccessPage()
        {
            employeeWorkInputPage = new EmployeeWorkInputPage(this);
            loginPage = new LoginPage(this);
            InitializeComponent();
        }

        private void LoginPageButton_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Hide();
        }

        private void EnterEmployeeCodeButton_Click(object sender, EventArgs e)
        {
            int ID = Employees.GetIDFromCode(FileReader.ReadFromEmployeeFile(), EmployeeCodeInputBox.Text);
            if (ID != -1)
            {
                CodeNotFoundLabel.Hide();
                employeeWorkInputPage.EmployeeID = ID;
                ID = 0;
                EmployeeCodeInputBox.Text = "";
                this.Hide();
                employeeWorkInputPage.Show();
            }
            else
            {
                CodeNotFoundLabel.Show();
            }

        }

    }
}
