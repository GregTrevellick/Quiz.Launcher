using System.Collections.Generic;
using System.Linq;

namespace Quiz.Ui.Gateway
{
    public class TriviaQuestion
    {
        public string Question { get; set; }
        public virtual List<TriviaOption> Options { get; set; }
    }

    public class TriviaOption
    {
        public string Question { get; set; }
        public virtual TriviaQuestion TriviaQuestion { get; set; }
        public bool IsCorrect { get; set; }
    }

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
                return new List<GatewayResponse>
                {
                    Get(DifficultyLevel.Easy, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage", "A computing-related protocol", "A very bad day at work"),
                    Get(DifficultyLevel.Hard, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Medium, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Easy, "Sunday is a month ?", false, true),
                    //gregt opentdb submitable questions - cmmi ? solid ? grunt ? gulp ?
                };
            }
        }

        public IEnumerable<TriviaQuestion> GetTriviaQuestions()
        {
            var questions = new List<TriviaQuestion>();

            questions.Add(new TriviaQuestion
            {
                Question = "When was .NET first released?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "2000", IsCorrect = false },
                        new TriviaOption { Question = "2001", IsCorrect = false },
                        new TriviaOption { Question = "2002", IsCorrect = true },
                        new TriviaOption { Question = "2003", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What fictional company did Nancy Davolio work for?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Contoso Ltd.", IsCorrect = false },
                        new TriviaOption { Question = "Initech", IsCorrect = false },
                        new TriviaOption { Question = "Fabrikam, Inc.", IsCorrect = false },
                        new TriviaOption { Question = "Northwind Traders", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "The first and still the oldest domain name on the internet is:",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Network.com", IsCorrect = false },
                        new TriviaOption { Question = "Alpha4.com", IsCorrect = false },
                        new TriviaOption { Question = "Symbolics.com", IsCorrect = true },
                        new TriviaOption { Question = "InterConnect.com", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which is not actually a Thing.js?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Mustache.js", IsCorrect = false },
                        new TriviaOption { Question = "Hammer.js", IsCorrect = false },
                        new TriviaOption { Question = "Horseradish.js", IsCorrect = true },
                        new TriviaOption { Question = "Uglify.js", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "In what year was the first Voice Over IP (VOIP) call made?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1973", IsCorrect = true },
                        new TriviaOption { Question = "1982", IsCorrect = false },
                        new TriviaOption { Question = "1991", IsCorrect = false },
                        new TriviaOption { Question = "1994", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "\"Chicago\" was codename for what Microsoft product?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Visual Basic", IsCorrect = false },
                        new TriviaOption { Question = "Microsoft Surface", IsCorrect = false },
                        new TriviaOption { Question = "Windows 95", IsCorrect = true },
                        new TriviaOption { Question = "Xbox", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "How many loop constructs are there in C#?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "2", IsCorrect = false },
                        new TriviaOption { Question = "3", IsCorrect = false },
                        new TriviaOption { Question = "4", IsCorrect = true },
                        new TriviaOption { Question = "5", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What was the first CodePlex.com project?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "EntLib", IsCorrect = false },
                        new TriviaOption { Question = "IronPython", IsCorrect = true },
                        new TriviaOption { Question = "Ajax Toolkit", IsCorrect = false },
                        new TriviaOption { Question = "JSON.Net", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Last name of the employee who wears Microsoft badge 00001",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "McDonald", IsCorrect = true },
                        new TriviaOption { Question = "Gates", IsCorrect = false },
                        new TriviaOption { Question = "Ballmer", IsCorrect = false },
                        new TriviaOption { Question = "Allen", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "When did Scott Hanselman join Microsoft?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "2007", IsCorrect = true },
                        new TriviaOption { Question = "2000", IsCorrect = false },
                        new TriviaOption { Question = "2005", IsCorrect = false },
                        new TriviaOption { Question = "2009", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "How big is a nibble?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "4 bits", IsCorrect = true },
                        new TriviaOption { Question = "8 bits", IsCorrect = false },
                        new TriviaOption { Question = "16 bits", IsCorrect = false },
                        new TriviaOption { Question = "2 bits", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "How many function calls did Windows 1.0 approximately have?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "100", IsCorrect = false },
                        new TriviaOption { Question = "200", IsCorrect = false },
                        new TriviaOption { Question = "600", IsCorrect = false },
                        new TriviaOption { Question = "400", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which Star Wars movie was filmed entirely in the studio?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1", IsCorrect = false },
                        new TriviaOption { Question = "2", IsCorrect = false },
                        new TriviaOption { Question = "3", IsCorrect = true },
                        new TriviaOption { Question = "4", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is Superman's Kryptonian name?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Jor-El", IsCorrect = false },
                        new TriviaOption { Question = "Zod", IsCorrect = false },
                        new TriviaOption { Question = "Kal-El", IsCorrect = true },
                        new TriviaOption { Question = "Jax-Ur", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is the image name for the Windows Task Manager application?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "taskmgr", IsCorrect = true },
                        new TriviaOption { Question = "tmanager", IsCorrect = false },
                        new TriviaOption { Question = "wtaskmgr", IsCorrect = false },
                        new TriviaOption { Question = "wintaskm", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "When was the internet opened to commercial use?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1989", IsCorrect = false },
                        new TriviaOption { Question = "1992", IsCorrect = false },
                        new TriviaOption { Question = "1990", IsCorrect = false },
                        new TriviaOption { Question = "1991", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "When was the Xbox unveiled?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "2000", IsCorrect = false },
                        new TriviaOption { Question = "2001", IsCorrect = true },
                        new TriviaOption { Question = "2002", IsCorrect = false },
                        new TriviaOption { Question = "2003", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is the value of an Object + Array in JavaScript?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "0", IsCorrect = true},
                        new TriviaOption { Question = "Array", IsCorrect = false },
                        new TriviaOption { Question = "Object", IsCorrect = false },
                        new TriviaOption { Question = "Type Error", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Why was the IBM PCjr despised by users?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Chicklet keyboard", IsCorrect = false },
                        new TriviaOption { Question = "No Hard Disk", IsCorrect = false },
                        new TriviaOption { Question = "Not PC compatible", IsCorrect = false },
                        new TriviaOption { Question = "All the above", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What was the max memory supported by MS-DOS?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "256K", IsCorrect = false },
                        new TriviaOption { Question = "512K", IsCorrect = false },
                        new TriviaOption { Question = "640K", IsCorrect = false },
                        new TriviaOption { Question = "1M", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "When was the first laser mouse released?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "2001", IsCorrect = false },
                        new TriviaOption { Question = "2002", IsCorrect = false },
                        new TriviaOption { Question = "2003", IsCorrect = false },
                        new TriviaOption { Question = "2004", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What was Microsoft's first product?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "DOS", IsCorrect = false },
                        new TriviaOption { Question = "Altair Basic", IsCorrect = true },
                        new TriviaOption { Question = "PC Basic", IsCorrect = false },
                        new TriviaOption { Question = "Windows", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What building does not exist on the Microsoft campus?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1", IsCorrect = false },
                        new TriviaOption { Question = "7", IsCorrect = true },
                        new TriviaOption { Question = "99", IsCorrect = false },
                        new TriviaOption { Question = "115", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Who wrote the first computer program?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Charles Babbage", IsCorrect = false },
                        new TriviaOption { Question = "Herman Hollerith", IsCorrect = false },
                        new TriviaOption { Question = "Ada Lovelace", IsCorrect = true },
                        new TriviaOption { Question = "Jakob Bernoulli", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Visual Basic was first released in what year?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1990", IsCorrect = false },
                        new TriviaOption { Question = "1991", IsCorrect = true },
                        new TriviaOption { Question = "1992", IsCorrect = false },
                        new TriviaOption { Question = "1993", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which of the following is NOT a prime number?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "257", IsCorrect = false },
                        new TriviaOption { Question = "379", IsCorrect = false },
                        new TriviaOption { Question = "571", IsCorrect = false },
                        new TriviaOption { Question = "697", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Yukihiro Matsumoto conceived what programming language on February 24, 1993?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Python", IsCorrect = false },
                        new TriviaOption { Question = "Ruby", IsCorrect = true },
                        new TriviaOption { Question = "Perl", IsCorrect = false },
                        new TriviaOption { Question = "Boo", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which release of the .NET Framework introduced support for dynamic languages?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1.1", IsCorrect = false },
                        new TriviaOption { Question = "2.0", IsCorrect = false },
                        new TriviaOption { Question = "3.5", IsCorrect = false },
                        new TriviaOption { Question = "4.0", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is the package manager for Node.js?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "npm", IsCorrect = true },
                        new TriviaOption { Question = "yum", IsCorrect = false },
                        new TriviaOption { Question = "rpm", IsCorrect = false },
                        new TriviaOption { Question = "PEAR", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "In the acronym PaaS, what do the P stand for",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Programming", IsCorrect = false },
                        new TriviaOption { Question = "Power", IsCorrect = false },
                        new TriviaOption { Question = "Platform", IsCorrect = true },
                        new TriviaOption { Question = "Pedestrian", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is the speed of light in metres per second?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "299,792,458", IsCorrect = true },
                        new TriviaOption { Question = "312,123,156", IsCorrect = false },
                        new TriviaOption { Question = "100,000,000", IsCorrect = false },
                        new TriviaOption { Question = "541,123,102", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What was the original name of the C# programming language?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Boo", IsCorrect = false },
                        new TriviaOption { Question = "C+++", IsCorrect = false },
                        new TriviaOption { Question = "Cool", IsCorrect = true },
                        new TriviaOption { Question = "Anders", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which of the following is an example of Boxing in C#?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "int foo = 12;", IsCorrect = false },
                        new TriviaOption { Question = "System.Box(56);", IsCorrect = false },
                        new TriviaOption { Question = "int foo = (int)bar;", IsCorrect = false },
                        new TriviaOption { Question = "object bar = 42;", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which of the following was not an alternative name considered for XML?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "MAGMA", IsCorrect = false },
                        new TriviaOption { Question = "SGML", IsCorrect = true },
                        new TriviaOption { Question = "SLIM", IsCorrect = false },
                        new TriviaOption { Question = "MGML", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "How many HTML tags are defined in the original description of the markup language?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1", IsCorrect = false },
                        new TriviaOption { Question = "11", IsCorrect = false },
                        new TriviaOption { Question = "18", IsCorrect = true },
                        new TriviaOption { Question = "25", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which of the following ECMA standards represents the standardization of JavaScript?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "ECMA-123", IsCorrect = false },
                        new TriviaOption { Question = "ECMA-262", IsCorrect = true },
                        new TriviaOption { Question = "ECMA-301", IsCorrect = false },
                        new TriviaOption { Question = "ECMA-431", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What was the first Web Browser called?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "WorldWideWeb", IsCorrect = true },
                        new TriviaOption { Question = "Mosaic", IsCorrect = false },
                        new TriviaOption { Question = "Lynx", IsCorrect = false },
                        new TriviaOption { Question = "Gopher", IsCorrect = false }
                }).ToList()
            });


            questions.Add(new TriviaQuestion
            {
                Question = "In version control systems, the process of bringing together two sets of changes is called what?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Branch", IsCorrect = false },
                        new TriviaOption { Question = "Commit", IsCorrect = false },
                        new TriviaOption { Question = "Merge", IsCorrect = true },
                        new TriviaOption { Question = "Share", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "In 1980, Microsoft released there first operating system. What was it called?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "MS-DOS", IsCorrect = false },
                        new TriviaOption { Question = "Windows", IsCorrect = false },
                        new TriviaOption { Question = "Xenix", IsCorrect = true },
                        new TriviaOption { Question = "Altair OS", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which ASCII code (in decimal) represents the character B?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "22", IsCorrect = false },
                        new TriviaOption { Question = "66", IsCorrect = true },
                        new TriviaOption { Question = "97", IsCorrect = false },
                        new TriviaOption { Question = "112", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which are the first 6 decimal digits of Pi?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "3.14159", IsCorrect = true },
                        new TriviaOption { Question = "3.14195", IsCorrect = false },
                        new TriviaOption { Question = "3.14132", IsCorrect = false },
                        new TriviaOption { Question = "3.14123", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Internet Protocol v4 provides approximately how many addresses?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "1.5 billion", IsCorrect = false },
                        new TriviaOption { Question = "4.3 billion", IsCorrect = true },
                        new TriviaOption { Question = "55 billion", IsCorrect = false },
                        new TriviaOption { Question = "3.4 trillion", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "What is Layer 4 of the OSI Model?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "Network Layer", IsCorrect = false },
                        new TriviaOption { Question = "Transport Layer", IsCorrect = true },
                        new TriviaOption { Question = "Session Layer", IsCorrect = false },
                        new TriviaOption { Question = "Presentation Layer", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Question = "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                Options = (new TriviaOption[]
                {
                        new TriviaOption { Question = "System.Integer", IsCorrect = false },
                        new TriviaOption { Question = "System.String", IsCorrect = true },
                        new TriviaOption { Question = "System.DateTime", IsCorrect = false },
                        new TriviaOption { Question = "System.Float", IsCorrect = false }
                }).ToList()
            });

            return questions;
        }
    }
}
