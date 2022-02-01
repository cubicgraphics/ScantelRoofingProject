
namespace ScantelRoofingPrototype
{
    partial class EmployeeWorkInputPage
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
            this.SlateReclaimedLabel = new System.Windows.Forms.Label();
            this.ReclaimedSlatesLabel2 = new System.Windows.Forms.Label();
            this.ReclaimedSlatesInputBox = new System.Windows.Forms.NumericUpDown();
            this.SlateMaterialTypesListBox = new System.Windows.Forms.ListBox();
            this.TimeWorkedInputBox = new System.Windows.Forms.NumericUpDown();
            this.TimeWorkedLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReclaimedSlatesInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeWorkedInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SlateReclaimedLabel
            // 
            this.SlateReclaimedLabel.AutoSize = true;
            this.SlateReclaimedLabel.Location = new System.Drawing.Point(22, 32);
            this.SlateReclaimedLabel.Name = "SlateReclaimedLabel";
            this.SlateReclaimedLabel.Size = new System.Drawing.Size(94, 15);
            this.SlateReclaimedLabel.TabIndex = 0;
            this.SlateReclaimedLabel.Text = "Reclaimed slates";
            // 
            // ReclaimedSlatesLabel2
            // 
            this.ReclaimedSlatesLabel2.AutoSize = true;
            this.ReclaimedSlatesLabel2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReclaimedSlatesLabel2.Location = new System.Drawing.Point(12, 47);
            this.ReclaimedSlatesLabel2.Name = "ReclaimedSlatesLabel2";
            this.ReclaimedSlatesLabel2.Size = new System.Drawing.Size(118, 11);
            this.ReclaimedSlatesLabel2.TabIndex = 1;
            this.ReclaimedSlatesLabel2.Text = "*If working on reclaiming slates";
            // 
            // ReclaimedSlatesInputBox
            // 
            this.ReclaimedSlatesInputBox.Location = new System.Drawing.Point(136, 30);
            this.ReclaimedSlatesInputBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ReclaimedSlatesInputBox.Name = "ReclaimedSlatesInputBox";
            this.ReclaimedSlatesInputBox.Size = new System.Drawing.Size(120, 23);
            this.ReclaimedSlatesInputBox.TabIndex = 2;
            // 
            // SlateMaterialTypesListBox
            // 
            this.SlateMaterialTypesListBox.FormattingEnabled = true;
            this.SlateMaterialTypesListBox.ItemHeight = 15;
            this.SlateMaterialTypesListBox.Location = new System.Drawing.Point(278, 32);
            this.SlateMaterialTypesListBox.Name = "SlateMaterialTypesListBox";
            this.SlateMaterialTypesListBox.Size = new System.Drawing.Size(263, 19);
            this.SlateMaterialTypesListBox.TabIndex = 3;
            // 
            // TimeWorkedInputBox
            // 
            this.TimeWorkedInputBox.Location = new System.Drawing.Point(136, 76);
            this.TimeWorkedInputBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TimeWorkedInputBox.Name = "TimeWorkedInputBox";
            this.TimeWorkedInputBox.Size = new System.Drawing.Size(120, 23);
            this.TimeWorkedInputBox.TabIndex = 6;
            // 
            // TimeWorkedLabel
            // 
            this.TimeWorkedLabel.AutoSize = true;
            this.TimeWorkedLabel.Location = new System.Drawing.Point(22, 78);
            this.TimeWorkedLabel.Name = "TimeWorkedLabel";
            this.TimeWorkedLabel.Size = new System.Drawing.Size(81, 15);
            this.TimeWorkedLabel.TabIndex = 4;
            this.TimeWorkedLabel.Text = "Hours worked";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(278, 76);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(263, 23);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(176, 9);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(38, 15);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "label1";
            this.UserNameLabel.VisibleChanged += new System.EventHandler(this.UserNameLabel_VisibleChanged);
            // 
            // EmployeeWorkInputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 111);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.TimeWorkedInputBox);
            this.Controls.Add(this.TimeWorkedLabel);
            this.Controls.Add(this.SlateMaterialTypesListBox);
            this.Controls.Add(this.ReclaimedSlatesInputBox);
            this.Controls.Add(this.ReclaimedSlatesLabel2);
            this.Controls.Add(this.SlateReclaimedLabel);
            this.Name = "EmployeeWorkInputPage";
            this.Text = "EmployeeWorkInputPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeWorkInputPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ReclaimedSlatesInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeWorkedInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SlateReclaimedLabel;
        private System.Windows.Forms.Label ReclaimedSlatesLabel2;
        private System.Windows.Forms.NumericUpDown ReclaimedSlatesInputBox;
        private System.Windows.Forms.ListBox SlateMaterialTypesListBox;
        private System.Windows.Forms.NumericUpDown TimeWorkedInputBox;
        private System.Windows.Forms.Label TimeWorkedLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label UserNameLabel;
    }
}