using Gradebook;

namespace GradeBookTest
{
    public class UnitTest1
    {
        [Fact]
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
            Assert.Equal(85.6, result.average,1);
            Assert.Equal(90.5, result.high,1);
            Assert.Equal(77.3, result.low, 1);
            Assert.Equal('B', result.letter);
        }
    }
}