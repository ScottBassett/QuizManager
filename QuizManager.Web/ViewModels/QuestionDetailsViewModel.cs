using System.Collections.Generic;
using System.Linq;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class QuestionDetailsViewModel
    {
        public Question Question { get; set; }
        public IQueryable<Answer> Answers { get; set; }
    }
}
