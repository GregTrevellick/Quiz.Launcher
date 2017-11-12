namespace Quiz.Questions
{
    public interface IQuestionsGateway
    {
        GatewayResponse SetGatewayResponseFromRestResponse(string responseContent);
    }
}