using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ScooterRent.Model.Repositories;

namespace ScooterRent_Model
{
    public partial class Office : IOfficeRepository{

        public virtual int Id { get; protected set; }

        public virtual string Name { get; set; }

        public virtual string TownName { get; set; }

        public virtual DateTime FoundingDate { get; set; }

        public virtual string Adress { get; set; }

        public virtual string WorkingTime { get; set; }


        public virtual ISet<Subscriber> Subscribers { get; set; }


        public Office()
        {
 
            this.Subscribers = new HashSet<Subscriber>();

        }

        public Office(string OfficeName, string OfficeTown, DateTime OfficeFoundingDate, string OfficeAdress, string OfficeWorkingTime)
        {
            this.Name = OfficeName;
            this.TownName = OfficeTown;
            this.FoundingDate = OfficeFoundingDate;
            this.Adress = OfficeAdress;
            this.WorkingTime = OfficeWorkingTime;
            this.Subscribers = new HashSet<Subscriber>();

        }

        
    }

}
