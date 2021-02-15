using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent.Model.Repositories;
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
    public partial class FormviewOffices : Form,IObserver
    {
        private OfficeRepository _repository;
        private IOfficeController _controller;

        public FormviewOffices(IOfficeController officeController, OfficeRepository officeRepository) {
            _repository = officeRepository;
            _controller = officeController;
            InitializeComponent();
        }
        private void FormviewOffices_Load(object sender, EventArgs e)
        {
            UpdateList();
        }


        public void UpdateView()
        {
            UpdateList();
        }


        public void UpdateList()
        {
            OfficeViewList.Items.Clear();

            for (int i = 0; i < _repository.CountOffices(); i++)
            {
                Office Office = _repository.getOfficeByIndex(i);
                ListViewItem listViewItem = new ListViewItem(Office.Id.ToString());
                listViewItem.SubItems.Add(Office.Name);
                listViewItem.SubItems.Add(Office.TownName);
                listViewItem.SubItems.Add(Office.FoundingDate.Date.ToString());
                listViewItem.SubItems.Add(Office.Adress);
                listViewItem.SubItems.Add(Office.WorkingTime);
                OfficeViewList.Items.Add(listViewItem);
            }  
        }

        private void OfficeViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddOffice AddOffice = new FormAddOffice(_controller,_repository);

            AddOffice.ShowDialog();
            
        }
    }
}

