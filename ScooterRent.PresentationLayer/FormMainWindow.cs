using ScooterRent.BaseLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScooterRent.PresentationLayer
{
    public partial class FormMainWindow : Form
    {

        IMainController controller;

        public FormMainWindow(IMainController _controller)
        {
            controller = _controller;
            InitializeComponent();
        }

        private void AddOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           controller.OfficesAddForm();
        }

        private void knjiznicaStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewOfficesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowOffices();
        }

        private void removeOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            controller.RemoveOffice();


        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AddSubscriber();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ViewSubscribers();
        }

       

        private void removeSubscriberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RemoveSubscriber();
        }


        private void rentScooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RentScooter();
        }


        private void viewScootersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ViewAvaliableScooters();
        }

        private void viewRentedScootersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ViewRentedScooters();
        }

        private void addScooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AddScooter();
        }

        private void removeScooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RemoveScooter();
        }

        private void viewOfficeStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ViewStatistics();
        }
    }
}
