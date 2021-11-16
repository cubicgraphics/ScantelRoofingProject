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
            try
            {
                int index = RoofsDataGridView.SelectedCells[0].RowIndex;
                ElevationNameBox.Text = Roofs[index].Name;
                ElevationWidthBox.Text = Roofs[index].Width.ToString();
                ElevationLengthBox.Text = Roofs[index].Length.ToString();
                ElevationSlantHeightBox.Text = Roofs[index].SlantAngle.ToString();
            }
            catch
            {

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

            int TileID = TileStocks[NewTileMaterialListBox.SelectedIndex].ID;
            int WoodID = WoodStocks[NewWoodMaterialListBox.SelectedIndex].ID;
            Roofs.Add(new RoofElevation(RoofElevation.GetHighestID(Roofs) + 1, NewElevationNameTextBox.Text, float.Parse(NewLengthTextBox.Text), float.Parse(NewWidthTextBox.Text), float.Parse(NewSlantAngleTextBox.Text), TileID, WoodID));
            FileReader.WriteToRoofFile(Roofs);

            UpdateAndRefreshRoofListAndTable();
            UpdateChangesTextBoxes();
        }

        private void WoodMaterialListBox_VisibleChanged(object sender, EventArgs e)
        {
            LoadAndUpdateRoofData();
            UpdateAndRefreshRoofListAndTable();
            UpdateChangesTextBoxes();
        }

        private void RoofsDataGridView_Click(object sender, EventArgs e)
        {
            UpdateChangesTextBoxes();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int TileID = TileStocks[TileMaterialListBox.SelectedIndex].ID;
            int WoodID = WoodStocks[WoodMaterialListBox.SelectedIndex].ID;
            Roofs[RoofsDataGridView.SelectedCells[0].RowIndex] = new RoofElevation(Roofs[RoofsDataGridView.SelectedCells[0].RowIndex].ID, ElevationNameBox.Text, float.Parse(ElevationLengthBox.Text), float.Parse(ElevationWidthBox.Text), float.Parse(ElevationSlantHeightBox.Text), TileID, WoodID);
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






        //When calculating needed materials for scantel roofs, calculate by diminishing courses - calculate by using small slates first then upwards to bigger ones and calculate how many batons are needed.
    }
}
