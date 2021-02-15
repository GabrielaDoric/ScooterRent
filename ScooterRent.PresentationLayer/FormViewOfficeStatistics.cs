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
    public partial class FormViewOfficeStatistics : Form,IObserver
    {
        IOfficeController officeController;
        OfficeRepository officeRepository;

        

        public FormViewOfficeStatistics()
        {
            InitializeComponent();
        }

        public FormViewOfficeStatistics(IOfficeController officeController,OfficeRepository officeRepository)
        {
            this.officeController = officeController;
            this.officeRepository = officeRepository;
            InitializeComponent();
        }



        public void UpdateView()
        {
           ViewList();
        }

        private void ViewList()
        {
            throw new NotImplementedException();
        }

        private void FormViewOfficeStatistics_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < officeRepository.CountOffices(); i++)
            {
                OfficesDropDownList.Items.Add(officeRepository.getOfficeByIndex(i).Name);
            }

            
        }



        private void TypesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void UpdateLists()
        {
            UpdateScootersList();
            UpdateEmployeeList();
            UpdateRentedScootersList();
        }

       

        private void UpdateScootersList()
        {
            ScooterRepository scooterRepository = ScooterRepository.getInstance();
            ScootersViewList.Items.Clear();

            Office office = officeRepository.GetOfficeByName(OfficesDropDownList.Text);


            // OfficesDropDownList
            for (int i = 0; i < scooterRepository.Count(); i++)
            {
               Scooter Scooter = scooterRepository.GetScooterByIndex(i);
                if (Scooter.Office.Id == office.Id)
                { 
                    ListViewItem listViewItem = new ListViewItem(Scooter.Tittle);
                    listViewItem.SubItems.Add(Scooter.Author);
                    ScootersViewList.Items.Add(listViewItem);
                }
            }
        }

        private void UpdateEmployeeList()
        {
            //EmployeeRepository employeeRepository = EmployeeRepository.GetInstance();
            SubscriberRepository subscriberRepository = SubscriberRepository.GetInstance();

            EmployeeListView.Items.Clear();


            Office office = officeRepository.GetOfficeByName(OfficesDropDownList.Text);
            for (int i = 0; i < subscriberRepository.Count(); i++)
            {
                Subscriber employee = subscriberRepository.getSubscriberByIndex(i);
                if (employee.Office.Id == office.Id)
                {
                    ListViewItem listViewItem = new ListViewItem(employee.Name);
                    listViewItem.SubItems.Add(employee.Surname);
                    EmployeeListView.Items.Add(listViewItem);
                }
            }

        }


        private void UpdateRentedScootersList()
        {
            ScooterRepository scooterRepository = ScooterRepository.getInstance();
            RentRepository rentRepository = RentRepository.GetInstance();
            RentedScootersViewList.Items.Clear();

            Office office = officeRepository.GetOfficeByName(OfficesDropDownList.Text);


            // OfficesDropDownList
            for (int i = 0; i < rentRepository.Count(); i++)
            {
                Rent rent = rentRepository.getRentByIndex(i);
                Scooter scooter = scooterRepository.GetScooterByName(rent.Scooter.Tittle);
                if (scooter.Office.Id == office.Id)
                {
                    ListViewItem listViewItem = new ListViewItem(rent.Scooter.Tittle);
                    listViewItem.SubItems.Add(rent.Scooter.Author);
                    RentedScootersViewList.Items.Add(listViewItem);
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
