using System;
using System.ComponentModel;

namespace Quiz.Questions.Entities
{
    [Flags]
    public enum Category
    {
        //Unknown = 0,
        //Music = 1,
        //Geek = 2,
        //CSharp = 4,
        //DotNet = 8,
        //Javascript = 16,
        //WebDev = 32,//gregt rename to front end
        Unknown = 0,
        Music,
        Geek,
        CSharp,
        DotNet,
        Javascript,
        WebDev,//gregt rename to front end
    }
}
