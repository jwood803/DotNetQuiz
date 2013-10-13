using System.ComponentModel.DataAnnotations;
namespace DotNetQuiz.Web.Models
{
    public class Answers
    {
        [Key]
        public int AnswersId { get; set; }
        public int QuestionsId { get; set; }
        public string AnswerText { get; set; }
    }
}