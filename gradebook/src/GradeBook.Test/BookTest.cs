using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GradeBook;

namespace GradeBook.Test
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var x = 5;
            //var y = 2;

            //var expected = 10;
            //var actual = x * y;
            //Assert.AreEqual(expected,actual) ;

            var book = new Book("Name");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            var result = book.GetStatistics();
            Assert.Equal(85.6, result.Average);
            Assert.Equal(90.5, result.Average);
            Assert.Equal(77.3, result.Average);


        }
    }
}
