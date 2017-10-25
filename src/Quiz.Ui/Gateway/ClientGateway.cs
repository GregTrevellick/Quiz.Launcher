using System;
using System.Diagnostics;
using RestSharp;

namespace Quiz.Ui.Gateway
{
    public class ClientGateway
    {
        public GatewayResponse GetGatewayResponse(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=18";//AppUrlHelper.GetUrl();

            var gatewayResponse = new GatewayResponse();

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
                        gatewayResponse = ClientGatewayQuiz.SetGatewayResponseFromRestResponse(responseDto.ResponseContent);
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

        private ResponseDto GetRestResponse(string url, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        private void HandleUnexpectedError(Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occured (possible JSON deserialization error).";
        }

        private void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occured (possible communication error with {url}).";
        }

        internal bool HasErrorOccured(IRestResponse response)
        {
            var errorHasOccured =
                response == null ||
                response.ErrorException != null ||
                !string.IsNullOrEmpty(response.ErrorMessage);

            return errorHasOccured;
        }

        private string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        private void SetGatewayResponseFromErrorDetails(GatewayResponse gatewayResponse, string errorDetails)
        {
            gatewayResponse.ErrorDetails = errorDetails;
        }
    }
}