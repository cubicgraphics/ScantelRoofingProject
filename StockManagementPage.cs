using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScantelRoofingPrototype
{
    public partial class StockManagementPage : Form
    {
        HighAccessLevelEmployeeInterface employeeInterface;
        AddNewMaterialPage addNewMaterialPage;
        List<Stocks> stocks;

        public StockManagementPage(HighAccessLevelEmployeeInterface Interface)
        {
            stocks = new List<Stocks>();
            addNewMaterialPage = new AddNewMaterialPage(this);
            employeeInterface = Interface;
            InitializeComponent();
            UpdateStocksAndStocksDataGrid();
            StocksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StocksDataGrid.MultiSelect = false;
        }


        private void UpdateStocks()
        {
            stocks = FileReader.ReadFromStocksFile();
        }
        
        private void UpdateStocksDataGrid()
        {
            StocksDataGrid.DataSource = stocks;
        }

        public void UpdateStocksAndStocksDataGrid()
        {
            UpdateStocks();
            UpdateStocksDataGrid();
        }
        private void RefreshStockSideInfo()
        {
            if(stocks.Count != 0 && StocksDataGrid.SelectedCells.Count >= 1)
            {
                int index = StocksDataGrid.SelectedCells[0].RowIndex;
                AmountCurrentlyStockedTextBox.Text = stocks[index].CurrentAmount.ToString();
                AmountNeededForWorkplacesTextBox.Text = stocks[index].ReservedForWorkplaces.ToString();
                if (stocks[index].ReservedForWorkplaces - stocks[index].CurrentAmount > 0)
                {
                    AmountToBuyAndCostLabelOutput.Text = (stocks[index].ReservedForWorkplaces - stocks[index].CurrentAmount).ToString() + " £" + ((stocks[index].ReservedForWorkplaces - stocks[index].CurrentAmount) * stocks[index].Cost).ToString();
                }
                else
                {
                    AmountToBuyAndCostLabelOutput.Text = "0";
                }
                MaterialNameTextBox.Text = stocks[index].Name;
                MaterialCostTextBox.Text = stocks[index].Cost.ToString();
                if (stocks[index].TOM == 0)
                {
                    PricePerTonneCheckBox.Checked = true;
                }
                else if (stocks[index].TOM == 1)
                {
                    PricePerOneCheckBox.Checked = true;
                }
                else if (stocks[index].TOM == 2)
                {
                    PricePerMeterCheckBox.Checked = true;
                }
                IsTileMaterialCheckBox.Checked = stocks[index].IsATypeOfSlate;
                IsWoodCheckBox.Checked = stocks[index].IsATypeOfWood;
                if (stocks[index].IsATypeOfSlate == true)
                {
                    TileWidthInputBox.Show();
                    TileLengthInputBox.Show();
                    WidthIfRoofTileWidthlabel.Show();
                    LengthIfRoofTIleLabel.Show();
                    TileWidthInputBox.Text = stocks[index].WidthIfSlate.ToString();
                    TileLengthInputBox.Text = stocks[index].LengthIfSlate.ToString();
                }
                else
                {
                    TileWidthInputBox.Hide();
                    TileLengthInputBox.Hide();
                    WidthIfRoofTileWidthlabel.Hide();
                    LengthIfRoofTIleLabel.Hide();
                    TileWidthInputBox.Text = "0";
                    TileLengthInputBox.Text = "0";
                }

            }

        }



        private void StockManagementPage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddNewMateriaButton_Click(object sender, EventArgs e)
        {
            addNewMaterialPage.Show();
            this.Hide();
        }

        private void StocksDataGrid_VisibleChanged(object sender, EventArgs e)
        {
            UpdateStocksAndStocksDataGrid();
            RefreshStockSideInfo();
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
                int index = StocksDataGrid.SelectedCells[0].RowIndex;
                TileWidthInputBox.Show();
                TileLengthInputBox.Show();
                WidthIfRoofTileWidthlabel.Show();
                LengthIfRoofTIleLabel.Show();
                TileWidthInputBox.Text = stocks[index].WidthIfSlate.ToString();
                TileLengthInputBox.Text = stocks[index].LengthIfSlate.ToString();
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

        private void StocksDataGrid_Click(object sender, EventArgs e)
        {
            RefreshStockSideInfo();
        }



        private void PricePerTonneCheckBox_Click(object sender, EventArgs e)
        {
            PricePerTonneCheckBox.Checked = true;
        }
        private void PricePerOneCheckBox_Click(object sender, EventArgs e)
        {
            PricePerOneCheckBox.Checked = true;
        }
        private void PricePerMeterCheckBox_Click(object sender, EventArgs e)
        {
            PricePerMeterCheckBox.Checked = true;
        }

        private void IsTileMaterialCheckBox_Click(object sender, EventArgs e)
        {
            IsTileMaterialCheckBox.Checked = true;
        }
        private void IsWoodCheckBox_Click(object sender, EventArgs e)
        {
            IsWoodCheckBox.Checked = true;
        }

        private void DeleteSelectedMaterialButton_Click(object sender, EventArgs e)
        {
            int index = StocksDataGrid.SelectedCells[0].RowIndex;
            stocks.RemoveAt(index);
            FileReader.WriteToStockFile(stocks);
            UpdateStocksAndStocksDataGrid();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (StocksDataGrid.Rows.Count > 0  && Utill.VerifyIntInput(AmountCurrentlyStockedTextBox.Text) && Utill.VerifyIntInput(AmountNeededForWorkplacesTextBox.Text) && Utill.VerifyIntInput(MaterialCostTextBox.Text) && Utill.VerifyIntInput(TileWidthInputBox.Text) && Utill.VerifyIntInput(TileLengthInputBox.Text))
            {
            int index = StocksDataGrid.SelectedCells[0].RowIndex;
            int tom = 0;
            if (PricePerOneCheckBox.Checked == true)
            {
                tom = 1;
            }
            else if (PricePerMeterCheckBox.Checked == true)
            {
                tom = 2;
            }
            stocks[index] = new Stocks(stocks[index].ID, MaterialNameTextBox.Text, tom, float.Parse(AmountCurrentlyStockedTextBox.Text), float.Parse(AmountNeededForWorkplacesTextBox.Text), float.Parse(MaterialCostTextBox.Text), IsTileMaterialCheckBox.Checked, IsWoodCheckBox.Checked, float.Parse(TileWidthInputBox.Text), float.Parse(TileLengthInputBox.Text), UseableInScantleCheckbox.Checked);
            FileReader.WriteToStockFile(stocks);
            UpdateStocksAndStocksDataGrid();
            }
            else
            {
                MessageBox.Show("incorrect data input");
            }
        }
    }
}
