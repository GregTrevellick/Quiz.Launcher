using MoreLinq;
using Quiz.Questions.Categories.Geek;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Questions
{
    public class QuizQuestionApi : IQuizQuestionApi
    {
        public QuizQuestion GetQuizQuestion(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<QuizQuestion> gatewayResponses = null;

            var categoryToSupply = CategoryHelper.GetCategoryToSupply(preferredCategoriesFromOptions);

            switch (categoryToSupply)
            {
                case Category.Unknown:
                    break;
                case Category.CSharp:
                    break;
                case Category.DotNet:
                    var gateways2 = new GeekGateways();
                    gatewayResponses = gateways2.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Geek:
                    var gateways = new GeekGateways();
                    gatewayResponses = gateways.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Javascript:
                    break;
                case Category.WebDev:
                    break;
            }

            var result = gatewayResponses.RandomSubset(1).Single();

            result.Category = categoryToSupply;

            return result;
        }
    }
}