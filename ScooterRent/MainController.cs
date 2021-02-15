using ScooterRent;
using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent.Model.Repositories;
using ScooterRent.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScooterRent
{
    public class MainController : IMainController
    {
        OfficeController officeController = new OfficeController();
        readonly OfficeRepository officeRepository = OfficeRepository.GetInstance();

        SubscriberController subscriberController = new SubscriberController();
        readonly SubscriberRepository subscriberRepository = SubscriberRepository.GetInstance();

        ScooterController scooterController = new ScooterController();
        readonly ScooterRepository scooterRepository = ScooterRepository.getInstance();


        RentController rentController = new RentController();
        readonly RentRepository rentRepository = RentRepository.GetInstance();



        public MainController()
        {
        }

        public void OfficesAddForm()
        {  
            FormAddOffice addForm = new FormAddOffice(officeController, officeRepository);
            addForm.ShowDialog();
          
        }

        public void ShowOffices()
        {
            FormviewOffices viewOffices = new FormviewOffices(officeController, officeRepository);
            officeRepository.Attach(viewOffices);
            viewOffices.ShowDialog();
            officeRepository.Delete(viewOffices);

        }

        public void RemoveOffice()
        {
            FormRemoveOffice RemoveOffice = new FormRemoveOffice(officeController, officeRepository);
            RemoveOffice.ShowDialog();
        }

        public void AddSubscriber()
        {
            FormAddSubscriber addSubscriber = new FormAddSubscriber(subscriberController, subscriberRepository);
            addSubscriber.ShowDialog();
        }
        public void ViewSubscribers()
        {
            FormViewSubscribers viewSubscriber = new FormViewSubscribers(subscriberController, subscriberRepository, rentController, rentRepository);
            subscriberRepository.Attach(viewSubscriber);
            viewSubscriber.ShowDialog();
            subscriberRepository.Delete(viewSubscriber);
        }

        public void RemoveSubscriber()
        {
            FormRemoveSubscriber removeSubscriber = new FormRemoveSubscriber(subscriberController, subscriberRepository);
            removeSubscriber.ShowDialog();
        }



        public void ViewAvaliableScooters()
        {
            FormViewAllScooters ViewAvaliableScooters = new FormViewAllScooters(scooterController, scooterRepository);
            scooterRepository.Attach(ViewAvaliableScooters);
            ViewAvaliableScooters.ShowDialog();
            scooterRepository.Delete(ViewAvaliableScooters);
        }

        public void ViewRentedScooters()
        {
            FormViewRentedScooters ViewRentedScooters = new FormViewRentedScooters(scooterController, scooterRepository, rentController, rentRepository);
            scooterRepository.Attach(ViewRentedScooters);
            ViewRentedScooters.ShowDialog();
            scooterRepository.Delete(ViewRentedScooters);
        }

        public void AddScooter()
        {
            FormAddScooter AddScooter = new FormAddScooter(scooterController,scooterRepository, officeController, officeRepository);
            AddScooter.ShowDialog();
        }

        public void RentScooter()
        {
            FormRentScooter RentScooter = new FormRentScooter(scooterController, scooterRepository, subscriberController, subscriberRepository, rentController, rentRepository);
            RentScooter.ShowDialog();
        }

        public void RemoveScooter()
        {
            FormRemoveScooter RemoveScooter = new FormRemoveScooter(scooterController, scooterRepository);
            RemoveScooter.ShowDialog();
        }

        public void ViewStatistics()
        {
            FormViewOfficeStatistics viewOfficeStatistic = new FormViewOfficeStatistics(officeController, officeRepository);
            officeRepository.Attach(viewOfficeStatistic);
            viewOfficeStatistic.ShowDialog();
            officeRepository.Delete(viewOfficeStatistic);
        }
    }
}
