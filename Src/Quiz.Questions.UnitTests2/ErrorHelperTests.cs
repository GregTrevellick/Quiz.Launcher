using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class ErrorHelperTests
    {
        [TestMethod]
        public void HasErrorOccuredTest1()
        {
            Assert.IsTrue(ErrorHelper.HasErrorOccured(null));
        }

        [TestMethod]
        public void HasErrorOccuredTest2()
        {
            IRestResponse response = new RestResponse();
            Assert.IsFalse(ErrorHelper.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest3()
        {
            IRestResponse response = new RestResponse
            {
                ErrorMessage = "abc"
            };
            Assert.IsTrue(ErrorHelper.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest4()
        {
            IRestResponse response = new RestResponse
            {
                ErrorException = new Exception()
            };
            Assert.IsTrue(ErrorHelper.HasErrorOccured(response));
        }
    }
}
