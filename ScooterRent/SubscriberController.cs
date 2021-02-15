using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent
{
    public class SubscriberController : ISubscriberController
    {

        readonly SubscriberRepository repository = SubscriberRepository.GetInstance();

        public SubscriberController() { }


        public void AddSubscriber(string subscriberName, string subscriberSurname, string subscriberEmail, string subscriberBirthDate, DateTime subscriberJoinDate,string OfficeName)
        {
           
            repository.AddSubscriber(subscriberName, subscriberSurname, subscriberEmail,subscriberBirthDate, subscriberJoinDate,OfficeName);
        }

        public void RemoveSubscriber(string name)
        {
            repository.RemoveSubscriber(name);
        }
    }



}
