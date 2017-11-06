namespace Quiz.Ui.Gateway
{
    public class QuestionsCocktailHerokuRootObject
    {
        public string text { get; set; }
        public Answer[] answers { get; set; }
    }

    public class Answer
    {
        public bool correct { get; set; }
        public string text { get; set; }
    }
}
