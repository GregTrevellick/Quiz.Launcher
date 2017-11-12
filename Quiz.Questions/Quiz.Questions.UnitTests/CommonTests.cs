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
        public bool HasErrorOccuredTest()
        {
            //gregt .?
            Assert.IsTrue(Common.HasErrorOccured(null));

            IRestResponse response = new RestResponse();
            Assert.IsTrue(Common.HasErrorOccured(response));

            response.ErrorMessage = "abc";
            Assert.IsTrue(Common.HasErrorOccured(response));

            response.ErrorException="abc";
            Assert.IsTrue(Common.HasErrorOccured(response));
        }
    }
}
