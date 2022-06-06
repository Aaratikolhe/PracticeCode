using CustomerManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CustomerManagementSystemTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "abcd@mail.com",
                FirstName = "Aarati",
                LastName = "Kolhe"
            };
            var actual = customerRepository.Retrieve(1);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        //public void RetrieveExistingWithAddress()
        //{
        //    var customerRepository = new CustomerRepository();
        //    var expected = new Customer(1)
        //    {
        //        EmailAddress = "abcd@mail.com",
        //        FirstName = "Aarati",
        //        LastName = "Kolhe",
        //        AddressList=new List<Address>()
        //        {
        //            new Address()
        //            {
        //                AddressType = 1,
        //                StreetLine1 = "Band Street",
        //                StreetLine2 = "Mahabal Road",
        //                City = "Jalgaon",
        //                State = "Maharashtra",
        //                PostalCode = "111221"
        //            },
        //            new Address()
        //            {
        //                AddressType = 2,
        //                StreetLine1 = "Green park",
        //                StreetLine2 = "Nelson Road",
        //                City = "Pune",
        //                State = "Maharashtra",
        //                PostalCode = "111222"
        //            }
        //        }
        //    };

        //    var actual=customerRepository.Retrieve(1);
        //    Assert.AreEqual(expected.CustomerId,actual.CustomerId);
        //    Assert.AreEqual(expected.EmailAddress,actual.EmailAddress);
        //    Assert.AreEqual(expected.FirstName,actual.FirstName);
        //    Assert.AreEqual (expected.LastName,actual.LastName);

        //    for(int i=0;i<1;i++)
        //    {
        //        Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
        //    }
        //}
    }
}
