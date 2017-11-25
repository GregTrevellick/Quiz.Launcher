using System;
using System.ComponentModel;

namespace Quiz.Questions.Entities
{
    [Flags]
    public enum Category
    {
        //////////[CustomWeighting(0)]
        Unknown = 0,

        //[Description("C#")]
        //////////[CustomWeighting(10)]
        CSharp = 1,

       // [Description(".Net")]
        //////////[CustomWeighting(10)]
        DotNet = 2,

      //  [Description("gGeek")]
        //////////[CustomWeighting(60)]
        Geek = 4,

      //  [Description("javascript")]
        //////////[CustomWeighting(10)]
        Javascript = 8,

    //    [Description("web dev")]
        //////////[CustomWeighting(10)]
        WebDev = 16,
    }

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
}
