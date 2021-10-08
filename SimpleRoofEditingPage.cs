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
    public partial class SimpleRoofEditingPage : Form
    {
        Form PrevInterface;

        public SimpleRoofEditingPage(Form Interface)
        {
            PrevInterface = Interface;
            InitializeComponent();
        }

        private void SimpleRoofEditingPage_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
