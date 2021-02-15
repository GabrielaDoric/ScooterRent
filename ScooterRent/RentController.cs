using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;
using ScooterRent.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScooterRent
{
    public class RentController: IRentController
    {

        readonly RentRepository repository = RentRepository.GetInstance();

        public RentController()
        {
        }


        public void AddRent(string scooter, DateTime startTime, DateTime endTime, string subscriber)
        {
            repository.AddRent(scooter, startTime, endTime,subscriber );


        }



    }
}
