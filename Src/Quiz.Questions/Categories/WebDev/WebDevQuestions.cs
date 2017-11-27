using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.WebDev
{
    internal class WebDevQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.WebDev;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                //webkit=?
                #endregion
                #region jeopardy / web camp training kit
                Common.Get(Category, DifficultyLevel.Hard,
                    "How many HTML tags are defined in the original description of the markup language?",
                    "18",
                    "1",
                    "11",
                    "25"),
                #endregion

                #region http://www.naukrieducation.com/20-top-css-multiple-choice-questions-and-answers-pdf/
                //1. What does CSS stand for?
                //A.Creative Style Sheets
                //B.Colorful Style Sheets
                //C.Cascading Style Sheets
                //D.Computer Style Sheets
                //Ans: C

                //2.What is the correct HTML for referring to an external style sheet ?
                //A. < stylesheet > mystyle.css </ stylesheet />
                //B. < style src =”mystyle.css” />
                //C. < link rel =”stylesheet” type =”text / css” href =”mystyle.css”>
                //Ans: C


                //3.Where in an HTML document is the correct place to refer to an external style sheet ?
                //A.At the end of the document
                //B.In the < head > section
                //C.At the top of the document
                //D.In the < body > section
                //Ans: B


                //4.Which HTML tag is used to define an internal style sheet?
                //A. <style>
                //B. <css>
                //C. <script>
                //Ans: A

                //5. Which HTML attribute is used to define inline styles?
                //A.font
                //B. class
                //C. styles
                //D.style
                //Ans: D

                //6. Which is the correct CSS syntax?

                //A.body { color: black}
                //B. {body;color:black
                //}
                //C. {body:color=black(body}
                //D.body:color=black
                //Ans: A

                //7. How do you insert a comment in a CSS file?
                //A. // this is a comment //
                //B. /* this is a comment */
                //C. ‘ this is a comment
                //D. // this is a comment
                //Ans: B

                //8. Which property is used to change the background color?
                //A.bgcolor:
                //B.background-color:
                //C.color:
                //Ans: background-color:

                //9. How do you add a background color for all<h1> elements?

                //A.all.h1 {
                //background - color:#FFFFFF}
                //B.h1.all {
                //background - color:#FFFFFF}
                //C.h1 {
                //background - color:#FFFFFF}
                //Ans: C

                //10.How do you change the text color of an element?
                //A.text - color =
                //B.fgcolor:
                //C.color:
                //D.text - color:
                //Ans: C

                //11.Which CSS property controls the text size?
                //A.font - size
                //B.font - style
                //C.text - style
                //D.text - size
                //Ans: A

                //12.What is the correct CSS syntax for making all the < p > elements bold ?
                //A. < p style =”text - size:bold”>
                //B.p { font - weight:bold}
                //C.p { text - size:bold}
                //D. < p style =”font - size:bold”>
                //Ans: B

                //13.How do you display hyperlinks without an underline?
                //A.a { text - decoration:no underline}
                //B.a { decoration: no underline}
                //C.a { text - decoration:none}
                //D.a { underline: none}
                //Ans: C

                //14.How do you make each word in a text start with a capital letter?
                //A.text - transform:capitalize
                //B.You can’t do that with CSS
                //C.text - transform:uppercase
                //Ans: A

                //15.How do you change the font of an element?
                //A.font - family:
                //B.font =
                //C.f:
                //Ans: A

                //16.How do you make the text bold?
                //A.font:b
                //B.font - weight:bold
                //C.style:bold
                //Ans: B

                //17.How do you display a border like this:
                //The top border = 10 pixels
                //The bottom border = 5 pixels
                //The left border = 20 pixels
                //The right border = 1pixel?
                //A.border - width:10px 20px 5px 1px
                //B.border - width:10px 1px 5px 20px
                //C.border - width:5px 20px 10px 1px
                //D.border - width:10px 5px 20px 1px
                //Ans: B

                //8.How do you change the left margin of an element?
                //A.margin:
                //B.indent:
                //C.margin - left:
                //D.text - indent:
                //Ans: C

                //19.To define the space between the element’s border and content, you use the padding property, but are you allowed to use negative values?
                //A.Yes
                //B.No
                //Ans: B

                //20.How do you make a list that lists its items with squares?
                //A.list - type: square
                //B.type: square
                //C.type: 2
                //D.list - style - type: square
                //Ans: D
                #endregion
        };

            return quizQuestions;
        }
    }
}
