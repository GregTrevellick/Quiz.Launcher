﻿using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsJeopardy
    {

        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Get("\"DOS\" stands for these 3 words?", "disk operating system", "Todo1", "Todo2", "Todo3"),
                Get("\"DSL\" is \"digital\" this \"line\"?", "subscriber", "Todo1", "Todo2", "Todo3"),
                Get("\"N-Gage\" with this company's cell phone, wihch is also a portable game?", "Nokia", "Todo1", "Todo2", "Todo3"),
                Get("2-word term for something nice to wear in winter, or for restarting a computer without turning off the power?", "warm boot", "Todo1", "Todo2", "Todo3"),
                Get("32 bits long, an ESN is an \"electronic\" this, used to identify devices?", "serial number", "Todo1", "Todo2", "Todo3"),
                Get("5-letter pome fruit of the family Rosaceae?", "Apple", "Todo1", "Todo2", "Todo3"),
                Get("A 1947 book trumpeted the fact that this new invention could be used to locate thunderstorms?", "Radar", "Todo1", "Todo2", "Todo3"),
                Get("A box of 64 Crayola crayons has one of these devices \"built-in\"?", "a sharpener", "Todo1", "Todo2", "Todo3"),
                Get("A class in school, or a record of where you've gone in a web browser?", "history", "Todo1", "Todo2", "Todo3"),
                Get("A common way of linking computers in the office is this type of local area networking technology, which uses a Cat5 cable with a special connector?", "ethernet", "Todo1", "Todo2", "Todo3"),
                Get("A famous one in ancient Greece bathed in the Castalian Spring before speaking?", "Oracle", "Todo1", "Todo2", "Todo3"),
                Get("A former U.S. Navy rank between captains & admirals?", "Commodore", "Todo1", "Todo2", "Todo3"),
                Get("A hydroelectric power plant at this U.S.landmark opened in 1881?", "Niagara Falls", "Todo1", "Todo2", "Todo3"),
                Get("A regional computer linker:LAN?", "local area network", "Todo1", "Todo2", "Todo3"),
                Get("A semiconductor diode is the most common of these devices that convert A.C.to D.C.?", "rectifiers", "Todo1", "Todo2", "Todo3"),
                Get("A single processor sharing multiple jobs is doing this, like when Mom tries to drive & put on makeup?", "multitasking", "Todo1", "Todo2", "Todo3"),
                Get("A small wooded valley, perhaps with a farmer?", "Dell", "Todo1", "Todo2", "Todo3"),
                Get("A spooler, a program that puts jobs in a queue to be done one at a time, is usually associated with this type of job?", "printing", "Todo1", "Todo2", "Todo3"),
                Get("A stupid or inept internet user can be called this 3 - digit number that means \"File Not Found\"?", "404", "Todo1", "Todo2", "Todo3"),
                Get("A swelling under the eye, or a quiet, timid person?", "mouse", "Todo1", "Todo2", "Todo3"),
                Get("A synonym for \"flowing\", it's the type of video you can watch when you visit us at jeopardy.com?", "streaming", "Todo1", "Todo2", "Todo3"),
                Get("A type of hacker who ethically reports security problems is called this, a proverbial accessory of cowboy heroes?", "white hat", "Todo1", "Todo2", "Todo3"),
                Get("Abbreviated BB, it's a popular data-transmission method capable of sending multiple channels at once?", "broadband", "Todo1", "Todo2", "Todo3"),
                Get("According to Moore's Law, named for a founder of Intel, these double in power roughly every 18 months?", "computer chips", "Todo1", "Todo2", "Todo3"),
                Get("Ace & True Value both serve as this type of store?", "hardware", "Todo1", "Todo2", "Todo3"),
                Get("Advertisers have discovered they can send ads instantaneously with this telephone technology?", "Fax Machine", "Todo1", "Todo2", "Todo3"),
                Get("After hearing this invention of his work, Edison said, \"I was never so taken aback in my life\"?", "the phonograph", "Todo1", "Todo2", "Todo3"),
                Get("Among Internet users, the World Wide Web has surpassed the system named for this burrowing rodent?", "gopher", "Todo1", "Todo2", "Todo3"),
                Get("An ancient Greek wanting to know Zeus' will might consult this in a grove of oak trees in Dodona?", "oracle", "Todo1", "Todo2", "Todo3"),
                Get("An empty Goodyear blimp weighs over 12, 000 lbs.; when they fill it with this gas, it weighs only 100 to gregt pounds?", "helium", "Todo1", "Todo2", "Todo3"),
                Get("Android's 4.1 O.S. is called this, just like one of Reagan's favorite treats?", "Jelly Bean", "Todo1", "Todo2", "Todo3"),
                Get("Apple's Leopard is a type of OS, one of these?", "an operating system", "Todo1", "Todo2", "Todo3"),
                Get("As part of its salute to this decade, the Post Office created a stamp with a MixMaster on it?", "the 1930s", "Todo1", "Todo2", "Todo3"),
                Get("ASIMO, one of these, differentiates multiple voices using 8 microphones & Hark software?", "a robot", "Todo1", "Todo2", "Todo3"),
                Get("At the 1939 New York World's Fair, the robot Elektro was accompanied by Sparko, a robot one of these?", "a dog", "Todo1", "Todo2", "Todo3"),
                Get("At the touch of a button on July 1, 1939, this Clay Puett invention made its horse - racing debut?", "Electric Starting Gate", "Todo1", "Todo2", "Todo3"),
                Get("Automaton is sometimes just a fancy name for one of these mechanical beings?", "a robot", "Todo1", "Todo2", "Todo3"),
                Get("Before a game's release, Joe Gamer may be asked to play a pre-version usually referred to by this Greek letter?", "beta", "Todo1", "Todo2", "Todo3"),
                Get("Bell invented it in 1876; David Hughes gave it this name in 1878, &don't lean into it when you reply?", "Microphone", "Todo1", "Todo2", "Todo3"),
                Get("Buckminster Fuller used \"energetic synergetic geometry\" to build these structures?", "geodesic domes", "Todo1", "Todo2", "Todo3"),
                Get("C.Vanderbilt thought George Westinghouse's idea of stopping a train by this means a fool notion?", "the air brake", "Todo1", "Todo2", "Todo3"),
                Get("Calculating device developed in ancient times which the Chinese call a \"reckoning board\"?", "abacus", "Todo1", "Todo2", "Todo3"),
                Get("Carlsbad's Callaway makes hi-tech these, like the FT Optiforce	?", "golf clubs	", "Todo1", "Todo2", "Todo3"),
                Get("Casement, bow & double-hung are these?", "windows", "Todo1", "Todo2", "Todo3"),
                Get("Cesium was the first element found by this process using the band of colored light produced by a prism?", "Spectroscopy", "Todo1", "Todo2", "Todo3"),
                Get("Charles Goodyear vulcanized rubber, and this Charles used rubber to waterproof cloth?", "Macintosh", "Todo1", "Todo2", "Todo3"),
                Get("Christiaan Huygens got into the swing of things in 1656 by adding this to the clock?", "Pendulum", "Todo1", "Todo2", "Todo3"),
                Get("Coherant & Xenix are 2 of these, part of the abbreviation in the better-known MS-DOS?", "operating systems", "Todo1", "Todo2", "Todo3"),
                Get("Connect to the Internet with ease with a wireless one of these//sounds like a seat for your little brother?", "a booster", "Todo1", "Todo2", "Todo3"),
                Get("Copying info from a computer to a CD is called burning; doing the reverse is this other destructive term?", "ripping", "Todo1", "Todo2", "Todo3"),
                Get("CSIRO has developed technology that helps drain this gas, CH4, released by the mining of coal?", "methane", "Todo1", "Todo2", "Todo3"),
                Get("CTR, the Computing-Tabulating-Recording Company, took on this current 3-letter name in 1924?", "IBM", "Todo1", "Todo2", "Todo3"),
                Get("Dan Bricklin developed VISICALC, the first of these programs, similar to an accounting ledger?", "spreadsheet", "Todo1", "Todo2", "Todo3"),
                Get("Despite the name, the San Jose headquarters of this maker of the creative cloud isn't built of clay bricks	?", "Adobe	", "Todo1", "Todo2", "Todo3"),
                Get("Device that stealth aircraft technology is designed to trick?", "radar", "Todo1", "Todo2", "Todo3"),
                Get("Dioxide of this element, symbol Cr, is used to make recording tape for cassettes?", "chromium", "Todo1", "Todo2", "Todo3"),
                Get("Drawings discovered in 1967 showed this artist invented the chain drive around 1492?", "Leonardo da Vinci", "Todo1", "Todo2", "Todo3"),
                Get("During the 15th - 17th centuries these developed from the matchlock to the wheellock to the flintlock?", "guns", "Todo1", "Todo2", "Todo3"),
                Get("Erase a hard disk before disposing of a computer: putting personal data out there risks this 2 - word crime?", "identity theft", "Todo1", "Todo2", "Todo3"),
                Get("Established in Mountain View in 1956, Shockley Semiconductor helped put this element in the name of a \"valley\"?", "silicon", "Todo1", "Todo2", "Todo3"),
                Get("Even before all the polls closed, CBS used this huge computer to predict the result of the 1952 presidential election?", "UNIVAC", "Todo1", "Todo2", "Todo3"),
                Get("Exhaust gas recirculation is one way to clean the emissions of these engines used in trucks & Jettas?", "Diesel engines", "Todo1", "Todo2", "Todo3"),
                Get("Fingerprint ID devices are part of this security technology, from the Greek for \"life\" & \"measure\"?", "biometric", "Todo1", "Todo2", "Todo3"),
                Get("First built in 1960, it's also been called an optical maser?", "laser", "Todo1", "Todo2", "Todo3"),
                Get("For a great deal, check out this smallest version of the Apple iPod, even tinier than the Nano?", "the Shuffle", "Todo1", "Todo2", "Todo3"),
                Get("From the Old English for \"clasp\" & \"table\", it's where anything you \"cut\" or \"copy\" is stored until you \"paste\"?", "a clipboard", "Todo1", "Todo2", "Todo3"),
                Get("Giving a play-by-play of an event while on Twitter is called doing this?", "live tweeting", "Todo1", "Todo2", "Todo3"),
                Get("GOES, INSAT & METEOSAT are satellites used for this purpose?", "Weather Forecasting", "Todo1", "Todo2", "Todo3"),
                Get("Google Keep is a digital note - taking app for this \"robotic\" mobile operating system?", "Android", "Todo1", "Todo2", "Todo3"),
                Get("Gooo//wait, is it? Yes! Gooooooal! In 2012 this sport's FIFA approved the use of goal-line technology?", "soccer	", "Todo1", "Todo2", "Todo3"),
                Get("Hans Lippershey, who invented this instrument in 1608, called it a \"looker\"?", "Telescope", "Todo1", "Todo2", "Todo3"),
                Get("hashtags.org tracks keywords on this social site that popularized the hashtag?", "Twitter", "Todo1", "Todo2", "Todo3"),
                Get("HDTV, which uses more lines to give clearer pictures, stands for this?", "High Definition Television", "Todo1", "Todo2", "Todo3"),
                Get("Hello: IM?", "instant message", "Todo1", "Todo2", "Todo3"),
                Get("Here it is in blue & white: printer from this brand Hewlett-Packard?", "the LaserJet Pro", "Todo1", "Todo2", "Todo3"),
                Get("Here you can clearly see the logo of this hi-def format for home theaters in 1080p?", "Blu-ray", "Todo1", "Todo2", "Todo3"),
                Get("Hubert Booth, not Herbert Hoover, developed the first practical electric one of these in 1901?", "Vacuum cleaner", "Todo1", "Todo2", "Todo3"),
                Get("If an atom loses one of these, it becomes a cation, a positively charged ion?", "electron", "Todo1", "Todo2", "Todo3"),
                Get("If you want true high def, see your way to finding this company's Bravia TV line?", "Sony", "Todo1", "Todo2", "Todo3"),
                Get("If your machine is being controlled by someone else, it may have been taken over by this 3 - letter piece of malware?", "a bot", "Todo1", "Todo2", "Todo3"),
                Get("I'll bet Christmas 1996 was the last time you thought you'd hear this toy's sound	?", "Tickle Me Elmo", "Todo1", "Todo2", "Todo3"),
                Get("imgur.com has a button to make this four-letter cultural reference that often spreads online?", "a meme", "Todo1", "Todo2", "Todo3"),
                Get("In 1611 Johannes Kepler introduced a second convex lens, giving this instrument greater power?", "a telescope", "Todo1", "Todo2", "Todo3"),
                Get("In 1835 C.S.A.Thilorier froze this gas to create the first \"dry ice\"?", "carbon dioxide", "Todo1", "Todo2", "Todo3"),
                Get("In 1859 Robert Fouls invented a steam-powered one of these to singal imperiled ships?", "a foghorn", "Todo1", "Todo2", "Todo3"),
                Get("In 1861, Elisha Otis patented an elevator driven by this, not electricity?", "steam", "Todo1", "Todo2", "Todo3"),
                Get("In 1901 Eugene Demarcay discovered Eu, this rare - earth metal that's named for a continent?", "Europium", "Todo1", "Todo2", "Todo3"),
                Get("In 1904, this ex - shoe salesman & Illinois medical school graduate patented his arch support?", "Dr.Scholl", "Todo1", "Todo2", "Todo3"),
                Get("In 1908 a carbon tetrachloride gas type of this was invented; in 1917 a foam type?", "Fire extinguishers", "Todo1", "Todo2", "Todo3"),
                Get("In 1946 Del Harder of this auto co.coined the term \"automation\" to describe the way its engines were assembled?", "Ford", "Todo1", "Todo2", "Todo3"),
                Get("In 1960 Theodore Maiman used this gem in his laser?", "Ruby", "Todo1", "Todo2", "Todo3"),
                Get("In 1981 the Solar Challenger was a solar-powered plane & in 1977 the Gossamer Condor was powered by this?", "human power(pedaling)", "Todo1", "Todo2", "Todo3"),
                Get("In 1981 this company introduced the PC, its first home computer?", "IBM", "Todo1", "Todo2", "Todo3"),
                Get("In 1982 one of these vehicles deployed a satellite for the first time?", "Space shuttle", "Todo1", "Todo2", "Todo3"),
                Get("In 1982 the Jarvik-7, the first permanent one of these, was implanted in patient Barney Clark?", "an artificial heart", "Todo1", "Todo2", "Todo3"),
                Get("In 1983 Apple's Lisa computer gave PCs this device that moves the cursor around the screen	?", "mouse", "Todo1", "Todo2", "Todo3"),
                Get("In 1989 scientists using a scanning tunneling microscope saw this double-stranded molecule for the 1st time?", "DNA", "Todo1", "Todo2", "Todo3"),
                Get("In 1991 Apple introduced this media player//would you like to download the latest version?", "QuickTime", "Todo1", "Todo2", "Todo3"),
                Get("In 1993 Intel introduced this new chip, which had 3.1 million transistors?", "Pentium", "Todo1", "Todo2", "Todo3"),
                Get("In 1995 Wells Fargo became the first bank whose customers could securely view their accounts here?", "online", "Todo1", "Todo2", "Todo3"),
                Get("In 1998 Deep Crack, designed for this science from the Greek for \"hidden writing\", broke the standard U.S.data cipher?", "cryptography", "Todo1", "Todo2", "Todo3"),
                Get("In 2007 President Bush said he'd do this \"to the finish...that's one way to ensure that I am relevant\"?", "sprint", "Todo1", "Todo2", "Todo3"),
                Get("In 2008 an IBM supercomputer named for this speedy state bird broke the 1 petaflop barrier//that's really fast	?", "a roadrunner", "Todo1", "Todo2", "Todo3"),
                Get("In 2008 lampposts in London were padded to prevent injuries due to this activity by pedestrians?", "texting", "Todo1", "Todo2", "Todo3"),
                Get("In 2008 Michael Phelps & NASA teamed to reduce drag on these & created \"the world's fastest\" one?", "a swimsuit", "Todo1", "Todo2", "Todo3"),
                Get("In 2014 Facebook agreed to pay $2 billion for Oculus, a maker of this immersive technology?", "virtual reality	", "Todo1", "Todo2", "Todo3"),
                Get("In chat rooms, \"YMMV\" is this disclaimer often used in car ads; it basically lets you off the hook for anything you say?", "your mileage may vary", "Todo1", "Todo2", "Todo3"),
                Get("In computerese, it's what the P stands for in the abbreviation HTTP?", "protocol", "Todo1", "Todo2", "Todo3"),
                Get("In July 1991 IBM & this rival announced a technology alliance?", "Apple", "Todo1", "Todo2", "Todo3"),
                Get("In the 1940s, Dr.William Sewell created an artificial one of these, using parts from an erector set?", "an artificial heart", "Todo1", "Todo2", "Todo3"),
                Get("In the abbreviation JPEG, the \"P\" is this 12 - letter adjective?", "Photographic", "Todo1", "Todo2", "Todo3"),
                Get("In Windows hitting Ctrl-C & Ctrl-V performs these 2 artsy & crafty actions?", "copy & paste", "Todo1", "Todo2", "Todo3"),
                Get("It can be a hiding place for food or treasure, or a place for memory on a computer's motherboard?", "a cache", "Todo1", "Todo2", "Todo3"),
                Get("It precedes arch in St.Louis?", "gateway", "Todo1", "Todo2", "Todo3"),
                Get("It's a big smartphone, it's a small iPad, it's this 7-letter hybrid word?", "phablet", "Todo1", "Todo2", "Todo3"),
                Get("It's a measure of speed:BPS?", "bytes per second", "Todo1", "Todo2", "Todo3"),
                Get("It's the brains of the operation:CPU?", "central processing unit", "Todo1", "Todo2", "Todo3"),
                Get("John Roebling designed this bridge across the East River, the oldest suspension bridge in NYC?", "The Brooklyn Bridge", "Todo1", "Todo2", "Todo3"),
                Get("Laser beams are \"directed\" by these optical devices?", "Mirrors", "Todo1", "Todo2", "Todo3"),
                Get("Le Bureau International de l'Heure in Paris is the keeper of this for the world?", "time", "Todo1", "Todo2", "Todo3"),
                Get("Like a villain in darkness, one who reads others' words in a newsgroup but won't contribute is doing this?", "Lurking", "Todo1", "Todo2", "Todo3"),
                Get("Los Alamos now has the fastest computer; it was designed using technology from this Sony gaming system?", "PlayStation 3", "Todo1", "Todo2", "Todo3"),
                Get("Los Gatos is home to this 40-million member movie & TV streaming business?", "Netflix", "Todo1", "Todo2", "Todo3"),
                Get("Men who hate asking for directions need a product by Garmin or Magellan using GPS, this type of \"system\"?", "a global positioning system", "Todo1", "Todo2", "Todo3"),
                Get("More cardiac arrest patients survive thanks to purposely induced this condition, which cools the blood 5 - 8 degrees?", "hypothermia", "Todo1", "Todo2", "Todo3"),
                Get("Most modern supercomputers run on this operating system developed by Linus Torvalds?", "Linux", "Todo1", "Todo2", "Todo3"),
                Get("Motorstorm, Lair & Warhawk are some of the products for this newest Sony entertainment system?", "the PlayStation 3", "Todo1", "Todo2", "Todo3"),
                Get("My PlayStation 3 lets me enjoy important historical movies in this \"colorful\" format?", "Blu-ray", "Todo1", "Todo2", "Todo3"),
                Get("Nearly 25 percent of U.S.teens now own one of these phones, so there's no excuse for not calling home?", "	a cell phone	", "Todo1", "Todo2", "Todo3"),
                Get("No relation to DC Comics' fastest man, this is the fast-loading animation by Adobe	?", "Flash	", "Todo1", "Todo2", "Todo3"),
                Get("Number of bulbs in the Magicube that replaced a battery-powered flash on cameras?", "4", "Todo1", "Todo2", "Todo3"),
                Get("Of Flash, Google or AltaVista, the one that's not a popular Internet search engine	?", "Flash	", "Todo1", "Todo2", "Todo3"),
                Get("On a monitor, 1280 x 1024 pixels is called \"native\" this, the degree of detail & sharpness?", "resolution", "Todo1", "Todo2", "Todo3"),
                Get("On a single digit LED readout, number shown when all 7 LEDs are lit?", "8", "Todo1", "Todo2", "Todo3"),
                Get("On August 12, 1981 the world saw the first IBM personal computer using this Microsoft operating system?", "MS-DOS", "Todo1", "Todo2", "Todo3"),
                Get("On Feb. 17, 2009 this type of TV broadcast technology will end in the U.S.; we're going digital?", "analog", "Todo1", "Todo2", "Todo3"),
                Get("On Feb. 29, 2008 Blu - Ray emerged as the new video disc choice as this Japanese co. abandoned its HD - DVD format?", "Toshiba", "Todo1", "Todo2", "Todo3"),
                Get("On Oct. 15, 2003 it became the third country to launch a man into space; the Shenzhou 5 spacecraft orbited the Earth 14 times?", "China", "Todo1", "Todo2", "Todo3"),
                Get("One-word name for the lizard seen here//remember the category!?", "monitor", "Todo1", "Todo2", "Todo3"),
                Get("Phishing is not allowed when you use the newest version of this web browser from Mozilla?", "Firefox", "Todo1", "Todo2", "Todo3"),
                Get("Proverbially, one of these \"a day\" keeps the M.D. from your presence?", "an apple", "Todo1", "Todo2", "Todo3"),
                Get("Put pulped cellulose fiber mixed with water & fillers into a Fourdrinier machine & it comes out as this?", "paper", "Todo1", "Todo2", "Todo3"),
                Get("Record each letter & number typed on a computer with this type of software that sounds like a lumberjack?", "a keylogger", "Todo1", "Todo2", "Todo3"),
                Get("Reddit is known for hosting online interviews where you can AMA, short for this?", "ask me anything", "Todo1", "Todo2", "Todo3"),
                Get("Releasing someone's personal info on the Internet is this word that can have 1 or 2 \"X\"s in the middle?", "doxing (or doxxing)", "Todo1", "Todo2", "Todo3"),
                Get("Replacing germanium with this in transistors got a California \"Valley\" named after it?", "silicon", "Todo1", "Todo2", "Todo3"),
                Get("Sealy makes these with \"advanced memory foam technology\"?", "mattresses", "Todo1", "Todo2", "Todo3"),
                Get("Seen here is an icon for this 3 - letter service that feeds you updates on your favorite web sites?", "RSS", "Todo1", "Todo2", "Todo3"),
                Get("Send me that report as a PDF, this \"format\"?", "portable document format", "Todo1", "Todo2", "Todo3"),
                Get("Shortened to 5 letters from a longer word, it's military information?", "Intel", "Todo1", "Todo2", "Todo3"),
                Get("smugmug.com lets you share these & back them up?", "pictures(or photographs)", "Todo1", "Todo2", "Todo3"),
                Get("Social insects, termites live in groups of a few hundred to several million called these?", "colonies", "Todo1", "Todo2", "Todo3"),
                Get("Sony's S is this type of computer//bigger than a smartphone but smaller than a laptop?", "a tablet	", "Todo1", "Todo2", "Todo3"),
                Get("Suggestions on what to call this device ranged from farscope to telebaird?", "Television", "Todo1", "Todo2", "Todo3"),
                Get("SYSADMIN, one who maintains a computer network, is short for this?", "System administrator", "Todo1", "Todo2", "Todo3"),
                Get("Term for a moving stairway, it was originally a trademark of the Otis Elevator Co.?", "Escalator", "Todo1", "Todo2", "Todo3"),
                Get("Term for any gas that pressurizes the liquid in an aerosol can?", "propellant", "Todo1", "Todo2", "Todo3"),
                Get("The \"B\" in COBOL?", "business", "Todo1", "Todo2", "Todo3"),
                Get("The \"D\" in a DoS attack?", "denial", "Todo1", "Todo2", "Todo3"),
                Get("The \"G\" in .gif & .png stands for these?", "graphics", "Todo1", "Todo2", "Todo3"),
                Get("The \"HT\" in both HTTP & HTML stands for this?", "hypertext", "Todo1", "Todo2", "Todo3"),
                Get("The \"P\" in jpeg?", "photographic", "Todo1", "Todo2", "Todo3"),
                Get("The \"Pearl\" model of this Research In Motion device is an e - mail client, media player, camera &cell phone?", "the BlackBerry", "Todo1", "Todo2", "Todo3"),
                Get("The \"RT\" in \"RTOS\"?", "real-time", "Todo1", "Todo2", "Todo3"),
                Get("The 1st automated instrument to analyze this genetic material's structure was developed in the mid-1980s?", "DNA", "Todo1", "Todo2", "Todo3"),
                Get("The Cassini spacecraft is scheduled to study this planet & send a probe to the surface of its moon Titan?", "Saturn", "Todo1", "Todo2", "Todo3"),
                Get("The Celsius temperature scale is also called this, meaning \"divided into one hundred parts\"?", "centigrade", "Todo1", "Todo2", "Todo3"),
                Get("The engine control unit, a car's smartest computer, monitors systems like injection of this?", "fuel", "Todo1", "Todo2", "Todo3"),
                Get("The February 2008 decision to abandon HD DVD technology gave a market victory to this rival video format?", "Blu-ray", "Todo1", "Todo2", "Todo3"),
                Get("The first modern ones of these, called Lucifers, were invented in 1827 & struck on sandpaper?", "Matches", "Todo1", "Todo2", "Todo3"),
                Get("The forerunner to the Internet known as the ARPANET was a 1960s network by this U.S. government dept.?", "Defense", "Todo1", "Todo2", "Todo3"),
                Get("The IBM \"computer\" of 1928 stored its data on these?", "Punch cards", "Todo1", "Todo2", "Todo3"),
                Get("The mental capacity to recall facts, or a show-stopping number from \"Cats\"?", "memory", "Todo1", "Todo2", "Todo3"),
                Get("The Multi-Sport GPS watch is made by this companycompany?", "TomTom", "Todo1", "Todo2", "Todo3"),
                Get("The Museum of Broadcasting is transferring masters of all its shows from analog videotape to this type?", "digital tape", "Todo1", "Todo2", "Todo3"),
                Get("The name of this colorful wireless headset technology refers to a tech trade association founded in 1998?", "Bluetooth", "Todo1", "Todo2", "Todo3"),
                Get("The name of this pivoted frame for the combustion chamber & nozzle of a rocket sounds like Macy's one-time rival?", "a gimbal", "Todo1", "Todo2", "Todo3"),
                Get("The Nomad Jukebox Zen Xtra is a device which plays music in this alphanumeric format?", "MP3", "Todo1", "Todo2", "Todo3"),
                Get("The reason the transistor was invented was to make this piece of equipment work better?", "Telephone(switcher)", "Todo1", "Todo2", "Todo3"),
                Get("The ROM of your computer's CD-ROM stands for this?", "read-only memory", "Todo1", "Todo2", "Todo3"),
                Get("The second \"T\" in HTTP?", "transfer or transport", "Todo1", "Todo2", "Todo3"),
                Get("The smallest units of information stored in a computer, they form bytes?", "bits", "Todo1", "Todo2", "Todo3"),
                Get("The stars align with its Galaxy Note II phone?", "Samsung", "Todo1", "Todo2", "Todo3"),
                Get("The tokamak, this type of nuclear reactor, uses plasma heated to 180 million degrees as fuel?", "fusion", "Todo1", "Todo2", "Todo3"),
                Get("The two most common types of mechanical clocks are driven by weights or these?", "springs", "Todo1", "Todo2", "Todo3"),
                Get("The USSR lost contact with its Phobos 2 craft before it landed on Phobos, a moon of this planet?", "Mars", "Todo1", "Todo2", "Todo3"),
                Get("These drone aircraft controlled from Nevada have been attacking targets in Pakistan?", "Predator drones", "Todo1", "Todo2", "Todo3"),
                Get("Thinking Machines Corp.pioneered this processing// as the geometric name indicates, many processors work side by side?", "parallel processing", "Todo1", "Todo2", "Todo3"),
                Get("This \"high-flying\" computer program from Adobe converts other types of documents into a PDF file?", "Acrobat", "Todo1", "Todo2", "Todo3"),
                Get("This 2-letter Windows computer operating system was introduced in October 2001?", "XP", "Todo1", "Todo2", "Todo3"),
                Get("This 4 - letter word from Sanskrit means someone who is a computer knowledge resource?", "Guru", "Todo1", "Todo2", "Todo3"),
                Get("This 4-letter word is \"warm\" when the computer's power is already on, \"cold\" when it's off?", "boot", "Todo1", "Todo2", "Todo3"),
                Get("This Apple product that was rolled out in 2010 has a 9.7-inch screen & is 1/2 inch thick?", "the iPad", "Todo1", "Todo2", "Todo3"),
                Get("This biologist first gained acclaim for writing in1937 with her article \"Undersea\" in the Atlantic Monthly?", "Rachel Carson", "Todo1", "Todo2", "Todo3"),
                Get("This brand of garbage disposer invented by John Hammes is celebrating its 60th anniversary in 1998?", "InSinkErator", "Todo1", "Todo2", "Todo3"),
                Get("This chipmaker, the world's largest, has announced \"systems on a chip\" measuring 22 nanometers?", "Intel	", "Todo1", "Todo2", "Todo3"),
                Get("This company that sells Dimension computers now sells a GPS system for the Axim PDAs?", "Dell", "Todo1", "Todo2", "Todo3"),
                Get("This company whose name is synonymous with copying introduced the first hand - held mouse in 1973?", "Xerox", "Todo1", "Todo2", "Todo3"),
                Get("This computer device slowly takes you online?", "a modem", "Todo1", "Todo2", "Todo3"),
                Get("This computer was introduced in 1984 & came with a MacWrite text program & a MacPaint program for graphics?", "Apple Macintosh", "Todo1", "Todo2", "Todo3"),
                Get("This engine innovation was introduced in 1940 by GM with the slogan \"No gears to shift! No clutch to press!\"?", "automatic transmission", "Todo1", "Todo2", "Todo3"),
                Get("This female warrior of myth mainly dealt with men for 1 reason//procreation; use the singular, please?", "Amazon", "Todo1", "Todo2", "Todo3"),
                Get("This Italian city, known for its flooding, plans to build sea gates to control flow from the Adriatic?", "Venice", "Todo1", "Todo2", "Todo3"),
                Get("This phone company's walkie talkie service sounds promising?", "Nextel", "Todo1", "Todo2", "Todo3"),
                Get("This photo co.created the EasyShare printer with prints that are less expensive &last 100 years?", "Kodak", "Todo1", "Todo2", "Todo3"),
                Get("This popular Internet service provider began as QCS, Quantum Computer Services?", "AOL(America Online)", "Todo1", "Todo2", "Todo3"),
                Get("This process that maximizes disk space is so named because it joins up pieces of files that were stored separately?", "defrag (or defragmenting)	", "Todo1", "Todo2", "Todo3"),
                Get("This programming language was named for calculating - machine inventor Blaise?", "PASCAL", "Todo1", "Todo2", "Todo3"),
                Get("This removable item used for data storage was introduced in 1971; the first one was 8 inches square?", "floppy disk", "Todo1", "Todo2", "Todo3"),
                Get("This search engine's Picasa program lets you store, edit & share pictures?", "	Google	", "Todo1", "Todo2", "Todo3"),
                Get("This technology used for wireless headsets is named after a Danish king who united parts of Scandinavia?", "Bluetooth", "Todo1", "Todo2", "Todo3"),
                Get("This type of \"net\" developed by Xerox has helped local area networks communicate since the 1970s?", "ethernet", "Todo1", "Todo2", "Todo3"),
                Get("This unit of weight is abbreviated mg.?", "Milligram", "Todo1", "Todo2", "Todo3"),
                Get("This word for fire is also an abusive note on a message board or in a chat room?", "flame", "Todo1", "Todo2", "Todo3"),
                Get("This word meaning to deal a blow is now a word for one look at a website?", "a hit", "Todo1", "Todo2", "Todo3"),
                Get("Thomas Edison's cylindrical ones were superceded by Emile Berliner's flat variety?", "phonograph records", "Todo1", "Todo2", "Todo3"),
                Get("Though not always accurate, a polygraph machine is supposed to show if you are doing this?", "lying", "Todo1", "Todo2", "Todo3"),
                Get("Time to process the Pentium 4 processor from this company?", "Intel", "Todo1", "Todo2", "Todo3"),
                Get("Title of the person who handles mail to a website; the U.S.has a \"General\" one?", "Postmaster", "Todo1", "Todo2", "Todo3"),
                Get("To hide a warship's engine noises, Prairie/Masker technology on the ship creates waves of bubbles, an effective tactic for outwitting the passive type of this detection device?", "sonar", "Todo1", "Todo2", "Todo3"),
                Get("To quickly copy text into your computer, use a \"pen\" type of this optical device?", "a scanner", "Todo1", "Todo2", "Todo3"),
                Get("To set up the pictures & clips on my blog, I might need a VGA, this \"array\"?", "video graphics", "Todo1", "Todo2", "Todo3"),
                Get("To stop attackers from accessing your computer, in network settings, shut off the print sharing &this other \"sharing\"?", "file sharing", "Todo1", "Todo2", "Todo3"),
                Get("To stop staining, Farah makes men's slacks coated with this, usually found on cookware	?", "Teflon	", "Todo1", "Todo2", "Todo3"),
                Get("Tom Scholz of the band Boston invented an amplifier that worked like a Walkman & called it this?", "the Rockman", "Todo1", "Todo2", "Todo3"),
                Get("Tony Hawk owns a Huntington Beach company that makes these pieces of sporting equipment?", "skateboards", "Todo1", "Todo2", "Todo3"),
                Get("Type of acid in your car battery?", "sulfuric", "Todo1", "Todo2", "Todo3"),
                Get("Until a 1967 table top model with a smaller electron tube was introduced, this kitchen device was big &pricey?", "Microwave oven", "Todo1", "Todo2", "Todo3"),
                Get("Useful for connecting devices, USB is short for Universal Serial this?", "Bus", "Todo1", "Todo2", "Todo3"),
                Get("Using 8 industrial fans, University of Florida engineers have built a simulator of these with 125 - mph winds?", "a hurricane", "Todo1", "Todo2", "Todo3"),
                Get("Using a kite antenna, he received the first transatlantic wireless message in 1901, the letter S?", "Marconi", "Todo1", "Todo2", "Todo3"),
                Get("We can geek - up your computer by installing a printer, digital camera or any other external device, which is called this in computer speak, from the Greek for \"to carry around\"?", "a peripheral", "Todo1", "Todo2", "Todo3"),
                Get("We're gonna go old school and use keyboard characters to translate my image into this computing code?", "ASCII", "Todo1", "Todo2", "Todo3"),
                Get("When a device can be attached to your computer & install itself, it's PnP, short for this?", "Plug and Play", "Todo1", "Todo2", "Todo3"),
                Get("When a plane travels faster than the speed of sound, it creates this thunderous noise?", "a sonic boom", "Todo1", "Todo2", "Todo3"),
                Get("When you've got too much data for just 1 of these, try RAID, short for a \"redundant array of inexpensive\" ones?", "disks", "Todo1", "Todo2", "Todo3"),
                Get("Wi-Fi technology uses these waves that brought us \"The Chase & Sanborn Hour\" in the 1930s?", "radio waves", "Todo1", "Todo2", "Todo3"),
                Get("Windows is one:OS?", "operating system", "Todo1", "Todo2", "Todo3"),
                Get("With its Ofoto online service & Easyshare cameras, you'll never have to develop this company's film?", "Kodak", "Todo1", "Todo2", "Todo3"),
                Get("You can feel your way around a game using the Dualshock controller for this video game console?", "PlayStation", "Todo1", "Todo2", "Todo3"),
                Get("You can get a special wristband for the iPod Nano; put the nano in the middle & it looks like you're wearing this?", "a watch", "Todo1", "Todo2", "Todo3"),
                Get("You don't need to go to this cell phone company's \"hotspot\" if you want to talk with your \"Sidekick\"?", "T - Mobile", "Todo1", "Todo2", "Todo3"),
                Get("You may have worked with a newfangled cash register called a POS terminal, the POS standing for this?", "point of sale", "Todo1", "Todo2", "Todo3"),
                Get("You'll hear it when making a season pass on this company's genius TV device?", "TiVo", "Todo1", "Todo2", "Todo3"),
                Get("Your AC, air conditioning, probably runs on AC, this?", "alternating current", "Todo1", "Todo2", "Todo3"),
                Get("Your I.T. guy knows \"I.T.\" means this?", "information technology", "Todo1", "Todo2", "Todo3"),
            };

            return gatewayResponses;
        }

        private static GatewayResponse Get(string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            var result = Common.Get(DifficultyLevel.Medium, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
            return result;
        }
    }
}
