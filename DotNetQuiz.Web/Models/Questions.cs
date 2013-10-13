namespace DotNetQuiz.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }
        public virtual List<Answers> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public string CorrectAnswerDesc { get; set; }
    }
}