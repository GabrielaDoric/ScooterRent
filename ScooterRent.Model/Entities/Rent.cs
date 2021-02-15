
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ScooterRent.Model.Repositories;

namespace ScooterRent_Model
{

    public partial class Rent : IRentRepository {



        public Rent(Scooter scooter, DateTime rentDate, DateTime deadline, Subscriber subscriber)
        {
            this.RentDate = rentDate;
            this.Deadline = deadline;
            this.Scooter = scooter;
            this.Subscriber = subscriber;

        }


        public Rent()
        {
        }

        public virtual int Id { get; protected set;}

        public virtual DateTime RentDate {get;set;}

        public virtual System.DateTime Deadline{ get;set; }


        public virtual string scooterName { get; set; }
        public virtual string subscriberName { get; set; }


        public virtual Subscriber Subscriber { get; set; }
        public virtual Scooter Scooter {get; set;}
    }

}
