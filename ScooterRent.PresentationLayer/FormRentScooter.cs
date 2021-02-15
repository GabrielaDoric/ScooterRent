using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent_Model;
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
    public partial class FormRentScooter : Form, IObserver
    {

        private IScooterController scooterController;
        private ScooterRepository scooterRepository;
        private ISubscriberController subscriberController;
        private SubscriberRepository subscriberRepository;


        private IRentController rentController;
        private RentRepository rentRepository;



        public FormRentScooter(IScooterController scooterController, ScooterRepository scooterRepository, ISubscriberController subscriberController, SubscriberRepository subscriberRepository, IRentController rentController, RentRepository rentRepository)
        {
            this.scooterController = scooterController;
            this.scooterRepository = scooterRepository;
            this.subscriberController = subscriberController;
            this.subscriberRepository = subscriberRepository;
            this.rentController = rentController;
            this.rentRepository = rentRepository;

            InitializeComponent();
        }

        public FormRentScooter()
        {
            InitializeComponent();
        }

        private void FormRentScooter_Load_Scooters(object sender, EventArgs e)
        {

            UpdateList();

        }

        
        public void UpdateView()
        {
            UpdateList();
        }
        

        private void UpdateList()
        {

            for (int i = 0; i < this.scooterRepository.Count(); i++){
                bool check = false;
                Scooter scooter = this.scooterRepository.GetScooterByIndex(i);
                for (int j = 0; j < this.rentRepository.Count(); j++){
                    ScooterRent_Model.Rent rent = rentRepository.getRentByIndex(j);

                    if (rent.Scooter.Id == scooter.Id)
                    {
                        check = true;
                        break;
                    }
                }

            if (check == true){
                continue;
            }
            else{
                ScootersDropDownList.Items.Add(this.scooterRepository.GetScooterByIndex(i).Tittle);
            }
            }
        }

        private void FormRentScooter_Load_Subscriber(object sender, EventArgs e)
        {
            for (int i = 0; i < this.subscriberRepository.Count(); i++)
            {
                SubscribersDropDownList.Items.Add(this.subscriberRepository.getSubscriberByIndex(i).Name);
            }
        }




        private void AddButton_Click(object sender, EventArgs e)
        {
            rentController.AddRent(ScootersDropDownList.Text, rentStart.Value, rentEnd.Value, SubscribersDropDownList.Text);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
