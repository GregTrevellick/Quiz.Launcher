﻿using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekQuestions : IGeekQuestions
    {
        private const Category Category = Entities.Category.Geek;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                //Foo?
                //Bar
                //Poo
                //Boo
                //Pub
                //Foo

                //TLD?
                //Top level domain
                //Too long don't read
                //The longest day
                //Top level developer
                //Three legged donkey

                //TLDR?
                //Too long don't read
                //Top level domain registrar
                //Technology licence delivery realm
                //Technology licence delivery region
                //Televison lets dogs rule

                //pwa?
                //ansi
                //ascii
                //ddos?
                //AAA?
                //IDE?
                //SKU?
                //Git flow / Gitter / Git tower / Git lab / Git hub / Git pup
                Common.Get(Category, DifficultyLevel.Hard, "You are a genius?",
                    "true",
                    "false"),
                Common.Get(Category, DifficultyLevel.Hard, "Are you a geek?",
                    "Yes",
                    "No",
                    "Don't know",
                    "Don't care",
                    "What's a geek ?"),
                Common.Get(Category, DifficultyLevel.Easy, "which is not podcast?",
                    "check in",
                    "merge conflict",
                    "syntax",
                    "request for commit",
                    "herding code"),
                Common.Get(Category, DifficultyLevel.Easy, "What does cdn stand for?",
                    "content delivery network",
                    "content distribution network",
                    "cascading delivery network",
                    "cross domain network",
                    "caught doing nothing"),
                Common.Get(Category, DifficultyLevel.Hard, "What is a DAG?",
                    "Directed acyclic graph",
                    "distribution above ground",
                    "distribution across ground",
                    "distributed architecture groups",
                    "dogs are great"),
                Common.Get(Category, DifficultyLevel.Hard, "CSP is short for?",
                    "content security policy",
                    "cross site privacy",
                    "cascading style presentation",
                    "code security policy",
                    "caught swearing partying"),
                Common.Get(Category, DifficultyLevel.Hard, "AMPQ?",
                    "Rabbit",
                    "Cat",
                    "Dog",
                    "Horse",
                    "Chicken"),
                Common.Get(Category, DifficultyLevel.Hard, "Rabbit ..?",
                    "M.Q.",
                    "P.I.",
                    "D.C.",
                    "M.A.",
                    "P.C."),
                Common.Get(Category, DifficultyLevel.Medium, "What is Brainfuck?",
                    "A programming language",
                    "A term used by programmers to describe hard-to-fix bugs",
                    "Any code that can get into an infinite loop",
                    "Any bug that exists in a high level programming language's compiler",
                    "A word not to be repeated"),
                Common.Get(Category, DifficultyLevel.Hard, "What is the abbreviation GAC short for?",
                    "global assembly cache",
                    "general assembly cache",
                    "global action cache",
                    "general activity cache"),
                Common.Get(Category, DifficultyLevel.Easy, "What is css short for?",
                    "cascading style sheets",
                    "cross site scripting",
                    "cascading script sheets",
                    "cascading style scripts",
                    "captain silly ship"),
                Common.Get(Category, DifficultyLevel.Medium, "What is the abbreviation WSDL short for?",
                    "Web Services Description Language",
                    "Web Services Design Language",
                    "Web Services Description Log",
                    "Web Standards for Design Langauages"),
                Common.Get(Category, DifficultyLevel.Medium, "What is the abbreviation SVG short for?",
                    "Scalable Vector Graphics",
                    "Standard Variable Graphics",
                    "Scalar Vector Graphic",
                    "Scalable Vector Graphs"),
                Common.Get(Category, DifficultyLevel.Hard, "Where does the word \"Redis\" derived from?",
                    "REmote DIctionary Server",
                    "REadable DIctionary Server",
                    "REduced DIctionary Server",
                    "REplicated DIctionary Server"),
                Common.Get(Category, DifficultyLevel.Medium, "What does the acronym XSS mean?",
                    "cross site scripting",
                    "cross site sequel",
                    "excess server store",
                    "extinct server store",
                    "ex-secret service"),
                Common.Get(Category, DifficultyLevel.Easy, "What is the abbreviation SEO short for?",
                    "search engine optimization",
                    "senior executive officer",
                    "search engine organisation",
                    "senior executive order",
                    "small eggs omelette"),
                Common.Get(Category, DifficultyLevel.Easy, "What is meant by the acronym DRY?",
                    "don't repeat yourself",
                    "do repeat yourself",
                    "dynamic real-time yourdon principle",
                    "Dry run your code"),
                Common.Get(Category, DifficultyLevel.Hard, "What is XHR short for?",
                    "XML http object",
                    "cross http reader ",
                    "XML html object",
                    "cross html reader"),
                Common.Get(Category, DifficultyLevel.Medium, "The Xerox Corporation helped create Javascript?",
                    "true",
                    "false"),
                Common.Get(Category, DifficultyLevel.Easy, "What is an evergreen browser?",
                    "A browser that always runs the latest version of itself",
                    "Any browser with a green colour theme",
                    "A collective description for bug-free browsers",
                    "A browser that doesn't shed its leaves in the winter"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "The Microsoft SQL Server in-memory database for OLTP workloads is also known as?",
                    "Hekaton",
                    "Hackathon",
                    "Megatron",
                    "Segatron",
                    "Decathlon"),
                Common.Get(Category, DifficultyLevel.Easy, "A white hat is?",
                    "A philanthropic penetration tester",
                    "A malicious penetration tester",
                    "A neutral penetration tester",
                    "An invisible hacker",
                    "Something to wear when very hot"),
                Common.Get(Category, DifficultyLevel.Medium, "What is the abbreviation SUT short for?",
                    "system under test",
                    "solution utilization tracker",
                    "system utilization tracker",
                    "system under trial",
                    "Suspected Underwear thief"),
                Common.Get(Category, DifficultyLevel.Medium, "What is unobtrusive javascript?",
                    "javascript that's in a file rather than intruding into the html page",
                    "javascript that's in the html page rather than in a file",
                    "raw javascript that is not polluted with any js frameworks",
                    "javascript after it has been minified",
                    "javascript that doesn't contain any swear words"),
                Common.Get(Category, DifficultyLevel.Medium, "What is the abbreviation SOA short for?",
                    "service oriented architecture",
                    "soap oriented architecture",
                    "systems oriented architecture",
                    "solutions oriented architecture",
                    "save our aragutans"),
                Common.Get(Category, DifficultyLevel.Hard, "What is the acronym SOAP short for?",
                    "Simple Object Access Protocol",
                    "Service oriented architecture Protocol",
                    "Standard Object Accessor Pattern",
                    "Security Offensive Attack Principal",
                    "soap obscures all pongs"),
                Common.Get(Category, DifficultyLevel.Hard, "What is the big-data related CAP theorem short for?",
                    "Consistency Availability Partition Tolerance",
                    "Consistency Availability Partition",
                    "Consistent Atomic Platform",
                    "Clone Available Pieces",
                    "climates and primates"),
                Common.Get(Category, DifficultyLevel.Hard, "The data-related acronym ACID is short for?",
                    "Atomicity Consistency Isolation Durability",
                    "Artifically Cloned Integrated Data",
                    "Active Cloud Integrated Data",
                    "Atomic Consistent Independent Data",
                    "anti-climactic ignorance day"),
                Common.Get(Category, DifficultyLevel.Hard, "What is the acronym REST short for?",
                    "REpresentational State Transfer",
                    "Really Easy Server Transport",
                    "Registry Extraction for System Testing",
                    "REgular Silent Transfers",
                    "a mars a day helps you work REST and play"),
                Common.Get(Category, DifficultyLevel.Hard, "What was an original name for Babel",
                    "6 to 5",
                    "9 to 5",
                    "Tower.JS",
                    "JS.Tower",
                    "Babe-L"),
                Common.Get(Category, DifficultyLevel.Hard, "In C#, what are verbatim strings?",
                    "Strings that start with the @ symbol in which the escape sequences are not processed",
                    "Strings that use the backslash character as an escape character",
                    "Strings that are formatted from strings and separately listed parametrized values",
                    "Strings that are formatted from strings and embedded parametrized values",
                    "Strings that contain the word 'verbatim'"),
                #endregion

                #region jeopardy / web camp training kit
                Common.Get(Category, DifficultyLevel.Hard, "What fictional company did Nancy Davolio work for?",
                    "Northwind Traders",
                    "Contoso Ltd.",
                    "Initech",
                    "Fabrikam, Inc."),
                Common.Get(Category, DifficultyLevel.Hard, "The first / oldest domain name on the internet is:",
                    "Symbolics.com",
                    "Network.com",
                    "Alpha4.com",
                    "InterConnect.com"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "In what year was the first Voice Over IP (VOIP) call made?",
                    "1973",
                    "1982",
                    "1991",
                    "1994"),
                Common.Get(Category, DifficultyLevel.Hard, "\"Chicago\" was codename for what Microsoft product?",
                    "Windows 95",
                    "Visual Basic",
                    "Microsoft Surface",
                    "Xbox"),
                Common.Get(Category, DifficultyLevel.Hard, "What was the first CodePlex.com project?",
                    "IronPython",
                    "EntLib",
                    "Ajax Toolkit",
                    "JSON.Net"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Last name of the employee who wears Microsoft badge 00001",
                    "McDonald",
                    "Gates",
                    "Ballmer",
                    "Allen"),
                Common.Get(Category, DifficultyLevel.Medium, "When did Scott Hanselman join Microsoft?",
                    "2007",
                    "2000",
                    "2005",
                    "2009"),
                Common.Get(Category, DifficultyLevel.Hard, "How big is a nibble?",
                    "4 bits",
                    "8 bits",
                    "16 bits",
                    "2 bits"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "How many function calls did Windows 1.0 approximately have?",
                    "400",
                    "100",
                    "200",
                    "600"),
                Common.Get(Category, DifficultyLevel.Easy,
                    "What is the image name for the Windows Task Manager application?",
                    "taskmgr",
                    "tmanager",
                    "wtaskmgr",
                    "wintaskm"),
                Common.Get(Category, DifficultyLevel.Medium, "When was the internet opened to commercial use?",
                    "1991",
                    "1989",
                    "1992",
                    "1990"),
                Common.Get(Category, DifficultyLevel.Medium, "When was the Xbox unveiled?",
                    "2001",
                    "2000",
                    "2002",
                    "2003"),
                Common.Get(Category, DifficultyLevel.Hard, "Why was the IBM PCjr despised by users?",
                    "All the above",
                    "Chicklet keyboard",
                    "No Hard Disk",
                    "Not PC compatible"),
                Common.Get(Category, DifficultyLevel.Hard, "What was the max memory supported by MS-DOS?",
                    "1M",
                    "256K",
                    "512K",
                    "640K"),
                Common.Get(Category, DifficultyLevel.Easy, "When was the first laser mouse released?",
                    "2004",
                    "2001",
                    "2002",
                    "2003"),
                Common.Get(Category, DifficultyLevel.Medium, "What was Microsoft's first product?",
                    "Altair Basic",
                    "DOS",
                    "PC Basic",
                    "Windows"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "What building does not exist on the Microsoft campus?",
                    "7",
                    "1",
                    "99",
                    "115"),
                Common.Get(Category, DifficultyLevel.Hard, "Who wrote the first computer program?",
                    "Ada Lovelace",
                    "Charles Babbage",
                    "Herman Hollerith",
                    "Jakob Bernoulli"),
                Common.Get(Category, DifficultyLevel.Hard, "Visual Basic was first released in what year?",
                    "1991",
                    "1990",
                    "1992",
                    "1993"),
                Common.Get(Category, DifficultyLevel.Hard, "Which of the following is NOT a prime number?",
                    "697",
                    "257",
                    "379",
                    "571"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "Yukihiro Matsumoto conceived what programming language on February 24, 1993?",
                    "Ruby",
                    "Python",
                    "Perl",
                    "Boo"),
                Common.Get(Category, DifficultyLevel.Easy, "What is the package manager for Node.js?",
                    "npm",
                    "yum",
                    "rpm",
                    "PEAR"),
                Common.Get(Category, DifficultyLevel.Easy, "In the acronym PaaS, what do the P stand for",
                    "Platform",
                    "Programming",
                    "Power",
                    "Pedestrian"),
                Common.Get(Category, DifficultyLevel.Hard, "What is the speed of light in metres per second?",
                    "299,792,458",
                    "312,123,156",
                    "100,000,000",
                    "541,123,102"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "Which of the following was not an alternative name considered for XML?",
                    "SGML",
                    "MAGMA",
                    "SLIM",
                    "MGML"),
                Common.Get(Category, DifficultyLevel.Hard, "What was the first Web Browser called?",
                    "WorldWideWeb",
                    "Mosaic",
                    "Lynx",
                    "Gopher"),
                Common.Get(Category, DifficultyLevel.Easy,
                    "In version control systems, the process of bringing together two sets of changes is called what?",
                    "Merge",
                    "Branch",
                    "Commit",
                    "Share"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "In 1980, Microsoft released there first operating system. What was it called?",
                    "Xenix",
                    "MS-DOS",
                    "Windows",
                    "Altair OS"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Which ASCII code (in decimal) represents the character B?",
                    "66",
                    "22",
                    "97",
                    "112"),
                Common.Get(Category, DifficultyLevel.Hard, "Which are the first 6 decimal digits of Pi?",
                    "3.14159",
                    "3.14195",
                    "3.14132",
                    "3.14123"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "Internet Protocol v4 provides approximately how many addresses?",
                    "4.3 billion",
                    "1.5 billion",
                    "55 billion",
                    "3.4 trillion"),
                Common.Get(Category, DifficultyLevel.Medium, "What is Layer 4 of the OSI Model?",
                    "Transport Layer",
                    "Network Layer",
                    "Session Layer",
                    "Presentation Layer"),
                Common.Get(Category, DifficultyLevel.Medium, "\"DOS\" stands for these 3 words?",
                    "disk operating system",
                    "device operating system",
                    "drive operating system",
                    "disc operating software"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "2-word term for restarting a computer without turning off the power?",
                    "warm boot",
                    "boot up",
                    "boot down",
                    "hard boot"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "A common way of linking computers in the office is this type of local area networking technology, which uses a Cat5 cable with a special connector?",
                    "ethernet",
                    "extranet",
                    "twin core and earth",
                    "ducting"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "According to Moore's Law, named for a founder of Intel, these double in power roughly every 18 months?",
                    "computer chips",
                    "disc drives",
                    "mice",
                    "monitors",
                    "humans"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "This 2-letter Windows computer operating system was introduced in October 2001?",
                    "XP",
                    "ce",
                    "nt",
                    "10"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "The February 2008 decision to abandon HD DVD technology gave a market victory to this rival video format?",
                    "Blu-ray",
                    "beta max",
                    "vhs",
                    "avi"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "In computerese, it's what the P stands for in the abbreviation HTTP?",
                    "protocol",
                    "promise",
                    "passive",
                    "private"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "It's a big smartphone, it's a small iPad, it's this 7-letter hybrid word?",
                    "phablet",
                    "fablet",
                    "padlet",
                    "padphone"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Most modern supercomputers run on this operating system developed by Linus Torvalds?",
                    "Linux",
                    "iOS",
                    "OSx",
                    "Windows"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "On a single digit LED readout, number shown when all 7 LEDs are lit?",
                    "8",
                    "1",
                    "7",
                    "1024",
                    "zero"),
                Common.Get(Category, DifficultyLevel.Medium, "Send me that report as a PDF, this \"format\"?",
                    "portable document format",
                    "printable document format",
                    "published document format",
                    "protected document format"),
                Common.Get(Category, DifficultyLevel.Medium, "The 'S' in DSL is digital what line?",
                    "subscriber",
                    "service",
                    "speed",
                    "secure"),
                Common.Get(Category, DifficultyLevel.Medium, "What does LAN stand for?",
                    "local area network",
                    "linked area network",
                    "large area network",
                    "lost area network"), //, "lost all nerds"),
                Common.Get(Category, DifficultyLevel.Medium, "which digit number that means \"File Not Found\"?",
                    "404",
                    "201",
                    "501",
                    int.MaxValue.ToString()),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Wi-Fi technology uses these waves that brought us \"The Chase & Sanborn Hour\" in the 1930s?",
                    "radio waves",
                    "magic",
                    "bluetooth",
                    "radar"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "You can feel your way around a game using the Dualshock controller for which video game console?",
                    "PlayStation",
                    "Xbox",
                    "Atari",
                    "Wii"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Even before all the polls closed, CBS used this huge computer to predict the result of the 1952 presidential election?",
                    "UNIVAC",
                    "watson",
                    "analytical engine",
                    "big blue",
                    "abacus"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "In 1981 this company introduced the PC, its first home computer?",
                    "IBM",
                    "microsoft",
                    "apple",
                    "tesla",
                    "google"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "At the 1939 New York World's Fair, what animal was the robot Elektro was accompanied by Sparko?",
                    "a dog",
                    "a cat",
                    "a mouse",
                    "a elephant"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Copying info from a computer to a CD is called burning; doing the reverse is this other destructive term?",
                    "ripping",
                    "stealing",
                    "copying",
                    "burning"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "CTR, the Computing-Tabulating-Recording Company, took on this current 3-letter name in 1924?",
                    "IBM",
                    "jvc",
                    "ici",
                    "htc"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Dan Bricklin developed VISICALC, the first of these programs?",
                    "spreadsheet",
                    "powerpoint",
                    "visio",
                    "calculator"),
              //  gregt fill in todo1/2/3 choices
                Common.Get(Category, DifficultyLevel.Medium, "Android's 4.1 O.S.  called this?",
                    "Jelly Bean",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Dioxide of this element, symbol Cr, is used to make recording tape for cassettes?",
                    "chromium",
                    "magnet",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Established in Mountain View in 1956, Shockley Semiconductor helped put this element in the name of a \"valley\"?",
                    "silicon",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "First built in 1960, it's also been called an optical maser?",
                    "laser",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "imgur.com has a button to make this four-letter cultural reference that often spreads online?",
                    "a meme",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In 1983 Apple's Lisa computer gave PCs this device that moves the cursor around the screen	?",
                    "mouse",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In 1993 Intel introduced this new chip, which had 3.1 million transistors?",
                    "Pentium",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In 1995 Wells Fargo became the first bank whose customers could securely view their accounts here?",
                    "online",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In 2014 Facebook agreed to pay $2 billion for Oculus, a maker of this immersive technology?",
                    "virtual reality	",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In the abbreviation JPEG, the \"P\" is this 12 - letter adjective?",
                    "Photographic",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "It's a measure of speed:BPS?",
                    "bytes per second",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "It's the brains of the operation:CPU?",
                    "central processing unit",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "On August 12, 1981 the world saw the first IBM personal computer using this Microsoft operating system?",
                    "MS-DOS",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "On Feb. 29, 2008 Blu - Ray emerged as the new video disc choice as this Japanese co. abandoned its HD - DVD format?",
                    "Toshiba",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Reddit is known for hosting online interviews where you can AMA, short for this?",
                    "ask me anything",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Seen here is an icon for this 3 - letter service that feeds you updates on your favorite web sites?",
                    "RSS",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "smugmug.com lets you share these & back them up?",
                    "pictures(or photographs)",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The \"G\" in .gif & .png stands for these?",
                    "graphics",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The \"HT\" in both HTTP & HTML stands for this?",
                    "hypertext",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The \"P\" in jpeg?",
                    "photographic",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "What does RAID stand for?",
                    "redundant array of inexpensive disks",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "A type of hacker who ethically reports security problems is called this, a proverbial accessory of cowboy heroes?",
                    "white hat",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Automaton is sometimes just a fancy name for one of these mechanical beings?",
                    "a robot",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "what was ASIMO?",
                    "a robot that differentiates multiple voices using 8 microphones & Hark software?",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "In 1991 Apple introduced this media player//would you like to download the latest version?",
                    "QuickTime",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The \"B\" in COBOL?",
                    "business",
                    "binary",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The \"D\" in a DoS attack?",
                    "denial",
                    "distributed",
                    "Todo2",
                    "Todo3"),
               Common.Get(Category, DifficultyLevel.Medium, "The forerunner to the Internet known as the ARPANET was a 1960s network by this U.S. government dept.?",
                    "Defense",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The IBM \"computer\" of 1928 stored its data on these?",
                    "Punch cards",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The ROM of your computer's CD-ROM stands for this?",
                    "read-only memory",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The second \"T\" in HTTP?",
                    "transfer or transport",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "The smallest units of information stored in a computer, they form bytes?",
                    "bits",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
               Common.Get(Category, DifficultyLevel.Medium, "This chipmaker, the world's largest, has announced \"systems on a chip\" measuring 22 nanometers?",
                    "Intel	",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This company whose name is synonymous with copying introduced the first hand - held mouse in 1973?",
                    "Xerox",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This computer device slowly takes you online?",
                    "a modem",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This computer was introduced in 1984 & came with a MacWrite text program & a MacPaint program for graphics?",
                    "Apple Macintosh",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This popular Internet service provider began as QCS, Quantum Computer Services?",
                    "AOL(America Online)",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This programming language was named for calculating - machine inventor Blaise?",
                    "PASCAL",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This removable item used for data storage was introduced in 1971; the first one was 8 inches square?",
                    "floppy disk",
                    "compact disc",
                    "flash drive",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "This type of \"net\" developed by Xerox has helped local area networks communicate since the 1970s?",
                    "ethernet",
                    "Todo1",
                    "Todo2",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "Useful for connecting devices, USB is short for Universal Serial this?",
                    "Bus",
                    "button",
                    "bytes",
                    "Todo3"),
                Common.Get(Category, DifficultyLevel.Medium, "When a device can be attached to your computer & install itself, it's PnP, short for this?",
                    "Plug and Play",
                    "push and pull",
                    "todo2",
                    "Todo3"),
                #endregion
            };

            return quizQuestions;
        }

    }
}
