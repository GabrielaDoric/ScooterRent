using System;

namespace ScooterRent.PresentationLayer
{
    partial class FormMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.officeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOfficeStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scootersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScootersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentedScootersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rentScooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officeStripMenuItem,
            this.scootersToolStripMenuItem,
            this.subscribersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OfficeStripMenuItem
            // 
            this.officeStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOfficeToolStripMenuItem,
            this.addOfficeToolStripMenuItem,
            this.removeOfficeToolStripMenuItem,
            this.viewOfficeStatisticsToolStripMenuItem});
            this.officeStripMenuItem.Name = "OfficeStripMenuItem";
            this.officeStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.officeStripMenuItem.Text = "Offices";
            this.officeStripMenuItem.Click += new System.EventHandler(this.knjiznicaStripMenuItem_Click);
            // 
            // viewOfficeToolStripMenuItem
            // 
            this.viewOfficeToolStripMenuItem.Name = "viewOfficeToolStripMenuItem";
            this.viewOfficeToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.viewOfficeToolStripMenuItem.Text = "View Offices";
            this.viewOfficeToolStripMenuItem.Click += new System.EventHandler(this.viewOfficesToolStripMenuItem_Click);
            // 
            // addOfficeToolStripMenuItem
            // 
            this.addOfficeToolStripMenuItem.Name = "addOfficeToolStripMenuItem";
            this.addOfficeToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.addOfficeToolStripMenuItem.Text = "Add Office";
            this.addOfficeToolStripMenuItem.Click += new System.EventHandler(this.AddOfficeToolStripMenuItem_Click);
            // 
            // removeOfficeToolStripMenuItem
            // 
            this.removeOfficeToolStripMenuItem.Name = "removeOfficeToolStripMenuItem";
            this.removeOfficeToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.removeOfficeToolStripMenuItem.Text = "Remove Office";
            this.removeOfficeToolStripMenuItem.Click += new System.EventHandler(this.removeOfficeToolStripMenuItem_Click);
            // 
            // viewOfficeStatisticsToolStripMenuItem
            // 
            this.viewOfficeStatisticsToolStripMenuItem.Name = "viewOfficeStatisticsToolStripMenuItem";
            this.viewOfficeStatisticsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.viewOfficeStatisticsToolStripMenuItem.Text = "View Office Statistics";
            this.viewOfficeStatisticsToolStripMenuItem.Click += new System.EventHandler(this.viewOfficeStatisticsToolStripMenuItem_Click);
            // 
            // scootersToolStripMenuItem
            // 
            this.scootersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScootersToolStripMenuItem,
            this.viewRentedScootersToolStripMenuItem,
            this.addScooterToolStripMenuItem,
            this.removeScooterToolStripMenuItem,
            this.rentScooterToolStripMenuItem});
            this.scootersToolStripMenuItem.Name = "officesToolStripMenuItem";
            this.scootersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.scootersToolStripMenuItem.Text = "Scooters";
            // 
            // viewScootersToolStripMenuItem
            // 
            this.viewScootersToolStripMenuItem.Name = "viewScootersToolStripMenuItem";
            this.viewScootersToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.viewScootersToolStripMenuItem.Text = "View All Scooters";
            this.viewScootersToolStripMenuItem.Click += new System.EventHandler(this.viewScootersToolStripMenuItem_Click);
            // 
            // viewRentedScootersToolStripMenuItem
            // 
            this.viewRentedScootersToolStripMenuItem.Name = "viewRentedScootersToolStripMenuItem";
            this.viewRentedScootersToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.viewRentedScootersToolStripMenuItem.Text = "View Rented Scooters";
            this.viewRentedScootersToolStripMenuItem.Click += new System.EventHandler(this.viewRentedScootersToolStripMenuItem_Click);
            // 
            // addScooterToolStripMenuItem
            // 
            this.addScooterToolStripMenuItem.Name = "addScooterToolStripMenuItem";
            this.addScooterToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.addScooterToolStripMenuItem.Text = "Add Scooter";
            this.addScooterToolStripMenuItem.Click += new System.EventHandler(this.addScooterToolStripMenuItem_Click);
            // 
            // removeScooterToolStripMenuItem
            // 
            this.removeScooterToolStripMenuItem.Name = "removeScooterToolStripMenuItem";
            this.removeScooterToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.removeScooterToolStripMenuItem.Text = "Remove Scooter";
            this.removeScooterToolStripMenuItem.Click += new System.EventHandler(this.removeScooterToolStripMenuItem_Click);
            // 
            // subscribersToolStripMenuItem
            // 
            this.subscribersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeSubscriberToolStripMenuItem});
            this.subscribersToolStripMenuItem.Name = "subscribersToolStripMenuItem";
            this.subscribersToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.subscribersToolStripMenuItem.Text = "Subscribers";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.viewToolStripMenuItem.Text = "View Subscribers";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addToolStripMenuItem.Text = "Add Subscriber";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeSubscriberToolStripMenuItem
            // 
            this.removeSubscriberToolStripMenuItem.Name = "removeSubscriberToolStripMenuItem";
            this.removeSubscriberToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.removeSubscriberToolStripMenuItem.Text = "Remove Subscriber";
            this.removeSubscriberToolStripMenuItem.Click += new System.EventHandler(this.removeSubscriberToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 326);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(645, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // rentScooterToolStripMenuItem
            // 
            this.rentScooterToolStripMenuItem.Name = "rentScooterToolStripMenuItem";
            this.rentScooterToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.rentScooterToolStripMenuItem.Text = "Rent Scooter";


            this.rentScooterToolStripMenuItem.Click += new System.EventHandler(this.rentScooterToolStripMenuItem_Click);

            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 348);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainWindow";
            this.Text = "ScooterRent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem officeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOfficeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem removeOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scootersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScootersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscribersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSubscriberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRentedScootersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOfficeStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentScooterToolStripMenuItem;
    }
}