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
    public partial class FormRemoveOffice : Form
    {

        private OfficeRepository _repository;
        private IOfficeController _controller;


        public FormRemoveOffice(IOfficeController officeController, OfficeRepository officeRepository)
        {
            _controller = officeController;
            _repository = officeRepository;
            InitializeComponent();
        }

        public FormRemoveOffice()
        {
            InitializeComponent();
        }

        private void FormRemoveOffice_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _repository.CountOffices(); i++)
            {
                OfficesDropDownList.Items.Add(_repository.getOfficeByIndex(i).Name);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OfficesDropDownList.SelectedIndex > -1)
            {
                _controller.RemoveOffice(OfficesDropDownList.SelectedItem.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("No office was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
