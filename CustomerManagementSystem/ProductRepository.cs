using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class ProductRepository
    {
        public Product RetrieveProduct(int productId)
        {
            Product product = new Product();
            if(productId ==2)
            {
                product.ProductName = "Gemini";
                product.ProductDescription = "1 Litre Gemini Refined Oil Pouch";
                product.CurrentPrice=200;
            }
            Console.WriteLine(product.ToString());
            return product;
        }
        
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Save product
                    }
                    else
                    {
                        //update data
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
