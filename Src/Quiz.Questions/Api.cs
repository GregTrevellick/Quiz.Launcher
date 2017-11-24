using MoreLinq;
using Quiz.Questions.Categories.Geek;
using Quiz.Questions.Categories.Geek.CocktailHeroku;
using Quiz.Questions.Categories.Geek.OpenTdb;
using Quiz.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Questions
{
    public class Api
    {
        public static GatewayResponse GetGatewayResponse(Category category, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<GatewayResponse> gatewayResponses = null;

            var categoryToSupply = GetCategoryToSupply(category);

            switch (categoryToSupply)
            {
                case Category.Unknown:
                    break;
                case Category.CSharp:
                    break;
                case Category.DotNet:
                    break;
                case Category.Geek:
                    var geekGateways = new GeekGateways();
                    gatewayResponses = geekGateways.GetGatewayResponses(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Javascript:
                    break;
                case Category.WebDev:
                    break;
            }

            var result= gatewayResponses.RandomSubset(1).Single();
            result.Category = categoryToSupply;
            return result;
        }

        private static Category GetCategoryToSupply(Category category)
        {
            //gregt todo leverage category to get relevant questions
            //var customeProName = ((CustomAttribute)typeof(Category).GetProperty(prop.Name).GetCustomAttributes(false)[0]).Weighting;

            var random = new Random();
            var remote = random.Next(1, 5);

            return Category.Geek;
        }
    }
}