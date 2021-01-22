using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess.Models;

namespace QuizManager.DataAccess
{
    public class QuizManagerDbContext : IdentityDbContext
    {
        public QuizManagerDbContext(DbContextOptions<QuizManagerDbContext> options) : base(options)
        { }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Quiz>().HasData(new Quiz
        //    {
        //        Id = 1,
        //        QuizName = "Sports"
        //    });

        //    modelBuilder.Entity<Question>().HasData(new 
        //    {
        //        Id = 1,
        //        QuestionName = "What is the only sport to be played on the moon?",
        //        QuizId = 1
        //    });

        //    modelBuilder.Entity<Answer>().HasData(new 
        //    {
        //        Id = 1,
        //        QuestionId = 1,
        //        AnswerName = "Football",
        //        IsCorrect = false
        //    });

        //    modelBuilder.Entity<Answer>().HasData(new 
        //    {
        //        Id = 2,
        //        QuestionId = 1,
        //        AnswerName = "Tennis",
        //        IsCorrect = false
        //    });

        //    modelBuilder.Entity<Answer>().HasData(new 
        //    {
        //        Id = 3,
        //        QuestionId = 1,
        //        AnswerName = "Rugby",
        //        IsCorrect = false
        //    });

        //    modelBuilder.Entity<Answer>().HasData(new 
        //    {
        //        Id = 4,
        //        QuestionId = 1,
        //        AnswerName = "Golf",
        //        IsCorrect = true
        //    });
        //}
    }
}
