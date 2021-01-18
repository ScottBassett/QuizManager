using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class EditQuestionViewModel
    {
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
