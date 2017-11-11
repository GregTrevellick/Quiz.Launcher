﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using RestSharp;

namespace Quiz.Questions
{
    public class Common
    {
        public static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null)
        {
            var result = new GatewayResponse
            {
                DifficultyLevel = difficultyLevel,
                MultipleChoiceAnswers = new List<string>
                {
                    correctAnswer,
                    wrongAnswer1,
                    wrongAnswer2,
                    wrongAnswer3,
                },
                MultipleChoiceCorrectAnswer = correctAnswer,
                Question = question,
                QuestionType = QuestionType.MultiChoice
            };

            return result;
        }

        public static ResponseDto GetRestResponse(string url, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        public static void HandleUnexpectedError(Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        public static void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)
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

        public static string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        public static void SetGatewayResponseFromErrorDetails(GatewayResponse gatewayResponse, string errorDetails)
        {
            gatewayResponse.ErrorDetails = errorDetails;
        }

        public static string UppercaseFirst(string str)//gregt unit test reqd
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string CharacterHandler(string str)//gregt unit test reqd
        {
            var result = WebUtility.HtmlDecode(str);
            return result;
        }

    }
}