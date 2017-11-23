using System;

namespace Quiz.Questions
{
    [Flags]
    public enum Category
    {
        Unknown = 0,
        CSharp = 1,
        DotNet = 2,
        Geek = 4,
        Javascript = 8,
        WebDev = 16,
    }
}
