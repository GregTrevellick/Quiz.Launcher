using Trivial.Entities;

namespace Trivial.Api.Gateway
{
    public class AppUrlHelper
    {
        public static string GetUrl(AppName appName)
        {
            string url = null;
            url = "https://opentdb.com/api.php?amount=1&category=18";
            return url;
        }
    }
}

//"https://icanhazdadjoke.com/api#fetch-a-random-dad-joke"
//"https://restcountries.eu/"
////"https://quotesondesign.com/api-v4-0/"
////https://www.coindesk.com/api/ 
////https://api.pandascore.co/rest#make-basic-requests 
////https://data.police.uk/docs/ 
////https://www.meetup.com/meetup_api/ 
////http://api.football-data.org/index