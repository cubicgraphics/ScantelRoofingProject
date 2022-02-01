using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    public partial class EmployeeWorkInputPage : Form
    {

        Form PrevInterface;
        public int EmployeeID;

        public EmployeeWorkInputPage(Form prevInterface)
        {
            
            PrevInterface = prevInterface;
            InitializeComponent();
        }
        

        private void DoneButton_Click(object sender, EventArgs e)
        {
            List<ReclaimedSlates> workdone=  FileReader.ReadFromReclaimedSlatesFile();
            workdone.Add(new ReclaimedSlates(workdone.Count, EmployeeID, int.Parse(ReclaimedSlatesInputBox.Value.ToString()), DateTime.Now, TimeSpan.FromHours(int.Parse(TimeWorkedInputBox.Value.ToString()))));
            FileReader.WriteToReclaimedSlatesFile(workdone);
            List<Stocks> stock = FileReader.ReadFromStocksFile();
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].IsATypeOfSlate == false)
                {
                    stock.RemoveAt(i);
                }
            }
            int stockID = stock[SlateMaterialTypesListBox.SelectedIndex].ID;
            stock = FileReader.ReadFromStocksFile();
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].ID == stockID)
                {
                    stock[i].CurrentAmount += float.Parse(ReclaimedSlatesInputBox.Value.ToString());
                }
            }
            FileReader.WriteToStockFile(stock);
            this.Hide();
            PrevInterface.Show();
        }

        private void EmployeeWorkInputPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            PrevInterface.Show();
            e.Cancel = true;
        }

        private void UserNameLabel_VisibleChanged(object sender, EventArgs e)
        {
            UserNameLabel.Text = Employees.GetUserNameFromID(FileReader.ReadFromEmployeeFile(), EmployeeID);
            List<Stocks> stock = FileReader.ReadFromStocksFile();
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].IsATypeOfSlate == false)
                {
                    stock.RemoveAt(i);
                }
            }
            SlateMaterialTypesListBox.DisplayMember = "Name";
            SlateMaterialTypesListBox.DataSource = stock;
        }
    }
}
