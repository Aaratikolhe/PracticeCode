using CustomerManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class Product:EntityBase,ILoggable
    {
        public Product()
        {
                
        }       
        public Product(int productId)
        {
            ProductId= productId;
        }
 
        private string productName;

        public string ProductName
        {
            get
            {
                //var stringHandler = new StringHandler();
                return productName.InsertSpaces();  
            }
            set
            {
                productName= value;
            }
        }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public string Log()
        {
            var logString = ProductId + ":" +
                ProductName + ":" +
                "Description: " + ProductDescription+
                 "Status: " + EntityState.ToString();
            return logString;

        }
        public override string ToString()
        {
            return ProductName;
        }
        public bool Save()
        {
            return true;
        }
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName))
                isValid = false;
            if (CurrentPrice==null)
                isValid = false;

            return isValid;
        }
        public List<Product> Retrieve()  //get all customers
        {
            return new List<Product>();

        }
        
    }
}
