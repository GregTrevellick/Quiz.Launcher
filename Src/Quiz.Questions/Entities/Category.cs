using System;

namespace Quiz.Questions.Entities
{
    [Flags]
    public enum Category
    {
        [Custom(0)]
        Unknown = 0,

        [Custom(10)]
        CSharp = 1,

        [Custom(10)]
        DotNet = 2,

        [Custom(60)]
        Geek = 4,

        [Custom(10)]
        Javascript = 8,

        [Custom(10)]
        WebDev = 16,
    }

    //https://docs.microsoft.com/en-us/dotnet/standard/attributes/retrieving-information-stored-in-attributes
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(int weighting)
        {
            Weighting = weighting;
        }

        public int Weighting { get; private set; }
    }
}
