using LinqPracticeProject.EntityClass;
using LinqPracticeProject.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProject.ViewModelClasses
{

    public class ViewModelToSelectSingleColumn
    {
        public List<Product> Products { get; set; }
        public ViewModelToSelectSingleColumn()
        {
            Products = ProductRepository.GetAll();
        }


        public List<string> GetSingleColumnUsingQuery()
        {
            List<string> list = new List<string>();
            list.AddRange(from prod in Products select prod.ProductName);
            return list;
        }
        public List<string> GetSingleColumnUsingMethod()
        {
            List<string> list = new List<string>();
            list.AddRange(Products.Select(prod => prod.ProductName).ToList());
            return list;
        }
    }
}
