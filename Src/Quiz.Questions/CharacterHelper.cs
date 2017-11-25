using System.Net;

namespace Quiz.Questions
{
    public class CharacterHelper
    {
        internal static string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        internal static string CharacterHandler(string str)
        {
            var result = WebUtility.HtmlDecode(str);
            return result;
        }
    }
}