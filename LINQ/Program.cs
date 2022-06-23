using LinqPracticeProject.EntityClass;
using LinqPracticeProject.ViewModelClasses;

namespace LinqPracticeProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            SamplesViewModel products = new SamplesViewModel();
            SamplesViewModel products2 = new SamplesViewModel();
            List<Product> list = products.GetAllProductsUsingQuery();
            Console.WriteLine("****Get all products using query****");
            foreach (var product in list)
               Console.WriteLine(product.ToString());

            //Console.WriteLine("****Get all products using Method****");
            ////products2.GetAllProductsUsingMethod();
            //foreach (var item in products2.Products)
            //    Console.WriteLine(item.ToString());

            Console.WriteLine("****Get only Name column of products using query****");
            ViewModelToSelectSingleColumn productSingleColumn =new ViewModelToSelectSingleColumn();
            List<string> productNameList = productSingleColumn.GetSingleColumnUsingQuery();
            foreach (var item in productNameList)
                Console.WriteLine(item);

            Console.WriteLine("****Get only Name column of products using query****");
            ViewModelToSelectSingleColumn productSingleColumnUsingMethod = new ViewModelToSelectSingleColumn();
            List<string> productNameListUsingMethod = productSingleColumnUsingMethod.GetSingleColumnUsingQuery();
            foreach (var item in productNameListUsingMethod)
                Console.WriteLine(item);

            Console.WriteLine("****Get only specific columns of products using query****");
            ViewModelToGetSpecificColumn specificColumns = new ViewModelToGetSpecificColumn();
            //List<string> productNameListUsingMethod = productSingleColumnUsingMethod.GetSingleColumnUsingQuery();
            specificColumns.GetSpecificColumnsUsingQuery();
            //specificColumns.GetSpecificColumnsUsingMethod();
            foreach (var item in specificColumns.Products)
                Console.WriteLine(item);

            Console.WriteLine("****Using Where Condition****");
            WhereExpressionDemo productStartsWithLetter = new WhereExpressionDemo();
            productStartsWithLetter.GetByFirstLetterUsingWhereCondition();
            foreach (var item in productStartsWithLetter.Products)
                Console.WriteLine(item);

        //}
    }
}