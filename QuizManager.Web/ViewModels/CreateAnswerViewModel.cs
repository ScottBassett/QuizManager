using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class CreateAnswerViewModel
    {
        public Answer Answer { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
