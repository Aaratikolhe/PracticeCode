using CustomerManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystemTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProductValidate()
        {
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Gemini",
                ProductDescription = "1 Litre Gemini Refined Oil Pouch",
                CurrentPrice = 200
            };

            var actual = productRepository.RetrieveProduct(2);

            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository=new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Gemini",
                ProductDescription = "1 Litre Gemini Refined Oil Pouch",
                CurrentPrice = 300,
                HasChanges = true
            };
            var actual=productRepository.Save(updatedProduct);
            Assert.AreEqual(true, actual);
        }
    }
}
