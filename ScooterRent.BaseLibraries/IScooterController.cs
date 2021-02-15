using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.BaseLibraries
{
    public interface IScooterController
    {
        void AddScooter(string ScooterName, string ScooterProducer, int maxSpeed,string ScooterType, string rentPrice, string office);
       
        void RemoveScooter(string name);
    }
}
