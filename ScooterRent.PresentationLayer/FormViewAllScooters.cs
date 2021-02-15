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
    public partial class FormViewAllScooters : Form,IObserver
    {

        private ScooterRepository _repository;
        private IScooterController _controller;

        private OfficeRepository officeRepository;
        private IOfficeController officeController;


        public FormViewAllScooters(IScooterController scooterController, ScooterRepository scooterRepository)
        {
            _repository = scooterRepository;
            _controller = scooterController;
            officeRepository = null;
            officeController = null;
            InitializeComponent();
        }



        public FormViewAllScooters()
        {
            InitializeComponent();
        }

        private void FormViewAvaliableScooters_Load(object sender, EventArgs e)
        {
            {
                UpdateList();
            }
        }

        public void UpdateView()
            {
                UpdateList();
            }

        private void UpdateList()
        {
            ScootersViewList.Items.Clear();
            for (int i = 0; i < _repository.Count(); i++)
            {
                Scooter Scooter = _repository.GetScooterByIndex(i);
                ListViewItem listViewItem = new ListViewItem(Scooter.Id.ToString());
                listViewItem.SubItems.Add(Scooter.Tittle);
                listViewItem.SubItems.Add(Scooter.Author);
                listViewItem.SubItems.Add(Scooter.ReleaseYear.ToString());
                listViewItem.SubItems.Add(Scooter.Type);
                listViewItem.SubItems.Add(Scooter.Price);
                listViewItem.SubItems.Add(Scooter.Office.Name);


                ScootersViewList.Items.Add(listViewItem);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddScooter AddScooter = new FormAddScooter(_controller, _repository, officeController, officeRepository);
            AddScooter.ShowDialog();
        }

        private void ScootersViewList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
