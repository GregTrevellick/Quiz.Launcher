using System;

namespace Quiz.Ui.Gateway
{
    public class QuestionsOpenTdb
    {
        public GatewayResponse GetGatewayResponse(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=18";

            var gatewayResponse = new GatewayResponse();

            if (!string.IsNullOrEmpty(url))
            {
                var responseDto = Common.GetRestResponse(url, timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);

                if (!string.IsNullOrEmpty(responseDto.ErrorDetails))
                {
                    Common.SetGatewayResponseFromErrorDetails(gatewayResponse, responseDto.ErrorDetails);
                }
                else
                {
                    try
                    {
                        gatewayResponse = QuestionsOpenTdbGateway.SetGatewayResponseFromRestResponse(responseDto.ResponseContent);
                    }
                    catch (Exception ex)
                    {
                        Common.HandleUnexpectedError(ex, responseDto);
                        Common.SetGatewayResponseFromErrorDetails(gatewayResponse, responseDto.ErrorDetails);
                    }
                }
            }

            return gatewayResponse;
        }
    }
}