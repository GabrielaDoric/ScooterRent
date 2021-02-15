using FluentNHibernate.Mapping;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.MemoryBasedDAL.Mapping
{
    public class SubscriberMap : ClassMap<Subscriber>
    {
        public SubscriberMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name).Length(30);
            Map(x => x.Surname).Length(30);
            Map(x => x.EMail).Length(30);
            Map(y => y.OIB);
            Map(y => y.JoiningDate);
            References(y => y.Office);
            HasMany(y => y.Rents).Cascade.All();
            Table("Subscriber");
        }
    }
}
