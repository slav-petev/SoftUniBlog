using System.ComponentModel.DataAnnotations;

namespace SoftUniBlog.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}