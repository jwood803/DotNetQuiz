namespace DotNetQuiz.Web.Models
{
    public class Answers
    {
        //[AutoIncrement]
        public int AnswersId { get; set; }

        //[References(typeof(Questions))]
        public int QuestionsId { get; set; }
        public string AnswerText { get; set; }
    }
}