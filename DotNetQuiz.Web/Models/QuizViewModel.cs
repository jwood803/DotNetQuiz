namespace DotNetQuiz.Web.Models
{
    using System.Collections.Generic;

    public class QuizViewModel
    {
        public Questions Questions { get; set; }
        public List<Answers> Answers { get; set; }
    }
}