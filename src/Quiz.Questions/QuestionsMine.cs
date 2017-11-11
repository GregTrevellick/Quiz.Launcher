using System.Collections.Generic;

namespace Quiz.Questions
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                //gregt add a 5th answer
                Common.Get(DifficultyLevel.Medium,"What is Brainfuck?","A Turing-complete language","A term used by programmers to describe hard-to-fix bugs","Any code that can get into an infinite loop","Any bug that exists in a high level programming language's compiler"),
                Common.Get(DifficultyLevel.Hard,"What is the abbreviation GAC short for?","global assembly cache","general assembly cache","global action cache","general activity cache"),
                Common.Get(DifficultyLevel.Easy,"What is css short for?","cascading style sheets","cross site scripting","cascading script sheets","cascading style scripts"),
                Common.Get(DifficultyLevel.Medium,"What is the abbreviation WSDL short for?","Web Services Description Language","Web Services Design Language","Web Services Description Log","Web Standards for Design Langauages"),
                Common.Get(DifficultyLevel.Medium,"What is the abbreviation SVG short for?","Scalable Vector Graphics","Standard Variable Graphics","Scalar Vector Graphic","Scalable Vector Graphs"),
                Common.Get(DifficultyLevel.Hard,"Where does the word \"Redis\" derived from?","REmote DIctionary Server","REadable DIctionary Server","REduced DIctionary Server","REplicated DIctionary Server"),
                Common.Get(DifficultyLevel.Medium,"What does the acronym XSS mean?","cross site scripting","cross site sequel","excess server store","extinct server store"),
                Common.Get(DifficultyLevel.Easy,"What is the abbreviation SEO short for?","search engine optimization","senior executive officer","search engine organisation","senior executive order"),
                Common.Get(DifficultyLevel.Easy,"What is meant by the acronym DRY?","don't repeat yourself","do repeat yourself","dynamic real-time yourdon principle","Dry run your code"),
                Common.Get(DifficultyLevel.Hard,"What is XHR short for?","XML http object","cross http reader ","XML html object","cross html reader "),
                Common.Get(DifficultyLevel.Medium,"The Xerox Corporation helped create Javascript?", true, false),
                Common.Get(DifficultyLevel.Easy,"What is an evergreen browser?","A browser that always runs the latest version of itself","Any browser with a green colour theme","Bug-free browsers",""),
                Common.Get(DifficultyLevel.Hard,"The Microsoft SQL Server in-memory database for OLTP workloads is also known as?","Hekaton","Hackathon","Megatron","Segatron"),
                Common.Get(DifficultyLevel.Easy,"A white hat is?","A philanthropic penetration tester","A malicious penetration tester","A neutral penetration tester","An invisible hacker"),
                Common.Get(DifficultyLevel.Medium,"What is the abbreviation SUT short for?","system under test","solution utilization tracker","system utilization tracker","system under trial"),
                Common.Get(DifficultyLevel.Medium,"Unobtrusive javascript?","javascript that's in a file rather than intruding into the html page","javascript that's in the html page rather than in a file","raw javascript that is not polluted with any js frameworks","javascript after it has been minified"),
                Common.Get(DifficultyLevel.Medium,"What is the abbreviation SOA short for?","service oriented architecture","soap oriented architecture","systems oriented architecture","solutions oriented architecture"),
                Common.Get(DifficultyLevel.Hard,"What is the acronym SOAP short for?","Simple Object Access Protocol","Service oriented architecture Protocol","Standard Object Accessor Pattern","Security Offensive Attack Principal"),
                Common.Get(DifficultyLevel.Hard,"What is the big-data related CAP theorem short for?","Consistency Availability Partition Tolerance","Consistency Availability Partition","Consistent Atomic Platform","Clone Available Pieces"),
                Common.Get(DifficultyLevel.Hard,"The data-related acronym ACID is short for?","Atomicity Consistency Isolation Durability","Artifically Cloned Integrated Data","Active Cloud Integrated Data","Atomic Consistent Independent Data"),
                Common.Get(DifficultyLevel.Hard,"What is the acronym REST short for?","REpresentational State Transfer","Really Easy Server Transport","Registry Extraction for System Testing","REgular Silent Transfers"),
            };

            return gatewayResponses;
        }
    }
}
