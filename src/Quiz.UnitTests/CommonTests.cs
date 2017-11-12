using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions;

namespace Quiz.Ui.UnitTests
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