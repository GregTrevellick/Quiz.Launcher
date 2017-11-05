using System;
using System.Diagnostics;
using RestSharp;

namespace Quiz.Ui.Gateway
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

            var gatewayResponse = new GatewayResponse();

            //gregt dedupe below here
            if (!string.IsNullOrEmpty(url))
            {
                var responseDto = GetRestResponse(url, timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);

                if (!string.IsNullOrEmpty(responseDto.ErrorDetails))
                {
                    SetGatewayResponseFromErrorDetails(gatewayResponse, responseDto.ErrorDetails);
                }
                else
                {
                    try
                    {
                        gatewayResponse = QuestionsCocktailHerokuGateway.SetGatewayResponseFromRestResponse(responseDto.ResponseContent);
                    }
                    catch (Exception ex)
                    {
                        HandleUnexpectedError(ex, responseDto);
                        SetGatewayResponseFromErrorDetails(gatewayResponse, responseDto.ErrorDetails);
                    }
                }
            }

            return gatewayResponse;
        }

        private ResponseDto GetRestResponse(string url, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)//gregt dedupe
        {
            var responseDto = new ResponseDto();

            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET) {Timeout = timeOutInMilliSeconds };
                var response = client.Execute(request);

                var hasErrorOccured = HasErrorOccured(response);
                if (hasErrorOccured)
                {
                    responseDto.ErrorDetails = GetErrorDetails(response, timeOutInMilliSecondsOptionLabel, optionName);
                }
                else
                {
                    responseDto.ResponseContent = response.Content;
                }
            }
            catch(Exception ex)
            {
                HandleUnexpectedError(url, ex, responseDto);
            }

            return responseDto;
        }

        private void HandleUnexpectedError(Exception ex, ResponseDto responseDto)//gregt dedupe
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occured (possible JSON deserialization error).";
        }

        private void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)//gregt dedupe
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occured (possible communication error with {url}).";
        }

        internal bool HasErrorOccured(IRestResponse response)//gregt dedupe
        {
            var errorHasOccured =
                response == null ||
                response.ErrorException != null ||
                !string.IsNullOrEmpty(response.ErrorMessage);

            return errorHasOccured;
        }

        private string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)//gregt dedupe
        {
            string errorDetails;

            if (response == null)
            {
                errorDetails = "An indeterminate error has occured";
            }
            else
            {
                errorDetails =
                    response.ResponseStatus + " " +
                    "(" + response.StatusCode + ") " +
                    response.StatusDescription + " " +
                    response.ErrorMessage + " ";

                if (response.ErrorException != null &&
                    response.ErrorException.Message != response.ErrorMessage)
                {
                    errorDetails = errorDetails + " " + response.ErrorException.Message;
                }

                if (response.ResponseStatus == ResponseStatus.TimedOut)
                {
                    errorDetails += $"{Environment.NewLine}{Environment.NewLine}Try increasing the value for '{timeOutInMilliSecondsOptionLabel}' in Tools | Options | {optionName}";
                }
            }

            return errorDetails;
        }

        private void SetGatewayResponseFromErrorDetails(GatewayResponse gatewayResponse, string errorDetails)//gregt dedupe
        {
            gatewayResponse.ErrorDetails = errorDetails;
        }
    }
}