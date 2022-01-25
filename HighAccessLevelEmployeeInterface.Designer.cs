
namespace ScantelRoofingPrototype
{
    partial class HighAccessLevelEmployeeInterface
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
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.CreateWorkplaceButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ScantelRoofingICO = new System.Windows.Forms.Label();
            this.StockButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.RoofEditorButton = new System.Windows.Forms.Button();
            this.WorkplacesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(237, 49);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(195, 31);
            this.EmployeesButton.TabIndex = 9;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // CreateWorkplaceButton
            // 
            this.CreateWorkplaceButton.Location = new System.Drawing.Point(11, 49);
            this.CreateWorkplaceButton.Name = "CreateWorkplaceButton";
            this.CreateWorkplaceButton.Size = new System.Drawing.Size(195, 31);
            this.CreateWorkplaceButton.TabIndex = 8;
            this.CreateWorkplaceButton.Text = "Create new workplace";
            this.CreateWorkplaceButton.UseVisualStyleBackColor = true;
            this.CreateWorkplaceButton.Click += new System.EventHandler(this.CreateWorkplaceButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(357, 6);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(251, 10);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 15);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "%username%";
            // 
            // ScantelRoofingICO
            // 
            this.ScantelRoofingICO.AutoSize = true;
            this.ScantelRoofingICO.Location = new System.Drawing.Point(12, 10);
            this.ScantelRoofingICO.Name = "ScantelRoofingICO";
            this.ScantelRoofingICO.Size = new System.Drawing.Size(166, 15);
            this.ScantelRoofingICO.TabIndex = 5;
            this.ScantelRoofingICO.Text = "Scantel Roofing - Logo/image";
            // 
            // StockButton
            // 
            this.StockButton.Location = new System.Drawing.Point(11, 86);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(195, 31);
            this.StockButton.TabIndex = 10;
            this.StockButton.Text = "Stock";
            this.StockButton.UseVisualStyleBackColor = true;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(237, 86);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(195, 31);
            this.CustomersButton.TabIndex = 11;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // RoofEditorButton
            // 
            this.RoofEditorButton.Location = new System.Drawing.Point(11, 123);
            this.RoofEditorButton.Name = "RoofEditorButton";
            this.RoofEditorButton.Size = new System.Drawing.Size(195, 31);
            this.RoofEditorButton.TabIndex = 12;
            this.RoofEditorButton.Text = "Roof editor";
            this.RoofEditorButton.UseVisualStyleBackColor = true;
            this.RoofEditorButton.Click += new System.EventHandler(this.RoofEditorButton_Click);
            // 
            // WorkplacesButton
            // 
            this.WorkplacesButton.Location = new System.Drawing.Point(237, 123);
            this.WorkplacesButton.Name = "WorkplacesButton";
            this.WorkplacesButton.Size = new System.Drawing.Size(195, 31);
            this.WorkplacesButton.TabIndex = 13;
            this.WorkplacesButton.Text = "Workplaces";
            this.WorkplacesButton.UseVisualStyleBackColor = true;
            this.WorkplacesButton.Click += new System.EventHandler(this.WorkplacesButton_Click);
            // 
            // HighAccessLevelEmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 162);
            this.Controls.Add(this.WorkplacesButton);
            this.Controls.Add(this.RoofEditorButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.StockButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.CreateWorkplaceButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ScantelRoofingICO);
            this.Name = "HighAccessLevelEmployeeInterface";
            this.Text = "HighAccessLevelEmployeeInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HighAccessLevelEmployeeInterface_FormClosing);
            this.Load += new System.EventHandler(this.HighAccessLevelEmployeeInterface_Load);
            this.VisibleChanged += new System.EventHandler(this.HighAccessLevelEmployeeInterface_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button CreateWorkplaceButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label ScantelRoofingICO;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button RoofEditorButton;
        private System.Windows.Forms.Button WorkplacesButton;
    }
}