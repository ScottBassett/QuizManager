using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess;
using Moq;
using QuizManager.DataAccess.Models;
using QuizManager.Web.Controllers;
using Xunit;

namespace QuizManager.Tests
{
    public class QuizzesControllerTests
    {
        [Fact]
        public async void CreateQuizTest()
        {
            // Arrange
            DbContextOptions<QuizManagerDbContext> options = new DbContextOptionsBuilder<QuizManagerDbContext>()
                .UseInMemoryDatabase(databaseName: "testDb")
                .Options;

            var context = new QuizManagerDbContext(options);

            var quizzesController = new QuizzesController(context);

            var testQuizName = "Test Quiz";

            var testQuiz = new Quiz
            {
                Id = 1,
                QuizName = testQuizName
            };

            var mockTempData = new Mock<ITempDataDictionary>();
            quizzesController.TempData = mockTempData.Object;

            // Act
            await quizzesController.Create(testQuiz);

            // Assert
            var quiz = await context.Quizzes.Where(q => q.QuizName == testQuiz.QuizName).FirstOrDefaultAsync();

            Assert.NotNull(quiz);
            Assert.Equal(testQuiz.Id, quiz.Id);

        }
    }
}
