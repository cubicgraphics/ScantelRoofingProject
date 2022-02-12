
namespace ScantelRoofingPrototype
{
    partial class LowAccessLevelEmployeeInterface
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
            this.ScantelRoofingICO = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.WorkInputButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScantelRoofingICO
            // 
            this.ScantelRoofingICO.AutoSize = true;
            this.ScantelRoofingICO.Location = new System.Drawing.Point(13, 13);
            this.ScantelRoofingICO.Name = "ScantelRoofingICO";
            this.ScantelRoofingICO.Size = new System.Drawing.Size(166, 15);
            this.ScantelRoofingICO.TabIndex = 0;
            this.ScantelRoofingICO.Text = "Scantel Roofing - Logo/image";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(252, 13);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "%username%";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(358, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.VisibleChanged += new System.EventHandler(this.LogoutButton_VisibleChanged);
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // WorkInputButton
            // 
            this.WorkInputButton.Location = new System.Drawing.Point(12, 52);
            this.WorkInputButton.Name = "WorkInputButton";
            this.WorkInputButton.Size = new System.Drawing.Size(195, 31);
            this.WorkInputButton.TabIndex = 3;
            this.WorkInputButton.Text = "Work Input ";
            this.WorkInputButton.UseVisualStyleBackColor = true;
            this.WorkInputButton.Click += new System.EventHandler(this.WorkInputButton_Click);
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(13, 106);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(194, 23);
            this.ChangePasswordTextBox.TabIndex = 5;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(237, 106);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(195, 23);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LowAccessLevelEmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 154);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ChangePasswordTextBox);
            this.Controls.Add(this.WorkInputButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ScantelRoofingICO);
            this.Name = "LowAccessLevelEmployeeInterface";
            this.Text = "LowAccessLevelEmployeeInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LowAccessLevelEmployeeInterface_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScantelRoofingICO;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button WorkInputButton;
        private System.Windows.Forms.TextBox ChangePasswordTextBox;
        private System.Windows.Forms.Button ChangePasswordButton;
    }
}