using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz.Ui.UnitTests
{
    [TestClass]
    public class QuizHelperTests
    {
        [DataRow(5, 20, 25)]
        [DataRow(1, 1, 100)]
        [DataTestMethod]
        public void GetPercentageSuccess2Test(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked, int expected)
        {
            Assert.AreEqual(expected, QuizHelper.GetPercentageSuccess2(totalQuestionsAnsweredCorrectly, totalQuestionsAsked));
        }
    }
}





//[TestClass]
//public class FibonacciTests
//{
//    [DataRow(0, 0)]
//    [DataRow(1, 1)]
//    [DataRow(2, 1)]
//    [DataRow(80, 23416728348467685)]
//    [DataTestMethod]
//    public void GivenDataFibonacciReturnsResultsOk(int number, Int64 result)
//    {
//        var fib = new Fib();
//        var actual = fib.Fibonacci(number);
//        Assert.AreEqual(result, actual);
//    }
//}