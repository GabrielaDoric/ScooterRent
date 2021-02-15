using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ScooterRent.BaseLibraries
{
    public interface IOfficeController
    {
        void AddOffice(string OfficeName, string OfficeTown, DateTime OfficeFoundingDate, string OfficeAdress, string OfficeWorkingTime);
        void RemoveOffice(string v);
        
    }
}
