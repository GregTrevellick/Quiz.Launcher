using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using MoreLinq;
using Quiz.Questions.CocktailHeroku;
using Quiz.Questions.OpenTdb;
using RestSharp;

namespace Quiz.Questions
{
    public class Common
    {
        public static GatewayResponse GetGatewayResponse(Category category, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var random = new Random();
            var remote = random.Next(1, 5);
            var gatewayResponse = new GatewayResponse();

            switch (remote)
            {
                case 1:
                case 2:
                    var questionsOpenTdb = new QuestionsOpenTdb();
                    gatewayResponse = questionsOpenTdb.GetGatewayResponse(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case 3:
                    var allGateways = new AllGateways();
                    gatewayResponse = allGateways.GetGatewayResponse();
                    break;
                case 4:
                case 5:
                    var questionsOpenCocktail = new QuestionsCocktailHeroku();
                    gatewayResponse = questionsOpenCocktail.GetGatewayResponse(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
            }

            return gatewayResponse;
        }

        internal static GatewayResponse GetGatewayResponse(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName, string url, IQuestionsGateway questionsGateway)
        {
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
                        gatewayResponse = questionsGateway.SetGatewayResponseFromRestResponse(responseDto.ResponseContent);
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

        internal static GatewayResponse Get(Category category, DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null, string wrongAnswer4 = null)
        {
            var result = new GatewayResponse
            {
                Category = category,
                DifficultyLevel = difficultyLevel,
                MultipleChoiceAnswers = new List<string>
                {
                    correctAnswer,
                    wrongAnswer1,
                    wrongAnswer2,
                    wrongAnswer3,
                    wrongAnswer4,
                },
                MultipleChoiceCorrectAnswer = correctAnswer,
                Question = question,
                QuestionType = QuestionType.MultiChoice
            };

            return result;
        }

        private static ResponseDto GetRestResponse(string url, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        public static void HandleUnexpectedError(Exception ex)//, ResponseDto responseDto) //gregt todo get error into responseDto.ErrorDetails so that it is visible in the ui
        {
            Debug.WriteLine(ex.Message);
            //var exceptionTypeName = ex.GetType().Name;
            //responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        private static void HandleUnexpectedError(Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        private static void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible communication error with {url}).";
        }

        public static bool HasErrorOccured(IRestResponse response)
        {
            var errorHasOccured = 
                response == null ||
                response.ErrorException != null ||
                !string.IsNullOrEmpty(response.ErrorMessage);

            return errorHasOccured;
        }

        private static string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            string errorDetails;

            if (response == null)
            {
                errorDetails = "An indeterminate error has occurred";
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

        private static void SetGatewayResponseFromErrorDetails(GatewayResponse gatewayResponse, string errorDetails)
        {
            gatewayResponse.ErrorDetails = errorDetails;
        }

        internal static string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        internal static string CharacterHandler(string str)
        {
            var result = WebUtility.HtmlDecode(str);
            return result;
        }

        public static DifficultyLevel GetDifficultyLevel(string textBlockDifficultyText)
        {
            if (string.IsNullOrWhiteSpace(textBlockDifficultyText))
            {
                return DifficultyLevel.Medium;
            }
            else
            {
                var str = textBlockDifficultyText.Replace("Difficulty: ", string.Empty);
                str = UppercaseFirst(str.ToLower());
                Enum.TryParse(str, out DifficultyLevel difficultyLevel);
                return difficultyLevel;
            }
        }
    }
}