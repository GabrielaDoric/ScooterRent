using FluentNHibernate.Mapping;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.MemoryBasedDAL.Mapping
{
   public class OfficeMapping:ClassMap<Office>
    {

        public OfficeMapping() {
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name).Length(30).Not.Nullable();
            Map(x => x.TownName).Length(30).Not.Nullable();
            Map(x => x.FoundingDate).Not.Nullable();
            Map(x => x.Adress).Length(30).Not.Nullable();
            Map(x => x.WorkingTime).Not.Nullable();
            HasMany(x => x.Subscribers);
            Table("Office");

        }


    }
}
