namespace DotNetQuiz.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Questions
    {
        //[AutoIncrement]
        [HiddenInput(DisplayValue=false)]
        public int QuestionId { get; set; }
        
        [Display(Name="Question")]
        public string QuestionText { get; set; }

        //[References(typeof(Answers))]
        public virtual List<Answers> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public string CorrectAnswerDesc { get; set; }
    }
}