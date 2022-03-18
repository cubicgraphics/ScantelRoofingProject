
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
            this.ScantelRoofing = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.WorkInputButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScantelRoofing
            // 
            this.ScantelRoofing.AutoSize = true;
            this.ScantelRoofing.Location = new System.Drawing.Point(13, 13);
            this.ScantelRoofing.Name = "ScantelRoofing";
            this.ScantelRoofing.Size = new System.Drawing.Size(90, 15);
            this.ScantelRoofing.TabIndex = 0;
            this.ScantelRoofing.Text = "Scantel Roofing";
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
            this.WorkInputButton.Size = new System.Drawing.Size(421, 44);
            this.WorkInputButton.TabIndex = 3;
            this.WorkInputButton.Text = "Work Input ";
            this.WorkInputButton.UseVisualStyleBackColor = true;
            this.WorkInputButton.Click += new System.EventHandler(this.WorkInputButton_Click);
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(13, 135);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(194, 23);
            this.ChangePasswordTextBox.TabIndex = 5;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(237, 149);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(195, 23);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordTextBox2
            // 
            this.ChangePasswordTextBox2.Location = new System.Drawing.Point(12, 164);
            this.ChangePasswordTextBox2.Name = "ChangePasswordTextBox2";
            this.ChangePasswordTextBox2.Size = new System.Drawing.Size(194, 23);
            this.ChangePasswordTextBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter new password twice";
            // 
            // LowAccessLevelEmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePasswordTextBox2);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ChangePasswordTextBox);
            this.Controls.Add(this.WorkInputButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ScantelRoofing);
            this.Name = "LowAccessLevelEmployeeInterface";
            this.Text = "Low level employee access";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LowAccessLevelEmployeeInterface_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScantelRoofing;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button WorkInputButton;
        private System.Windows.Forms.TextBox ChangePasswordTextBox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox ChangePasswordTextBox2;
        private System.Windows.Forms.Label label1;
    }
}