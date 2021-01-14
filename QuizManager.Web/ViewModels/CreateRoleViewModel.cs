using System.ComponentModel.DataAnnotations;

namespace QuizManager.Web.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
