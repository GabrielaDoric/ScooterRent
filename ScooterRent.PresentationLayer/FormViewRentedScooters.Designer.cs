namespace ScooterRent.PresentationLayer
{
    partial class FormViewRentedScooters
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ScootersViewList = new System.Windows.Forms.ListView();
            this.RentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            
            this.ScooterStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Scootersubscriber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(322, 336);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(125, 43);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ScootersViewList
            // 
            this.ScootersViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RentID,
            this.ScooterName,
            this.ScooterStartDate,
            this.ScooterEndDate,
            this.Scootersubscriber});
            this.ScootersViewList.HideSelection = false;
            this.ScootersViewList.Location = new System.Drawing.Point(65, 66);
            this.ScootersViewList.Name = "ScootersViewList";
            this.ScootersViewList.Size = new System.Drawing.Size(661, 242);
            this.ScootersViewList.TabIndex = 8;
            this.ScootersViewList.UseCompatibleStateImageBehavior = false;
            this.ScootersViewList.View = System.Windows.Forms.View.Details;
            this.ScootersViewList.SelectedIndexChanged += new System.EventHandler(this.ScootersViewList_SelectedIndexChanged);
            // 
            // RentID
            // 
            this.RentID.Text = "ID";
            this.RentID.Width = 186;
            // 
            // ScooterName
            // 
            this.ScooterName.Text = "Name";
            this.ScooterName.Width = 186;
            // 
            // ScooterRentedDate
            // 
            this.ScooterStartDate.Text = "Start date";
            this.ScooterStartDate.Width = 185;
            // 
            // ScooterDeadline
            // 
            this.ScooterEndDate.Text = "End date";
            this.ScooterEndDate.Width = 141;
            // 
            // Scootersubscriber
            // 
            this.Scootersubscriber.Text = "Subscriber";
            this.Scootersubscriber.Width = 245;
            // 
            // FormViewRentedScooters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ScootersViewList);
            this.Name = "FormViewRentedScooters";
            this.Text = "View Rented Scooters";
            this.Load += new System.EventHandler(this.FormViewRentedScooters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView ScootersViewList;
        private System.Windows.Forms.ColumnHeader RentID;
        private System.Windows.Forms.ColumnHeader ScooterName;
        private System.Windows.Forms.ColumnHeader Scootersubscriber;
        private System.Windows.Forms.ColumnHeader ScooterStartDate;
        private System.Windows.Forms.ColumnHeader ScooterEndDate;
    }
}