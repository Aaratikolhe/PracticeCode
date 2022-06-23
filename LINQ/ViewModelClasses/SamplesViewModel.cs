using LinqPracticeProject.EntityClass;
using LinqPracticeProject.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPracticeProject.ViewModelClasses
{
  public class SamplesViewModel
  {
        public List<Product> Products { get; set; }
        public SamplesViewModel()
         {
              Products = ProductRepository.GetAll();
         }
    
        public string ResultText { get; set; }

        public List<Product> GetAllProductsUsingQuery()
        {
            List<Product> list = new List<Product>();
            list = (from prod in Products select prod).ToList();
            //list.Add(from prod in Products select prod);
            return list;
        }
        public void GetAllProductsUsingMethod()
        {
            List<Product> list = new List<Product>();
            list = Products.Select(prod => prod).ToList();
            //list.Add(from prod in Products select prod);
        }




    }
}
