using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizManager.DataAccess.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public int QuizId { get; set; }

        [Required]
        [Display (Name = "Question")]
        public string QuestionName { get; set; }

        public virtual List<Answer> AllAnswers { get; set; }
    }
}