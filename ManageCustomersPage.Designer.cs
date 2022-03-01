
namespace ScantelRoofingPrototype
{
    partial class ManageCustomersPage
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
            this.ScantelRoofingLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CustomerAddressInputBox = new System.Windows.Forms.TextBox();
            this.CustomerEmailInputBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneInputBox = new System.Windows.Forms.TextBox();
            this.CustomerNameInputBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerEmailLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.DeleteSelectedCustomerButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ScantelRoofingLabel
            // 
            this.ScantelRoofingLabel.AutoSize = true;
            this.ScantelRoofingLabel.Location = new System.Drawing.Point(12, 9);
            this.ScantelRoofingLabel.Name = "ScantelRoofingLabel";
            this.ScantelRoofingLabel.Size = new System.Drawing.Size(87, 15);
            this.ScantelRoofingLabel.TabIndex = 0;
            this.ScantelRoofingLabel.Text = "Scantle roofing";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(60, 50);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(171, 23);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(706, 309);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(104, 23);
            this.SaveChangesButton.TabIndex = 7;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CustomerAddressInputBox
            // 
            this.CustomerAddressInputBox.Location = new System.Drawing.Point(736, 272);
            this.CustomerAddressInputBox.Name = "CustomerAddressInputBox";
            this.CustomerAddressInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerAddressInputBox.TabIndex = 6;
            // 
            // CustomerEmailInputBox
            // 
            this.CustomerEmailInputBox.Location = new System.Drawing.Point(736, 241);
            this.CustomerEmailInputBox.Name = "CustomerEmailInputBox";
            this.CustomerEmailInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerEmailInputBox.TabIndex = 5;
            // 
            // CustomerPhoneInputBox
            // 
            this.CustomerPhoneInputBox.Location = new System.Drawing.Point(736, 208);
            this.CustomerPhoneInputBox.Name = "CustomerPhoneInputBox";
            this.CustomerPhoneInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerPhoneInputBox.TabIndex = 4;
            // 
            // CustomerNameInputBox
            // 
            this.CustomerNameInputBox.Location = new System.Drawing.Point(736, 177);
            this.CustomerNameInputBox.Name = "CustomerNameInputBox";
            this.CustomerNameInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerNameInputBox.TabIndex = 3;
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(616, 275);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(107, 15);
            this.CustomerAddressLabel.TabIndex = 12;
            this.CustomerAddressLabel.Text = "Customer Address:";
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.AutoSize = true;
            this.CustomerEmailLabel.Location = new System.Drawing.Point(616, 244);
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(94, 15);
            this.CustomerEmailLabel.TabIndex = 11;
            this.CustomerEmailLabel.Text = "Customer Email:";
            // 
            // CustomerPhoneNumberLabel
            // 
            this.CustomerPhoneNumberLabel.AutoSize = true;
            this.CustomerPhoneNumberLabel.Location = new System.Drawing.Point(616, 211);
            this.CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            this.CustomerPhoneNumberLabel.Size = new System.Drawing.Size(99, 15);
            this.CustomerPhoneNumberLabel.TabIndex = 10;
            this.CustomerPhoneNumberLabel.Text = "Customer Phone:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(616, 180);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(97, 15);
            this.CustomerNameLabel.TabIndex = 9;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(617, 79);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(291, 43);
            this.NewCustomerButton.TabIndex = 1;
            this.NewCustomerButton.Text = "New customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // DeleteSelectedCustomerButton
            // 
            this.DeleteSelectedCustomerButton.Location = new System.Drawing.Point(617, 128);
            this.DeleteSelectedCustomerButton.Name = "DeleteSelectedCustomerButton";
            this.DeleteSelectedCustomerButton.Size = new System.Drawing.Size(291, 43);
            this.DeleteSelectedCustomerButton.TabIndex = 2;
            this.DeleteSelectedCustomerButton.Text = "Delete selected customer";
            this.DeleteSelectedCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedCustomerButton.Click += new System.EventHandler(this.DeleteSelectedCustomerButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(759, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(148, 43);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Location = new System.Drawing.Point(12, 79);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.ReadOnly = true;
            this.CustomerDataGrid.RowTemplate.Height = 25;
            this.CustomerDataGrid.Size = new System.Drawing.Size(598, 307);
            this.CustomerDataGrid.TabIndex = 9;
            this.CustomerDataGrid.Click += new System.EventHandler(this.CustomerDataBox_Click);
            // 
            // ManageCustomersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 401);
            this.Controls.Add(this.CustomerDataGrid);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteSelectedCustomerButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.CustomerAddressInputBox);
            this.Controls.Add(this.CustomerEmailInputBox);
            this.Controls.Add(this.CustomerPhoneInputBox);
            this.Controls.Add(this.CustomerNameInputBox);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.CustomerEmailLabel);
            this.Controls.Add(this.CustomerPhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ScantelRoofingLabel);
            this.Name = "ManageCustomersPage";
            this.Text = "ManageCustomersPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCustomersPage_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.ManageCustomersPage_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScantelRoofingLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox CustomerAddressInputBox;
        private System.Windows.Forms.TextBox CustomerEmailInputBox;
        private System.Windows.Forms.TextBox CustomerPhoneInputBox;
        private System.Windows.Forms.TextBox CustomerNameInputBox;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerEmailLabel;
        private System.Windows.Forms.Label CustomerPhoneNumberLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button DeleteSelectedCustomerButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView CustomerDataGrid;
    }
}