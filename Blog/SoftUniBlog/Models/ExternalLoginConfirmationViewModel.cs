using System.ComponentModel.DataAnnotations;

namespace SoftUniBlog.Models
{
    public class ExternalLoginConfirmationViewModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}