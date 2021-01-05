using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizManager.DataAccess.Models
{
    public class Quiz
    {
        [Key]   
        public int Id { get; set; }

        [Required]
        [Display(Name = "Quiz Name")]
        public string QuizName { get; set; }

        public virtual List<Question> Questions { get; set; }
    }
}
