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
    public partial class FormViewSubscribers : Form,IObserver
    {
        private ISubscriberController subscriberController;
        private SubscriberRepository subscriberRepository;

        private IRentController rentController;
        private RentRepository rentRepository;

        public FormViewSubscribers()
        {
            InitializeComponent();
        }

        public FormViewSubscribers(ISubscriberController subscriberController, SubscriberRepository subscriberRepository, IRentController rentController, RentRepository rentRepository)
        {
            this.subscriberController = subscriberController;
            this.subscriberRepository = subscriberRepository;
            this.rentController = rentController;
            this.rentRepository = rentRepository;

            InitializeComponent();
        }

        public void UpdateView()
        {
            UpdateList();
        }


        private void FormViewSubscribers_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            SubscribersViewList.Items.Clear();

            for (int i = 0; i < subscriberRepository.Count(); i++)
            {
                Subscriber subscriber = subscriberRepository.getSubscriberByIndex(i);
                ListViewItem listViewItem = new ListViewItem(subscriber.Id.ToString());
                listViewItem.SubItems.Add(subscriber.Name);
                listViewItem.SubItems.Add(subscriber.Surname);
                listViewItem.SubItems.Add(subscriber.EMail);
                
                listViewItem.SubItems.Add(subscriber.OIB);
                listViewItem.SubItems.Add(subscriber.JoiningDate.Date.ToShortDateString());


                int totalDays = 0;
                int debt = 0;
                for (int j=0; j < rentRepository.Count(); j++)
                {
                    Rent rent = rentRepository.getRentByIndex(j);

                    totalDays = Convert.ToInt32((rent.Deadline - rent.RentDate).Days);

                    if (rent.Subscriber.Id == subscriber.Id)
                    {
                        debt += (totalDays+1) * Int32.Parse(rent.Scooter.Price);
                    }

                }

                string debtString = debt.ToString();
                listViewItem.SubItems.Add(debtString);
                SubscribersViewList.Items.Add(listViewItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }





