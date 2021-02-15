using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;

namespace ScooterRent.PresentationLayer
{
    public partial class FormRemoveSubscriber : Form
    {
        private ISubscriberController subscriberController;
        private SubscriberRepository subscriberRepository;

        public FormRemoveSubscriber()
        {
            InitializeComponent();
        }

        public FormRemoveSubscriber(ISubscriberController subscriberController, SubscriberRepository subscriberRepository)
        {
            this.subscriberController = subscriberController;
            this.subscriberRepository = subscriberRepository;
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (SubscribersDropDownList.SelectedIndex > -1)
            {
                subscriberController.RemoveSubscriber(SubscribersDropDownList.SelectedItem.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("No subscriber was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void FormRemoveSubscriber_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < subscriberRepository.Count(); i++)
            {
                SubscribersDropDownList.Items.Add(subscriberRepository.getSubscriberByIndex(i).Name);
            }
        }
    }
}
