using BookMyMovie.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyMovie.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture url is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Full name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full shoud between 3 to 50 chars")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
