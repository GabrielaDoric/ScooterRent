namespace ScooterRent.PresentationLayer
{
    partial class FormviewOffices
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
            this.components = new System.ComponentModel.Container();
            this.OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficeViewList = new System.Windows.Forms.ListView();
            this.OfficeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeTown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeFoundingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OfficeWorkingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficeBindingSource
            // 
            this.OfficeBindingSource.DataSource = typeof(ScooterRent_Model.Office);
            // 
            // OfficeViewList
            // 
            this.OfficeViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OfficeId,
            this.OfficeName,
            this.OfficeTown,
            this.OfficeFoundingDate,
            this.OfficeAdress,
            this.OfficeWorkingTime});
            this.OfficeViewList.Location = new System.Drawing.Point(61, 39);
            this.OfficeViewList.Name = "OfficeViewList";
            this.OfficeViewList.Size = new System.Drawing.Size(661, 242);
            this.OfficeViewList.TabIndex = 1;
            this.OfficeViewList.UseCompatibleStateImageBehavior = false;
            this.OfficeViewList.View = System.Windows.Forms.View.Details;
            this.OfficeViewList.SelectedIndexChanged += new System.EventHandler(this.OfficeViewList_SelectedIndexChanged);
            // 
            // OfficeId
            // 
            this.OfficeId.Text = "Id";
            // 
            // OfficeName
            // 
            this.OfficeName.Text = "Name";
            this.OfficeName.Width = 93;
            // 
            // OfficeTown
            // 
            this.OfficeTown.Text = "Town";
            this.OfficeTown.Width = 80;
            // 
            // OfficeFoundingDate
            // 
            this.OfficeFoundingDate.Text = "Office Founding Date";
            this.OfficeFoundingDate.Width = 141;
            // 
            // OfficeAdress
            // 
            this.OfficeAdress.Text = "Address";
            this.OfficeAdress.Width = 97;
            // 
            // OfficeWorkingTime
            // 
            this.OfficeWorkingTime.Text = "Working Hours";
            this.OfficeWorkingTime.Width = 127;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormviewOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OfficeViewList);
            this.Name = "FormviewOffices";
            this.Text = "View Offices";
            this.Load += new System.EventHandler(this.FormviewOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfficeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OfficeBindingSource;
        private System.Windows.Forms.ListView OfficeViewList;
        private System.Windows.Forms.ColumnHeader OfficeId;
        private System.Windows.Forms.ColumnHeader OfficeName;
        private System.Windows.Forms.ColumnHeader OfficeTown;
        private System.Windows.Forms.ColumnHeader OfficeFoundingDate;
        private System.Windows.Forms.ColumnHeader OfficeAdress;
        private System.Windows.Forms.ColumnHeader OfficeWorkingTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}