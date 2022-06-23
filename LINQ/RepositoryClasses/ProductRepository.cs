using LinqPracticeProject.EntityClass;
using System;
using System.Collections.Generic;

namespace LinqPracticeProject.RepositoryClasses
{
    public class ProductRepository
    {
        public static List<Product> GetAll()
        {
            return new List<Product>
        {
        new Product {
          ProductID = 1,
          ProductName = "Sofa",
          ProductColor = "Black",
          ProductPrice = 30000,
          ProductQuantity = 3,
        },
        new Product {
          ProductID = 51,
          ProductName = "Chair",
          ProductColor = "Red",
          ProductPrice = 3000,
          ProductQuantity = 6,
        },
        new Product {
          ProductID = 3,
          ProductName = "Mobile",
          ProductColor = "Blue",
          ProductPrice = 70000,
          ProductQuantity = 10,
        },
        new Product {
          ProductID = 4,
          ProductName = "Pen",
          ProductColor = "Green",
          ProductPrice =10,
          ProductQuantity = 100,
        },
        new Product {
          ProductID = 9,
          ProductName = "Pencil",
          ProductColor = "Black",
          ProductPrice = 3,
          ProductQuantity = 500,
        },
        new Product {
          ProductID = 15,
          ProductName = "Bottle",
          ProductColor = "Orange",
          ProductPrice = 300,
          ProductQuantity = 30,
        },
        new Product {
          ProductID = 21,
          ProductName = "Bag",
          ProductColor = "Blue",
          ProductPrice = 3000,
          ProductQuantity = 13,
        }

      };
    }

}
}