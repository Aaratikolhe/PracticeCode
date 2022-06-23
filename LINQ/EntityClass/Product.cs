using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProject.EntityClass
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public override string? ToString()
        {
            return ProductID+" "+ProductName+" "+ProductPrice+" "+ProductColor+" "+ProductQuantity;
        }
    }
}
