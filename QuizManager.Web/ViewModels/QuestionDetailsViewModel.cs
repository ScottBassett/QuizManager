using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class QuestionDetailsViewModel
    {
        public Question Question { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
