using CustomerManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTest()
        {
            var source = "AaratiKolhe";
            var expected = "Aarati Kolhe";
            //var stringHandler = new StringHandler();
            //var actual= StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Aarati Kolhe";
            var expected = "Aarati Kolhe";
            //var stringHandler = new StringHandler();
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
    }
}
