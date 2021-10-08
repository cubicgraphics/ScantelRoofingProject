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
    public partial class CreateNewWorkplacePage : Form
    {
        Form PrevInterface;
        NewCustomerPage newCustomerPage;

        public CreateNewWorkplacePage(Form Interface)
        {
            PrevInterface = Interface;
            newCustomerPage = new NewCustomerPage(this);
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

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            newCustomerPage.Show();
        }

        private void CreateWorkplaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrevInterface.Show();
        }
    }
}
