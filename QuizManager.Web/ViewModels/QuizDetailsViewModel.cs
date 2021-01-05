using System.Collections.Generic;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class QuizDetailsViewModel
    {
        public Quiz Quiz { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
