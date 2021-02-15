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
    public class OfficeController : IOfficeController
    {

        readonly OfficeRepository repository = OfficeRepository.GetInstance();

        public OfficeController()
        {
        }

        public void AddOffice(string OfficeName, string OfficeTown, DateTime OfficeFoundingDate, string OfficeAdress, string OfficeWorkingTime)
        {
                repository.AddOffice(OfficeName,OfficeTown,OfficeFoundingDate,OfficeAdress,OfficeWorkingTime);


        }

        public void RemoveOffice(string OfficeName)
        {
               repository.RemoveOffice(OfficeName);
         }
      
        

    }
}

