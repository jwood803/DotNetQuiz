namespace DotNetQuiz.Web.Models
{
    using ServiceStack.DataAnnotations;
    using System.Collections.Generic;

    public class Questions
    {
        [AutoIncrement]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        [References(typeof(Answers))]
        public virtual List<Answers> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public string CorrectAnswerDesc { get; set; }
    }
}