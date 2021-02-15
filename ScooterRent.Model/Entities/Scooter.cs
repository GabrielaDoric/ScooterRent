using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ScooterRent.Model.Repositories;

namespace ScooterRent_Model
{
 
    public partial class Scooter : IScooterRepository {
   
        public Scooter()
        {
       
        }

        public Scooter(string ScooterName, string ScooterProducer, int maxSpeed1, string ScooterType, string Price, Office office)
        {
            this.Tittle = ScooterName;
            this.Author = ScooterProducer;
            this.ReleaseYear = maxSpeed1;
            this.Type = ScooterType;
            this.Price = Price;
            this.Office = office;
        }

        public virtual int Id { get; protected set; }

        public virtual string Tittle{get;set;}

        public virtual string Author{get;set;}

        public virtual int ReleaseYear{get;set;}

        public virtual string Type { get; set; }
        public virtual string Price { get; set; }

        public virtual Office Office { get; set; }



        public virtual Rent Rent { get; set; }

    }

}
