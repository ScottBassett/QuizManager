using System.ComponentModel.DataAnnotations;

namespace QuizManager.DataAccess.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string AnswerName { get; set; }

        public int QuestionId { get; set; }
    }
}