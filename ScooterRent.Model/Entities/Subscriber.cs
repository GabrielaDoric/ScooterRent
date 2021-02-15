using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ScooterRent.Model.Repositories;

namespace ScooterRent_Model
{

    public partial class Subscriber : ISubscriberRepository{

        

        public Subscriber()
        {
        }

        public Subscriber(string subscriberName, string subscriberSurname, string subscriberEmail, string subscriberOIB, DateTime subscriberJoinDate,Office Office)
        {
            
            this.Name = subscriberName;
            this.Surname = subscriberSurname;
            this.EMail = subscriberEmail;
            this.OIB = subscriberOIB;
            this.JoiningDate = subscriberJoinDate;
            this.Office = Office;
           
        }

        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string EMail { get; set; }
        public virtual string OIB { get; set; }
        public virtual DateTime JoiningDate {get;set;}
        public virtual Office Office {get; set; }
        public virtual ISet<Rent> Rents {get;set;}
    }

}
