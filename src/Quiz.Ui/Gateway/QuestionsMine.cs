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
//MassTransit = a free, open source, lightweight message bus for creating distributed applications using the.NET framework.
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
//Redis = ? Short for REmote DIctionary Server
//SUT = ? system under test
//GAC = ? global assembly cache
//c# - What does “var” mean – is it at run time or compile time
//c# - all classes derive from System.Object
//CAP Theorem(Big Data) = ? In Big Data CAP theorem is that you can only have 2 of the 3 parts of CAP, never all 3 parts; C = Consistency, A = Availability, P = Partition Tolerance
//ACID = ? Atomicity, Consistency, Isolation, Durability


//TRENDS
//======
//http://w3techs.com/technologies/details/js-jquery/all/all
//http://trends.builtwith.com/framework
//http://www.w3schools.com/browsers/browsers_stats.asp
//http://www.netcraft.com/
//(oct 2015) JQuery is used by 95.6% of all the websites whose JavaScript library we know. This is 66.6% of all websites. Of which jquery vers1 >95% & jquery vers2 <5%.
//(oct 2015) PHP 80%, .net 15%, Java/ruby/python/etc < 5%
//(oct 2015) 90% sites use javascript 10% flash			
//(oct 2015) frameworks: PHP=30% .net=15% j2ee=10%			
//(oct 2015) apache=30% nginx=25% iis=15%			
//(oct 2015) languages: php=60% .net=35% ruby=10%
//(sep 2015) chrome=65% IE=7% Firefox=20% safari=4%
//75% php, 15% asp.net (https://www.datanyze.com/market-share/frameworks/)




//Access modifiers
//public    - any class in any DLL can use access the method
//private   - (this is the default) can be used only by methods within the same class
//internal  - can be used only by classes within the same project/DLL/assembly
//virtual   - can be overridden in a class that inherits from that [base] class
//abstract  - have no concrete implementation hence must be implemented in a class that inheits from that [base] class
//protected - can be accessed by other methods in the base class itself and by methods in any class that inheits from that [base] class
//protected internal - access is limited to the current assembly or types derived from the containing class
//partial   - splits class definitions across multiple files in the SAME project
//sealed    - cannot be inherited
//* 'structs' are implicitly sealed & therefore not inheritable
//* Object.ReferenceEquals(obj1,obj2) - this will check if two reference types (pointers) point to the same object on the heap


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
