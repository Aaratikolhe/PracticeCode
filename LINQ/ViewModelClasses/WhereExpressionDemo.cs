using LinqPracticeProject.EntityClass;
using LinqPracticeProject.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProject.ViewModelClasses
{
    public class WhereExpressionDemo
    {
        public List<Product> Products { get; set; }
        public WhereExpressionDemo()
        {
            Products = ProductRepository.GetAll();
        }

        //public string ResultText { get; set; }

        public void GetByFirstLetterUsingWhereCondition()
        { 
            Products = (from prod in Products where prod.ProductName.StartsWith("P") select prod).ToList();
            //list.Add(from prod in Products select prod);
        }
    }
}
