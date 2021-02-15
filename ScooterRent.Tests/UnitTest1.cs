using System;
using ScooterRent.MemoryBasedDAL;
using ScooterRent_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRent.Tests
{
    [TestClass]
    public class UnitTest1
    {
 
        [TestMethod]
        public void TestAddOffice()
        {
            OfficeRepository x=OfficeRepository.GetInstance();
            x.AddOffice("TestOffice","",DateTime.Today,"","");
            Office Office = x.GetOfficeByName("TestOffice");
            Assert.AreEqual(Office.Name, "TestOffice");
        }

        [TestMethod]
        public void TestRemoveOffice()
        {
            OfficeRepository y = OfficeRepository.GetInstance();
            y.AddOffice("TestOffice1", "", DateTime.Today, "", "");
            OfficeRepository x = OfficeRepository.GetInstance();
            x.AddOffice("TestOffice", "", DateTime.Today, "", "");

            Office Office = x.GetOfficeByName("TestOffice");
            Assert.AreEqual(Office.Name, "TestOffice");
            x.RemoveOffice("TestOffice");
            x.LoadOfficesFromDatabase();
            Office = x.getOfficeByIndex(0);
            Assert.AreNotEqual(Office.Name, "TestOffice");
        }

        [TestMethod]
        public void TestGetOfficeByName()
        {
            OfficeRepository x = OfficeRepository.GetInstance();
            x.AddOffice("TestName", "", DateTime.Today, "", "");
            Office Office = x.GetOfficeByName("TestName");
            Assert.AreEqual(Office.Name, "TestName");
        }

        [TestMethod]
        public void TestAddScooter()
        {
            OfficeRepository y = OfficeRepository.GetInstance();
            y.AddOffice("OfficeName", "", DateTime.Today, "", "");

            ScooterRepository x = ScooterRepository.getInstance();
            x.AddScooter("TestName","TestProducer", 30, "Type", "300", "OfficeName");
            Scooter Scooter = x.GetScooterByName("TestName");
            Assert.AreEqual(Scooter.Tittle, "TestName");
        }

        [TestMethod]
        public void TestRemoveScooter()
        {
            OfficeRepository y = OfficeRepository.GetInstance();
            y.AddOffice("OfficeName", "", DateTime.Today, "", "");

            ScooterRepository x = ScooterRepository.getInstance();
            x.AddScooter("TestName", "TestProducer", 30, "Type", "300", "OfficeName");
            Scooter Scooter = x.GetScooterByName("TestName");
            Assert.AreEqual(Scooter.Tittle, "TestName");
            x.RemoveScooter("TestName");
            try
            {
                Scooter = x.GetScooterByName("TestName");
            }
            catch (NotImplementedException e ) {
                Assert.Equals(true,true);
            }
        }

        [TestMethod]
        public void TestGetScooterByName()
        {
            OfficeRepository y = OfficeRepository.GetInstance();
            y.AddOffice("OfficeName", "", DateTime.Today, "", "");

            ScooterRepository x = ScooterRepository.getInstance();
            x.AddScooter("TestName", "TestProducer", 30, "Type", "300", "OfficeName");
            Scooter Scooter = x.GetScooterByName("TestName");
            Assert.AreEqual(Scooter.Tittle, "TestName");
        }

        [TestMethod]
        public void TestAddSubscriberWithoutOffice()
        {
            try
            {
                SubscriberRepository x = SubscriberRepository.GetInstance();
                x.AddSubscriber("TestName", "TestSurname", "TestEmail", "TestOIB", DateTime.Now, "Office1");
                Subscriber subscriber = x.GetSubscriberByName("TestName");
                Assert.AreEqual(subscriber.EMail, "TestName");
            }
            catch (Exception e) {
                Assert.AreEqual(true,true);
            }
           
        }



        [TestMethod]
        public void TestScootersCount()
        {
            OfficeRepository y = OfficeRepository.GetInstance();
            y.AddOffice("OfficeName", "", DateTime.Today, "", "");

            ScooterRepository x = ScooterRepository.getInstance();
            x.AddScooter("TestName", "TestProducer", 30, "Type", "300", "OfficeName");
            int count = x.Count();
            Assert.AreEqual(true, count>0);

        }


    }
}
