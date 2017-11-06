﻿using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsJeopardy
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                //gregt convert below to proper questions

                ////http://jservice.io/popular/14968
                Get("Wi-Fi technology uses these waves that brought us \"The Chase & Sanborn Hour\" in the 1930s?", "radio waves", "Todo1", "Todo2", "Todo3"),
                Get("Reddit is known for hosting online interviews where you can AMA, short for this?", "ask me anything", "Todo1", "Todo2", "Todo3"),
                Get("This type of \"net\" developed by Xerox has helped local area networks communicate since the 1970s?", "ethernet", "Todo1", "Todo2", "Todo3"),
                Get("We're gonna go old school and use keyboard characters to translate my image into this computing code?","ASCII", "Todo1", "Todo2", "Todo3"),
                Get("It's a big smartphone, it's a small iPad, it's this 7-letter hybrid word?", "phablet", "Todo1", "Todo2", "Todo3"),
                Get("You can get a special wristband for the iPod Nano; put the nano in the middle & it looks like you're wearing this	?","a watch", "Todo1", "Todo2", "Todo3"),
                Get("Sony's S is this type of computer--bigger than a smartphone but smaller than a laptop?","a tablet", "Todo1", "Todo2", "Todo3"),
                Get("My PlayStation 3 lets me enjoy important historical movies in this \"colorful\" format?", "Blu - ray ", "Todo1", "Todo2", "Todo3"),
                Get("To quickly copy text into your computer, use a \"pen\" type of this optical device?", "a scanner ", "Todo1", "Todo2", "Todo3"),
                Get("Connect to the Internet with ease with a wireless one of these--sounds like a seat for your little brother?", "a booster  ", "Todo1", "Todo2", "Todo3"),

                #region

                ////http://jservice.io/popular/17037
                Get("Android's 4.1 O.S. is called this, just like one of Reagan's favorite treats?", "Jelly Bean", "Todo1", "Todo2", "Todo3"),
                Get("32 bits long, an ESN is an \"electronic\" this, used to identify devices?", "serial number", "Todo1", "Todo2", "Todo3"),
                Get("A type of hacker who ethically reports security problems is called this, a proverbial accessory of cowboy heroes?", "    white hat ", "Todo1", "Todo2", "Todo3"),
                Get("In 1991 Apple introduced this media player--would you like to download the latest version?", " QuickTime ", "Todo1", "Todo2", "Todo3"),
                Get("In 2014 Facebook agreed to pay $2 billion for Oculus, a maker of this immersive technology?", " virtual reality	", "Todo1", "Todo2", "Todo3"),

                ////http://jservice.io/popular/17078
                Get("Time to process the Pentium 4 processor from this company?", "  Intel  ", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 23, 2014
                Get("CTR, the Computing-Tabulating-Recording Company, took on this current 3-letter name in 1924?", " IBM ", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//400 April 23, 2014
                Get("Here it is in blue & white: the LaserJet Pro?", "analog", "Todo1", "Todo2", "Todo3"),//400 printer from this brand?", "Hewlett-Packard ", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//600 April 23, 2014
                Get("The stars align with its Galaxy Note II phone?", "Samsung ", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//800 April 23, 2014
                Get("The Multi-Sport GPS watch is made by this company?", "TomTom  ", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    April 23, 2014

                ////http://jservice.io/popular/10511
                Get("This Apple product that was rolled out in 2010 has a 9.7-inch screen & is 1/2 inch thick?","     the iPad", "Todo1", "Todo2", "Todo3"),//  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 March 4, 2011
                Get("Here you can clearly see the logo of this hi-def format for home theaters in 1080p?","   Blu - ray", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//400 March 4, 2011
                Get("smugmug.com lets you share these & back them up pictures(or photographs) ?", "analog", "Todo1", "Todo2", "Todo3"),//600 March 4, 2011
                Get("Copying info from a computer to a CD is called burning; doing the reverse is this other destructive term ripping?", "analog", "Todo1", "Todo2", "Todo3"),//800 March 4, 2011
                Get("Seen here is an icon for this 3 - letter service that feeds you updates on your favorite web sites?","     RSS", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    March 4, 2011
                Get("For a great deal, check out this smallest version of the Apple iPod, even tinier than the Nano?","   the Shuffle", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//200 February 7,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("Motorstorm, Lair & Warhawk are some of the products for this newest Sony entertainment system?", "  the PlayStation 3", "Todo1", "Todo2", "Todo3"),// ?", "analog", "Todo1", "Todo2", "Todo3"),//400 February 7,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("This search engine's Picasa program lets you store, edit & share pictures?"," 	Google", "Todo1", "Todo2", "Todo3"),//	?","analog", "Todo1", "Todo2", "Todo3"),//600	February 7,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("Phishing is not allowed when you use the newest version of this web browser from Mozilla Firefox?", "analog", "Todo1", "Todo2", "Todo3"),//800 February 7,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("You don't need to go to this cell phone company's \"hotspot\" if you want to talk with your \"Sidekick\"?", "   T - Mobile", "Todo1", "Todo2", "Todo3"),//  ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    February 7,?", "analog", "Todo1", "Todo2", "Todo3"),//2007

                ////http://jservice.io/popular/12223
                Get("On Feb. 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2009 this type of TV broadcast technology will end in the U.S.; we're going digital?"," 	analog", "Todo1", "Todo2", "Todo3"),//	?","analog", "Todo1", "Todo2", "Todo3"),//200	December 24,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("This photo co.created the EasyShare printer with prints that are less expensive &last?", "analog", "Todo1", "Todo2", "Todo3"),//100 years?", " Kodak", "Todo1", "Todo2", "Todo3"),// ?", "analog", "Todo1", "Todo2", "Todo3"),//400 December 24,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("In?", "analog", "Todo1", "Todo2", "Todo3"),//2008 lampposts in London were padded to prevent injuries due to this activity by pedestrians?", " texting", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//600 December 24,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("To stop attackers from accessing your computer, in network settings, shut off the print sharing &this other \"sharing\"?", "  file sharing", "Todo1", "Todo2", "Todo3"),//  ?", "analog", "Todo1", "Todo2", "Todo3"),//800 December 24,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("We can geek - up your computer by installing a printer, digital camera or any other external device, which is called this in computer speak, from the Greek for \"to carry around\"?", "     a peripheral", "Todo1", "Todo2", "Todo3"),//  ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    December 24,?", "analog", "Todo1", "Todo2", "Todo3"),//2008

                ////http://jservice.io/popular/17308
                Get("Established in Mountain View in 1956, Shockley Semiconductor helped put this element in the name of a \"valley\"?", " silicon", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//200 February 10, 2014
                Get("Despite the name, the San Jose headquarters of this maker of the creative cloud isn't built of clay bricks?","	Adobe", "Todo1", "Todo2", "Todo3"),//	?","analog", "Todo1", "Todo2", "Todo3"),//400	February 10, 2014
                Get("Tony Hawk owns a Huntington Beach company that makes these pieces of sporting equipment?"," skateboards", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//600 February 10, 2014
                Get("Los Gatos is home to this 40-million member movie & TV streaming business?","   Netflix", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//800 February 10, 2014
                Get("Carlsbad's Callaway makes hi-tech these, like the FT Optiforce	?","golf clubs", "Todo1", "Todo2", "Todo3"),//	?","analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	February 10, 2014

                ////http://jservice.io/popular/17737
                Get("hashtags.org tracks keywords on this social site that popularized the hashtag   Twitter?"," 	analog", "Todo1", "Todo2", "Todo3"),//?", "analog", "Todo1", "Todo2", "Todo3"),//200 October 2, 2013
                Get("The \"G\" in .gif & .png stands for these graphics  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 October 2, 2013
                Get("Record each letter & number typed on a computer with this type of software that sounds like a lumberjack    a keylogger?", "analog", "Todo1", "Todo2", "Todo3"),//600 October 2, 2013
                Get("Google Keep is a digital note - taking app for this \"robotic\" mobile operating system Android?", "analog", "Todo1", "Todo2", "Todo3"),//800 October 2, 2013

                ////http://jservice.io/popular/11075
                Get("Proverbially, one of these \"a day\" keeps the M.D. from your presence    an apple  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 June 16,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("This female warrior of myth mainly dealt with men for 1 reason--procreation; use the singular, please   Amazon?", "analog", "Todo1", "Todo2", "Todo3"),//400 June 16,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("An ancient Greek wanting to know Zeus' will might consult this in a grove of oak trees in Dodona	oracle	?","analog", "Todo1", "Todo2", "Todo3"),//600	June 16,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("It precedes arch in St.Louis   gateway?", "analog", "Todo1", "Todo2", "Todo3"),//800 June 16,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("In?", "analog", "Todo1", "Todo2", "Todo3"),//2007 President Bush said he'd do this "to the finish...that's one way to ensure that I am relevant"	sprint	?","analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	June 16,?", "analog", "Todo1", "Todo2", "Todo3"),//2008

                ////http://jservice.io/popular/348
                Get("Gooo--wait, is it? Yes! Gooooooal! In 2012 this sport's FIFA approved the use of goal-line technology	soccer	?","analog", "Todo1", "Todo2", "Todo3"),//200	June 5, 2013
                Get("This chipmaker, the world's largest, has announced \"systems on a chip\" measuring 22 nanometers	Intel	?","analog", "Todo1", "Todo2", "Todo3"),//600	June 5, 2013
                Get("The name of this colorful wireless headset technology refers to a tech trade association founded in 1998    Bluetooth ?", "analog", "Todo1", "Todo2", "Todo3"),//800 June 5, 2013
                Get("CSIRO has developed technology that helps drain this gas, CH4, released by the mining of coal   methane?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    June 5, 2013
                Get("To hide a warship's engine noises, Prairie/Masker technology on the ship creates waves of bubbles, an effective tactic for outwitting the passive type of this detection device?", "	sonar", "Todo1", "Todo2", "Todo3"),//		June 5, 2013
                Get("Exhaust gas recirculation is one way to clean the emissions of these engines used in trucks & Jettas    Diesel engines?", "analog", "Todo1", "Todo2", "Todo3"),//200 February 19, 2010
                Get("Erase a hard disk before disposing of a computer: putting personal data out there risks this 2 - word crime identity theft?", "analog", "Todo1", "Todo2", "Todo3"),//400 February 19, 2010
                Get("Using 8 industrial fans, University of Florida engineers have built a simulator of these with 125 - mph winds a hurricane?", "analog", "Todo1", "Todo2", "Todo3"),//600 February 19, 2010
                Get("More cardiac arrest patients survive thanks to purposely induced this condition, which cools the blood 5 - 8 degrees hypothermia?", "analog", "Todo1", "Todo2", "Todo3"),//800 February 19, 2010
                Get("These drone aircraft controlled from Nevada have been attacking targets in Pakistan Predator drones?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    February 19, 2010
                Get("As part of its salute to this decade, the Post Office created a stamp with a MixMaster on it the 1930s ?", "analog", "Todo1", "Todo2", "Todo3"),//200 May 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("This engine innovation was introduced in 1940 by GM with the slogan \"No gears to shift! No clutch to press!\"    automatic transmission?", "analog", "Todo1", "Todo2", "Todo3"),//400 May 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("On Feb. 29,?", "analog", "Todo1", "Todo2", "Todo3"),//2008 Blu - Ray emerged as the new video disc choice as this Japanese co. abandoned its HD - DVD format Toshiba?", "analog", "Todo1", "Todo2", "Todo3"),//600 May 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("Fingerprint ID devices are part of this security technology, from the Greek for \"life\" & \"measure\"  biometric ?", "analog", "Todo1", "Todo2", "Todo3"),//800 May 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("The engine control unit, a car's smartest computer, monitors systems like injection of this	fuel	?","analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	May 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2008
                Get("Suggestions on what to call this device ranged from farscope to telebaird   Television?", "analog", "Todo1", "Todo2", "Todo3"),//100 April 20, 1999
                Get("Hubert Booth, not Herbert Hoover, developed the first practical electric one of these in 1901   Vacuum cleaner?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 20, 1999
                Get("In 1982 one of these vehicles deployed a satellite for the first time   Space shuttle ?", "analog", "Todo1", "Todo2", "Todo3"),//300 April 20, 1999
                Get("On August 12, 1981 the world saw the first IBM personal computer using this Microsoft operating system MS-DOS?", "analog", "Todo1", "Todo2", "Todo3"),//500 April 20, 1999
                Get("Until a 1967 table top model with a smaller electron tube was introduced, this kitchen device was big &pricey?", "  Microwave oven", "Todo1", "Todo2", "Todo3"),//      April 20, 1999
                Get("Number of bulbs in the Magicube that replaced a battery-powered flash on cameras    4 ?", "analog", "Todo1", "Todo2", "Todo3"),//100 December 5, 1997
                Get("The IBM \"computer\" of 1928 stored its data on these Punch cards?", "analog", "Todo1", "Todo2", "Todo3"),//200 December 5, 1997
                Get("Laser beams are \"directed\" by these optical devices Mirrors?", "analog", "Todo1", "Todo2", "Todo3"),//300 December 5, 1997
                Get("This brand of garbage disposer invented by John Hammes is celebrating its 60th anniversary in 1998  InSinkErator  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 December 5, 1997
                Get("In 1908 a carbon tetrachloride gas type of this was invented; in 1917 a foam type Fire extinguishers?", "analog", "Todo1", "Todo2", "Todo3"),//500 December 5, 1997
                Get("Your AC, air conditioning, probably runs on AC, this    alternating current?", "analog", "Todo1", "Todo2", "Todo3"),//100 September 23, 1996
                Get("Device that stealth aircraft technology is designed to trick radar ?", "analog", "Todo1", "Todo2", "Todo3"),//200 September 23, 1996
                Get("At the 1939 New York World's Fair, the robot Elektro was accompanied by Sparko, a robot one of these	a dog	?","analog", "Todo1", "Todo2", "Todo3"),//300	September 23, 1996
                Get("The smallest units of information stored in a computer, they form bytes bits  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 September 23, 1996
                Get("In 1981 the Solar Challenger was a solar-powered plane & in 1977 the Gossamer Condor was powered by this    human power(pedaling)?", "analog", "Todo1", "Todo2", "Todo3"),//500 September 23, 1996
                Get("A box of 64 Crayola crayons has one of these devices \"built-in\" a sharpener?", "analog", "Todo1", "Todo2", "Todo3"),//100 June 29, 1993
                Get("In 1835 C.S.A.Thilorier froze this gas to create the first \"dry ice\"   carbon dioxide?", "analog", "Todo1", "Todo2", "Todo3"),//200 June 29, 1993
                Get("After hearing this invention of his work, Edison said, \"I was never so taken aback in my life\"  the phonograph?", "analog", "Todo1", "Todo2", "Todo3"),//300 June 29, 1993
                Get("C.Vanderbilt thought George Westinghouse's idea of stopping a train by this means a fool notion	the air brake	?","analog", "Todo1", "Todo2", "Todo3"),//400	June 29, 1993
                Get("First built in 1960, it's also been called an optical maser	laser	?","analog", "Todo1", "Todo2", "Todo3"),//500	June 29, 1993
                Get("In July 1991 IBM & this rival announced a technology alliance Apple ?", "analog", "Todo1", "Todo2", "Todo3"),//100 November 6, 1991
                Get("Drawings discovered in 1967 showed this artist invented the chain drive around 1492 Leonardo da Vinci ?", "analog", "Todo1", "Todo2", "Todo3"),//200 November 6, 1991
                Get("In 1960 Theodore Maiman used this gem in his laser  Ruby  ?", "analog", "Todo1", "Todo2", "Todo3"),//300 November 6, 1991
                Get("Bell invented it in 1876; David Hughes gave it this name in 1878, &don't lean into it when you reply	Microphone	?","analog", "Todo1", "Todo2", "Todo3"),//400	November 6, 1991
                Get("Christiaan Huygens got into the swing of things in 1656 by adding this to the clock Pendulum  ?", "analog", "Todo1", "Todo2", "Todo3"),//500 November 6, 1991
                Get("In 1981 this company introduced the PC, its first home computer IBM?", "analog", "Todo1", "Todo2", "Todo3"),//100 April 18, 1990
                Get("This Italian city, known for its flooding, plans to build sea gates to control flow from the Adriatic   Venice?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 18, 1990
                Get("The Museum of Broadcasting is transferring masters of all its shows from analog videotape to this type  digital tape  ?", "analog", "Todo1", "Todo2", "Todo3"),//300 April 18, 1990
                Get("The USSR lost contact with its Phobos 2 craft before it landed on Phobos, a moon of this planet Mars  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 18, 1990
                Get("A semiconductor diode is the most common of these devices that convert A.C.to D.C.rectifiers?", "analog", "Todo1", "Todo2", "Todo3"),//500 April 18, 1990
                Get("During the 15th - 17th centuries these developed from the matchlock to the wheellock to the flintlock guns  ?", "analog", "Todo1", "Todo2", "Todo3"),//100 November 20, 1989
                Get("In 1861, Elisha Otis patented an elevator driven by this, not electricity   steam ?", "analog", "Todo1", "Todo2", "Todo3"),//200 November 20, 1989
                Get("Thomas Edison's cylindrical ones were superceded by Emile Berliner's flat variety   phonograph records?", "analog", "Todo1", "Todo2", "Todo3"),//300 November 20, 1989
                Get("The two most common types of mechanical clocks are driven by weights or these   springs?", "analog", "Todo1", "Todo2", "Todo3"),//400 November 20, 1989
                Get("In 1983 Apple's Lisa computer gave PCs this device that moves the cursor around the screen	mouse	?","analog", "Todo1", "Todo2", "Todo3"),//500	November 20, 1989
                Get("Term for a moving stairway, it was originally a trademark of the Otis Elevator Co.Escalator ?", "analog", "Todo1", "Todo2", "Todo3"),//100 November 14, 1988
                Get("At the touch of a button on July 1, 1939, this Clay Puett invention made its horse - racing debut Electric Starting Gate?", "analog", "Todo1", "Todo2", "Todo3"),//200 November 14, 1988
                Get("A 1947 book trumpeted the fact that this new invention could be used to locate thunderstorms    Radar ?", "analog", "Todo1", "Todo2", "Todo3"),//300 November 14, 1988
                Get("Charles Goodyear vulcanized rubber, and this Charles used rubber to waterproof cloth    Macintosh ?", "analog", "Todo1", "Todo2", "Todo3"),//400 November 14, 1988
                Get("The reason the transistor was invented was to make this piece of equipment work better  Telephone(switcher)  ?", "analog", "Todo1", "Todo2", "Todo3"),//500 November 14, 1988
                Get("Le Bureau International de l'Heure in Paris is the keeper of this for the world	time	?","analog", "Todo1", "Todo2", "Todo3"),//100	April 22, 1987
                Get("On a single digit LED readout, number shown when all 7 LEDs are lit 8 ?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 22, 1987
                Get("Replacing germanium with this in transistors got a California \"Valley\" named after it   silicon?", "analog", "Todo1", "Todo2", "Todo3"),//300 April 22, 1987
                Get("In 1904, this ex - shoe salesman & Illinois medical school graduate patented his arch support Dr.Scholl?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 22, 1987
                Get("Term for any gas that pressurizes the liquid in an aerosol can  propellant?", "analog", "Todo1", "Todo2", "Todo3"),//500 April 22, 1987
                Get("Though not always accurate, a polygraph machine is supposed to show if you are doing this   lying ?", "analog", "Todo1", "Todo2", "Todo3"),//100 February 5, 1987
                Get("Calculating device developed in ancient times which the Chinese call a \"reckoning board\"    abacus?", "analog", "Todo1", "Todo2", "Todo3"),//200 February 5, 1987
                Get("Type of acid in your car battery sulfuric  ?", "analog", "Todo1", "Todo2", "Todo3"),//300 February 5, 1987

                ////http://jservice.io/popular/950
                Get("Social insects, termites live in groups of a few hundred to several million called these    colonies  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 October 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("Dioxide of this element, symbol Cr, is used to make recording tape for cassettes chromium  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 October 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("The Cassini spacecraft is scheduled to study this planet & send a probe to the surface of its moon Titan    Saturn?", "analog", "Todo1", "Todo2", "Todo3"),//600 October 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("The name of this pivoted frame for the combustion chamber & nozzle of a rocket sounds like Macy's one-time rival	a gimbal	?","analog", "Todo1", "Todo2", "Todo3"),//800	October 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("This biologist first gained acclaim for writing in1937 with her article \"Undersea\" in the Atlantic Monthly  Rachel Carson ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    October 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("On Oct. 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2003 it became the third country to launch a man into space; the Shenzhou 5 spacecraft orbited the Earth 14 times China ?", "analog", "Todo1", "Todo2", "Todo3"),//200 March 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("In 1901 Eugene Demarcay discovered Eu, this rare - earth metal that's named for a continent	Europium	?","analog", "Todo1", "Todo2", "Todo3"),//400	March 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("If an atom loses one of these, it becomes a cation, a positively charged ion electron  ?", "analog", "Todo1", "Todo2", "Todo3"),//600 March 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("In the 1940s, Dr.William Sewell created an artificial one of these, using parts from an erector set an artificial heart?", "analog", "Todo1", "Todo2", "Todo3"),//800 March 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("The tokamak, this type of nuclear reactor, uses plasma heated to 180 million degrees as fuel    fusion?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    March 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2004
                Get("Nearly 25 percent of U.S.teens now own one of these phones, so there's no excuse for not calling home	a cell phone	?","analog", "Todo1", "Todo2", "Todo3"),//200	April 30,?", "analog", "Todo1", "Todo2", "Todo3"),//2002
                Get("Automaton is sometimes just a fancy name for one of these mechanical beings a robot?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 30,?", "analog", "Todo1", "Todo2", "Todo3"),//2002
                Get("When a plane travels faster than the speed of sound, it creates this thunderous noise   a sonic boom  ?", "analog", "Todo1", "Todo2", "Todo3"),//600 April 30,?", "analog", "Todo1", "Todo2", "Todo3"),//2002
                Get("The Celsius temperature scale is also called this, meaning \"divided into one hundred parts\" centigrade?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    April 30,?", "analog", "Todo1", "Todo2", "Todo3"),//2002
                Get("An empty Goodyear blimp weighs over 12, 000 lbs.; when they fill it with this gas, it weighs only?", "analog", "Todo1", "Todo2", "Todo3"),//100 to?", "analog", "Todo1", "Todo2", "Todo3"),//200 pounds helium      April 30,?", "analog", "Todo1", "Todo2", "Todo3"),//2002
                Get("This unit of weight is abbreviated mg.	Milligram ?", "analog", "Todo1", "Todo2", "Todo3"),//100 January 31, 1996
                Get("The first modern ones of these, called Lucifers, were invented in 1827 & struck on sandpaper    Matches?", "analog", "Todo1", "Todo2", "Todo3"),//200 January 31, 1996
                Get("To stop staining, Farah makes men's slacks coated with this, usually found on cookware	Teflon	?","analog", "Todo1", "Todo2", "Todo3"),//300	January 31, 1996
                Get("Hans Lippershey, who invented this instrument in 1608, called it a \"looker\" Telescope ?", "analog", "Todo1", "Todo2", "Todo3"),//400 January 31, 1996
                Get("Cesium was the first element found by this process using the band of colored light produced by a prism Spectroscopy  ?", "analog", "Todo1", "Todo2", "Todo3"),//500 January 31, 1996
                Get("In 1982 the Jarvik-7, the first permanent one of these, was implanted in patient Barney Clark an artificial heart?", "analog", "Todo1", "Todo2", "Todo3"),//100 June 30, 1993
                Get("Using a kite antenna, he received the first transatlantic wireless message in 1901, the letter S Marconi?", "analog", "Todo1", "Todo2", "Todo3"),//200 June 30, 1993
                Get("In 1611 Johannes Kepler introduced a second convex lens, giving this instrument greater power a telescope?", "analog", "Todo1", "Todo2", "Todo3"),//300 June 30, 1993
                Get("Buckminster Fuller used \"energetic synergetic geometry\" to build these structures   geodesic domes?", "analog", "Todo1", "Todo2", "Todo3"),//400 June 30, 1993
                Get("The 1st automated instrument to analyze this genetic material's structure was developed in the mid-1980s	DNA	?","analog", "Todo1", "Todo2", "Todo3"),//500	June 30, 1993
                Get("Advertisers have discovered they can send ads instantaneously with this telephone technology    Fax Machine?", "analog", "Todo1", "Todo2", "Todo3"),//100 December 8, 1989
                Get("John Roebling designed this bridge across the East River, the oldest suspension bridge in NYC The Brooklyn Bridge?", "analog", "Todo1", "Todo2", "Todo3"),//200 December 8, 1989
                Get("HDTV, which uses more lines to give clearer pictures, stands for this   High Definition Television?", "analog", "Todo1", "Todo2", "Todo3"),//300 December 8, 1989
                Get("In 1989 scientists using a scanning tunneling microscope saw this double-stranded molecule for the 1st time DNA?", "analog", "Todo1", "Todo2", "Todo3"),//400 December 8, 1989
                Get("GOES, INSAT & METEOSAT are satellites used for this purpose Weather Forecasting?", "analog", "Todo1", "Todo2", "Todo3"),//500 December 8, 1989

                //http://jservice.io/popular/9357
                Get("Men who hate asking for directions need a product by Garmin or Magellan using GPS, this type of \"system\"    a global positioning system?", "analog", "Todo1", "Todo2", "Todo3"),//200 June 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("The \"Pearl\" model of this Research In Motion device is an e - mail client, media player, camera &cell phone the BlackBerry?", "analog", "Todo1", "Todo2", "Todo3"),//400 June 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("If you want true high def, see your way to finding this company's Bravia TV line	Sony	?","analog", "Todo1", "Todo2", "Todo3"),//600	June 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("A common way of linking computers in the office is this type of local area networking technology, which uses a Cat5 cable with a special connector   ethernet  ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    June 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("This technology used for wireless headsets is named after a Danish king who united parts of Scandinavia Bluetooth       June 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2007
                Get("In 1946 Del Harder of this auto co.coined the term \"automation\" to describe the way its engines were assembled Ford  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 11,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("In 1995 Wells Fargo became the first bank whose customers could securely view their accounts here   online?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 11,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("A hydroelectric power plant at this U.S.landmark opened in 1881    Niagara Falls ?", "analog", "Todo1", "Todo2", "Todo3"),//600 April 11,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("Tom Scholz of the band Boston invented an amplifier that worked like a Walkman & called it this the Rockman?", "analog", "Todo1", "Todo2", "Todo3"),//800 April 11,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("Put pulped cellulose fiber mixed with water & fillers into a Fourdrinier machine & it comes out as this paper ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    April 11,?", "analog", "Todo1", "Todo2", "Todo3"),//2006

                //http://jservice.io/popular/11877
                Get("Sealy makes these with \"advanced memory foam technology\"    mattresses?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 8,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("In?", "analog", "Todo1", "Todo2", "Todo3"),//2008 Michael Phelps & NASA teamed to reduce drag on these & created "the world's fastest" one    a swimsuit?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 8,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("The February?", "analog", "Todo1", "Todo2", "Todo3"),//2008 decision to abandon HD DVD technology gave a market victory to this rival video format    Blu-ray?", "analog", "Todo1", "Todo2", "Todo3"),//600 April 8,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("Los Alamos now has the fastest computer; it was designed using technology from this Sony gaming system PlayStation 3 ?", "analog", "Todo1", "Todo2", "Todo3"),//800 April 8,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("ASIMO, one of these, differentiates multiple voices using 8 microphones & Hark software a robot?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    April 8,?", "analog", "Todo1", "Todo2", "Todo3"),//2009

                //http://jservice.io/popular/8029
                Get("This computer device slowly takes you online    a modem?", "analog", "Todo1", "Todo2", "Todo3"),//200 July 21,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("In 1859 Robert Fouls invented a steam-powered one of these to singal imperiled ships    a foghorn ?", "analog", "Todo1", "Todo2", "Todo3"),//400 July 21,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("I'll bet Christmas 1996 was the last time you thought you'd hear this toy's sound	Tickle Me Elmo	?","analog", "Todo1", "Todo2", "Todo3"),//600	July 21,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("This phone company's walkie talkie service sounds promising	Nextel	?","analog", "Todo1", "Todo2", "Todo3"),//800	July 21,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("You'll hear it when making a season pass on this company's genius TV device TiVo  ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    July 21,?", "analog", "Todo1", "Todo2", "Todo3"),//2005

                //http://jservice.io/popular/8571
                Get("The Nomad Jukebox Zen Xtra is a device which plays music in this alphanumeric format    MP3?", "analog", "Todo1", "Todo2", "Todo3"),//200 January 31,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("\"N-Gage\" with this company's cell phone, wihch is also a portable game	Nokia	?","analog", "Todo1", "Todo2", "Todo3"),//400	January 31,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("You can feel your way around a game using the Dualshock controller for this video game console  PlayStation?", "analog", "Todo1", "Todo2", "Todo3"),//600 January 31,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("This company that sells Dimension computers now sells a GPS system for the Axim PDAs    Dell  ?", "analog", "Todo1", "Todo2", "Todo3"),//800 January 31,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("With its Ofoto online service & Easyshare cameras, you'll never have to develop this company's film Kodak ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    January 31,?", "analog", "Todo1", "Todo2", "Todo3"),//2005

                //http://jservice.io/popular/18254
                Get("Giving a play-by-play of an event while on Twitter is called doing this	live tweeting	?","analog", "Todo1", "Todo2", "Todo3"),//200	March 12, 2015
                Get("This 4-letter word is \"warm\" when the computer's power is already on, \"cold\" when it's off boot	?","analog", "Todo1", "Todo2", "Todo3"),//400	March 12, 2015
                Get("In Windows hitting Ctrl-C & Ctrl-V performs these 2 artsy & crafty actions copy & paste	?","analog", "Todo1", "Todo2", "Todo3"),//600	March 12, 2015
                Get("This process that maximizes disk space is so named because it joins up pieces of files that were stored separately defrag (or defragmenting)	?","analog", "Todo1", "Todo2", "Todo3"),//800	March 12, 2015
                Get("Releasing someone's personal info on the Internet is this word that can have 1 or 2 \"X\"s in the middle	doxing (or doxxing)	?","analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	March 12, 2015

                //http://jservice.io/popular/16244
                Get("Apple's Leopard is a type of OS, one of these	an operating system	?","analog", "Todo1", "Todo2", "Todo3"),//200	February 19, 2013
                Get("The \"HT\" in both HTTP & HTML stands for this    hypertext ?", "analog", "Todo1", "Todo2", "Todo3"),//400 February 19, 2013
                Get("If your machine is being controlled by someone else, it may have been taken over by this 3 - letter piece of malware  a bot ?", "analog", "Todo1", "Todo2", "Todo3"),//600 February 19, 2013
                Get("To set up the pictures & clips on my blog, I might need a VGA, this \"array\" video graphics?", "analog", "Todo1", "Todo2", "Todo3"),//800 February 19, 2013
                Get("Send me that report as a PDF, this \"format\" portable document format  ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    February 19, 2013

                //http://jservice.io/popular/16775
                Get("A class in school, or a record of where you've gone in a web browser	history	?","analog", "Todo1", "Todo2", "Todo3"),//200	July 29, 2014
                Get("A single processor sharing multiple jobs is doing this, like when Mom tries to drive & put on makeup multitasking	?","analog", "Todo1", "Todo2", "Todo3"),//400	July 29, 2014
                Get("Before a game's release, Joe Gamer may be asked to play a pre-version usually referred to by this Greek letter	beta	?","analog", "Todo1", "Todo2", "Todo3"),//600	July 29, 2014
                Get("You may have worked with a newfangled cash register called a POS terminal, the POS standing for this point of sale ?", "analog", "Todo1", "Todo2", "Todo3"),//800	July 29, 2014
                Get("imgur.com has a button to make this four-letter cultural reference that often spreads online a meme?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	July 29, 2014

                //http://jservice.io/popular/17140
                Get("The \"B\" in COBOL    business  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 April 4, 2014
                Get("The \"P\" in jpeg photographic  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 April 4, 2014
                Get("The \"D\" in a DoS attack denial?", "analog", "Todo1", "Todo2", "Todo3"),//600 April 4, 2014
                Get("The second \"T\" in HTTP  transfer or transport ?", "analog", "Todo1", "Todo2", "Todo3"),//800 April 4, 2014
                Get("The \"RT\" in \"RTOS\"  real-time ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    April 4, 2014

                //http://jservice.io/popular/15702
                Get("In?", "analog", "Todo1", "Todo2", "Todo3"),//2008 an IBM supercomputer named for this speedy state bird broke the 1 petaflop barrier--that's really fast	a roadrunner	?","analog", "Todo1", "Todo2", "Todo3"),//200	September 21, 2011
                Get("Most modern supercomputers run on this operating system developed by Linus Torvalds Linux ?", "analog", "Todo1", "Todo2", "Todo3"),//400 September 21, 2011
                Get("In 1998 Deep Crack, designed for this science from the Greek for \"hidden writing\", broke the standard U.S.data cipher  cryptography  ?", "analog", "Todo1", "Todo2", "Todo3"),//600 September 21, 2011
                Get("Thinking Machines Corp.pioneered this processing-- as the geometric name indicates, many processors work side by side  parallel processing?", "analog", "Todo1", "Todo2", "Todo3"),//800 September 21, 2011

                //http://jservice.io/popular/4521
                Get("Title of the person who handles mail to a website; the U.S.has a \"General\" one Postmaster?", "analog", "Todo1", "Todo2", "Todo3"),//100 February 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2000
                Get("SYSADMIN, one who maintains a computer network, is short for this     ?", "System administrator", "Todo1", "Todo2", "Todo3"),//200 February 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2000
                Get("This 4 - letter word from Sanskrit means someone who is a computer knowledge resource Guru  ?", "analog", "Todo1", "Todo2", "Todo3"),//300 February 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2000
                Get("A stupid or inept internet user can be called this 3 - digit number that means \"File Not Found\"   ?", "404", "Todo1", "Todo2", "Todo3"),//400 February 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2000
                Get("Like a villain in darkness, one who reads others' words in a newsgroup but won't contribute is doing this   ?", "Lurking", "Todo1", "Todo2", "Todo3"),//500 February 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2000

                //http://jservice.io/popular/5528
                Get("According to Moore's Law, named for a founder of Intel, these double in power roughly every 18 months	computer chips	?","analog", "Todo1", "Todo2", "Todo3"),//100	February 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2001
                Get("Dan Bricklin developed VISICALC, the first of these programs, similar to an accounting ledger   spreadsheet?", "analog", "Todo1", "Todo2", "Todo3"),//200 February 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2001
                Get("Coherant & Xenix are 2 of these, part of the abbreviation in the better-known MS-DOS    operating systems ?", "analog", "Todo1", "Todo2", "Todo3"),//300 February 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2001
                Get("This programming language was named for calculating - machine inventor Blaise PASCAL?", "analog", "Todo1", "Todo2", "Todo3"),//400 February 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2001
                Get("Among Internet users, the World Wide Web has surpassed the system named for this burrowing rodent   gopher?", "analog", "Todo1", "Todo2", "Todo3"),//500 February 1,?", "analog", "Todo1", "Todo2", "Todo3"),//2001

                //http://jservice.io/popular/9539
                Get("Of Flash, Google or AltaVista, the one that's not a popular Internet search engine	Flash	?","analog", "Todo1", "Todo2", "Todo3"),//200	February 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("This 2-letter Windows computer operating system was introduced in October?", "analog", "Todo1", "Todo2", "Todo3"),//2001  XP?", "analog", "Todo1", "Todo2", "Todo3"),//400 February 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("Abbreviated BB, it's a popular data-transmission method capable of sending multiple channels at once	broadband	?","analog", "Todo1", "Todo2", "Todo3"),//600	February 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("In computerese, it's what the P stands for in the abbreviation HTTP	protocol	?","analog", "Todo1", "Todo2", "Todo3"),//800	February 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("The forerunner to the Internet known as the ARPANET was a 1960s network by this U.S. government dept.   Defense?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    February 17,?", "analog", "Todo1", "Todo2", "Todo3"),//2006

                //http://jservice.io/popular/9242
                Get("This \"high-flying\" computer program from Adobe converts other types of documents into a PDF file   ?", "Acrobat", "Todo1", "Todo2", "Todo3"),//200 May 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("A synonym for \"flowing\", it's the type of video you can watch when you visit us at jeopardy.com		?","streaming", "Todo1", "Todo2", "Todo3"),//400	May 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("This popular Internet service provider began as QCS, Quantum Computer Services    ?", "AOL(America Online)", "Todo1", "Todo2", "Todo3"),//600 May 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("From the Old English for \"clasp\" & \"table\", it's where anything you \"cut\" or \"copy\" is stored until you \"paste\"		?","a clipboard", "Todo1", "Todo2", "Todo3"),//800	May 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("It can be a hiding place for food or treasure, or a place for memory on a computer's motherboard		?","a cache", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000	May 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2006

                //http://jservice.io/popular/9726
                Get("When you've got too much data for just 1 of these, try RAID, short for a \"redundant array of inexpensive\" ones	disks	?","analog", "Todo1", "Todo2", "Todo3"),//200	December 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("A spooler, a program that puts jobs in a queue to be done one at a time, is usually associated with this type of job    printing  ?", "analog", "Todo1", "Todo2", "Todo3"),//400 December 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("The ROM of your computer's CD-ROM stands for this	read-only memory	?","analog", "Todo1", "Todo2", "Todo3"),//600	December 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("2-word term for something nice to wear in winter, or for restarting a computer without turning off the power    warm boot ?", "analog", "Todo1", "Todo2", "Todo3"),//800 December 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2005
                Get("On a monitor, 1280 x 1024 pixels is called \"native\" this, the degree of detail & sharpness  resolution?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    December 15,?", "analog", "Todo1", "Todo2", "Todo3"),//2005

                //http://jservice.io/popular/10873
                Get("This word for fire is also an abusive note on a message board or in a chat room flame ?", "analog", "Todo1", "Todo2", "Todo3"),//200 October 9,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("No relation to DC Comics' fastest man, this is the fast-loading animation by Adobe	Flash	?","analog", "Todo1", "Todo2", "Todo3"),//400	October 9,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("When a device can be attached to your computer & install itself, it's PnP, short for this	Plug and Play	?","analog", "Todo1", "Todo2", "Todo3"),//600	October 9,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("This word meaning to deal a blow is now a word for one look at a website    a hit ?", "analog", "Todo1", "Todo2", "Todo3"),//800 October 9,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("In chat rooms, \"YMMV\" is this disclaimer often used in car ads; it basically lets you off the hook for anything you say your mileage may vary ?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    October 9,?", "analog", "Todo1", "Todo2", "Todo3"),//2006

                //http://jservice.io/popular/11626
                Get("Windows is one:OS operating system  ?", "analog", "Todo1", "Todo2", "Todo3"),//200 June 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("Hello: IM instant message?", "analog", "Todo1", "Todo2", "Todo3"),//400 June 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("It's the brains of the operation:CPU	central processing unit	?","analog", "Todo1", "Todo2", "Todo3"),//600	June 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("It's a measure of speed:BPS		?","bytes per second", "Todo1", "Todo2", "Todo3"),//800	June 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("A regional computer linker:LAN local area network?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    June 19,?", "analog", "Todo1", "Todo2", "Todo3"),//2009

                //http://jservice.io/popular/10929
                Get("This removable item used for data storage was introduced in 1971; the first one was 8 inches square floppy disk?", "analog", "Todo1", "Todo2", "Todo3"),//200 September 14,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("This computer was introduced in 1984 & came with a MacWrite text program & a MacPaint program for graphics Apple Macintosh?", "analog", "Todo1", "Todo2", "Todo3"),//400 September 14,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("This company whose name is synonymous with copying introduced the first hand - held mouse in 1973 Xerox ?", "analog", "Todo1", "Todo2", "Todo3"),//600 September 14,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("Even before all the polls closed, CBS used this huge computer to predict the result of the 1952 presidential election   UNIVAC?", "analog", "Todo1", "Todo2", "Todo3"),//800 September 14,?", "analog", "Todo1", "Todo2", "Todo3"),//2006
                Get("In 1993 Intel introduced this new chip, which had 3.1 million transistors   Pentium?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    September 14,?", "analog", "Todo1", "Todo2", "Todo3"),//2006

                //http://jservice.io/popular/13365
                Get("Your I.T. guy knows \"I.T.\" means this   ?", "  information technology", "Todo1", "Todo2", "Todo3"),//200 November 27,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("Useful for connecting devices, USB is short for Universal Serial this   Bus?", "analog", "Todo1", "Todo2", "Todo3"),//400 November 27,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("In the abbreviation JPEG, the \"P\" is this 12 - letter adjective   Photographic  ?", "analog", "Todo1", "Todo2", "Todo3"),//600 November 27,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("\"DOS\" stands for these 3 words  disk operating system ?", "analog", "Todo1", "Todo2", "Todo3"),//800 November 27,?", "analog", "Todo1", "Todo2", "Todo3"),//2009
                Get("\"DSL\" is \"digital\" this \"line\"  subscriber?", "analog", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    November 27,?", "analog", "Todo1", "Todo2", "Todo3"),//2009

                ////http://jservice.io/popular/13737
                Get("Ace & True Value both serve as this type of store     ?", "  hardware", "Todo1", "Todo2", "Todo3"),//200 June 22, 2011
                Get("The mental capacity to recall facts, or a show-stopping number from \"Cats\"  ?", "  memory", "Todo1", "Todo2", "Todo3"),//400 June 22, 2011
                Get("Casement, bow & double-hung are these  ?", "  windows", "Todo1", "Todo2", "Todo3"),//600 June 22, 2011
                Get("One-word name for the lizard seen here--remember the category!monitor?", "analog", "Todo1", "Todo2", "Todo3"),//800 June 22, 2011
                Get("A swelling under the eye, or a quiet, timid person   ?", "  mouse", "Todo1", "Todo2", "Todo3"),//?","analog", "Todo1", "Todo2", "Todo3"),//1000    June 22, 2011   

                #endregion
            };

            return gatewayResponses;
        }

        private static GatewayResponse Get(string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2  , string wrongAnswer3 )
        {
            var result = Common.Get(DifficultyLevel.Medium, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
            return result;
        }
    }
}
