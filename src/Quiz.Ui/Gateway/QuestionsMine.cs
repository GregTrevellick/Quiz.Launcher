using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Common.Get(DifficultyLevel.Easy, "What is Brainfuck?", "A Turing complete programming language", "", "", "A very bad day at work"),
                Common.Get(DifficultyLevel.Hard, "What is gulp?", "A Turing complete programming language", "", "", "An alcoholic beverage"),
                Common.Get(DifficultyLevel.Hard, "Did the Xerox Corporation help create Javascript ?", "True", "False"),
                Common.Get(DifficultyLevel.Medium, "What is grunt?", "A task runner", "", "", "A methane gas"),
                Common.Get(DifficultyLevel.Easy, "What is a blackhat?", "A malicious hacker", "", "", "A teenage spot"),
                Common.Get(DifficultyLevel.Medium, "What is PARC?", "Palo Alto Research Centre", "", "", "Somewhere to take the kids"),
                Common.Get(DifficultyLevel.Easy, "Are whitehats good ?", "True", "False"),
                Common.Get(DifficultyLevel.Easy, "What does the S in SOLID stand for?", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the O in SOLID stand for?", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the L in SOLID stand for?", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the I in SOLID stand for?", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the D in SOLID stand for?", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What is DRY short for?", "", "", "", ""),

                //What is a Evergreen browser
                //poco
                //POX = ? Plain Old XML
                //WSDL = ? Web Services Description Language
                //XHR = ? XML http object
                //XHR  = ? calls ~_ Ajax call
                //SVG = ?  Scalable Vector Graphics. 
                //Unobtrusive javascript  = ? javascript that's in a file rather than intruding into the html page
                //SPID = ? SQL Server is a Server Process ID.
                //SOAP = ? Simple Object Access Protocol; XML - based; protocol(e.g.HTTP, SMTP) agnostic; service actions often have same name as methods (e.g.GetAllVehicles).
                //REST = ? REpresentational State Transfer; HTTP - based(GET / POST / PUT / DELETE verbs);
                //SOA = ? 
                //XSS = ? 
                //SEO = ? 
                //TSQL = ? Transact - SQL = microsoft implemetation of SQL query language
                //Hekaton = ? (also known as SQL Server In - Memory OLTP)
                //Redis = ? REmote DIctionary Server
                //SUT = ? system under test
                //GAC = ? global assembly cache
                //CAP Theorem(Big Data) = ? In Big Data CAP theorem is that you can only have 2 of the 3 parts of CAP, never all 3 parts; C = Consistency, A = Availability, P = Partition Tolerance
                //ACID = ? Atomicity, Consistency, Isolation, Durability
                //php
                //ruby
                //python
                //apache
                //nginx
                //iis

                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
          
            };

            return gatewayResponses;
        }
    }
}
