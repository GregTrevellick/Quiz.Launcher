using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsWebCampTrainingKit
    {
        public static IEnumerable<Question> GetQuestions()
        {
            var triviaQuestions = new List<Question>
            {
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was .NET first released?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2000", IsCorrect = false},
                        new Answer {AnswerText = "2001", IsCorrect = false},
                        new Answer {AnswerText = "2002", IsCorrect = true},
                        new Answer {AnswerText = "2003", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What fictional company did Nancy Davolio work for?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Contoso Ltd.", IsCorrect = false},
                        new Answer {AnswerText = "Initech", IsCorrect = false},
                        new Answer {AnswerText = "Fabrikam, Inc.", IsCorrect = false},
                        new Answer {AnswerText = "Northwind Traders", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "The first and still the oldest domain name on the internet is:",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Network.com", IsCorrect = false},
                        new Answer {AnswerText = "Alpha4.com", IsCorrect = false},
                        new Answer {AnswerText = "Symbolics.com", IsCorrect = true},
                        new Answer {AnswerText = "InterConnect.com", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which is not actually a Thing.js?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Mustache.js", IsCorrect = false},
                        new Answer {AnswerText = "Hammer.js", IsCorrect = false},
                        new Answer {AnswerText = "Horseradish.js", IsCorrect = true},
                        new Answer {AnswerText = "Uglify.js", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "In what year was the first Voice Over IP (VOIP) call made?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1973", IsCorrect = true},
                        new Answer {AnswerText = "1982", IsCorrect = false},
                        new Answer {AnswerText = "1991", IsCorrect = false},
                        new Answer {AnswerText = "1994", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "\"Chicago\" was codename for what Microsoft product?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Visual Basic", IsCorrect = false},
                        new Answer {AnswerText = "Microsoft Surface", IsCorrect = false},
                        new Answer {AnswerText = "Windows 95", IsCorrect = true},
                        new Answer {AnswerText = "Xbox", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many loop constructs are there in C#?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2", IsCorrect = false},
                        new Answer {AnswerText = "3", IsCorrect = false},
                        new Answer {AnswerText = "4", IsCorrect = true},
                        new Answer {AnswerText = "5", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the first CodePlex.com project?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "EntLib", IsCorrect = false},
                        new Answer {AnswerText = "IronPython", IsCorrect = true},
                        new Answer {AnswerText = "Ajax Toolkit", IsCorrect = false},
                        new Answer {AnswerText = "JSON.Net", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Last name of the employee who wears Microsoft badge 00001",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "McDonald", IsCorrect = true},
                        new Answer {AnswerText = "Gates", IsCorrect = false},
                        new Answer {AnswerText = "Ballmer", IsCorrect = false},
                        new Answer {AnswerText = "Allen", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When did Scott Hanselman join Microsoft?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2007", IsCorrect = true},
                        new Answer {AnswerText = "2000", IsCorrect = false},
                        new Answer {AnswerText = "2005", IsCorrect = false},
                        new Answer {AnswerText = "2009", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How big is a nibble?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "4 bits", IsCorrect = true},
                        new Answer {AnswerText = "8 bits", IsCorrect = false},
                        new Answer {AnswerText = "16 bits", IsCorrect = false},
                        new Answer {AnswerText = "2 bits", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many function calls did Windows 1.0 approximately have?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "100", IsCorrect = false},
                        new Answer {AnswerText = "200", IsCorrect = false},
                        new Answer {AnswerText = "600", IsCorrect = false},
                        new Answer {AnswerText = "400", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "What is the image name for the Windows Task Manager application?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "taskmgr", IsCorrect = true},
                        new Answer {AnswerText = "tmanager", IsCorrect = false},
                        new Answer {AnswerText = "wtaskmgr", IsCorrect = false},
                        new Answer {AnswerText = "wintaskm", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was the internet opened to commercial use?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1989", IsCorrect = false},
                        new Answer {AnswerText = "1992", IsCorrect = false},
                        new Answer {AnswerText = "1990", IsCorrect = false},
                        new Answer {AnswerText = "1991", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was the Xbox unveiled?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2000", IsCorrect = false},
                        new Answer {AnswerText = "2001", IsCorrect = true},
                        new Answer {AnswerText = "2002", IsCorrect = false},
                        new Answer {AnswerText = "2003", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What is the value of an Object + Array in JavaScript?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "0", IsCorrect = true},
                        new Answer {AnswerText = "Array", IsCorrect = false},
                        new Answer {AnswerText = "Object", IsCorrect = false},
                        new Answer {AnswerText = "Type Error", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Why was the IBM PCjr despised by users?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Chicklet keyboard", IsCorrect = false},
                        new Answer {AnswerText = "No Hard Disk", IsCorrect = false},
                        new Answer {AnswerText = "Not PC compatible", IsCorrect = false},
                        new Answer {AnswerText = "All the above", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the max memory supported by MS-DOS?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "256K", IsCorrect = false},
                        new Answer {AnswerText = "512K", IsCorrect = false},
                        new Answer {AnswerText = "640K", IsCorrect = false},
                        new Answer {AnswerText = "1M", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "When was the first laser mouse released?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2001", IsCorrect = false},
                        new Answer {AnswerText = "2002", IsCorrect = false},
                        new Answer {AnswerText = "2003", IsCorrect = false},
                        new Answer {AnswerText = "2004", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What was Microsoft's first product?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "DOS", IsCorrect = false},
                        new Answer {AnswerText = "Altair Basic", IsCorrect = true},
                        new Answer {AnswerText = "PC Basic", IsCorrect = false},
                        new Answer {AnswerText = "Windows", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What building does not exist on the Microsoft campus?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1", IsCorrect = false},
                        new Answer {AnswerText = "7", IsCorrect = true},
                        new Answer {AnswerText = "99", IsCorrect = false},
                        new Answer {AnswerText = "115", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel. Hard,
                    QuestionText = "Who wrote the first computer program?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Charles Babbage", IsCorrect = false},
                        new Answer {AnswerText = "Herman Hollerith", IsCorrect = false},
                        new Answer {AnswerText = "Ada Lovelace", IsCorrect = true},
                        new Answer {AnswerText = "Jakob Bernoulli", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Visual Basic was first released in what year?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1990", IsCorrect = false},
                        new Answer {AnswerText = "1991", IsCorrect = true},
                        new Answer {AnswerText = "1992", IsCorrect = false},
                        new Answer {AnswerText = "1993", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following is NOT a prime number?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "257", IsCorrect = false},
                        new Answer {AnswerText = "379", IsCorrect = false},
                        new Answer {AnswerText = "571", IsCorrect = false},
                        new Answer {AnswerText = "697", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Yukihiro Matsumoto conceived what programming language on February 24, 1993?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Python", IsCorrect = false},
                        new Answer {AnswerText = "Ruby", IsCorrect = true},
                        new Answer {AnswerText = "Perl", IsCorrect = false},
                        new Answer {AnswerText = "Boo", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which release of the .NET Framework introduced support for dynamic languages?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1.1", IsCorrect = false},
                        new Answer {AnswerText = "2.0", IsCorrect = false},
                        new Answer {AnswerText = "3.5", IsCorrect = false},
                        new Answer {AnswerText = "4.0", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "What is the package manager for Node.js?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "npm", IsCorrect = true},
                        new Answer {AnswerText = "yum", IsCorrect = false},
                        new Answer {AnswerText = "rpm", IsCorrect = false},
                        new Answer {AnswerText = "PEAR", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "In the acronym PaaS, what do the P stand for",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Programming", IsCorrect = false},
                        new Answer {AnswerText = "Power", IsCorrect = false},
                        new Answer {AnswerText = "Platform", IsCorrect = true},
                        new Answer {AnswerText = "Pedestrian", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What is the speed of light in metres per second?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "299,792,458", IsCorrect = true},
                        new Answer {AnswerText = "312,123,156", IsCorrect = false},
                        new Answer {AnswerText = "100,000,000", IsCorrect = false},
                        new Answer {AnswerText = "541,123,102", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the original name of the C# programming language?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Boo", IsCorrect = false},
                        new Answer {AnswerText = "C+++", IsCorrect = false},
                        new Answer {AnswerText = "Cool", IsCorrect = true},
                        new Answer {AnswerText = "Anders", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which of the following is an example of Boxing in C#?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "int foo = 12;", IsCorrect = false},
                        new Answer {AnswerText = "System.Box(56);", IsCorrect = false},
                        new Answer {AnswerText = "int foo = (int)bar;", IsCorrect = false},
                        new Answer {AnswerText = "object bar = 42;", IsCorrect = true}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following was not an alternative name considered for XML?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "MAGMA", IsCorrect = false},
                        new Answer {AnswerText = "SGML", IsCorrect = true},
                        new Answer {AnswerText = "SLIM", IsCorrect = false},
                        new Answer {AnswerText = "MGML", IsCorrect = false}
                    }
                },
                new Question
                {
                   DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "How many HTML tags are defined in the original description of the markup language?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1", IsCorrect = false},
                        new Answer {AnswerText = "11", IsCorrect = false},
                        new Answer {AnswerText = "18", IsCorrect = true},
                        new Answer {AnswerText = "25", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which of the following ECMA standards represents the standardization of JavaScript?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "ECMA-123", IsCorrect = false},
                        new Answer {AnswerText = "ECMA-262", IsCorrect = true},
                        new Answer {AnswerText = "ECMA-301", IsCorrect = false},
                        new Answer {AnswerText = "ECMA-431", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "What was the first Web Browser called?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "WorldWideWeb", IsCorrect = true},
                        new Answer {AnswerText = "Mosaic", IsCorrect = false},
                        new Answer {AnswerText = "Lynx", IsCorrect = false},
                        new Answer {AnswerText = "Gopher", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "In version control systems, the process of bringing together two sets of changes is called what?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Branch", IsCorrect = false},
                        new Answer {AnswerText = "Commit", IsCorrect = false},
                        new Answer {AnswerText = "Merge", IsCorrect = true},
                        new Answer {AnswerText = "Share", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "In 1980, Microsoft released there first operating system. What was it called?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "MS-DOS", IsCorrect = false},
                        new Answer {AnswerText = "Windows", IsCorrect = false},
                        new Answer {AnswerText = "Xenix", IsCorrect = true},
                        new Answer {AnswerText = "Altair OS", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "Which ASCII code (in decimal) represents the character B?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "22", IsCorrect = false},
                        new Answer {AnswerText = "66", IsCorrect = true},
                        new Answer {AnswerText = "97", IsCorrect = false},
                        new Answer {AnswerText = "112", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Which are the first 6 decimal digits of Pi?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "3.14159", IsCorrect = true},
                        new Answer {AnswerText = "3.14195", IsCorrect = false},
                        new Answer {AnswerText = "3.14132", IsCorrect = false},
                        new Answer {AnswerText = "3.14123", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Hard,
                    QuestionText = "Internet Protocol v4 provides approximately how many addresses?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "1.5 billion", IsCorrect = false},
                        new Answer {AnswerText = "4.3 billion", IsCorrect = true},
                        new Answer {AnswerText = "55 billion", IsCorrect = false},
                        new Answer {AnswerText = "3.4 trillion", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "What is Layer 4 of the OSI Model?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "Network Layer", IsCorrect = false},
                        new Answer {AnswerText = "Transport Layer", IsCorrect = true},
                        new Answer {AnswerText = "Session Layer", IsCorrect = false},
                        new Answer {AnswerText = "Presentation Layer", IsCorrect = false}
                    }
                },
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Easy,
                    QuestionText = "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "System.Integer", IsCorrect = false},
                        new Answer {AnswerText = "System.String", IsCorrect = true},
                        new Answer {AnswerText = "System.DateTime", IsCorrect = false},
                        new Answer {AnswerText = "System.Float", IsCorrect = false}
                    }
                }
            };

            return triviaQuestions;
        }
    }
}