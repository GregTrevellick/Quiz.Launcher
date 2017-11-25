using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Quiz.Questions
{
    internal class Common
    {
        internal static QuizQuestion GetQuizQuestion(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName, string url, IQuestionsGateway questionsGateway)
        {
            var quizQuestion = new QuizQuestion();

            if (!string.IsNullOrEmpty(url))
            {
                var responseDto = GetRestResponse(url, timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);

                if (!string.IsNullOrEmpty(responseDto.ErrorDetails))
                {
                    ErrorHelper.SetQuizQuestionErrorDetailsFromErrorDetails(quizQuestion, responseDto.ErrorDetails);
                }
                else
                {
                    try
                    {
                        quizQuestion = questionsGateway.SetQuizQuestionFromRestResponse(responseDto.ResponseContent);
                    }
                    catch (Exception ex)
                    {
                        ErrorHelper.HandleUnexpectedError(ex, responseDto);
                        ErrorHelper.SetQuizQuestionErrorDetailsFromErrorDetails(quizQuestion, responseDto.ErrorDetails);
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

                var hasErrorOccured = ErrorHelper.HasErrorOccured(response);
                if (hasErrorOccured)
                {
                    responseDto.ErrorDetails = ErrorHelper.GetErrorDetails(response, timeOutInMilliSecondsOptionLabel, optionName);
                }
                else
                {
                    responseDto.ResponseContent = response.Content;
                }
            }
            catch(Exception ex)
            {
                ErrorHelper.HandleUnexpectedError(url, ex, responseDto);
            }

            return responseDto;
        }
    }
}