using System;
using System.ComponentModel;

namespace Quiz.Questions.Entities
{
    [Flags]
    public enum Category
    {
        Unknown = 0,
        Music = 1,
        Geek = 2,
        CSharp = 4,
        DotNet = 8,
        Javascript = 16,
        WebDev = 32,//gregt rename to front end
    }
}







//[Description(".Net")]
//[CustomWeighting(10)]
////https://docs.microsoft.com/en-us/dotnet/standard/attributes/retrieving-information-stored-in-attributes
//public class CustomWeightingAttribute : Attribute
//{
//    public CustomWeightingAttribute(int weighting)
//    {
//        Weighting = weighting;
//    }
//
//    public int Weighting { get; }
//}