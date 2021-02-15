using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScooterRent.BaseLibraries
{
    public interface IRentController
    {

        void AddRent(string scooter, DateTime rentStart, DateTime rentEnd, string subscriber);
        //void RemoveRent(Scooter scooter);

        
    }
}

