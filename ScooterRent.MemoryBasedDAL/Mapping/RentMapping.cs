using FluentNHibernate.Mapping;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.MemoryBasedDAL.Mapping
{
    class RentMapping:ClassMap<Rent>
    {

        public RentMapping() {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.RentDate).Not.Nullable();
            Map(x => x.Deadline).Not.Nullable();
            References(x => x.Subscriber).Not.LazyLoad();
            References(x=>x.Scooter).Not.LazyLoad();

            Table("Rent");

        }

    }
}
