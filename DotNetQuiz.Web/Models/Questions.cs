namespace DotNetQuiz.Web.Models
{
    using ServiceStack.DataAnnotations;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Questions
    {
        [AutoIncrement]
        [HiddenInput(DisplayValue=false)]
        public int QuestionId { get; set; }
        
        [Display(Name="Question")]
        public string QuestionText { get; set; }

        [References(typeof(Answers))]
        public virtual List<Answers> Answers { get; set; }

        [Display(Name="Correct Answer ID")]
        public int CorrectAnswerId { get; set; }

        [Display(Name="Correct Answer Description")]
        public string CorrectAnswerDesc { get; set; }
    }
}