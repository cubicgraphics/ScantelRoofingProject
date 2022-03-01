
namespace ScantelRoofingPrototype
{
    partial class StockManagementPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScantleRoofingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SeachBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MaterialNameTextBox = new System.Windows.Forms.TextBox();
            this.MaterialNameLabel = new System.Windows.Forms.Label();
            this.MaterialPriceLabel = new System.Windows.Forms.Label();
            this.MaterialCostTextBox = new System.Windows.Forms.TextBox();
            this.IsTileMaterialCheckBox = new System.Windows.Forms.CheckBox();
            this.IsWoodCheckBox = new System.Windows.Forms.CheckBox();
            this.PricePerMeterCheckBox = new System.Windows.Forms.CheckBox();
            this.PricePerTonneCheckBox = new System.Windows.Forms.CheckBox();
            this.PricePerOneCheckBox = new System.Windows.Forms.CheckBox();
            this.WidthIfRoofTileWidthlabel = new System.Windows.Forms.Label();
            this.TileWidthInputBox = new System.Windows.Forms.TextBox();
            this.LengthIfRoofTIleLabel = new System.Windows.Forms.Label();
            this.TileLengthInputBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.AmountCurrentlyStockedTextBox = new System.Windows.Forms.TextBox();
            this.MaterialAmountStockLabel = new System.Windows.Forms.Label();
            this.AddNewMateriaButton = new System.Windows.Forms.Button();
            this.DeleteSelectedMaterialButton = new System.Windows.Forms.Button();
            this.StocksDataGrid = new System.Windows.Forms.DataGridView();
            this.UseableInScantleCheckbox = new System.Windows.Forms.CheckBox();
            this.MeasurementLabel1 = new System.Windows.Forms.Label();
            this.MeasurementLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ScantleRoofingLabel
            // 
            this.ScantleRoofingLabel.AutoSize = true;
            this.ScantleRoofingLabel.Location = new System.Drawing.Point(12, 9);
            this.ScantleRoofingLabel.Name = "ScantleRoofingLabel";
            this.ScantleRoofingLabel.Size = new System.Drawing.Size(87, 15);
            this.ScantleRoofingLabel.TabIndex = 0;
            this.ScantleRoofingLabel.Text = "Scantle roofing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // SeachBox
            // 
            this.SeachBox.Location = new System.Drawing.Point(72, 53);
            this.SeachBox.Name = "SeachBox";
            this.SeachBox.Size = new System.Drawing.Size(131, 23);
            this.SeachBox.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 56);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Search";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1296, 14);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 37);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MaterialNameTextBox
            // 
            this.MaterialNameTextBox.Location = new System.Drawing.Point(1110, 164);
            this.MaterialNameTextBox.Name = "MaterialNameTextBox";
            this.MaterialNameTextBox.Size = new System.Drawing.Size(131, 23);
            this.MaterialNameTextBox.TabIndex = 6;
            // 
            // MaterialNameLabel
            // 
            this.MaterialNameLabel.AutoSize = true;
            this.MaterialNameLabel.Location = new System.Drawing.Point(1011, 167);
            this.MaterialNameLabel.Name = "MaterialNameLabel";
            this.MaterialNameLabel.Size = new System.Drawing.Size(83, 15);
            this.MaterialNameLabel.TabIndex = 7;
            this.MaterialNameLabel.Text = "Material name";
            // 
            // MaterialPriceLabel
            // 
            this.MaterialPriceLabel.AutoSize = true;
            this.MaterialPriceLabel.Location = new System.Drawing.Point(1011, 191);
            this.MaterialPriceLabel.Name = "MaterialPriceLabel";
            this.MaterialPriceLabel.Size = new System.Drawing.Size(31, 15);
            this.MaterialPriceLabel.TabIndex = 9;
            this.MaterialPriceLabel.Text = "Cost";
            // 
            // MaterialCostTextBox
            // 
            this.MaterialCostTextBox.Location = new System.Drawing.Point(1110, 188);
            this.MaterialCostTextBox.Name = "MaterialCostTextBox";
            this.MaterialCostTextBox.Size = new System.Drawing.Size(131, 23);
            this.MaterialCostTextBox.TabIndex = 7;
            // 
            // IsTileMaterialCheckBox
            // 
            this.IsTileMaterialCheckBox.AutoSize = true;
            this.IsTileMaterialCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsTileMaterialCheckBox.Location = new System.Drawing.Point(1068, 302);
            this.IsTileMaterialCheckBox.Name = "IsTileMaterialCheckBox";
            this.IsTileMaterialCheckBox.Size = new System.Drawing.Size(173, 19);
            this.IsTileMaterialCheckBox.TabIndex = 11;
            this.IsTileMaterialCheckBox.Text = "material is a type of roof tile";
            this.IsTileMaterialCheckBox.UseVisualStyleBackColor = true;
            this.IsTileMaterialCheckBox.CheckedChanged += new System.EventHandler(this.IsTileMaterialCheckBox_CheckedChanged);
            this.IsTileMaterialCheckBox.Click += new System.EventHandler(this.IsTileMaterialCheckBox_Click);
            // 
            // IsWoodCheckBox
            // 
            this.IsWoodCheckBox.AutoSize = true;
            this.IsWoodCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsWoodCheckBox.Location = new System.Drawing.Point(1077, 327);
            this.IsWoodCheckBox.Name = "IsWoodCheckBox";
            this.IsWoodCheckBox.Size = new System.Drawing.Size(164, 19);
            this.IsWoodCheckBox.TabIndex = 12;
            this.IsWoodCheckBox.Text = "material is a type of Wood";
            this.IsWoodCheckBox.UseVisualStyleBackColor = true;
            this.IsWoodCheckBox.CheckedChanged += new System.EventHandler(this.IsWoodCheckBox_CheckedChanged);
            this.IsWoodCheckBox.Click += new System.EventHandler(this.IsWoodCheckBox_Click);
            // 
            // PricePerMeterCheckBox
            // 
            this.PricePerMeterCheckBox.AutoSize = true;
            this.PricePerMeterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PricePerMeterCheckBox.Location = new System.Drawing.Point(1124, 277);
            this.PricePerMeterCheckBox.Name = "PricePerMeterCheckBox";
            this.PricePerMeterCheckBox.Size = new System.Drawing.Size(117, 19);
            this.PricePerMeterCheckBox.TabIndex = 10;
            this.PricePerMeterCheckBox.Text = "Price is per meter";
            this.PricePerMeterCheckBox.UseVisualStyleBackColor = true;
            this.PricePerMeterCheckBox.CheckedChanged += new System.EventHandler(this.PricePerMeterCheckBox_CheckedChanged);
            this.PricePerMeterCheckBox.Click += new System.EventHandler(this.PricePerMeterCheckBox_Click);
            // 
            // PricePerTonneCheckBox
            // 
            this.PricePerTonneCheckBox.AutoSize = true;
            this.PricePerTonneCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PricePerTonneCheckBox.Location = new System.Drawing.Point(1124, 227);
            this.PricePerTonneCheckBox.Name = "PricePerTonneCheckBox";
            this.PricePerTonneCheckBox.Size = new System.Drawing.Size(117, 19);
            this.PricePerTonneCheckBox.TabIndex = 8;
            this.PricePerTonneCheckBox.Text = "Price is per tonne";
            this.PricePerTonneCheckBox.UseVisualStyleBackColor = true;
            this.PricePerTonneCheckBox.CheckedChanged += new System.EventHandler(this.PricePerTonneCheckBox_CheckedChanged);
            this.PricePerTonneCheckBox.Click += new System.EventHandler(this.PricePerTonneCheckBox_Click);
            // 
            // PricePerOneCheckBox
            // 
            this.PricePerOneCheckBox.AutoSize = true;
            this.PricePerOneCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PricePerOneCheckBox.Location = new System.Drawing.Point(1135, 252);
            this.PricePerOneCheckBox.Name = "PricePerOneCheckBox";
            this.PricePerOneCheckBox.Size = new System.Drawing.Size(106, 19);
            this.PricePerOneCheckBox.TabIndex = 9;
            this.PricePerOneCheckBox.Text = "Price is per one";
            this.PricePerOneCheckBox.UseVisualStyleBackColor = true;
            this.PricePerOneCheckBox.CheckedChanged += new System.EventHandler(this.PricePerOneCheckBox_CheckedChanged);
            this.PricePerOneCheckBox.Click += new System.EventHandler(this.PricePerOneCheckBox_Click);
            // 
            // WidthIfRoofTileWidthlabel
            // 
            this.WidthIfRoofTileWidthlabel.AutoSize = true;
            this.WidthIfRoofTileWidthlabel.Location = new System.Drawing.Point(1011, 355);
            this.WidthIfRoofTileWidthlabel.Name = "WidthIfRoofTileWidthlabel";
            this.WidthIfRoofTileWidthlabel.Size = new System.Drawing.Size(93, 15);
            this.WidthIfRoofTileWidthlabel.TabIndex = 16;
            this.WidthIfRoofTileWidthlabel.Text = "Width if roof tile";
            // 
            // TileWidthInputBox
            // 
            this.TileWidthInputBox.Location = new System.Drawing.Point(1110, 352);
            this.TileWidthInputBox.Name = "TileWidthInputBox";
            this.TileWidthInputBox.Size = new System.Drawing.Size(131, 23);
            this.TileWidthInputBox.TabIndex = 13;
            // 
            // LengthIfRoofTIleLabel
            // 
            this.LengthIfRoofTIleLabel.AutoSize = true;
            this.LengthIfRoofTIleLabel.Location = new System.Drawing.Point(1011, 379);
            this.LengthIfRoofTIleLabel.Name = "LengthIfRoofTIleLabel";
            this.LengthIfRoofTIleLabel.Size = new System.Drawing.Size(98, 15);
            this.LengthIfRoofTIleLabel.TabIndex = 18;
            this.LengthIfRoofTIleLabel.Text = "Length if roof tile";
            // 
            // TileLengthInputBox
            // 
            this.TileLengthInputBox.Location = new System.Drawing.Point(1110, 376);
            this.TileLengthInputBox.Name = "TileLengthInputBox";
            this.TileLengthInputBox.Size = new System.Drawing.Size(131, 23);
            this.TileLengthInputBox.TabIndex = 14;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(1011, 430);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(230, 29);
            this.SaveChangesButton.TabIndex = 16;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // AmountCurrentlyStockedTextBox
            // 
            this.AmountCurrentlyStockedTextBox.Location = new System.Drawing.Point(1247, 97);
            this.AmountCurrentlyStockedTextBox.Name = "AmountCurrentlyStockedTextBox";
            this.AmountCurrentlyStockedTextBox.Size = new System.Drawing.Size(131, 23);
            this.AmountCurrentlyStockedTextBox.TabIndex = 3;
            // 
            // MaterialAmountStockLabel
            // 
            this.MaterialAmountStockLabel.AutoSize = true;
            this.MaterialAmountStockLabel.Location = new System.Drawing.Point(1068, 100);
            this.MaterialAmountStockLabel.Name = "MaterialAmountStockLabel";
            this.MaterialAmountStockLabel.Size = new System.Drawing.Size(145, 15);
            this.MaterialAmountStockLabel.TabIndex = 22;
            this.MaterialAmountStockLabel.Text = "Amount currently stocked";
            // 
            // AddNewMateriaButton
            // 
            this.AddNewMateriaButton.Location = new System.Drawing.Point(1260, 164);
            this.AddNewMateriaButton.Name = "AddNewMateriaButton";
            this.AddNewMateriaButton.Size = new System.Drawing.Size(146, 29);
            this.AddNewMateriaButton.TabIndex = 17;
            this.AddNewMateriaButton.Text = "Add new Material";
            this.AddNewMateriaButton.UseVisualStyleBackColor = true;
            this.AddNewMateriaButton.Click += new System.EventHandler(this.AddNewMateriaButton_Click);
            // 
            // DeleteSelectedMaterialButton
            // 
            this.DeleteSelectedMaterialButton.Location = new System.Drawing.Point(1260, 199);
            this.DeleteSelectedMaterialButton.Name = "DeleteSelectedMaterialButton";
            this.DeleteSelectedMaterialButton.Size = new System.Drawing.Size(146, 29);
            this.DeleteSelectedMaterialButton.TabIndex = 18;
            this.DeleteSelectedMaterialButton.Text = "Delete selected material";
            this.DeleteSelectedMaterialButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedMaterialButton.Click += new System.EventHandler(this.DeleteSelectedMaterialButton_Click);
            // 
            // StocksDataGrid
            // 
            this.StocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksDataGrid.Location = new System.Drawing.Point(12, 82);
            this.StocksDataGrid.Name = "StocksDataGrid";
            this.StocksDataGrid.ReadOnly = true;
            this.StocksDataGrid.RowTemplate.Height = 25;
            this.StocksDataGrid.Size = new System.Drawing.Size(993, 377);
            this.StocksDataGrid.TabIndex = 2;
            this.StocksDataGrid.VisibleChanged += new System.EventHandler(this.StocksDataGrid_VisibleChanged);
            this.StocksDataGrid.Click += new System.EventHandler(this.StocksDataGrid_Click);
            // 
            // UseableInScantleCheckbox
            // 
            this.UseableInScantleCheckbox.AutoSize = true;
            this.UseableInScantleCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UseableInScantleCheckbox.Location = new System.Drawing.Point(1121, 405);
            this.UseableInScantleCheckbox.Name = "UseableInScantleCheckbox";
            this.UseableInScantleCheckbox.Size = new System.Drawing.Size(120, 19);
            this.UseableInScantleCheckbox.TabIndex = 15;
            this.UseableInScantleCheckbox.Text = "Useable in scantle";
            this.UseableInScantleCheckbox.UseVisualStyleBackColor = true;
            // 
            // MeasurementLabel1
            // 
            this.MeasurementLabel1.AutoSize = true;
            this.MeasurementLabel1.Location = new System.Drawing.Point(1247, 355);
            this.MeasurementLabel1.Name = "MeasurementLabel1";
            this.MeasurementLabel1.Size = new System.Drawing.Size(18, 15);
            this.MeasurementLabel1.TabIndex = 25;
            this.MeasurementLabel1.Text = "M";
            // 
            // MeasurementLabel2
            // 
            this.MeasurementLabel2.AutoSize = true;
            this.MeasurementLabel2.Location = new System.Drawing.Point(1247, 379);
            this.MeasurementLabel2.Name = "MeasurementLabel2";
            this.MeasurementLabel2.Size = new System.Drawing.Size(18, 15);
            this.MeasurementLabel2.TabIndex = 26;
            this.MeasurementLabel2.Text = "M";
            // 
            // StockManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 491);
            this.Controls.Add(this.MeasurementLabel2);
            this.Controls.Add(this.MeasurementLabel1);
            this.Controls.Add(this.UseableInScantleCheckbox);
            this.Controls.Add(this.StocksDataGrid);
            this.Controls.Add(this.DeleteSelectedMaterialButton);
            this.Controls.Add(this.AddNewMateriaButton);
            this.Controls.Add(this.MaterialAmountStockLabel);
            this.Controls.Add(this.AmountCurrentlyStockedTextBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.LengthIfRoofTIleLabel);
            this.Controls.Add(this.TileLengthInputBox);
            this.Controls.Add(this.WidthIfRoofTileWidthlabel);
            this.Controls.Add(this.TileWidthInputBox);
            this.Controls.Add(this.PricePerOneCheckBox);
            this.Controls.Add(this.PricePerTonneCheckBox);
            this.Controls.Add(this.PricePerMeterCheckBox);
            this.Controls.Add(this.IsWoodCheckBox);
            this.Controls.Add(this.IsTileMaterialCheckBox);
            this.Controls.Add(this.MaterialPriceLabel);
            this.Controls.Add(this.MaterialCostTextBox);
            this.Controls.Add(this.MaterialNameLabel);
            this.Controls.Add(this.MaterialNameTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SeachBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScantleRoofingLabel);
            this.Name = "StockManagementPage";
            this.Text = "StockManagementPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockManagementPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScantleRoofingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeachBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox MaterialNameTextBox;
        private System.Windows.Forms.Label MaterialNameLabel;
        private System.Windows.Forms.Label MaterialPriceLabel;
        private System.Windows.Forms.TextBox MaterialCostTextBox;
        private System.Windows.Forms.CheckBox IsTileMaterialCheckBox;
        private System.Windows.Forms.CheckBox IsWoodCheckBox;
        private System.Windows.Forms.CheckBox PricePerMeterCheckBox;
        private System.Windows.Forms.CheckBox PricePerTonneCheckBox;
        private System.Windows.Forms.CheckBox PricePerOneCheckBox;
        private System.Windows.Forms.Label WidthIfRoofTileWidthlabel;
        private System.Windows.Forms.TextBox TileWidthInputBox;
        private System.Windows.Forms.Label LengthIfRoofTIleLabel;
        private System.Windows.Forms.TextBox TileLengthInputBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox AmountCurrentlyStockedTextBox;
        private System.Windows.Forms.Label MaterialAmountStockLabel;
        private System.Windows.Forms.Button AddNewMateriaButton;
        private System.Windows.Forms.Button DeleteSelectedMaterialButton;
        private System.Windows.Forms.DataGridView StocksDataGrid;
        private System.Windows.Forms.CheckBox UseableInScantleCheckbox;
        private System.Windows.Forms.Label MeasurementLabel1;
        private System.Windows.Forms.Label MeasurementLabel2;
    }
}