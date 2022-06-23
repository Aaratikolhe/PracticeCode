using LinqPracticeProject.EntityClass;
using LinqPracticeProject.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProject.ViewModelClasses
{
    public class ViewModelToGetSpecificColumn
    {
        public List<Product> Products { get; set; }
        public ViewModelToGetSpecificColumn()
        {
            Products = ProductRepository.GetAll();
        }


        public void GetSpecificColumnsUsingQuery()
        {
            Products=(from prod in Products select new Product { ProductID=prod.ProductID,
                                                                ProductName=prod.ProductName,
                                                                ProductPrice=prod.ProductPrice}).ToList();
        }
        public void GetSpecificColumnsUsingMethod()
        {
           Products=Products.Select(prod=> new Product { ProductID=prod.ProductID,ProductPrice=prod.ProductPrice}).ToList();
        }
    }
}
