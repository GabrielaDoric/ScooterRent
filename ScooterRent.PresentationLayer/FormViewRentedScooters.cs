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
using ScooterRent_Model;

namespace ScooterRent.PresentationLayer
{
    public partial class FormViewRentedScooters : Form,IObserver
    {
        private IScooterController scooterController;
        private ScooterRepository scooterRepository;

        private IRentController rentController;
        private RentRepository rentRepository;

        public FormViewRentedScooters()
        {
            InitializeComponent();
        }

        public FormViewRentedScooters(IScooterController scooterController, ScooterRepository scooterRepository, IRentController rentController,
            RentRepository rentRepository)
        {
            this.scooterController = scooterController;
            this.scooterRepository = scooterRepository;
            this.rentController = rentController;
            this.rentRepository = rentRepository;
            InitializeComponent();
        }

        public void UpdateView()
        {
            UpdateList();
        }

        private void FormViewRentedScooters_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {


            ScootersViewList.Items.Clear();
            for (int i = 0; i < rentRepository.Count(); i++)
            {
                Rent rent = rentRepository.getRentByIndex(i);
                ListViewItem listViewItem = new ListViewItem(rent.Id.ToString());
                listViewItem.SubItems.Add(rent.Scooter.Tittle.ToString());
                listViewItem.SubItems.Add(rent.RentDate.Date.ToString());
                listViewItem.SubItems.Add(rent.Deadline.ToString());
                listViewItem.SubItems.Add(rent.Subscriber.Name);


                ScootersViewList.Items.Add(listViewItem);

            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScootersViewList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

       
    }

