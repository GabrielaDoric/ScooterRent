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
    public partial class FormAddScooter : Form,IObserver
    {
        private IScooterController scooterController;
        private ScooterRepository scooterRepository;

        private IOfficeController officeController;
        private OfficeRepository officeRepository;


        public FormAddScooter()
        {
            InitializeComponent();
        }

        public FormAddScooter(IScooterController scooterController, ScooterRepository scooterRepository, IOfficeController officeController, OfficeRepository officeRepository)
        {
            this.scooterController = scooterController;
            this.scooterRepository = scooterRepository;
            this.officeController = officeController;
            this.officeRepository = officeRepository;
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
 
            scooterController.AddScooter(ScooterName.Text, ScooterProducer.Text, Convert.ToInt32(maxSpeed.Text), ScooterType.Text, price.Text, ScootersOffice.Text);
            this.Close();
        }



        private void FormAddScooter_Load_Office(object sender, EventArgs e)
        {
            for (int i = 0; i < this.officeRepository.CountOffices(); i++)
            {
                ScootersOffice.Items.Add(this.officeRepository.getOfficeByIndex(i).Name);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maxSpeed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAddScooter_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.officeRepository.CountOffices(); i++)
            {
                ScootersOffice.Items.Add(this.officeRepository.getOfficeByIndex(i).Name);
            }
        }
    }
}
