using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class QuestionIndexViewModel
    {
        public List<Quiz> Quizzes { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
