using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class CommonTests
    {
        [DataRow("", "")]
        [DataRow(null, "")]
        [DataRow("Abc", "Abc")]
        [DataRow("Ab cd", "Ab cd")]
        [DataRow("abc", "Abc")]
        [DataRow("ab cd", "Ab cd")]
        [DataRow("aBc", "ABc")]
        [DataRow("aB Cd", "AB Cd")]
        [DataTestMethod]
        public void UppercaseFirstTest(string str, string expected)
        {
            Assert.AreEqual(expected, Common.UppercaseFirst(str));
        }

        [TestMethod]
        public void HasErrorOccuredTest1()
        {
            Assert.IsTrue(Common.HasErrorOccured(null));
        }

        [TestMethod]
        public void HasErrorOccuredTest2()
        {
            IRestResponse response = new RestResponse();
            Assert.IsFalse(Common.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest3()
        {
            IRestResponse response = new RestResponse
            {
                ErrorMessage = "abc"
            };
            Assert.IsTrue(Common.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest4()
        {
            IRestResponse response = new RestResponse
            {
                ErrorException = new Exception()
            };
            Assert.IsTrue(Common.HasErrorOccured(response));
        }
    }
}
