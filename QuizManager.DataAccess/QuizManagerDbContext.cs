using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess.Models;

namespace QuizManager.DataAccess
{
    public class QuizManagerDbContext : DbContext
    {
        public QuizManagerDbContext(DbContextOptions<QuizManagerDbContext> options) : base(options)
        { }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
