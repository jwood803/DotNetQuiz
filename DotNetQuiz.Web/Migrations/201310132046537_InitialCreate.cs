namespace DotNetQuiz.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionTitle = c.String(),
                        QuestionText = c.String(),
                        CorrectAnswerId = c.Int(nullable: false),
                        CorrectAnswerDesc = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswersId = c.Int(nullable: false, identity: true),
                        QuestionsId = c.Int(nullable: false),
                        AnswerText = c.String(),
                        Questions_QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.AnswersId)
                .ForeignKey("dbo.Questions", t => t.Questions_QuestionId)
                .Index(t => t.Questions_QuestionId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Answers", new[] { "Questions_QuestionId" });
            DropForeignKey("dbo.Answers", "Questions_QuestionId", "dbo.Questions");
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
        }
    }
}
