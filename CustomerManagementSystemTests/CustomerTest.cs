using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem;

namespace CustomerManagementSystemTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer { FirstName = "Aarati", LastName = "" };
        
            string expected = "Aarati";

            string actual = customer.FullName;

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            var c1=new Customer();
            c1.FirstName = "Aarati";
            Customer.InstanceCount += 1;

            var c2=new Customer();
            c2.FirstName = "Yash";
            Customer.InstanceCount+=1;

            var c3=new Customer();
            c3.FirstName = "Shubham";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3,Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                EmailAddress = "aaratikolhe@gmail.com"
            };
            var expected = false;
            var actual = customer.Validate();
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Kolhe",
                EmailAddress = "aaratikolhe@gmail.com"
            };

            var expected = true;
            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }
    }
}
