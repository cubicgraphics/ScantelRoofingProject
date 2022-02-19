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
        List<RoofElevation> Roofs;
        List<Stocks> stocks;
        List<Stocks> WoodStocks;
        List<Stocks> TileStocks;

        public SimpleRoofEditingPage(Form Interface)

        {
            PrevInterface = Interface;
            InitializeComponent();
            WoodStocks = new List<Stocks>();
            TileStocks = new List<Stocks>();
            RoofsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RoofsDataGridView.MultiSelect = false;
            UpdateAndRefreshRoofListAndTable();
        }

        public void UpdateAndRefreshRoofListAndTable()
        {
            UpdateRoofList();
            RefreshRoofDataTable();
        }
        private void UpdateRoofList()
        {
            Roofs = FileReader.ReadFromRoofFile();
        }
        private void RefreshRoofDataTable()
        {
            RoofsDataGridView.DataSource = Roofs;
        }

        private void LoadAndUpdateRoofData()
        {
            UpdateMaterialLists();
            TileMaterialListBox.DataSource = null;
            TileMaterialListBox.DataSource = TileStocks;
            TileMaterialListBox.DisplayMember = "Name";

            WoodMaterialListBox.DataSource = null;
            WoodMaterialListBox.DataSource = WoodStocks;
            WoodMaterialListBox.DisplayMember = "Name";

            
            NewTileMaterialListBox.DataSource = null;
            NewTileMaterialListBox.DataSource = TileStocks;
            NewTileMaterialListBox.DisplayMember = "Name";

            NewWoodMaterialListBox.DataSource = null;
            NewWoodMaterialListBox.DataSource = WoodStocks;
            NewWoodMaterialListBox.DisplayMember = "Name";
            
        }

        private void UpdateMaterialLists()
        {
            stocks = FileReader.ReadFromStocksFile();
            WoodStocks = new List<Stocks>();
            TileStocks = new List<Stocks>();
            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].IsATypeOfSlate == true)
                {
                    TileStocks.Add(stocks[i]);
                }
                else if (stocks[i].IsATypeOfWood == true)
                {
                    WoodStocks.Add(stocks[i]);       
                }
            }
        }
        private void UpdateChangesTextBoxes()
        {
            if(Roofs.Count != 0)
            {
                int index = RoofsDataGridView.SelectedCells[0].RowIndex;
                ElevationNameBox.Text = Roofs[index].Name;
                ElevationWidthBox.Text = Roofs[index].Width.ToString();
                ElevationLengthBox.Text = Roofs[index].Length.ToString();
                ElevationSlantAngleBox.Text = Roofs[index].SlantAngle.ToString();
                ScantleRoofCheckBox.Checked = Roofs[index].Scantle;
            }
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

        private void CreateNewElevationButton_Click(object sender, EventArgs e)
        {
            if ((TileStocks.Count != 0) || (WoodStocks.Count != 0))
            {
                int TileID = TileStocks[NewTileMaterialListBox.SelectedIndex].ID;
                int WoodID = WoodStocks[NewWoodMaterialListBox.SelectedIndex].ID;
                Roofs.Add(new RoofElevation(RoofElevation.GetHighestID(Roofs) + 1, NewElevationNameTextBox.Text, float.Parse(NewLengthTextBox.Text), float.Parse(NewWidthTextBox.Text), float.Parse(NewSlantAngleTextBox.Text), TileID, WoodID, NewScantleRoofCheckBoxLabel.Checked));
                FileReader.WriteToRoofFile(Roofs);
                UpdateAndRefreshRoofListAndTable();
                UpdateChangesTextBoxes();
            }
        }

        private void RoofsDataGridView_Click(object sender, EventArgs e)
        {
            UpdateChangesTextBoxes();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int index = RoofsDataGridView.SelectedCells[0].RowIndex;
            RoofElevation roof = new RoofElevation(Roofs[index].ID, ElevationNameBox.Text,float.Parse( ElevationLengthBox.Text),float.Parse(ElevationWidthBox.Text),float.Parse(ElevationSlantAngleBox.Text), TileStocks[TileMaterialListBox.SelectedIndex].ID, WoodStocks[WoodMaterialListBox.SelectedIndex].ID,ScantleRoofCheckBox.Checked);
            Roofs[index] = roof;
            FileReader.WriteToRoofFile(Roofs);
            UpdateAndRefreshRoofListAndTable();
            UpdateChangesTextBoxes();
        }

        private void RemoveElevationButton_Click(object sender, EventArgs e)
        {
            Roofs.RemoveAt(RoofsDataGridView.SelectedCells[0].RowIndex);
            FileReader.WriteToRoofFile(Roofs);
            UpdateAndRefreshRoofListAndTable();
            UpdateChangesTextBoxes();
        }

        private void ScantleRoofCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ScantleRoofCheckBox.Checked == true)
            {
                ElevationTileMaterialLabel.Hide();
                TileMaterialListBox.Hide();
            }
            else
            {
                ElevationTileMaterialLabel.Show();
                TileMaterialListBox.Show();
            }
        }

        private void SimpleRoofEditingPage_VisibleChanged(object sender, EventArgs e)
        {
            LoadAndUpdateRoofData();
            UpdateAndRefreshRoofListAndTable();
            UpdateChangesTextBoxes();
        }

        private void CalculateRoofButton_Click(object sender, EventArgs e)
        {
            RoofOutputMultiLineTextBox.Lines = ExportData.CalculatePlainRoof(Roofs[RoofsDataGridView.SelectedCells[0].RowIndex], FileReader.ReadFromStocksFile());

        }

        private void SaveOutputButton_Click(object sender, EventArgs e)
        {
            //takes what is in the test box and saves it to a file
        }
    }
}
