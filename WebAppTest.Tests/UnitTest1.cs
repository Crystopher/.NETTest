using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            libraryTest.Class1 test = new libraryTest.Class1();

            test.getInt = 20;

            Assert.AreEqual(expected:21, actual: test.getInt, message: "GetInt returns incorrect value");
        }
    }
}
