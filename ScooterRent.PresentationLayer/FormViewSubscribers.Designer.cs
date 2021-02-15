namespace ScooterRent.PresentationLayer
{
    partial class FormViewSubscribers
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
            this.SubscribersViewList = new System.Windows.Forms.ListView();
            this.SubscriberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subscriberEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscriberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscriberSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscriberBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscribersJoinDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscriberDebt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SubscribersViewList
            // 
            this.SubscribersViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubscriberId,
            this.subscriberEmail,
            this.SubscriberName,
            this.SubscriberSurname,
            this.SubscriberBirthDate,
            this.SubscribersJoinDate,
            this.SubscriberDebt});
            this.SubscribersViewList.HideSelection = false;
            this.SubscribersViewList.Location = new System.Drawing.Point(51, 28);
            this.SubscribersViewList.Name = "SubscribersViewList";
            this.SubscribersViewList.Size = new System.Drawing.Size(629, 260);
            this.SubscribersViewList.TabIndex = 0;
            this.SubscribersViewList.UseCompatibleStateImageBehavior = false;
            this.SubscribersViewList.View = System.Windows.Forms.View.Details;
            // 
            // SubscriberId
            // 
            this.SubscriberId.Text = "Id";
            // 
            // subscriberEmail
            // 
            this.subscriberEmail.Text = "Email";
            // 
            // SubscriberName
            // 
            this.SubscriberName.Text = "Name";
            // 
            // SubscriberSurname
            // 
            this.SubscriberSurname.Text = "Surname";
            // 
            // SubscriberBirthDate
            // 
            this.SubscriberBirthDate.Text = "OIB";
            // 
            // SubscribersJoinDate
            // 
            this.SubscribersJoinDate.Text = "JoinDate";
            // 
            // SubscriberDebt
            // 
            this.SubscriberDebt.Text = "Debt";
            this.SubscriberDebt.Width = 152;
            // 
            // FormViewSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 357);
            this.Controls.Add(this.SubscribersViewList);
            this.Name = "FormViewSubscribers";
            this.Text = "View Subscribers";
            this.Load += new System.EventHandler(this.FormViewSubscribers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SubscribersViewList;
        private System.Windows.Forms.ColumnHeader SubscriberId;
        private System.Windows.Forms.ColumnHeader subscriberEmail;
        private System.Windows.Forms.ColumnHeader SubscriberName;
        private System.Windows.Forms.ColumnHeader SubscriberSurname;
        private System.Windows.Forms.ColumnHeader SubscriberBirthDate;
        private System.Windows.Forms.ColumnHeader SubscribersJoinDate;
        private System.Windows.Forms.ColumnHeader SubscriberDebt;
    }
}