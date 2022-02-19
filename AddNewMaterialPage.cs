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
    public partial class AddNewMaterialPage : Form
    {
        StockManagementPage stockManagementPage;
        public AddNewMaterialPage(StockManagementPage stock)
        {
            stockManagementPage = stock;
            InitializeComponent();
        }

        private void CreateNewMaterialButton_Click(object sender, EventArgs e)
        {
            if (Utill.VerifyIntInput(MaterialPriceInputBox.Text) && Utill.VerifyIntInput(TileWidthInputBox.Text) && Utill.VerifyIntInput(TileLengthInputBox.Text))
            {

                List<Stocks> stock = FileReader.ReadFromStocksFile();
                int tom = 0;
                if (PricePerOneCheckBox.Checked == true)
                {
                    tom = 1;
                }
                else if (PricePerMeterCheckBox.Checked == true)
                {
                    tom = 2;
                }
                stock.Add(new Stocks(
                    (Stocks.GetHighestID(stock) + 1),
                    MaterialNameInputBox.Text,
                    tom,
                    0,
                    float.Parse(MaterialPriceInputBox.Text),
                    IsTileMaterialCheckBox.Checked,
                    IsWoodCheckBox.Checked,
                    float.Parse(TileWidthInputBox.Text),
                    float.Parse(TileLengthInputBox.Text),
                    UseableInScantleCheckbox.Checked
                    ));
                FileReader.WriteToStockFile(stock);

                stockManagementPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cannot use letters in a number input");
            }
        }

        private void AddNewMaterialPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            stockManagementPage.Show();
            this.Hide();
            e.Cancel = true;
        }








        private void PricePerMeterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PricePerMeterCheckBox.Checked == true)
            {
                PricePerTonneCheckBox.Checked = false;
                PricePerOneCheckBox.Checked = false;
            }
        }
        private void PricePerTonneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PricePerTonneCheckBox.Checked == true)
            {
                PricePerMeterCheckBox.Checked = false;
                PricePerOneCheckBox.Checked = false;
            }
        }
        private void PricePerOneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PricePerOneCheckBox.Checked == true)
            {
                PricePerTonneCheckBox.Checked = false;
                PricePerMeterCheckBox.Checked = false;
            }
        }

        private void IsTileMaterialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsTileMaterialCheckBox.Checked == true)
            {
                IsWoodCheckBox.Checked = false;
                TileWidthInputBox.Show();
                TileLengthInputBox.Show();
                UseableInScantleCheckbox.Show();
                WidthIfRoofTileWidthlabel.Show();
                LengthIfRoofTIleLabel.Show();
            }
        }
        private void IsWoodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsWoodCheckBox.Checked == true)
            {
                IsTileMaterialCheckBox.Checked = false;
                TileWidthInputBox.Hide();
                TileLengthInputBox.Hide();
                UseableInScantleCheckbox.Hide();
                WidthIfRoofTileWidthlabel.Hide();
                LengthIfRoofTIleLabel.Hide();
                TileWidthInputBox.Text = "0";
                TileLengthInputBox.Text = "0";
            }
        }
        private void PricePerMeterCheckBox_Click(object sender, EventArgs e)
        {
            PricePerMeterCheckBox.Checked = true;
        }
        private void PricePerTonneCheckBox_Click(object sender, EventArgs e)
        {
            PricePerTonneCheckBox.Checked = true;
        }
        private void PricePerOneCheckBox_Click(object sender, EventArgs e)
        {
            PricePerOneCheckBox.Checked = true;
        }
        private void IsTileMaterialCheckBox_Click(object sender, EventArgs e)
        {
            IsTileMaterialCheckBox.Checked = true;
        }
        private void IsWoodCheckBox_Click(object sender, EventArgs e)
        {
            IsWoodCheckBox.Checked = true;
        }
        private void AddNewMaterialPage_VisibleChanged(object sender, EventArgs e)
        {
            PricePerOneCheckBox.Checked = true;
            IsTileMaterialCheckBox.Checked = true;
        }

        private void WidthIfRoofTileWidthlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
