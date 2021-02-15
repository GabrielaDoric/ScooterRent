namespace ScooterRent.PresentationLayer
{
    partial class FormViewAllScooters
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScootersViewList = new System.Windows.Forms.ListView();
            this.ScooterId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScooterOffice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScootersViewList
            // 
            this.ScootersViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScooterId,
            this.ScooterName,
            this.ScooterProducer,
            this.maxSpeed,
            this.ScooterType,
            this.ScooterPrice,
            this.ScooterOffice});
            this.ScootersViewList.HideSelection = false;
            this.ScootersViewList.Location = new System.Drawing.Point(58, 37);
            this.ScootersViewList.Name = "ScootersViewList";
            this.ScootersViewList.Size = new System.Drawing.Size(661, 242);
            this.ScootersViewList.TabIndex = 5;
            this.ScootersViewList.UseCompatibleStateImageBehavior = false;
            this.ScootersViewList.View = System.Windows.Forms.View.Details;
            this.ScootersViewList.SelectedIndexChanged += new System.EventHandler(this.ScootersViewList_SelectedIndexChanged);
            // 
            // ScooterId
            // 
            this.ScooterId.Text = "Id";
            // 
            // ScooterName
            // 
            this.ScooterName.Text = "Name";
            this.ScooterName.Width = 93;
            // 
            // ScooterProducer
            // 
            this.ScooterProducer.Text = "Producer";
            this.ScooterProducer.Width = 80;
            // 
            // maxSpeed
            // 
            this.maxSpeed.Text = "Max Speed";
            this.maxSpeed.Width = 141;
            // 
            // ScooterType
            // 
            this.ScooterType.Text = "Type";
            this.ScooterType.Width = 97;
            // 
            // Scootersection
            // 
            this.ScooterPrice.Text = "Price";
            this.ScooterPrice.Width = 127;

            // 
            // Scootersection
            // 
            this.ScooterOffice.Text = "Office";
            this.ScooterOffice.Width = 127;


            // 
            // FormViewAvaliableScooters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScootersViewList);
            this.Name = "FormViewAvaliableScooters";
            this.Text = "View All Scooters";
            this.Load += new System.EventHandler(this.FormViewAvaliableScooters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ScootersViewList;
        private System.Windows.Forms.ColumnHeader ScooterId;
        private System.Windows.Forms.ColumnHeader ScooterName;
        private System.Windows.Forms.ColumnHeader ScooterProducer;
        private System.Windows.Forms.ColumnHeader maxSpeed;
        private System.Windows.Forms.ColumnHeader ScooterType;
        private System.Windows.Forms.ColumnHeader ScooterPrice;
        private System.Windows.Forms.ColumnHeader ScooterOffice;

        

    }
}