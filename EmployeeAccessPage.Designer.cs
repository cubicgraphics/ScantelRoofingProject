
namespace ScantelRoofingPrototype
{
    partial class EmployeeAccessPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.LoginPageButton = new System.Windows.Forms.Button();
            this.EnterEmployeeCodeButton = new System.Windows.Forms.Button();
            this.EmployeeCodeInputBox = new System.Windows.Forms.TextBox();
            this.CodeNotFoundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(90, 15);
            this.LoginTitleLabel.TabIndex = 0;
            this.LoginTitleLabel.Text = "Scantel Roofing";
            // 
            // LoginPageButton
            // 
            this.LoginPageButton.Location = new System.Drawing.Point(254, 12);
            this.LoginPageButton.Name = "LoginPageButton";
            this.LoginPageButton.Size = new System.Drawing.Size(124, 41);
            this.LoginPageButton.TabIndex = 1;
            this.LoginPageButton.Text = "Login Page";
            this.LoginPageButton.UseVisualStyleBackColor = true;
            this.LoginPageButton.Click += new System.EventHandler(this.LoginPageButton_Click);
            // 
            // EnterEmployeeCodeButton
            // 
            this.EnterEmployeeCodeButton.Location = new System.Drawing.Point(254, 64);
            this.EnterEmployeeCodeButton.Name = "EnterEmployeeCodeButton";
            this.EnterEmployeeCodeButton.Size = new System.Drawing.Size(124, 45);
            this.EnterEmployeeCodeButton.TabIndex = 3;
            this.EnterEmployeeCodeButton.Text = "Enter code";
            this.EnterEmployeeCodeButton.UseVisualStyleBackColor = true;
            this.EnterEmployeeCodeButton.Click += new System.EventHandler(this.EnterEmployeeCodeButton_Click);
            // 
            // EmployeeCodeInputBox
            // 
            this.EmployeeCodeInputBox.Location = new System.Drawing.Point(12, 76);
            this.EmployeeCodeInputBox.Name = "EmployeeCodeInputBox";
            this.EmployeeCodeInputBox.Size = new System.Drawing.Size(208, 23);
            this.EmployeeCodeInputBox.TabIndex = 2;
            // 
            // CodeNotFoundLabel
            // 
            this.CodeNotFoundLabel.AutoSize = true;
            this.CodeNotFoundLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CodeNotFoundLabel.Location = new System.Drawing.Point(71, 102);
            this.CodeNotFoundLabel.Name = "CodeNotFoundLabel";
            this.CodeNotFoundLabel.Size = new System.Drawing.Size(91, 15);
            this.CodeNotFoundLabel.TabIndex = 4;
            this.CodeNotFoundLabel.Text = "Code not found";
            this.CodeNotFoundLabel.Visible = false;
            // 
            // EmployeeAccessPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 124);
            this.Controls.Add(this.CodeNotFoundLabel);
            this.Controls.Add(this.EmployeeCodeInputBox);
            this.Controls.Add(this.EnterEmployeeCodeButton);
            this.Controls.Add(this.LoginPageButton);
            this.Controls.Add(this.LoginTitleLabel);
            this.Name = "EmployeeAccessPage";
            this.Text = "Employee access page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Button LoginPageButton;
        private System.Windows.Forms.Button EnterEmployeeCodeButton;
        private System.Windows.Forms.TextBox EmployeeCodeInputBox;
        private System.Windows.Forms.Label CodeNotFoundLabel;
    }
}

