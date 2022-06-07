using CustomerManagementSystem;
using CustomerManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTest
{
    [TestClass]
    public class LoginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems=new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "abcd@a.com",
                FirstName = "Aarati",
                LastName = "Kolhe",
                AddressList =null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Gemini",
                ProductDescription = "1 Litre Gemini Refined Oil Pouch",
                CurrentPrice = 300
                //HasChanges = true
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
