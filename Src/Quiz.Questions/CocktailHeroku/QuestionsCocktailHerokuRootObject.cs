namespace Quiz.Questions.CocktailHeroku
{
    internal class QuestionsCocktailHerokuRootObject
    {
        public string text { get; set; }
        public Answer[] answers { get; set; }
    }

    internal class Answer
    {
        public bool correct { get; set; }
        public string text { get; set; }
    }
}
