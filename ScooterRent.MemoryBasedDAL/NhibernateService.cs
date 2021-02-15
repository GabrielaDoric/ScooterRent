using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using global::NHibernate;
using global::NHibernate.Cfg;
using global::NHibernate.Tool.hbm2ddl;
using ScooterRent.MemoryBasedDAL.Mapping;
using ScooterRent_Model;


namespace ScooterRent.MemoryBasedDAL
{
   public class NhibernateService
    {
        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = CreateSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw e.InnerException ?? e;
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(
                SQLiteConfiguration.Standard
                  .UsingFile("ScooterRentDb.db")
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<OfficeMapping>()).ExposeConfiguration(e => new SchemaUpdate(e).Execute(true, true))
              .BuildSessionFactory();
        }

      }
    }
