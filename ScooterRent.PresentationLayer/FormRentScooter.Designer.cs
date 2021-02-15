
namespace ScooterRent.PresentationLayer
{
    partial class FormRentScooter
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
            this.ScootersDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rentStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rentEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SubscribersDropDownList = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OfficeDropDownList
            // 
            this.ScootersDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScootersDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScootersDropDownList.FormattingEnabled = true;
            this.ScootersDropDownList.Location = new System.Drawing.Point(287, 44);
            this.ScootersDropDownList.Margin = new System.Windows.Forms.Padding(4);
            this.ScootersDropDownList.Name = "OfficeDropDownList";
            this.ScootersDropDownList.Size = new System.Drawing.Size(254, 24);
            this.ScootersDropDownList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rent Start";
            // 
            // comboBox1
            // 
            this.rentStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.comboBox1.FormattingEnabled = true;
            this.rentStart.Location = new System.Drawing.Point(287, 119);
            this.rentStart.Margin = new System.Windows.Forms.Padding(4);
            this.rentStart.Name = "comboBox1";
            this.rentStart.Size = new System.Drawing.Size(254, 24);
            this.rentStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rent End";
            // 
            // comboBox2
            // 
            this.rentEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.comboBox2.FormattingEnabled = true;
            this.rentEnd.Location = new System.Drawing.Point(287, 195);
            this.rentEnd.Margin = new System.Windows.Forms.Padding(4);
            this.rentEnd.Name = "comboBox2";
            this.rentEnd.Size = new System.Drawing.Size(254, 24);
            this.rentEnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subscriber";
            // 
            // comboBox3
            // 
            this.SubscribersDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubscribersDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubscribersDropDownList.FormattingEnabled = true;
            this.SubscribersDropDownList.Location = new System.Drawing.Point(287, 283);
            this.SubscribersDropDownList.Margin = new System.Windows.Forms.Padding(4);
            this.SubscribersDropDownList.Name = "comboBox3";
            this.SubscribersDropDownList.Size = new System.Drawing.Size(254, 24);
            this.SubscribersDropDownList.TabIndex = 9;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(441, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 33);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(303, 365);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 33);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormRentScooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubscribersDropDownList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScootersDropDownList);
            this.Name = "FormRentScooter";
            this.Text = "Rent scooter";
            this.Load += new System.EventHandler(this.FormRentScooter_Load_Scooters);
            this.Load += new System.EventHandler(this.FormRentScooter_Load_Subscriber);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ScootersDropDownList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker rentStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker rentEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SubscribersDropDownList;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}