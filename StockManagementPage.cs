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
                    MeasurementLabel1.Show();
                    MeasurementLabel2.Show();
                    WidthIfRoofTileWidthlabel.Show();
                    LengthIfRoofTIleLabel.Show();
                    UseableInScantleCheckbox.Show();
                    UseableInScantleCheckbox.Checked = stocks[index].UseableInScantle;
                    TileWidthInputBox.Text = stocks[index].WidthIfSlate.ToString();
                    TileLengthInputBox.Text = stocks[index].LengthIfSlate.ToString();
                }
                else
                {
                    TileWidthInputBox.Hide();
                    MeasurementLabel1.Hide();
                    MeasurementLabel2.Hide();
                    TileLengthInputBox.Hide();
                    WidthIfRoofTileWidthlabel.Hide();
                    LengthIfRoofTIleLabel.Hide();
                    UseableInScantleCheckbox.Hide();
                    UseableInScantleCheckbox.Checked = false;
                    TileWidthInputBox.Text = "0"; //TODO would add conversions between inches and meters(evaluation or stuff that could make program better)
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
            List<Stocks> newList = FileReader.ReadFromStocksFile();
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i].ID == stocks[index].ID)
                {
                    newList.RemoveAt(i);
                    break;
                }
            }
            FileReader.WriteToStockFile(newList);
            UpdateStocksAndStocksDataGrid();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (StocksDataGrid.Rows.Count > 0  && Utill.VerifyIntInput(AmountCurrentlyStockedTextBox.Text)  && Utill.VerifyIntInput(MaterialCostTextBox.Text) && Utill.VerifyIntInput(TileWidthInputBox.Text) && Utill.VerifyIntInput(TileLengthInputBox.Text))
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

                List<Stocks> newList = FileReader.ReadFromStocksFile();
                for (int i = 0; i < newList.Count; i++)
                {
                    if(newList[i].ID == stocks[index].ID)
                    {
                        newList[i] = new Stocks(stocks[index].ID, MaterialNameTextBox.Text, tom, float.Parse(AmountCurrentlyStockedTextBox.Text), float.Parse(MaterialCostTextBox.Text), IsTileMaterialCheckBox.Checked, IsWoodCheckBox.Checked, float.Parse(TileLengthInputBox.Text), float.Parse(TileWidthInputBox.Text), UseableInScantleCheckbox.Checked);
                        break;
                    }
                }
                FileReader.WriteToStockFile(newList);
                UpdateStocksAndStocksDataGrid();
            }
            else
            {
                MessageBox.Show("incorrect data input");
            }
        }

        private void SeachBox_TextChanged(object sender, EventArgs e)
        {
            stocks = OrderListBySearch(stocks, SeachBox.Text);
            UpdateStocksDataGrid();
            RefreshStockSideInfo();
        }

        private List<Stocks> OrderListBySearch(List<Stocks> StocksList, string search)
        {
            List<Stocks> newList = new List<Stocks>();
            for (int i = 0; i < StocksList.Count; i++)
            {
                if (StocksList[i].Name.Contains(search))
                {
                    newList.Insert(0, StocksList[i]);
                }
                else
                {
                    newList.Add(StocksList[i]);
                }
            }
            return newList;
        }
    }
}
