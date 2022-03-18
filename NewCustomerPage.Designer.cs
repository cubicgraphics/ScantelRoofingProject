
namespace ScantelRoofingPrototype
{
    partial class NewCustomerPage
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
            this.CreateNewCustomerButton = new System.Windows.Forms.Button();
            this.CustomerAddressInputBox = new System.Windows.Forms.TextBox();
            this.CustomerEmailInputBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneInputBox = new System.Windows.Forms.TextBox();
            this.CustomerNameInputBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerEmailLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateNewCustomerButton
            // 
            this.CreateNewCustomerButton.Location = new System.Drawing.Point(6, 134);
            this.CreateNewCustomerButton.Name = "CreateNewCustomerButton";
            this.CreateNewCustomerButton.Size = new System.Drawing.Size(291, 23);
            this.CreateNewCustomerButton.TabIndex = 5;
            this.CreateNewCustomerButton.Text = "Create new customer";
            this.CreateNewCustomerButton.UseVisualStyleBackColor = true;
            this.CreateNewCustomerButton.Click += new System.EventHandler(this.CreateNewCustomerButton_Click);
            // 
            // CustomerAddressInputBox
            // 
            this.CustomerAddressInputBox.Location = new System.Drawing.Point(126, 101);
            this.CustomerAddressInputBox.Name = "CustomerAddressInputBox";
            this.CustomerAddressInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerAddressInputBox.TabIndex = 4;
            // 
            // CustomerEmailInputBox
            // 
            this.CustomerEmailInputBox.Location = new System.Drawing.Point(126, 70);
            this.CustomerEmailInputBox.Name = "CustomerEmailInputBox";
            this.CustomerEmailInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerEmailInputBox.TabIndex = 3;
            // 
            // CustomerPhoneInputBox
            // 
            this.CustomerPhoneInputBox.Location = new System.Drawing.Point(126, 37);
            this.CustomerPhoneInputBox.Name = "CustomerPhoneInputBox";
            this.CustomerPhoneInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerPhoneInputBox.TabIndex = 2;
            // 
            // CustomerNameInputBox
            // 
            this.CustomerNameInputBox.Location = new System.Drawing.Point(126, 6);
            this.CustomerNameInputBox.Name = "CustomerNameInputBox";
            this.CustomerNameInputBox.Size = new System.Drawing.Size(171, 23);
            this.CustomerNameInputBox.TabIndex = 1;
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(6, 104);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(107, 15);
            this.CustomerAddressLabel.TabIndex = 21;
            this.CustomerAddressLabel.Text = "Customer Address:";
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.AutoSize = true;
            this.CustomerEmailLabel.Location = new System.Drawing.Point(6, 73);
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(94, 15);
            this.CustomerEmailLabel.TabIndex = 20;
            this.CustomerEmailLabel.Text = "Customer Email:";
            // 
            // CustomerPhoneNumberLabel
            // 
            this.CustomerPhoneNumberLabel.AutoSize = true;
            this.CustomerPhoneNumberLabel.Location = new System.Drawing.Point(6, 40);
            this.CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            this.CustomerPhoneNumberLabel.Size = new System.Drawing.Size(99, 15);
            this.CustomerPhoneNumberLabel.TabIndex = 19;
            this.CustomerPhoneNumberLabel.Text = "Customer Phone:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(6, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(97, 15);
            this.CustomerNameLabel.TabIndex = 18;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // NewCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 162);
            this.Controls.Add(this.CreateNewCustomerButton);
            this.Controls.Add(this.CustomerAddressInputBox);
            this.Controls.Add(this.CustomerEmailInputBox);
            this.Controls.Add(this.CustomerPhoneInputBox);
            this.Controls.Add(this.CustomerNameInputBox);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.CustomerEmailLabel);
            this.Controls.Add(this.CustomerPhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "NewCustomerPage";
            this.Text = "New customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCustomerPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNewCustomerButton;
        private System.Windows.Forms.TextBox CustomerAddressInputBox;
        private System.Windows.Forms.TextBox CustomerEmailInputBox;
        private System.Windows.Forms.TextBox CustomerPhoneInputBox;
        private System.Windows.Forms.TextBox CustomerNameInputBox;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerEmailLabel;
        private System.Windows.Forms.Label CustomerPhoneNumberLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
    }
}