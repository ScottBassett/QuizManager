using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class CreateAnswersViewModel
    {
        public int QuestionId { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
