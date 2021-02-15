using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
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
    public partial class FormAddSubscriber : Form,IObserver
    {
        private SubscriberRepository _repository;
        private ISubscriberController _controller;



        public FormAddSubscriber()
        {
            InitializeComponent();
        }

        public FormAddSubscriber(ISubscriberController controller, SubscriberRepository repository)
        {
            _controller = controller;
            _repository = repository;
            InitializeComponent();
        }

        public void UpdateView()
        {
            UpdateList();
        }

        private void UpdateList()
        {
            throw new NotImplementedException();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _controller.AddSubscriber(SubscriberName.Text, SubscriberSurname.Text, subscriberEmail.Text, SubscriberBirthDate.Text, SubscriberJoiningDate.Value, OfficesDropDownList.Text);
            this.Close();
        }

        private void FormAddSubscriber_Load(object sender, EventArgs e)
        {
            OfficeRepository x = OfficeRepository.GetInstance();


            for (int i = 0; i < x.CountOffices(); i++)
            {
                OfficesDropDownList.Items.Add(x.getOfficeByIndex(i).Name);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OfficesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
