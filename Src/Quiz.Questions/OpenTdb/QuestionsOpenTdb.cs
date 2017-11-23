namespace Quiz.Questions.OpenTdb
{
    public class QuestionsOpenTdb
    {
        public GatewayResponse GetGatewayResponse(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=18";

            var gatewayResponse = Common.GetGatewayResponse(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new QuestionsOpenTdbGateway());

            return gatewayResponse;
        }
    }
}