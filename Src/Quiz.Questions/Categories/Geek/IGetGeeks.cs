using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek
{
    interface IGetGeeks
    {
        IEnumerable<GatewayResponse> GetGatewayResponses();
    }
}
