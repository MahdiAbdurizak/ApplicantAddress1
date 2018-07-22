using Microsoft.VisualStudio.TestTools.UnitTesting;
using Option02.Core;
using Option02.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option02.Test
{
    [TestClass]
    public class ApplicantAddressRepositoryTest
    {
        ApplicantAddressRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            ApplicantInitializeDB db = new ApplicantInitializeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ApplicantAddressRepository();
        }

        [TestMethod]
        public void IsRepositoryInitializeWithValidNumberOfData()
        {
            var result = Repo.GetAddresses();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }

        [TestMethod]
        public void IsRepositoryAddAddresses()
        {
            ApplicantAddress AddressToInsert = new ApplicantAddress
            {
                Id = 3,
                Address1 = "ул. Красная",
                Address2 = "д.47",
                Address3 = "K33",
                Address4 = "кв. 11",
                город = "Пермь",
                Край_Область = "Пермский край"

            };
            Repo.Add(AddressToInsert);
            //if The Address inserted successfully
            //The number of the record will increase to 3
            var result = Repo.GetAddresses();
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(3, numberOfRecords);
        }
        [TestMethod]
        public void IsRepositoryRemoveAddresses()
        {
            int AddressToRemove = 4;
            
            Repo.Remove(AddressToRemove);
            //if The Address Removed successfully
            //The number of the record will decrease to 2
            var result = Repo.GetAddresses();
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }

        [TestMethod]
        public void IsRepositoryFindByIdAddresses()
        {
            int AddressID = 1;

            Repo.FindById(AddressID);
            var result = Repo.FindById(AddressID);
            Assert.IsNotNull(result);
        }

    }
}
