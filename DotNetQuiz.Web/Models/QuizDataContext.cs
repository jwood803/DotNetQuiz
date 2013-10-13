namespace DotNetQuiz.Web
{
    using DotNetQuiz.Web.Models;
    using System.Data.Entity;

    public class QuizDataContext : DbContext
    {
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
    }
}