using MoreLinq;
using Quiz.Questions.Categories.Geek;
using Quiz.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Questions
{
    public class Api : IApi
    {
        public GatewayResponse GetGatewayResponse(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<GatewayResponse> gatewayResponses = null;

            var categoryToSupply = GetCategoryToSupply(preferredCategoriesFromOptions);

            switch (categoryToSupply)
            {
                case Category.Unknown:
                    break;
                case Category.CSharp:
                    break;
                case Category.DotNet:
                    var gateways2 = new GeekGateways();
                    gatewayResponses = gateways2.GetGatewayResponses(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Geek:
                    var gateways = new GeekGateways();
                    gatewayResponses = gateways.GetGatewayResponses(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
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

        //gregt todo extract to separate class below
           
        internal static Category GetCategoryToSupply(Category preferredCategoriesFromOptions)
        {
            SetPreferredCategoriesFromOptionsDictionary(preferredCategoriesFromOptions);

            foreach (var preferredCategoryFromOptions in preferredCategoriesFromOptionsDictionary)
            {
                SetWeightingDictionry(preferredCategoryFromOptions.Value,preferredCategoryFromOptions.Key);
            }

            var random = new Random();
            var rand = random.Next(1, weightingDictionary.Count);
            var result = weightingDictionary.SingleOrDefault(x => x.Key == rand);
            return result.Value;
        }

        private static void SetPreferredCategoriesFromOptionsDictionary(Category preferredCategoriesFromOptions)
        {
            var categoryWeightingDictionary = new Dictionary<Category, int>
            {
                {Category.CSharp, 30},
                {Category.DotNet, 20},
                {Category.Geek, 50}
            };

            var validCategories = Enum.GetValues(typeof(Category));

            foreach (Category category in validCategories)
            {
                if (category > 0)
                {
                    SetPreferredCategoriesFromOptionsDictionary(preferredCategoriesFromOptions, category, categoryWeightingDictionary);
                }
            }
        }

        private static void SetPreferredCategoriesFromOptionsDictionary(Category preferredCategoriesFromOptions, Category preferredCategoryFromOptions, Dictionary<Category, int> categoryWeightingDictionary)
        {
            if (preferredCategoriesFromOptions.HasFlag(preferredCategoryFromOptions))
            {
                preferredCategoriesFromOptionsDictionary.Add(preferredCategoryFromOptions, categoryWeightingDictionary.Single(x => x.Key == preferredCategoryFromOptions).Value);
            }
        }

        private static void SetWeightingDictionry(int weighting, Category category)
        {
            var index = weightingDictionary.Count;

            for (int i = index; i <= weighting; i++)
            {
                weightingDictionary.Add(i, category);
            }
        }

        private static IDictionary<int, Category> weightingDictionary = new Dictionary<int, Category>();

        private static IDictionary<Category, int> preferredCategoriesFromOptionsDictionary = new Dictionary<Category, int>();
    }
}