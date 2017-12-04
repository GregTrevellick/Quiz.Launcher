using System.Collections.Generic;
using System.Linq;

namespace Quiz.Core
{
    public static class IntegerExtensions
    {
        public static string UserStatusDescription(this int percentageCorrect)
        {
            return Ratings.Single(x=>x.Key == percentageCorrect).Value;
        }

        private static IDictionary<int, string> Ratings
        {
            get
            {
                return new Dictionary<int, string>
                {
                    //gregt tidy up words
                    {0, "Rubbish"},
                    {1, "Go back to school"},
                    {2, "Homer Simpson"},
                    {3, "Fail"},
                    {4, "Thick as"},
                    {5, "E-minus"},
                    {6, "Donkey"},
                    {7, "Doofus"},
                    {8, "Dork"},
                    {9, "Nincompoop"},
                    {10, "Doughnut"},
                    {11, "Dummy"},
                    {12, "Dunce"},
                    {13, "Goon"},
                    {14, "Nitwit"},
                    {15, "Half-wit"},
                    {16, "Nugget"},
                    {17, "Pathetic"},
                    {18, "Poor show"},
                    {19, "Numbskull"},
                    {20, "Must try harder"},
                    {21, "Blockhead"},
                    {22, "Birdbrain"},
                    {23, "Abnormal"},
                    {24, "Awful"},
                    {25, "Rainy"},
                    {26, "Dull"},
                    {27, "Dreadful"},
                    {28, "Dismal"},
                    {29, "Toilet"},
                    {30, "Lavatorial"},
                    {31, "Scraping by"},
                    {32, "Getting there"},
                    {33, "Beginner"},
                    {34, "Apprentice"},
                    {35, "Novice"},
                    {36, "Average"},
                    {37, "Standard"},
                    {38, "Run-of-the-mill"},
                    {39, "Unexceptional"},
                    {40, "Ordinary"},
                    {41, "Passable"},
                    {42, "Regular"},
                    {43, "Respectable"},
                    {44, "Modest"},
                    {45, "Normal"},
                    {46, "Bottom half"},
                    {47, "Decent"},
                    {48, "Bright"},
                    {49, "Comic book guy"},
                    {50, "Nerd"},
                    {51, "Basic"},
                    {52, "Adequate"},
                    {53, "Pedestrian"},
                    {54, "Amateur"},
                    {55, "Bog-standard"},
                    {56, "Acceptable"},
                    {57, "Top half"},
                    {58, "Lightweight"},
                    {59, "Middle of the road"},
                    {60, "Mediocre"},
                    {61, "Good"},
                    {62, "Fairly good"},
                    {63, "Pretty good"},
                    {64, "Not bad"},
                    {65, "Wonderful"},
                    {66, "Getting hotter"},
                    {67, "Capable"},
                    {68, "Deluxe"},
                    {69, "Admirable"},
                    {70, "Olympian"},
                    {71, "Superb"},
                    {72, "Heavyweight"},
                    {73, "Unbelievable"},
                    {74, "Sage"},
                    {75, "Whiz"},
                    {76, "Wow"},
                    {77, "Ace"},
                    {78, "Brain box"},
                    {79, "Brainiac"},
                    {80, "A-plus"},
                    {81, "Watson"},
                    {82, "Lisa Simpson"},
                    {83, "Wunderbar"},
                    {84, "IQ buster"},
                    {85, "Awesome"},
                    {86, "Liskov"},
                    {87, "Cerebral"},
                    {88, "Egg head"},
                    {89, "Skeet"},
                    {90, "Rocket scientist"},
                    {91, "Top of the class"},
                    {92, "Alan Turing"},
                    {93, "Charles Babbage"},
                    {94, "Exceptional"},
                    {95, "Ada Lovelace"},
                    {96, "Expert"},
                    {97, "Einstein"},
                    {98, "10 out of 10"},
                    {99, "11 out of 10"},
                    {100, "Genius"},
                };
            }
        }
    }
}



//internal static string GetDescription<T>(this T e) where T : IConvertible
//{
//    string description = null;
//    if (e is Enum)
//    {
//        Type type = e.GetType();
//        Array values = System.Enum.GetValues(type);
//        foreach (int val in values)
//        {
//            if (val == e.ToInt32(CultureInfo.InvariantCulture))
//            {
//                var memInfo = type.GetMember(type.GetEnumName(val));
//                var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
//                if (descriptionAttributes.Length > 0)
//                {
//                    // we're only getting the first description we find
//                    // others will be ignored
//                    description = ((DescriptionAttribute)descriptionAttributes[0]).Description;
//                }
//                break;
//            }
//        }
//    }
//    return description;
//}
