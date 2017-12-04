using System;
using System.ComponentModel;

namespace Quiz.Questions.Entities
{
    [Flags]
    public enum GeekCategory
    {
        Unknown = 0,
        Geek = 1,
        CSharp = 2,
        DotNet = 4,
        Javascript = 8,
        WebDev = 16,//gregt rename to front end
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