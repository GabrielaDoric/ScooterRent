using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent
{
    public class ScooterController : IScooterController
    {

        ScooterRepository repository = ScooterRepository.getInstance();


        public void AddScooter(string ScooterName, string ScooterProducer, int maxSpeed,string ScooterType, string rentPrice, string office)
        {
            repository.AddScooter(ScooterName, ScooterProducer, maxSpeed,ScooterType,rentPrice, office);
        }


        public void RemoveScooter(string name)
        {
            repository.RemoveScooter(name);
        }
    }
}
