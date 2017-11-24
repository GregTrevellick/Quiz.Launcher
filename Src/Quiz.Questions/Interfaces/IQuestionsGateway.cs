using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IQuestionsGateway
    {
        GatewayResponse SetGatewayResponseFromRestResponse(string responseContent);
    }
}