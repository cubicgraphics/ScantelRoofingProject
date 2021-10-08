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
            stockManagementPage.Show();
            this.Hide();
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
            stock.Add(new Stocks(Stocks.GetHighestID(stock) + 1, MaterialNameInputBox.Text, tom, 0, 0, float.Parse(MaterialPriceInputBox.Text), IsTileMaterialCheckBox.Checked, IsWoodCheckBox.Checked,float.Parse(WidthIfRoofTileWidthlabel.Text),float.Parse(LengthIfRoofTIleLabel.Text)));
            FileReader.WriteToStockFile(stock);
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
    }
}
