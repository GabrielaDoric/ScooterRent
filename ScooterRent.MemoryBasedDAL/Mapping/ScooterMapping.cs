using FluentNHibernate.Mapping;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.MemoryBasedDAL.Mapping
{
   public class ScooterMapping : ClassMap<Scooter>
    {

        public ScooterMapping() {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Tittle).Length(30).Not.Nullable();
            Map(x => x.Author).Length(30).Not.Nullable();
            Map(x => x.ReleaseYear).Not.Nullable();
            
            Map(x => x.Type).Length(30).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            References(x => x.Rent).Not.LazyLoad();
            References(x => x.Office).Not.LazyLoad();
        }
        


    }
}
