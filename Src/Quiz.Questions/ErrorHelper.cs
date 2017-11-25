using Quiz.Questions.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions
{
    public class ErrorHelper
    {
        //gregt put into api and make this internal
        public static void HandleUnexpectedError(Exception ex)//, ResponseDto responseDto) //gregt todo get error into responseDto.ErrorDetails so that it is visible in the ui
        {
            Debug.WriteLine(ex.Message);
            //var exceptionTypeName = ex.GetType().Name;
            //responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        internal static void HandleUnexpectedError(Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        internal static void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible communication error with {url}).";
        }

        internal static bool HasErrorOccured(IRestResponse response)
        {
            var errorHasOccured = 
                response == null ||
                response.ErrorException != null ||
                !string.IsNullOrEmpty(response.ErrorMessage);

            return errorHasOccured;
        }

        internal static string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)
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

        internal static void SetQuizQuestionErrorDetailsFromErrorDetails(QuizQuestion quizQuestion, string errorDetails)
        {
            quizQuestion.ErrorDetails = errorDetails;
        }
    }
}