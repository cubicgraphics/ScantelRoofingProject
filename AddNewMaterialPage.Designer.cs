
namespace ScantelRoofingPrototype
{
    partial class AddNewMaterialPage
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
            this.CreateNewMaterialButton = new System.Windows.Forms.Button();
            this.LengthIfRoofTIleLabel = new System.Windows.Forms.Label();
            this.TileLengthInputBox = new System.Windows.Forms.TextBox();
            this.WidthIfRoofTileWidthlabel = new System.Windows.Forms.Label();
            this.TileWidthInputBox = new System.Windows.Forms.TextBox();
            this.PricePerOneCheckBox = new System.Windows.Forms.CheckBox();
            this.PricePerTonneCheckBox = new System.Windows.Forms.CheckBox();
            this.PricePerMeterCheckBox = new System.Windows.Forms.CheckBox();
            this.IsWoodCheckBox = new System.Windows.Forms.CheckBox();
            this.IsTileMaterialCheckBox = new System.Windows.Forms.CheckBox();
            this.MaterialPriceLabel = new System.Windows.Forms.Label();
            this.MaterialPriceInputBox = new System.Windows.Forms.TextBox();
            this.MaterialNameLabel = new System.Windows.Forms.Label();
            this.MaterialNameInputBox = new System.Windows.Forms.TextBox();
            this.UseableInScantleCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CreateNewMaterialButton
            // 
            this.CreateNewMaterialButton.Location = new System.Drawing.Point(12, 277);
            this.CreateNewMaterialButton.Name = "CreateNewMaterialButton";
            this.CreateNewMaterialButton.Size = new System.Drawing.Size(230, 29);
            this.CreateNewMaterialButton.TabIndex = 33;
            this.CreateNewMaterialButton.Text = "Create new material";
            this.CreateNewMaterialButton.UseVisualStyleBackColor = true;
            this.CreateNewMaterialButton.Click += new System.EventHandler(this.CreateNewMaterialButton_Click);
            // 
            // LengthIfRoofTIleLabel
            // 
            this.LengthIfRoofTIleLabel.AutoSize = true;
            this.LengthIfRoofTIleLabel.Location = new System.Drawing.Point(12, 221);
            this.LengthIfRoofTIleLabel.Name = "LengthIfRoofTIleLabel";
            this.LengthIfRoofTIleLabel.Size = new System.Drawing.Size(98, 15);
            this.LengthIfRoofTIleLabel.TabIndex = 32;
            this.LengthIfRoofTIleLabel.Text = "Length if roof tile";
            // 
            // TileLengthInputBox
            // 
            this.TileLengthInputBox.Location = new System.Drawing.Point(111, 218);
            this.TileLengthInputBox.Name = "TileLengthInputBox";
            this.TileLengthInputBox.Size = new System.Drawing.Size(131, 23);
            this.TileLengthInputBox.TabIndex = 31;
            // 
            // WidthIfRoofTileWidthlabel
            // 
            this.WidthIfRoofTileWidthlabel.AutoSize = true;
            this.WidthIfRoofTileWidthlabel.Location = new System.Drawing.Point(12, 197);
            this.WidthIfRoofTileWidthlabel.Name = "WidthIfRoofTileWidthlabel";
            this.WidthIfRoofTileWidthlabel.Size = new System.Drawing.Size(93, 15);
            this.WidthIfRoofTileWidthlabel.TabIndex = 30;
            this.WidthIfRoofTileWidthlabel.Text = "Width if roof tile";
            // 
            // TileWidthInputBox
            // 
            this.TileWidthInputBox.Location = new System.Drawing.Point(111, 194);
            this.TileWidthInputBox.Name = "TileWidthInputBox";
            this.TileWidthInputBox.Size = new System.Drawing.Size(131, 23);
            this.TileWidthInputBox.TabIndex = 29;
            // 
            // PricePerOneCheckBox
            // 
            this.PricePerOneCheckBox.AutoSize = true;
            this.PricePerOneCheckBox.Location = new System.Drawing.Point(12, 87);
            this.PricePerOneCheckBox.Name = "PricePerOneCheckBox";
            this.PricePerOneCheckBox.Size = new System.Drawing.Size(106, 19);
            this.PricePerOneCheckBox.TabIndex = 28;
            this.PricePerOneCheckBox.Text = "Price is per one";
            this.PricePerOneCheckBox.UseVisualStyleBackColor = true;
            this.PricePerOneCheckBox.CheckedChanged += new System.EventHandler(this.PricePerOneCheckBox_CheckedChanged);
            this.PricePerOneCheckBox.Click += new System.EventHandler(this.PricePerOneCheckBox_Click);
            // 
            // PricePerTonneCheckBox
            // 
            this.PricePerTonneCheckBox.AutoSize = true;
            this.PricePerTonneCheckBox.Location = new System.Drawing.Point(12, 59);
            this.PricePerTonneCheckBox.Name = "PricePerTonneCheckBox";
            this.PricePerTonneCheckBox.Size = new System.Drawing.Size(117, 19);
            this.PricePerTonneCheckBox.TabIndex = 27;
            this.PricePerTonneCheckBox.Text = "Price is per tonne";
            this.PricePerTonneCheckBox.UseVisualStyleBackColor = true;
            this.PricePerTonneCheckBox.CheckedChanged += new System.EventHandler(this.PricePerTonneCheckBox_CheckedChanged);
            this.PricePerTonneCheckBox.Click += new System.EventHandler(this.PricePerTonneCheckBox_Click);
            // 
            // PricePerMeterCheckBox
            // 
            this.PricePerMeterCheckBox.AutoSize = true;
            this.PricePerMeterCheckBox.Location = new System.Drawing.Point(12, 112);
            this.PricePerMeterCheckBox.Name = "PricePerMeterCheckBox";
            this.PricePerMeterCheckBox.Size = new System.Drawing.Size(117, 19);
            this.PricePerMeterCheckBox.TabIndex = 26;
            this.PricePerMeterCheckBox.Text = "Price is per meter";
            this.PricePerMeterCheckBox.UseVisualStyleBackColor = true;
            this.PricePerMeterCheckBox.CheckedChanged += new System.EventHandler(this.PricePerMeterCheckBox_CheckedChanged);
            this.PricePerMeterCheckBox.Click += new System.EventHandler(this.PricePerMeterCheckBox_Click);
            // 
            // IsWoodCheckBox
            // 
            this.IsWoodCheckBox.AutoSize = true;
            this.IsWoodCheckBox.Location = new System.Drawing.Point(12, 169);
            this.IsWoodCheckBox.Name = "IsWoodCheckBox";
            this.IsWoodCheckBox.Size = new System.Drawing.Size(164, 19);
            this.IsWoodCheckBox.TabIndex = 25;
            this.IsWoodCheckBox.Text = "material is a type of Wood";
            this.IsWoodCheckBox.UseVisualStyleBackColor = true;
            this.IsWoodCheckBox.CheckedChanged += new System.EventHandler(this.IsWoodCheckBox_CheckedChanged);
            this.IsWoodCheckBox.Click += new System.EventHandler(this.IsWoodCheckBox_Click);
            // 
            // IsTileMaterialCheckBox
            // 
            this.IsTileMaterialCheckBox.AutoSize = true;
            this.IsTileMaterialCheckBox.Location = new System.Drawing.Point(12, 141);
            this.IsTileMaterialCheckBox.Name = "IsTileMaterialCheckBox";
            this.IsTileMaterialCheckBox.Size = new System.Drawing.Size(173, 19);
            this.IsTileMaterialCheckBox.TabIndex = 24;
            this.IsTileMaterialCheckBox.Text = "material is a type of roof tile";
            this.IsTileMaterialCheckBox.UseVisualStyleBackColor = true;
            this.IsTileMaterialCheckBox.CheckedChanged += new System.EventHandler(this.IsTileMaterialCheckBox_CheckedChanged);
            this.IsTileMaterialCheckBox.Click += new System.EventHandler(this.IsTileMaterialCheckBox_Click);
            // 
            // MaterialPriceLabel
            // 
            this.MaterialPriceLabel.AutoSize = true;
            this.MaterialPriceLabel.Location = new System.Drawing.Point(12, 33);
            this.MaterialPriceLabel.Name = "MaterialPriceLabel";
            this.MaterialPriceLabel.Size = new System.Drawing.Size(31, 15);
            this.MaterialPriceLabel.TabIndex = 23;
            this.MaterialPriceLabel.Text = "Cost";
            // 
            // MaterialPriceInputBox
            // 
            this.MaterialPriceInputBox.Location = new System.Drawing.Point(111, 30);
            this.MaterialPriceInputBox.Name = "MaterialPriceInputBox";
            this.MaterialPriceInputBox.Size = new System.Drawing.Size(131, 23);
            this.MaterialPriceInputBox.TabIndex = 22;
            // 
            // MaterialNameLabel
            // 
            this.MaterialNameLabel.AutoSize = true;
            this.MaterialNameLabel.Location = new System.Drawing.Point(12, 9);
            this.MaterialNameLabel.Name = "MaterialNameLabel";
            this.MaterialNameLabel.Size = new System.Drawing.Size(83, 15);
            this.MaterialNameLabel.TabIndex = 21;
            this.MaterialNameLabel.Text = "Material name";
            // 
            // MaterialNameInputBox
            // 
            this.MaterialNameInputBox.Location = new System.Drawing.Point(111, 6);
            this.MaterialNameInputBox.Name = "MaterialNameInputBox";
            this.MaterialNameInputBox.Size = new System.Drawing.Size(131, 23);
            this.MaterialNameInputBox.TabIndex = 20;
            // 
            // UseableInScantleCheckbox
            // 
            this.UseableInScantleCheckbox.AutoSize = true;
            this.UseableInScantleCheckbox.Location = new System.Drawing.Point(12, 247);
            this.UseableInScantleCheckbox.Name = "UseableInScantleCheckbox";
            this.UseableInScantleCheckbox.Size = new System.Drawing.Size(120, 19);
            this.UseableInScantleCheckbox.TabIndex = 34;
            this.UseableInScantleCheckbox.Text = "Useable in scantle";
            this.UseableInScantleCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddNewMaterialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 318);
            this.Controls.Add(this.UseableInScantleCheckbox);
            this.Controls.Add(this.CreateNewMaterialButton);
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
            this.Controls.Add(this.MaterialPriceInputBox);
            this.Controls.Add(this.MaterialNameLabel);
            this.Controls.Add(this.MaterialNameInputBox);
            this.Name = "AddNewMaterialPage";
            this.Text = "AddNewMaterialPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewMaterialPage_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.AddNewMaterialPage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNewMaterialButton;
        private System.Windows.Forms.Label LengthIfRoofTIleLabel;
        private System.Windows.Forms.TextBox TileLengthInputBox;
        private System.Windows.Forms.Label WidthIfRoofTileWidthlabel;
        private System.Windows.Forms.TextBox TileWidthInputBox;
        private System.Windows.Forms.CheckBox PricePerOneCheckBox;
        private System.Windows.Forms.CheckBox PricePerTonneCheckBox;
        private System.Windows.Forms.CheckBox PricePerMeterCheckBox;
        private System.Windows.Forms.CheckBox IsWoodCheckBox;
        private System.Windows.Forms.CheckBox IsTileMaterialCheckBox;
        private System.Windows.Forms.Label MaterialPriceLabel;
        private System.Windows.Forms.TextBox MaterialPriceInputBox;
        private System.Windows.Forms.Label MaterialNameLabel;
        private System.Windows.Forms.TextBox MaterialNameInputBox;
        private System.Windows.Forms.CheckBox UseableInScantleCheckbox;
    }
}