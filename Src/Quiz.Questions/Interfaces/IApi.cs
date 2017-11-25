using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IApi
    {
        GatewayResponse GetGatewayResponse(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
    }
}