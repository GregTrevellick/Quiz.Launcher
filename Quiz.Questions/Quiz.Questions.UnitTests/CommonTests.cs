using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class CommonTests
    {
        [TestMethod]
        public void UppercaseFirstTest()
        {
            Assert.AreEqual("Abc", Common.UppercaseFirst("abc"));
        }
    }
}
