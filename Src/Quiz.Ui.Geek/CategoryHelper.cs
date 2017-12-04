using System;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Entities;

namespace Quiz.Ui
{
    internal class CategoryHelper
    {
        private static IDictionary<GeekCategory, int> preferredGeekCategoriesFromOptionsDictionary = new Dictionary<GeekCategory, int>();
        private static IDictionary<int, Category> weightingDictionary = new Dictionary<int, Category>();

        internal static Category GetCategoryToSupply(GeekCategory preferredGeekCategoriesFromOptions)
        {
            SetPreferredGeekCategoriesFromOptionsDictionary(preferredGeekCategoriesFromOptions);

            foreach (var preferredGeekCategoryFromOptions in preferredGeekCategoriesFromOptionsDictionary)
            {
                SetWeightingDictionry(preferredGeekCategoryFromOptions.Value,preferredGeekCategoryFromOptions.Key);
            }

            var random = new Random();
            var rand = random.Next(1, weightingDictionary.Count);
            var result = weightingDictionary.SingleOrDefault(x => x.Key == rand);
            return result.Value;
        }

        private static void SetPreferredGeekCategoriesFromOptionsDictionary(GeekCategory preferredGeekCategoriesFromOptions)
        {
            var geekCategoryWeightingDictionary = new Dictionary<GeekCategory, int>
            {
                //gregt assess these weightings
                {GeekCategory.CSharp, 20},
                {GeekCategory.DotNet, 20},
                {GeekCategory.FrontEnd, 5},
                {GeekCategory.Geek, 50},
                {GeekCategory.Javascript, 5},
            };

            var validGeekCategories = Enum.GetValues(typeof(GeekCategory));

            foreach (GeekCategory geekCategory in validGeekCategories)
            {
                if (geekCategory > 0)
                {
                    SetPreferredGeekCategoriesFromOptionsDictionary(preferredGeekCategoriesFromOptions, geekCategory, geekCategoryWeightingDictionary);
                }
            }
        }

        private static void SetPreferredGeekCategoriesFromOptionsDictionary(GeekCategory preferredGeekCategoriesFromOptions, GeekCategory preferredGeekCategoryFromOptions, Dictionary<GeekCategory, int> geekCategoryWeightingDictionary)
        {
            if (preferredGeekCategoriesFromOptions.HasFlag(preferredGeekCategoryFromOptions))
            {
                preferredGeekCategoriesFromOptionsDictionary.Add(preferredGeekCategoryFromOptions, geekCategoryWeightingDictionary.Single(x => x.Key == preferredGeekCategoryFromOptions).Value);
            }
        }

        private static void SetWeightingDictionry(int weighting, GeekCategory geekCategory)
        {
            var index = weightingDictionary.Count;

            for (int i = 0; i < weighting; i++)
            {
                var category = MapGeekCategoryToCategory(geekCategory);
                weightingDictionary.Add(index, category);
                index++;
            }
        }

        private static Category MapGeekCategoryToCategory(GeekCategory geekCategory)//gregt unit test reqd
        {
            switch (geekCategory)
            {
                case GeekCategory.Unknown:
                    //gregt error here
                    return Category.Unknown;
                case GeekCategory.CSharp:
                    return Category.CSharp;
                case GeekCategory.DotNet:
                    return Category.DotNet;
                case GeekCategory.FrontEnd:
                    return Category.FrontEnd;
                case GeekCategory.Geek:
                    return Category.Geek;
                case GeekCategory.Javascript:
                    return Category.Javascript;
                default:
                    //gregt error here
                    return Category.Unknown;
            }
        }
    }
}