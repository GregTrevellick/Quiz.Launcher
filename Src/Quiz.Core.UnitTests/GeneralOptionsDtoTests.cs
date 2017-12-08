using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Entities;
using Quiz.Ui;

namespace Quiz.Core.UnitTests
{
    [TestClass]
    public class GeneralOptionsDtoTests
    {
        [TestMethod]
        public void PreferredGeekCategoriesFromOptionsTest()
        {
            // Arrange 
            var sut = new GeneralOptionsDto//C:\Users\gtrev\Source\Repos\Quiz.Launcher\Src\Quiz.Ui.Geek\GeneralOptionsDto.cs
            {
                IncludeQuizCategoryCSharp = true,
                IncludeQuizCategoryDotNet = false,
                IncludeQuizCategoryFrontEnd = true,
                IncludeQuizCategoryGeek = false,
                IncludeQuizCategoryJavascript = true,
            };

            // Act
            var actual = sut.PreferredGeekCategoriesFromOptions;

            // Assert
            Assert.IsTrue(actual.HasFlag(GeekCategory.CSharp));
            Assert.IsFalse(actual.HasFlag(GeekCategory.DotNet));
            Assert.IsTrue(actual.HasFlag(GeekCategory.FrontEnd));
            Assert.IsFalse(actual.HasFlag(GeekCategory.Geek));
            Assert.IsTrue(actual.HasFlag(GeekCategory.Javascript));
        }
    }
}
