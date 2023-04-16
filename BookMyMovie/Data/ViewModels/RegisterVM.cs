using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyMovie.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name ="Full name")]
        [Required(ErrorMessage ="Full name is required")]
        public string FullName { get; set; }

        [Display(Name ="Email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Confirm password is required")]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
