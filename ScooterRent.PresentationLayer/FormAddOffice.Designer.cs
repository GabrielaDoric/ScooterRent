namespace ScooterRent.PresentationLayer
{
    partial class FormAddOffice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OfficeTown = new System.Windows.Forms.TextBox();
            this.OfficeName = new System.Windows.Forms.TextBox();
            this.WorkingTime = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OfficeAdress = new System.Windows.Forms.TextBox();
            this.OfficeFoundingDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "OfficeTown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "OfficeFoundingDate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "WorkingTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // OfficeTown
            // 
            this.OfficeTown.Location = new System.Drawing.Point(219, 74);
            this.OfficeTown.Name = "OfficeTown";
            this.OfficeTown.Size = new System.Drawing.Size(100, 22);
            this.OfficeTown.TabIndex = 7;
            // 
            // OfficeName
            // 
            this.OfficeName.Location = new System.Drawing.Point(219, 46);
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.Size = new System.Drawing.Size(100, 22);
            this.OfficeName.TabIndex = 8;
            // 
            // WorkingTime
            // 
            this.WorkingTime.Location = new System.Drawing.Point(219, 163);
            this.WorkingTime.Name = "WorkingTime";
            this.WorkingTime.Size = new System.Drawing.Size(100, 22);
            this.WorkingTime.TabIndex = 11;
            this.WorkingTime.Text = "08-16";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(81, 214);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 33);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(219, 214);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 33);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OfficeAdress
            // 
            this.OfficeAdress.Location = new System.Drawing.Point(219, 131);
            this.OfficeAdress.Name = "OfficeAdress";
            this.OfficeAdress.Size = new System.Drawing.Size(100, 22);
            this.OfficeAdress.TabIndex = 16;
            // 
            // OfficeFoundingDate
            // 
            this.OfficeFoundingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OfficeFoundingDate.Location = new System.Drawing.Point(218, 103);
            this.OfficeFoundingDate.Name = "OfficeFoundingDate";
            this.OfficeFoundingDate.Size = new System.Drawing.Size(138, 22);
            this.OfficeFoundingDate.TabIndex = 17;
            // 
            // FormAddOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.OfficeFoundingDate);
            this.Controls.Add(this.OfficeAdress);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WorkingTime);
            this.Controls.Add(this.OfficeName);
            this.Controls.Add(this.OfficeTown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormAddOffice";
            this.Text = "Add Office";
            this.Load += new System.EventHandler(this.FormAddOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OfficeTown;
        private System.Windows.Forms.TextBox OfficeName;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox WorkingTime;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker FoundingDate;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox OfficeAdress;
        private System.Windows.Forms.DateTimePicker OfficeFoundingDate;
    }
}