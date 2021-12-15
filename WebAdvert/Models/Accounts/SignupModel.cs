using System;
using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Models
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage ="Your password must have 6 caracteres")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password is different")]
        [StringLength(6, ErrorMessage = "Your password must have 6 caracteres")]
        public string ConfirmPassword { get; set; }
        public SignupModel()
        {
        }
    }
}
