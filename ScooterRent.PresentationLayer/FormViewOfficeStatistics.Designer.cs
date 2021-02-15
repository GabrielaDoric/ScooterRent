namespace ScooterRent.PresentationLayer
{
    partial class FormViewOfficeStatistics
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
            this.OfficesDropDownList = new System.Windows.Forms.ComboBox();
            this.ScootersViewList = new System.Windows.Forms.ListView();
            this.OfficeScooterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeScooterProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeRentedScooterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeRentedScooterProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.OfficeEmployeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentedScootersViewList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Office";
            // 
            // OfficesDropDownList
            // 
            this.OfficesDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficesDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfficesDropDownList.FormattingEnabled = true;
            this.OfficesDropDownList.Location = new System.Drawing.Point(203, 50);
            this.OfficesDropDownList.Margin = new System.Windows.Forms.Padding(4);
            this.OfficesDropDownList.Name = "OfficesDropDownList";
            this.OfficesDropDownList.Size = new System.Drawing.Size(536, 24);
            this.OfficesDropDownList.TabIndex = 4;
            this.OfficesDropDownList.SelectedIndexChanged += new System.EventHandler(this.TypesDropDownList_SelectedIndexChanged);
            // 
            // ScootersViewList
            // 
            this.ScootersViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OfficeScooterName,
            this.OfficeScooterProducer});
            this.ScootersViewList.HideSelection = false;
            this.ScootersViewList.Location = new System.Drawing.Point(32, 172);
            this.ScootersViewList.Name = "ScootersViewList";
            this.ScootersViewList.Size = new System.Drawing.Size(220, 131);
            this.ScootersViewList.TabIndex = 6;
            this.ScootersViewList.UseCompatibleStateImageBehavior = false;
            this.ScootersViewList.View = System.Windows.Forms.View.Details;
            // 
            // OfficeScooterName
            // 
            this.OfficeScooterName.Text = "Name";
            this.OfficeScooterName.Width = 93;
            // 
            // OfficeScooterProducer
            // 
            this.OfficeScooterProducer.Text = "Producer";
            this.OfficeScooterProducer.Width = 97;
            // 
            // OfficeRentedScooterName
            // 
            this.OfficeRentedScooterName.Text = "Name";
            this.OfficeRentedScooterName.Width = 93;
            // 
            // OfficeRentedScooterProducer
            // 
            this.OfficeRentedScooterProducer.Text = "Producer";
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OfficeEmployeName,
            this.Surname});
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(640, 172);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(264, 131);
            this.EmployeeListView.TabIndex = 7;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            // 
            // OfficeEmployeName
            // 
            this.OfficeEmployeName.Text = "Name";
            this.OfficeEmployeName.Width = 116;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 124;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(408, 384);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 33);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Close";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "All Scooters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Subscribers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rented Scooters";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // listView1
            // 
            this.RentedScootersViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.RentedScootersViewList.HideSelection = false;
            this.RentedScootersViewList.Location = new System.Drawing.Point(310, 172);
            this.RentedScootersViewList.Name = "RentedScootersView";
            this.RentedScootersViewList.Size = new System.Drawing.Size(264, 131);
            this.RentedScootersViewList.TabIndex = 21;
            this.RentedScootersViewList.UseCompatibleStateImageBehavior = false;
            this.RentedScootersViewList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producer";
            this.columnHeader2.Width = 124;
            // 
            // FormViewOfficeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.RentedScootersViewList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EmployeeListView);
            this.Controls.Add(this.ScootersViewList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OfficesDropDownList);
            this.Name = "FormViewOfficeStatistics";
            this.Text = "View Office Statistics";
            this.Load += new System.EventHandler(this.FormViewOfficeStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OfficesDropDownList;
        private System.Windows.Forms.ListView ScootersViewList;
        private System.Windows.Forms.ColumnHeader OfficeScooterName;
        private System.Windows.Forms.ColumnHeader OfficeRentedScooterName;
        

        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader OfficeEmployeName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader OfficeScooterProducer;
        private System.Windows.Forms.ColumnHeader OfficeRentedScooterProducer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView RentedScootersViewList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}