using System;

namespace Quiz.Ui
{
    [Flags]
    public enum GeekCategory
    {
        Unknown = 0,
        CSharp = 1,
        DotNet = 2,
        FrontEnd = 4,
        Geek = 8,
        Javascript = 16,
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