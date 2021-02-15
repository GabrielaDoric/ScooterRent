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
   public class RentRepository:Subject,IRentRepository
    {
        private static RentRepository _instance = null;
        private IList<Rent> _listRents = new List<Rent>();

        public RentRepository() { }
        public static RentRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RentRepository();
            }
            return _instance;
        }

        public void LoadRentsFromDatabase()
        {
            using (ISession nhibernateSession = NhibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Rent as ws order by ws.Id asc");
                _listRents = query.List<Rent>();

            }
        }

        public Rent getRentByIndex(int index)
        {
            LoadRentsFromDatabase();

            if (0 <= index && index < Count())
            {
                return _listRents[index];
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public int Count()
        {
            LoadRentsFromDatabase();
            return _listRents.Count();
        }




        public void AddRent(string scooterName, DateTime startTime, DateTime endTime, string subscriberName)
        {

            //OfficeRepository x = OfficeRepository.GetInstance();
            //Office Office = x.GetOfficeByName(OfficeName);


            ScooterRepository sc = ScooterRepository.getInstance();
            Scooter scooter = sc.GetScooterByName(scooterName);


            SubscriberRepository sub = SubscriberRepository.GetInstance();
            Subscriber subscriber = sub.GetSubscriberByName(subscriberName);


            Rent rent = new Rent(scooter,startTime,endTime,subscriber);
            using (ISession session = NhibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(rent);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }

    }
}
