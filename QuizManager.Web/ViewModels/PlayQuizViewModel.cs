using System.Linq;
using QuizManager.DataAccess.Models;

namespace QuizManager.Web.ViewModels
{
    public class PlayQuizViewModel
    {
        public Quiz Quiz { get; set; }
        public IQueryable<Question> Questions { get; set; }
        public int PlayerScore { get; set; }
    }
}
