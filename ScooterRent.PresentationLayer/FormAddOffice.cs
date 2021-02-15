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
    public partial class FormAddOffice : Form,IObserver
    {
        private OfficeRepository _repository;
        private IOfficeController _controller;


        public FormAddOffice(IOfficeController officeController,OfficeRepository officeRepository)
        {
            _controller = officeController;
            _repository = officeRepository;

            InitializeComponent();
        }

        private void FormAddOffice_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        _controller.AddOffice(OfficeName.Text, OfficeTown.Text, OfficeFoundingDate.Value, OfficeAdress.Text, WorkingTime.Text);
            
            this.Close();
        }

        public void UpdateView()
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}










