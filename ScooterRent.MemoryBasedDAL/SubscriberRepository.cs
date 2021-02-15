using ScooterRent.BaseLibraries;
using ScooterRent.Model.Repositories;
using ScooterRent_Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.MemoryBasedDAL
{
    public class SubscriberRepository : Subject,ISubscriberRepository
    {
        private static SubscriberRepository _instance = null;
        private IList<Subscriber> _listSuscribers = new List<Subscriber>();
        private IList<Office> _listOffices = new List<Office>();

        public static SubscriberRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SubscriberRepository();
            }
            return _instance;
        }

        public void AddSubscriber(string subscriberName, string subscriberSurname, string subscriberEmail, string subscriberBirthDate, DateTime subscriberJoinDate,string OfficeName)
        {
            OfficeRepository x = OfficeRepository.GetInstance();
            Office Office = x.GetOfficeByName(OfficeName);
            Subscriber subscriber = new Subscriber(subscriberName, subscriberSurname, subscriberEmail, subscriberBirthDate, subscriberJoinDate,Office);
            using (ISession session = NhibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(subscriber);
                    transaction.Commit();
                }
            }
        }
        public void RemoveSubscriber(string name)
        {
            Subscriber subscriber = GetSubscriberByName(name);
            using (ISession session = NhibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(subscriber);
                    transaction.Commit();
                }
            }
            NotifyObservers();

        }

        public Subscriber GetSubscriberByName(string name)
        {
            if (name != null)
            {
                Subscriber fromDB;
                using (ISession session = NhibernateService.OpenSession())
                {
                    IQuery q = session.CreateQuery("from Subscriber where Name = '" + name + "'");
                    fromDB = q.List<Subscriber>()[0];

                }
                return fromDB;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public Subscriber getSubscriberByIndex(int index)
        {
            LoadSubscribersFromDatabase();

            if (0 <= index && index < Count())
            {
                return _listSuscribers[index];
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public int Count()
        {
            LoadSubscribersFromDatabase();
            return _listSuscribers.Count();
        }

        private void LoadSubscribersFromDatabase()
        {
            using (ISession nhibernateSession = NhibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Subscriber as ws order by ws.Id asc");
                _listSuscribers = query.List<Subscriber>();

            }
        }

        

       
    }
}
