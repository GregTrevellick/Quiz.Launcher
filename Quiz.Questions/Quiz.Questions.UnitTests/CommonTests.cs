using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
