using System.ComponentModel.DataAnnotations;

namespace QuizManager.DataAccess.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Answer")]
        public string AnswerName { get; set; }

        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }
    }
}