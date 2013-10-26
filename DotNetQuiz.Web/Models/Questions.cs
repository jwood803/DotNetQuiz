namespace DotNetQuiz.Web.Models
{
    using ServiceStack.DataAnnotations;
    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

    public class Questions
    {
        [AutoIncrement]
        [ScaffoldColumn(false)]
        public int QuestionId { get; set; }
        
        [Display(Name="Question")]
        public string QuestionText { get; set; }

        [References(typeof(Answers))]
        public virtual List<Answers> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public string CorrectAnswerDesc { get; set; }
    }
}