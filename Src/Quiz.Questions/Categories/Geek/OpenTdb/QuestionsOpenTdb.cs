using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek.OpenTdb
{
    internal class QuestionsOpenTdb : IGetGatewayResponses
    {
        public IEnumerable<GatewayResponse> GetGatewayResponses(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=18";

            var gatewayResponse = Common.GetGatewayResponse(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new QuestionsOpenTdbGateway());

            return new List<GatewayResponse> { gatewayResponse };
        }
    }
}