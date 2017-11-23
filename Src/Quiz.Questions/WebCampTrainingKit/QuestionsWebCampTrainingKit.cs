using System.Collections.Generic;
using System.Linq;

namespace Quiz.Questions.WebCampTrainingKit
{
    public class QuestionsWebCampTrainingKit
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses(IEnumerable<WebCampTrainingKitQuestion> triviaQuestions)
        {
            var gatewayResponses = new List<GatewayResponse>();

            foreach (var triviaQuestion in triviaQuestions)
            {
                var localTriviaQuestion = new GatewayResponse
                {
                    Category = triviaQuestion.Category,
                    DifficultyLevel = triviaQuestion.DifficultyLevel,
                    MultipleChoiceAnswers = triviaQuestion.Answers.Select(x => x.AnswerText),
                    MultipleChoiceCorrectAnswer = triviaQuestion.Answers.Where(x => x.IsCorrect).Select(x => x.AnswerText).Single(),
                    Question = triviaQuestion.QuestionText,
                    QuestionType = QuestionType.MultiChoice
                };

                gatewayResponses.Add(localTriviaQuestion);
            }

            return gatewayResponses;
        }

        /// <summary>
        /// https://github.com/Microsoft-Web/DEMO-GeekQuiz-Web-API-backend
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<WebCampTrainingKitQuestion> GetQuestions()
        {
            var triviaQuestions = new List<WebCampTrainingKitQuestion>
            {
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was .NET first released?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "2000", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2001", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2002", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "2003", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What fictional company did Nancy Davolio work for?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Contoso Ltd.", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Initech", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Fabrikam, Inc.", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Northwind Traders", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "The first / oldest domain name on the internet is:",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Network.com", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Alpha4.com", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Symbolics.com", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "InterConnect.com", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which is not actually a Thing.js?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Mustache.js", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Hammer.js", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Horseradish.js", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Uglify.js", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "In what year was the first Voice Over IP (VOIP) call made?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1973", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "1982", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1991", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1994", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "\"Chicago\" was codename for what Microsoft product?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Visual Basic", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Microsoft Surface", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Windows 95", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Xbox", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many loop constructs are there in C#?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "2", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "3", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "4", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "5", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the first CodePlex.com project?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "EntLib", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "IronPython", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Ajax Toolkit", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "JSON.Net", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Last name of the employee who wears Microsoft badge 00001",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "McDonald", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Gates", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Ballmer", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Allen", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When did Scott Hanselman join Microsoft?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "2007", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "2000", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2005", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2009", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How big is a nibble?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "4 bits", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "8 bits", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "16 bits", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2 bits", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many function calls did Windows 1.0 approximately have?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "100", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "200", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "600", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "400", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "What is the image name for the Windows Task Manager application?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "taskmgr", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "tmanager", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "wtaskmgr", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "wintaskm", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was the internet opened to commercial use?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1989", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1992", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1990", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1991", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was the Xbox unveiled?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "2000", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2001", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "2002", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2003", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What is the value of an Object + Array in JavaScript?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "0", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Array", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Object", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Type Error", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Why was the IBM PCjr despised by users?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Chicklet keyboard", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "No Hard Disk", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Not PC compatible", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "All the above", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the max memory supported by MS-DOS?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "256K", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "512K", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "640K", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1M", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "When was the first laser mouse released?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "2001", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2002", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2003", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2004", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What was Microsoft's first product?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "DOS", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Altair Basic", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "PC Basic", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Windows", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What building does not exist on the Microsoft campus?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "7", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "99", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "115", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel. Hard,
                    QuestionText = "Who wrote the first computer program?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Charles Babbage", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Herman Hollerith", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Ada Lovelace", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Jakob Bernoulli", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Visual Basic was first released in what year?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1990", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1991", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "1992", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "1993", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following is NOT a prime number?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "257", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "379", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "571", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "697", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Yukihiro Matsumoto conceived what programming language on February 24, 1993?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Python", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Ruby", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Perl", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Boo", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which release of the .NET Framework introduced support for dynamic languages?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1.1", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "2.0", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "3.5", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "4.0", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "What is the package manager for Node.js?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "npm", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "yum", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "rpm", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "PEAR", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "In the acronym PaaS, what do the P stand for",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Programming", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Power", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Platform", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Pedestrian", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What is the speed of light in metres per second?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "299,792,458", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "312,123,156", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "100,000,000", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "541,123,102", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the original name of the C# programming language?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Boo", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "C+++", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Cool", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Anders", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which of the following is an example of Boxing in C#?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "int foo = 12;", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "System.Box(56);", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "int foo = (int)bar;", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "object bar = 42;", IsCorrect = true}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following was not an alternative name considered for XML?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "MAGMA", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "SGML", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "SLIM", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "MGML", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                   DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many HTML tags are defined in the original description of the markup language?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "11", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "18", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "25", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following ECMA standards represents the standardization of JavaScript?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "ECMA-123", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "ECMA-262", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "ECMA-301", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "ECMA-431", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the first Web Browser called?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "WorldWideWeb", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Mosaic", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Lynx", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Gopher", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "In version control systems, the process of bringing together two sets of changes is called what?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Branch", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Commit", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Merge", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Share", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "In 1980, Microsoft released there first operating system. What was it called?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "MS-DOS", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Windows", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Xenix", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Altair OS", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which ASCII code (in decimal) represents the character B?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "22", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "66", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "97", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "112", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which are the first 6 decimal digits of Pi?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "3.14159", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "3.14195", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "3.14132", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "3.14123", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Internet Protocol v4 provides approximately how many addresses?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "1.5 billion", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "4.3 billion", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "55 billion", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "3.4 trillion", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What is Layer 4 of the OSI Model?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "Network Layer", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Transport Layer", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "Session Layer", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "Presentation Layer", IsCorrect = false}
                    }
                },
                new WebCampTrainingKitQuestion
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                    Answers = new List<WebCampTrainingKitAnswer>
                    {
                        new WebCampTrainingKitAnswer {AnswerText = "System.Integer", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "System.String", IsCorrect = true},
                        new WebCampTrainingKitAnswer {AnswerText = "System.DateTime", IsCorrect = false},
                        new WebCampTrainingKitAnswer {AnswerText = "System.Float", IsCorrect = false}
                    }
                }
            };

            return triviaQuestions;
        }
    }
}