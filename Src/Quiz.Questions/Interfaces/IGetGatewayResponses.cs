using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IGetGatewayResponses
    {
        IEnumerable<GatewayResponse> GetGatewayResponses(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
    }
}