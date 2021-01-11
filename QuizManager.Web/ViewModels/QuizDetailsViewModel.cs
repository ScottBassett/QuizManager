using System.Collections.Generic;
using System.Linq;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class QuizDetailsViewModel
    {
        public Quiz Quiz { get; set; }
        public IQueryable<Question> Questions { get; set; }
    }
}
