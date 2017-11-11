using System;

namespace Quiz.Questions
{
    public class QuestionsCocktailHeroku
    {
        public GatewayResponse GetGatewayResponse(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var urlEasy = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/easy/count/1";
            var urlMedium = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/medium/count/1";
            var urlHard = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/hard/count/1";

            var random = new Random();
            var remote = random.Next(1, 3);
            var url = string.Empty;

            switch (remote)
            {
                case 1:
                    url = urlEasy;
                    break;
                case 2:
                    url = urlMedium;
                    break;
                case 3:
                    url = urlHard;
                    break;
            }

            //gregt dedupe below here
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
                        gatewayResponse = QuestionsCocktailHerokuGateway.SetGatewayResponseFromRestResponse(responseDto.ResponseContent);
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