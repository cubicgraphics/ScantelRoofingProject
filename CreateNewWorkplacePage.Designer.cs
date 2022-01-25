
namespace ScantelRoofingPrototype
{
    partial class CreateNewWorkplacePage
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
            this.BackButton = new System.Windows.Forms.Button();
            this.WorkplaceNameLabel = new System.Windows.Forms.Label();
            this.WorkplaceAddressLabel = new System.Windows.Forms.Label();
            this.WorkplaceCustomersLabel = new System.Windows.Forms.Label();
            this.CustomersToWorkplaceListBox = new System.Windows.Forms.ListBox();
            this.AddCustomerToWorkplaceButton = new System.Windows.Forms.Button();
            this.RemoveCustomerFromWorkplaceButton = new System.Windows.Forms.Button();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PredictedEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PredictedEndDateLabel = new System.Windows.Forms.Label();
            this.RoofListBox = new System.Windows.Forms.ListBox();
            this.RemoveRoofButton = new System.Windows.Forms.Button();
            this.AddRoofButton = new System.Windows.Forms.Button();
            this.SelectedRoofsListBox = new System.Windows.Forms.ListBox();
            this.RoofLabel = new System.Windows.Forms.Label();
            this.RoofInfoLabel = new System.Windows.Forms.Label();
            this.CreateWorkplaceButton = new System.Windows.Forms.Button();
            this.WorkplaceNameInputBox = new System.Windows.Forms.TextBox();
            this.AddressInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScantelRoofingLabel
            // 
            this.ScantelRoofingLabel.AutoSize = true;
            this.ScantelRoofingLabel.Location = new System.Drawing.Point(12, 9);
            this.ScantelRoofingLabel.Name = "ScantelRoofingLabel";
            this.ScantelRoofingLabel.Size = new System.Drawing.Size(160, 15);
            this.ScantelRoofingLabel.TabIndex = 0;
            this.ScantelRoofingLabel.Text = "Scantel roofing - logo/image";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(429, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(162, 64);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WorkplaceNameLabel
            // 
            this.WorkplaceNameLabel.AutoSize = true;
            this.WorkplaceNameLabel.Location = new System.Drawing.Point(12, 87);
            this.WorkplaceNameLabel.Name = "WorkplaceNameLabel";
            this.WorkplaceNameLabel.Size = new System.Drawing.Size(99, 15);
            this.WorkplaceNameLabel.TabIndex = 2;
            this.WorkplaceNameLabel.Text = "Workplace name:";
            // 
            // WorkplaceAddressLabel
            // 
            this.WorkplaceAddressLabel.AutoSize = true;
            this.WorkplaceAddressLabel.Location = new System.Drawing.Point(287, 87);
            this.WorkplaceAddressLabel.Name = "WorkplaceAddressLabel";
            this.WorkplaceAddressLabel.Size = new System.Drawing.Size(52, 15);
            this.WorkplaceAddressLabel.TabIndex = 3;
            this.WorkplaceAddressLabel.Text = "Address:";
            // 
            // WorkplaceCustomersLabel
            // 
            this.WorkplaceCustomersLabel.AutoSize = true;
            this.WorkplaceCustomersLabel.Location = new System.Drawing.Point(12, 150);
            this.WorkplaceCustomersLabel.Name = "WorkplaceCustomersLabel";
            this.WorkplaceCustomersLabel.Size = new System.Drawing.Size(67, 15);
            this.WorkplaceCustomersLabel.TabIndex = 4;
            this.WorkplaceCustomersLabel.Text = "Customers:";
            // 
            // CustomersToWorkplaceListBox
            // 
            this.CustomersToWorkplaceListBox.FormattingEnabled = true;
            this.CustomersToWorkplaceListBox.ItemHeight = 15;
            this.CustomersToWorkplaceListBox.Location = new System.Drawing.Point(85, 150);
            this.CustomersToWorkplaceListBox.Name = "CustomersToWorkplaceListBox";
            this.CustomersToWorkplaceListBox.Size = new System.Drawing.Size(120, 64);
            this.CustomersToWorkplaceListBox.TabIndex = 3;
            // 
            // AddCustomerToWorkplaceButton
            // 
            this.AddCustomerToWorkplaceButton.Location = new System.Drawing.Point(221, 150);
            this.AddCustomerToWorkplaceButton.Name = "AddCustomerToWorkplaceButton";
            this.AddCustomerToWorkplaceButton.Size = new System.Drawing.Size(31, 23);
            this.AddCustomerToWorkplaceButton.TabIndex = 6;
            this.AddCustomerToWorkplaceButton.Text = "<";
            this.AddCustomerToWorkplaceButton.UseVisualStyleBackColor = true;
            this.AddCustomerToWorkplaceButton.Click += new System.EventHandler(this.AddCustomerToWorkplaceButton_Click);
            // 
            // RemoveCustomerFromWorkplaceButton
            // 
            this.RemoveCustomerFromWorkplaceButton.Location = new System.Drawing.Point(221, 191);
            this.RemoveCustomerFromWorkplaceButton.Name = "RemoveCustomerFromWorkplaceButton";
            this.RemoveCustomerFromWorkplaceButton.Size = new System.Drawing.Size(31, 23);
            this.RemoveCustomerFromWorkplaceButton.TabIndex = 4;
            this.RemoveCustomerFromWorkplaceButton.Text = ">";
            this.RemoveCustomerFromWorkplaceButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerFromWorkplaceButton.VisibleChanged += new System.EventHandler(this.RemoveCustomerFromWorkplaceButton_VisibleChanged);
            this.RemoveCustomerFromWorkplaceButton.Click += new System.EventHandler(this.RemoveCustomerFromWorkplaceButton_Click);
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 15;
            this.CustomerListBox.Location = new System.Drawing.Point(269, 150);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(120, 64);
            this.CustomerListBox.TabIndex = 5;
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(429, 150);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(162, 64);
            this.NewCustomerButton.TabIndex = 7;
            this.NewCustomerButton.Text = "New customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(12, 232);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 15);
            this.StartDateLabel.TabIndex = 10;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(12, 250);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 23);
            this.StartDatePicker.TabIndex = 8;
            // 
            // PredictedEndDatePicker
            // 
            this.PredictedEndDatePicker.Location = new System.Drawing.Point(12, 358);
            this.PredictedEndDatePicker.Name = "PredictedEndDatePicker";
            this.PredictedEndDatePicker.Size = new System.Drawing.Size(200, 23);
            this.PredictedEndDatePicker.TabIndex = 9;
            // 
            // PredictedEndDateLabel
            // 
            this.PredictedEndDateLabel.AutoSize = true;
            this.PredictedEndDateLabel.Location = new System.Drawing.Point(12, 340);
            this.PredictedEndDateLabel.Name = "PredictedEndDateLabel";
            this.PredictedEndDateLabel.Size = new System.Drawing.Size(106, 15);
            this.PredictedEndDateLabel.TabIndex = 12;
            this.PredictedEndDateLabel.Text = "Predicted end date";
            // 
            // RoofListBox
            // 
            this.RoofListBox.FormattingEnabled = true;
            this.RoofListBox.ItemHeight = 15;
            this.RoofListBox.Location = new System.Drawing.Point(471, 250);
            this.RoofListBox.Name = "RoofListBox";
            this.RoofListBox.Size = new System.Drawing.Size(120, 64);
            this.RoofListBox.TabIndex = 12;
            // 
            // RemoveRoofButton
            // 
            this.RemoveRoofButton.Location = new System.Drawing.Point(423, 291);
            this.RemoveRoofButton.Name = "RemoveRoofButton";
            this.RemoveRoofButton.Size = new System.Drawing.Size(31, 23);
            this.RemoveRoofButton.TabIndex = 11;
            this.RemoveRoofButton.Text = ">";
            this.RemoveRoofButton.UseVisualStyleBackColor = true;
            this.RemoveRoofButton.Click += new System.EventHandler(this.RemoveRoofButton_Click);
            // 
            // AddRoofButton
            // 
            this.AddRoofButton.Location = new System.Drawing.Point(423, 250);
            this.AddRoofButton.Name = "AddRoofButton";
            this.AddRoofButton.Size = new System.Drawing.Size(31, 23);
            this.AddRoofButton.TabIndex = 13;
            this.AddRoofButton.Text = "<";
            this.AddRoofButton.UseVisualStyleBackColor = true;
            this.AddRoofButton.Click += new System.EventHandler(this.AddRoofButton_Click);
            // 
            // SelectedRoofsListBox
            // 
            this.SelectedRoofsListBox.FormattingEnabled = true;
            this.SelectedRoofsListBox.ItemHeight = 15;
            this.SelectedRoofsListBox.Location = new System.Drawing.Point(287, 250);
            this.SelectedRoofsListBox.Name = "SelectedRoofsListBox";
            this.SelectedRoofsListBox.Size = new System.Drawing.Size(120, 64);
            this.SelectedRoofsListBox.TabIndex = 10;
            // 
            // RoofLabel
            // 
            this.RoofLabel.AutoSize = true;
            this.RoofLabel.Location = new System.Drawing.Point(234, 250);
            this.RoofLabel.Name = "RoofLabel";
            this.RoofLabel.Size = new System.Drawing.Size(37, 15);
            this.RoofLabel.TabIndex = 14;
            this.RoofLabel.Text = "Roofs";
            // 
            // RoofInfoLabel
            // 
            this.RoofInfoLabel.AutoSize = true;
            this.RoofInfoLabel.Location = new System.Drawing.Point(234, 323);
            this.RoofInfoLabel.Name = "RoofInfoLabel";
            this.RoofInfoLabel.Size = new System.Drawing.Size(142, 15);
            this.RoofInfoLabel.TabIndex = 19;
            this.RoofInfoLabel.Text = "*Roofs can be added later";
            // 
            // CreateWorkplaceButton
            // 
            this.CreateWorkplaceButton.Location = new System.Drawing.Point(391, 354);
            this.CreateWorkplaceButton.Name = "CreateWorkplaceButton";
            this.CreateWorkplaceButton.Size = new System.Drawing.Size(200, 40);
            this.CreateWorkplaceButton.TabIndex = 14;
            this.CreateWorkplaceButton.Text = "Create New Workplace";
            this.CreateWorkplaceButton.UseVisualStyleBackColor = true;
            this.CreateWorkplaceButton.Click += new System.EventHandler(this.CreateWorkplaceButton_Click);
            // 
            // WorkplaceNameInputBox
            // 
            this.WorkplaceNameInputBox.Location = new System.Drawing.Point(117, 84);
            this.WorkplaceNameInputBox.Name = "WorkplaceNameInputBox";
            this.WorkplaceNameInputBox.Size = new System.Drawing.Size(164, 23);
            this.WorkplaceNameInputBox.TabIndex = 1;
            // 
            // AddressInputBox
            // 
            this.AddressInputBox.Location = new System.Drawing.Point(345, 84);
            this.AddressInputBox.Name = "AddressInputBox";
            this.AddressInputBox.Size = new System.Drawing.Size(245, 23);
            this.AddressInputBox.TabIndex = 2;
            // 
            // CreateNewWorkplacePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 401);
            this.Controls.Add(this.AddressInputBox);
            this.Controls.Add(this.WorkplaceNameInputBox);
            this.Controls.Add(this.CreateWorkplaceButton);
            this.Controls.Add(this.RoofInfoLabel);
            this.Controls.Add(this.RoofListBox);
            this.Controls.Add(this.RemoveRoofButton);
            this.Controls.Add(this.AddRoofButton);
            this.Controls.Add(this.SelectedRoofsListBox);
            this.Controls.Add(this.RoofLabel);
            this.Controls.Add(this.PredictedEndDatePicker);
            this.Controls.Add(this.PredictedEndDateLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.RemoveCustomerFromWorkplaceButton);
            this.Controls.Add(this.AddCustomerToWorkplaceButton);
            this.Controls.Add(this.CustomersToWorkplaceListBox);
            this.Controls.Add(this.WorkplaceCustomersLabel);
            this.Controls.Add(this.WorkplaceAddressLabel);
            this.Controls.Add(this.WorkplaceNameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ScantelRoofingLabel);
            this.Name = "CreateNewWorkplacePage";
            this.Text = "CreateNewWorkplacePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewWorkplacePage_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.CreateNewWorkplacePage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScantelRoofingLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label WorkplaceNameLabel;
        private System.Windows.Forms.Label WorkplaceAddressLabel;
        private System.Windows.Forms.Label WorkplaceCustomersLabel;
        private System.Windows.Forms.ListBox CustomersToWorkplaceListBox;
        private System.Windows.Forms.Button AddCustomerToWorkplaceButton;
        private System.Windows.Forms.Button RemoveCustomerFromWorkplaceButton;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker PredictedEndDatePicker;
        private System.Windows.Forms.Label PredictedEndDateLabel;
        private System.Windows.Forms.ListBox RoofListBox;
        private System.Windows.Forms.Button RemoveRoofButton;
        private System.Windows.Forms.Button AddRoofButton;
        private System.Windows.Forms.ListBox SelectedRoofsListBox;
        private System.Windows.Forms.Label RoofLabel;
        private System.Windows.Forms.Label RoofInfoLabel;
        private System.Windows.Forms.Button CreateWorkplaceButton;
        private System.Windows.Forms.TextBox WorkplaceNameInputBox;
        private System.Windows.Forms.TextBox AddressInputBox;
    }
}