using System.Collections.Generic;
using System.Linq;

namespace Quiz.Ui.Gateway
{
    public class LocalGateway
    {
        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, bool correctAnswer, bool wrongAnswer)
        {
            var result = Get(difficultyLevel, question, correctAnswer.ToString(), wrongAnswer.ToString());
            result.QuestionType = QuestionType.TrueFalse;
            return result;
        }

        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null)
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

        public static IEnumerable<GatewayResponse> GatewayResponses
        {
            get
            {
                var triviaQuestions = GetTriviaQuestions();

                var localTriviaQuestions = new List<GatewayResponse>();

                foreach (var triviaQuestion in triviaQuestions)
                {
                    var localTriviaQuestion = new GatewayResponse
                    {
                        DifficultyLevel = triviaQuestion.DifficultyLevel,
                        MultipleChoiceAnswers = triviaQuestion.TriviaAnswers.Select(x => x.Answer),
                        MultipleChoiceCorrectAnswer = triviaQuestion.TriviaAnswers.Where(x=>x.IsCorrect).Select(x=>x.Answer).Single(),
                        Question = triviaQuestion.Question,
                        QuestionType = QuestionType.MultiChoice
                    };

                    localTriviaQuestions.Add(localTriviaQuestion);
                }

                var localResponse = new List<GatewayResponse>
                {
                    Get(DifficultyLevel.Easy, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage", "A computing-related protocol", "A very bad day at work"),
                    Get(DifficultyLevel.Hard, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Medium, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Easy, "Sunday is a month ?", false, true),
                    //gregt opentdb submitable questions - cmmi ? solid ? grunt ? gulp ?
                };

                var result = localResponse.Union(localTriviaQuestions);

                return result;
            }
        }

        public static IEnumerable<TriviaQuestion> GetTriviaQuestions()
        {
            var triviaQuestions = new List<TriviaQuestion>();

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "When was .NET first released?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "2000", IsCorrect = false },
                    new TriviaAnswer { Answer = "2001", IsCorrect = false },
                    new TriviaAnswer { Answer = "2002", IsCorrect = true },
                    new TriviaAnswer { Answer = "2003", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What fictional company did Nancy Davolio work for?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Contoso Ltd.", IsCorrect = false },
                    new TriviaAnswer { Answer = "Initech", IsCorrect = false },
                    new TriviaAnswer { Answer = "Fabrikam, Inc.", IsCorrect = false },
                    new TriviaAnswer { Answer = "Northwind Traders", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "The first and still the oldest domain name on the internet is:",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Network.com", IsCorrect = false },
                    new TriviaAnswer { Answer = "Alpha4.com", IsCorrect = false },
                    new TriviaAnswer { Answer = "Symbolics.com", IsCorrect = true },
                    new TriviaAnswer { Answer = "InterConnect.com", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which is not actually a Thing.js?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Mustache.js", IsCorrect = false },
                    new TriviaAnswer { Answer = "Hammer.js", IsCorrect = false },
                    new TriviaAnswer { Answer = "Horseradish.js", IsCorrect = true },
                    new TriviaAnswer { Answer = "Uglify.js", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "In what year was the first Voice Over IP (VOIP) call made?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1973", IsCorrect = true },
                    new TriviaAnswer { Answer = "1982", IsCorrect = false },
                    new TriviaAnswer { Answer = "1991", IsCorrect = false },
                    new TriviaAnswer { Answer = "1994", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "\"Chicago\" was codename for what Microsoft product?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Visual Basic", IsCorrect = false },
                    new TriviaAnswer { Answer = "Microsoft Surface", IsCorrect = false },
                    new TriviaAnswer { Answer = "Windows 95", IsCorrect = true },
                    new TriviaAnswer { Answer = "Xbox", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "How many loop constructs are there in C#?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "2", IsCorrect = false },
                    new TriviaAnswer { Answer = "3", IsCorrect = false },
                    new TriviaAnswer { Answer = "4", IsCorrect = true },
                    new TriviaAnswer { Answer = "5", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What was the first CodePlex.com project?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "EntLib", IsCorrect = false },
                    new TriviaAnswer { Answer = "IronPython", IsCorrect = true },
                    new TriviaAnswer { Answer = "Ajax Toolkit", IsCorrect = false },
                    new TriviaAnswer { Answer = "JSON.Net", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Last name of the employee who wears Microsoft badge 00001",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "McDonald", IsCorrect = true },
                    new TriviaAnswer { Answer = "Gates", IsCorrect = false },
                    new TriviaAnswer { Answer = "Ballmer", IsCorrect = false },
                    new TriviaAnswer { Answer = "Allen", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "When did Scott Hanselman join Microsoft?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "2007", IsCorrect = true },
                    new TriviaAnswer { Answer = "2000", IsCorrect = false },
                    new TriviaAnswer { Answer = "2005", IsCorrect = false },
                    new TriviaAnswer { Answer = "2009", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "How big is a nibble?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "4 bits", IsCorrect = true },
                    new TriviaAnswer { Answer = "8 bits", IsCorrect = false },
                    new TriviaAnswer { Answer = "16 bits", IsCorrect = false },
                    new TriviaAnswer { Answer = "2 bits", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "How many function calls did Windows 1.0 approximately have?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "100", IsCorrect = false },
                    new TriviaAnswer { Answer = "200", IsCorrect = false },
                    new TriviaAnswer { Answer = "600", IsCorrect = false },
                    new TriviaAnswer { Answer = "400", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which Star Wars movie was filmed entirely in the studio?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1", IsCorrect = false },
                    new TriviaAnswer { Answer = "2", IsCorrect = false },
                    new TriviaAnswer { Answer = "3", IsCorrect = true },
                    new TriviaAnswer { Answer = "4", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is Superman's Kryptonian name?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Jor-El", IsCorrect = false },
                    new TriviaAnswer { Answer = "Zod", IsCorrect = false },
                    new TriviaAnswer { Answer = "Kal-El", IsCorrect = true },
                    new TriviaAnswer { Answer = "Jax-Ur", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is the image name for the Windows Task Manager application?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "taskmgr", IsCorrect = true },
                    new TriviaAnswer { Answer = "tmanager", IsCorrect = false },
                    new TriviaAnswer { Answer = "wtaskmgr", IsCorrect = false },
                    new TriviaAnswer { Answer = "wintaskm", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "When was the internet opened to commercial use?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1989", IsCorrect = false },
                    new TriviaAnswer { Answer = "1992", IsCorrect = false },
                    new TriviaAnswer { Answer = "1990", IsCorrect = false },
                    new TriviaAnswer { Answer = "1991", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "When was the Xbox unveiled?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "2000", IsCorrect = false },
                    new TriviaAnswer { Answer = "2001", IsCorrect = true },
                    new TriviaAnswer { Answer = "2002", IsCorrect = false },
                    new TriviaAnswer { Answer = "2003", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is the value of an Object + Array in JavaScript?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "0", IsCorrect = true},
                    new TriviaAnswer { Answer = "Array", IsCorrect = false },
                    new TriviaAnswer { Answer = "Object", IsCorrect = false },
                    new TriviaAnswer { Answer = "Type Error", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Why was the IBM PCjr despised by users?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Chicklet keyboard", IsCorrect = false },
                    new TriviaAnswer { Answer = "No Hard Disk", IsCorrect = false },
                    new TriviaAnswer { Answer = "Not PC compatible", IsCorrect = false },
                    new TriviaAnswer { Answer = "All the above", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What was the max memory supported by MS-DOS?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "256K", IsCorrect = false },
                    new TriviaAnswer { Answer = "512K", IsCorrect = false },
                    new TriviaAnswer { Answer = "640K", IsCorrect = false },
                    new TriviaAnswer { Answer = "1M", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "When was the first laser mouse released?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "2001", IsCorrect = false },
                    new TriviaAnswer { Answer = "2002", IsCorrect = false },
                    new TriviaAnswer { Answer = "2003", IsCorrect = false },
                    new TriviaAnswer { Answer = "2004", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What was Microsoft's first product?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "DOS", IsCorrect = false },
                    new TriviaAnswer { Answer = "Altair Basic", IsCorrect = true },
                    new TriviaAnswer { Answer = "PC Basic", IsCorrect = false },
                    new TriviaAnswer { Answer = "Windows", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What building does not exist on the Microsoft campus?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1", IsCorrect = false },
                    new TriviaAnswer { Answer = "7", IsCorrect = true },
                    new TriviaAnswer { Answer = "99", IsCorrect = false },
                    new TriviaAnswer { Answer = "115", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Who wrote the first computer program?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Charles Babbage", IsCorrect = false },
                    new TriviaAnswer { Answer = "Herman Hollerith", IsCorrect = false },
                    new TriviaAnswer { Answer = "Ada Lovelace", IsCorrect = true },
                    new TriviaAnswer { Answer = "Jakob Bernoulli", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Visual Basic was first released in what year?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1990", IsCorrect = false },
                    new TriviaAnswer { Answer = "1991", IsCorrect = true },
                    new TriviaAnswer { Answer = "1992", IsCorrect = false },
                    new TriviaAnswer { Answer = "1993", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which of the following is NOT a prime number?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "257", IsCorrect = false },
                    new TriviaAnswer { Answer = "379", IsCorrect = false },
                    new TriviaAnswer { Answer = "571", IsCorrect = false },
                    new TriviaAnswer { Answer = "697", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Yukihiro Matsumoto conceived what programming language on February 24, 1993?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Python", IsCorrect = false },
                    new TriviaAnswer { Answer = "Ruby", IsCorrect = true },
                    new TriviaAnswer { Answer = "Perl", IsCorrect = false },
                    new TriviaAnswer { Answer = "Boo", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which release of the .NET Framework introduced support for dynamic languages?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1.1", IsCorrect = false },
                    new TriviaAnswer { Answer = "2.0", IsCorrect = false },
                    new TriviaAnswer { Answer = "3.5", IsCorrect = false },
                    new TriviaAnswer { Answer = "4.0", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is the package manager for Node.js?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "npm", IsCorrect = true },
                    new TriviaAnswer { Answer = "yum", IsCorrect = false },
                    new TriviaAnswer { Answer = "rpm", IsCorrect = false },
                    new TriviaAnswer { Answer = "PEAR", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "In the acronym PaaS, what do the P stand for",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Programming", IsCorrect = false },
                    new TriviaAnswer { Answer = "Power", IsCorrect = false },
                    new TriviaAnswer { Answer = "Platform", IsCorrect = true },
                    new TriviaAnswer { Answer = "Pedestrian", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is the speed of light in metres per second?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "299,792,458", IsCorrect = true },
                    new TriviaAnswer { Answer = "312,123,156", IsCorrect = false },
                    new TriviaAnswer { Answer = "100,000,000", IsCorrect = false },
                    new TriviaAnswer { Answer = "541,123,102", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What was the original name of the C# programming language?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Boo", IsCorrect = false },
                    new TriviaAnswer { Answer = "C+++", IsCorrect = false },
                    new TriviaAnswer { Answer = "Cool", IsCorrect = true },
                    new TriviaAnswer { Answer = "Anders", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which of the following is an example of Boxing in C#?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "int foo = 12;", IsCorrect = false },
                    new TriviaAnswer { Answer = "System.Box(56);", IsCorrect = false },
                    new TriviaAnswer { Answer = "int foo = (int)bar;", IsCorrect = false },
                    new TriviaAnswer { Answer = "object bar = 42;", IsCorrect = true }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which of the following was not an alternative name considered for XML?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "MAGMA", IsCorrect = false },
                    new TriviaAnswer { Answer = "SGML", IsCorrect = true },
                    new TriviaAnswer { Answer = "SLIM", IsCorrect = false },
                    new TriviaAnswer { Answer = "MGML", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "How many HTML tags are defined in the original description of the markup language?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1", IsCorrect = false },
                    new TriviaAnswer { Answer = "11", IsCorrect = false },
                    new TriviaAnswer { Answer = "18", IsCorrect = true },
                    new TriviaAnswer { Answer = "25", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which of the following ECMA standards represents the standardization of JavaScript?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "ECMA-123", IsCorrect = false },
                    new TriviaAnswer { Answer = "ECMA-262", IsCorrect = true },
                    new TriviaAnswer { Answer = "ECMA-301", IsCorrect = false },
                    new TriviaAnswer { Answer = "ECMA-431", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What was the first Web Browser called?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "WorldWideWeb", IsCorrect = true },
                    new TriviaAnswer { Answer = "Mosaic", IsCorrect = false },
                    new TriviaAnswer { Answer = "Lynx", IsCorrect = false },
                    new TriviaAnswer { Answer = "Gopher", IsCorrect = false }
                }
            });


            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "In version control systems, the process of bringing together two sets of changes is called what?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Branch", IsCorrect = false },
                    new TriviaAnswer { Answer = "Commit", IsCorrect = false },
                    new TriviaAnswer { Answer = "Merge", IsCorrect = true },
                    new TriviaAnswer { Answer = "Share", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "In 1980, Microsoft released there first operating system. What was it called?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "MS-DOS", IsCorrect = false },
                    new TriviaAnswer { Answer = "Windows", IsCorrect = false },
                    new TriviaAnswer { Answer = "Xenix", IsCorrect = true },
                    new TriviaAnswer { Answer = "Altair OS", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which ASCII code (in decimal) represents the character B?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "22", IsCorrect = false },
                    new TriviaAnswer { Answer = "66", IsCorrect = true },
                    new TriviaAnswer { Answer = "97", IsCorrect = false },
                    new TriviaAnswer { Answer = "112", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which are the first 6 decimal digits of Pi?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "3.14159", IsCorrect = true },
                    new TriviaAnswer { Answer = "3.14195", IsCorrect = false },
                    new TriviaAnswer { Answer = "3.14132", IsCorrect = false },
                    new TriviaAnswer { Answer = "3.14123", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Internet Protocol v4 provides approximately how many addresses?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "1.5 billion", IsCorrect = false },
                    new TriviaAnswer { Answer = "4.3 billion", IsCorrect = true },
                    new TriviaAnswer { Answer = "55 billion", IsCorrect = false },
                    new TriviaAnswer { Answer = "3.4 trillion", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "What is Layer 4 of the OSI Model?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "Network Layer", IsCorrect = false },
                    new TriviaAnswer { Answer = "Transport Layer", IsCorrect = true },
                    new TriviaAnswer { Answer = "Session Layer", IsCorrect = false },
                    new TriviaAnswer { Answer = "Presentation Layer", IsCorrect = false }
                }
            });

            triviaQuestions.Add(new TriviaQuestion
            {
                Question = "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                TriviaAnswers = new List<TriviaAnswer>
                {
                    new TriviaAnswer { Answer = "System.Integer", IsCorrect = false },
                    new TriviaAnswer { Answer = "System.String", IsCorrect = true },
                    new TriviaAnswer { Answer = "System.DateTime", IsCorrect = false },
                    new TriviaAnswer { Answer = "System.Float", IsCorrect = false }
                }
            });

            return triviaQuestions;
        }
    }
}
