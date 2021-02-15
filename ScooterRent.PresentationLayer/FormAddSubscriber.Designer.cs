namespace ScooterRent.PresentationLayer
{
    partial class FormAddSubscriber
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubscriberName = new System.Windows.Forms.TextBox();
            this.SubscriberSurname = new System.Windows.Forms.TextBox();
            this.subscriberEmail = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubscriberBirthDate = new System.Windows.Forms.TextBox();
            this.SubscriberJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.OfficesDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "OIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Joining Date";
            // 
            // SubscriberName
            // 
            this.SubscriberName.Location = new System.Drawing.Point(165, 90);
            this.SubscriberName.Name = "SubscriberName";
            this.SubscriberName.Size = new System.Drawing.Size(100, 22);
            this.SubscriberName.TabIndex = 6;
            // 
            // SubscriberSurname
            // 
            this.SubscriberSurname.Location = new System.Drawing.Point(165, 127);
            this.SubscriberSurname.Name = "SubscriberSurname";
            this.SubscriberSurname.Size = new System.Drawing.Size(100, 22);
            this.SubscriberSurname.TabIndex = 7;
            // 
            // subscriberEmail
            // 
            this.subscriberEmail.Location = new System.Drawing.Point(165, 163);
            this.subscriberEmail.Name = "subscriberEmail";
            this.subscriberEmail.Size = new System.Drawing.Size(100, 22);
            this.subscriberEmail.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(282, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 33);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(140, 369);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 33);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubscriberBirthDate
            // 
            this.SubscriberBirthDate.Location = new System.Drawing.Point(165, 198);
            this.SubscriberBirthDate.Name = "SubscriberBirthDate";
            this.SubscriberBirthDate.Size = new System.Drawing.Size(200, 22);
            this.SubscriberBirthDate.TabIndex = 18;
            // 
            // SubscriberJoiningDate
            // 
            this.SubscriberJoiningDate.Location = new System.Drawing.Point(165, 241);
            this.SubscriberJoiningDate.Name = "SubscriberJoiningDate";
            this.SubscriberJoiningDate.Size = new System.Drawing.Size(200, 22);
            this.SubscriberJoiningDate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Office";
            // 
            // OfficesDropDownList
            // 
            this.OfficesDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficesDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfficesDropDownList.FormattingEnabled = true;
            this.OfficesDropDownList.Location = new System.Drawing.Point(160, 293);
            this.OfficesDropDownList.Margin = new System.Windows.Forms.Padding(4);
            this.OfficesDropDownList.Name = "OfficesDropDownList";
            this.OfficesDropDownList.Size = new System.Drawing.Size(205, 24);
            this.OfficesDropDownList.TabIndex = 20;
            this.OfficesDropDownList.SelectedIndexChanged += new System.EventHandler(this.OfficesDropDownList_SelectedIndexChanged);
            // 
            // FormAddSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OfficesDropDownList);
            this.Controls.Add(this.SubscriberJoiningDate);
            this.Controls.Add(this.SubscriberBirthDate);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.subscriberEmail);
            this.Controls.Add(this.SubscriberSurname);
            this.Controls.Add(this.SubscriberName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSubscriber";
            this.Text = "Add New Subscriber";
            this.Load += new System.EventHandler(this.FormAddSubscriber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubscriberName;
        private System.Windows.Forms.TextBox SubscriberSurname;
        private System.Windows.Forms.TextBox subscriberEmail;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SubscriberBirthDate;
        private System.Windows.Forms.DateTimePicker SubscriberJoiningDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox OfficesDropDownList;
    }
}