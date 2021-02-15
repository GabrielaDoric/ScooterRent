using ScooterRent.BaseLibraries;
using ScooterRent.Model;
using ScooterRent.Model.Repositories;
using ScooterRent_Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScooterRent.MemoryBasedDAL
{
    public class OfficeRepository : Subject,IOfficeRepository
    {
        private static OfficeRepository _instance = null;
        private IList<Office> _listOffices = new List<Office>();

        public OfficeRepository() { }
        public static OfficeRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OfficeRepository();
            }
            return _instance;
        }
        public  void AddOffice(string OfficeName, string OfficeTown, DateTime OfficeFoundingDate, string OfficeAdress, string OfficeWorkingTime)
        {
            Office Office = new Office(OfficeName,OfficeTown,OfficeFoundingDate,OfficeAdress,OfficeWorkingTime);
            using (ISession session = NhibernateService.OpenSession())
            {
             using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(Office);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }
        public void RemoveOffice(string name)
        {
            Office Office = GetOfficeByName(name);
            using (ISession session = NhibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(Office);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }
        public Office GetOfficeByName(string name)
        {
            if (name != null)
            {
                Office fromDB;
                using (ISession session = NhibernateService.OpenSession())
                {
                    IQuery q = session.CreateQuery("from Office where Name = '" + name + "'");
                    fromDB = q.List<Office>()[0];
                  
                }
                return fromDB;
            }
            else
            {
                throw new NotImplementedException();
            }   
        }
        public Office getOfficeByIndex(int index)
        {
            LoadOfficesFromDatabase();

            if (0 <= index && index < CountOffices())
            {
                return _listOffices[index];
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void LoadOfficesFromDatabase()
        {
            using (ISession nhibernateSession = NhibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Office as ws order by ws.Id asc");
                _listOffices = query.List<Office>();

            }
        }
        public int CountOffices()
        {
            LoadOfficesFromDatabase();
            return _listOffices.Count();
        }
    }
}
