using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Entities;
using Quiz.Ui;

namespace Quiz.Core.UnitTests
{
    [TestClass]
    public class GeneralOptionsDtoTests
    {
        [TestMethod]
        public void PreferredCategoriesFromOptionsTest()
        {
            // Arrange 
            var sut = new GeneralOptionsDto
            {
                IncludeQuizCategoryCSharp = true,
                IncludeQuizCategoryDotNet = false,
                IncludeQuizCategoryGeek = true,
                IncludeQuizCategoryJavascript = false,
                IncludeQuizCategoryFrontEnd = true
            };

            // Act
            var actual = sut.PreferredGeekCategoriesFromOptions;

            // Assert
            //Assert.IsFalse(actual.HasFlag(Category.Unknown)); gregt reinstate this
            Assert.IsTrue(actual.HasFlag(Category.CSharp));
            Assert.IsFalse(actual.HasFlag(Category.DotNet));
            Assert.IsTrue(actual.HasFlag(Category.Geek));
            Assert.IsFalse(actual.HasFlag(Category.Javascript));
            Assert.IsTrue(actual.HasFlag(Category.FrontEnd));
        }
    }
}
