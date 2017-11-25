using Quiz.Questions.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions
{
    public class Common
    {
        internal static QuizQuestion GetQuizQuestion(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName, string url, IQuestionsGateway questionsGateway)
        {
            var quizQuestion = new QuizQuestion();

            if (!string.IsNullOrEmpty(url))
            {
                var responseDto = GetRestResponse(url, timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);

                if (!string.IsNullOrEmpty(responseDto.ErrorDetails))
                {
                    SetQuizQuestionErrorDetailsFromErrorDetails(quizQuestion, responseDto.ErrorDetails);
                }
                else
                {
                    try
                    {
                        quizQuestion = questionsGateway.SetQuizQuestionFromRestResponse(responseDto.ResponseContent);
                    }
                    catch (Exception ex)
                    {
                        HandleUnexpectedError(ex, responseDto);
                        SetQuizQuestionErrorDetailsFromErrorDetails(quizQuestion, responseDto.ErrorDetails);
                    }
                }
            }
            return quizQuestion;
        }

        internal static QuizQuestion Get(Category category, DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null, string wrongAnswer4 = null)
        {
            var quizQuestion = new QuizQuestion
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

            return quizQuestion;
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

        #region gregt extract to error helper
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

        private static void SetQuizQuestionErrorDetailsFromErrorDetails(QuizQuestion quizQuestion, string errorDetails)
        {
            quizQuestion.ErrorDetails = errorDetails;
        }
        #endregion

        #region gregt extract to character helper
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
        #endregion

        //gregt move to API class
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