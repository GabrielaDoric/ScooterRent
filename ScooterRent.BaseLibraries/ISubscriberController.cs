using System;
namespace ScooterRent.BaseLibraries
{
    public  interface ISubscriberController
    {

    void AddSubscriber(string subscriberName, string subscriberSurname,string subscriberEmail, string subscriberBirthDate, DateTime subscriberJoinDate,String Office);
    void RemoveSubscriber(string name);
    

    }
}
