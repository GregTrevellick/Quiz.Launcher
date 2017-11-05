namespace Quiz.Ui.Gateway
{
    public class QuestionsCocktailHerokuRootObject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
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