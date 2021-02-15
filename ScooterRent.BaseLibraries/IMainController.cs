using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BaseLibraries
{
    public interface IMainController
    {
        void ShowOffices();
        void OfficesAddForm();
        void RemoveOffice();
        void AddSubscriber();
        void ViewSubscribers();
        void RemoveSubscriber();
        void ViewAvaliableScooters();
        void ViewRentedScooters();
        void AddScooter();
        void RemoveScooter();
        void ViewStatistics();

        void RentScooter();
    }
}
