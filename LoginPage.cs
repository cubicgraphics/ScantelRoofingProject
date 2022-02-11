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
    public partial class LoginPage : Form
    {
        public EmployeeAccessPage AccessPage;
        public HighAccessLevelEmployeeInterface highLevelEmployeeInterface;
        public LowAccessLevelEmployeeInterface lowAccessLevelEmployeeInterface;

        public LoginPage(EmployeeAccessPage access)
        {
            highLevelEmployeeInterface = new HighAccessLevelEmployeeInterface(this);
            lowAccessLevelEmployeeInterface = new LowAccessLevelEmployeeInterface(this);
            AccessPage = access;
            InitializeComponent();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AccessPage.Show();
            e.Cancel = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            if (UsernameInput.Text != "")
            {
                int ID = Employees.GetIDFromUserPassword(FileReader.ReadFromEmployeeFile(), UsernameInput.Text, PasswordInput.Text);
                if(ID != -1)
                {
                    if (Employees.IsEmployeeAccessLevel(FileReader.ReadFromEmployeeFile(), 0, ID) == true)
                    {
                        lowAccessLevelEmployeeInterface.UserID = ID;
                        lowAccessLevelEmployeeInterface.Show();
                        this.Hide();
                    }
                    else
                    {
                        highLevelEmployeeInterface.UserID = ID;
                        highLevelEmployeeInterface.Show();
                        this.Hide();
                    }
                }
            }
            else //TODO this is here for testing purposes - it bypasses the need for a password. remove it eventually
            {
                highLevelEmployeeInterface.UserID = 0;
                highLevelEmployeeInterface.Show();
                this.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccessPage.Show();
        }
    }
}
