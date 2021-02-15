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
    public class ScooterRepository : Subject,IScooterRepository
    {
        private IList<Scooter> _listScooters = new List<Scooter>();

        private static ScooterRepository _instance = null;

        public static ScooterRepository getInstance()
        {
                if (_instance == null)
                {
                    _instance = new ScooterRepository();
                }
                return _instance;
            }

        public void AddScooter(string ScooterName, string ScooterProducer, int maxSpeed,string ScooterType, string Price, string OfficeName)
        {

            

            OfficeRepository x = OfficeRepository.GetInstance();
            Office Office = x.GetOfficeByName(OfficeName);

            Scooter Scooter = new Scooter(ScooterName,ScooterProducer,maxSpeed,ScooterType,Price, Office);
            using (ISession session = NhibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(Scooter);
                    transaction.Commit();
                }
            }
        }

        public void RemoveScooter(string name)
        {
            
                Scooter Scooter = GetScooterByName(name);
                using (ISession session = NhibernateService.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(Scooter);
                        transaction.Commit();
                    }
                }
                NotifyObservers();
            
        }

        public int Count()
        {
            LoadScootersFromDatabase();
            return _listScooters.Count();
        }

        private void LoadScootersFromDatabase()
        {
            using (ISession nhibernateSession = NhibernateService.OpenSession())
            {
                _listScooters = nhibernateSession
                     .QueryOver<Scooter>()
                     .Where(x=>x.Rent==null)
                     .OrderBy(c => c.Tittle).Asc
                     .List<Scooter>();

                //IQuery query = nhibernateSession.CreateQuery(
                //"from Scooter as ws  order by ws.Id asc");
                //_listScooters = query.List<Scooter>();
            }
        }

        public Scooter GetScooterByName(string name)
        {
            if (name != null)
            {
               Scooter fromDB;
                using (ISession session = NhibernateService.OpenSession())
                {
                    IQuery q = session.CreateQuery("from Scooter where Tittle = '" + name + "'");
                    fromDB = q.List<Scooter>()[0];

                }
                return fromDB;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public Scooter GetScooterByIndex(int index)
        {
            LoadScootersFromDatabase();

            if (0 <= index && index <= Count())
            {
                return _listScooters[index];
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public Scooter GetRentedScooterByIndex(int index)
        {
            LoadRentedScootersFromDatabase();

            if (0 <= index && index <= CountRented())
            {
                return _listScooters[index];
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void LoadRentedScootersFromDatabase()
        {
            using (ISession nhibernateSession = NhibernateService.OpenSession())
            {
                _listScooters = nhibernateSession
                     .QueryOver<Scooter>()
                     .Where(x => x.Rent != null)
                     .OrderBy(c => c.Tittle).Asc
                     .List<Scooter>();

                //IQuery query = nhibernateSession.CreateQuery(
                //"from Scooter as ws  order by ws.Id asc");
                //_listScooters = query.List<Scooter>();
            }
        }

        public int CountRented()
        {
            LoadRentedScootersFromDatabase();
            return _listScooters.Count();
        }

    }

}

