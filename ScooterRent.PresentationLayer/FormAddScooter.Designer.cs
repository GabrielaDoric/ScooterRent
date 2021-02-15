namespace ScooterRent.PresentationLayer
{
    partial class FormAddScooter
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
            this.ScooterName = new System.Windows.Forms.TextBox();
            this.ScooterProducer = new System.Windows.Forms.TextBox();
            this.maxSpeed = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ScooterType = new System.Windows.Forms.ComboBox();
            this.ScootersOffice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Speed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // ScooterName
            // 
            this.ScooterName.Location = new System.Drawing.Point(267, 65);
            this.ScooterName.Name = "ScooterName";
            this.ScooterName.Size = new System.Drawing.Size(100, 22);
            this.ScooterName.TabIndex = 5;
            // 
            // ScooterProducer
            // 
            this.ScooterProducer.Location = new System.Drawing.Point(267, 99);
            this.ScooterProducer.Name = "ScooterProducer";
            this.ScooterProducer.Size = new System.Drawing.Size(100, 22);
            this.ScooterProducer.TabIndex = 6;
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(267, 137);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(200, 22);
            this.maxSpeed.TabIndex = 8;
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price.Location = new System.Drawing.Point(267, 216);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(200, 22);
            this.price.TabIndex = 9;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(294, 344);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 33);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(168, 344);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 33);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ScooterType
            // 
            this.ScooterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScooterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScooterType.FormattingEnabled = true;
            this.ScooterType.Items.AddRange(new object[] {
            "Electric Kick Scooters",
            "Foldable Electric Scooters",
            "Off-road Electric Kick Scooters",
            "Fat Tires Electric Kick Scooters",
            "Electric Scooters for Kids",
            "Self-balancing Electric Scooters",
            "Electric Mopeds"});
            this.ScooterType.Location = new System.Drawing.Point(267, 177);
            this.ScooterType.Margin = new System.Windows.Forms.Padding(4);
            this.ScooterType.Name = "ScooterType";
            this.ScooterType.Size = new System.Drawing.Size(200, 24);
            this.ScooterType.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.ScootersOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScootersOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScootersOffice.FormattingEnabled = true;
            this.ScootersOffice.Location = new System.Drawing.Point(267, 264);
            this.ScootersOffice.Margin = new System.Windows.Forms.Padding(4);
            this.ScootersOffice.Name = "comboBox1";
            this.ScootersOffice.Size = new System.Drawing.Size(200, 24);
            this.ScootersOffice.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Office";
            // 
            // FormAddScooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ScootersOffice);
            this.Controls.Add(this.ScooterType);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.ScooterProducer);
            this.Controls.Add(this.ScooterName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddScooter";
            this.Text = "Add Scooter";
            this.Load += new System.EventHandler(this.FormAddScooter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ScooterName;
        private System.Windows.Forms.TextBox ScooterProducer;
        private System.Windows.Forms.TextBox maxSpeed;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ScooterType;
        private System.Windows.Forms.ComboBox ScootersOffice;
        private System.Windows.Forms.Label label6;
    }
}