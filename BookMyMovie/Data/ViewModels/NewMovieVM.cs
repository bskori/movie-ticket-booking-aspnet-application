using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyMovie.Data.ViewModels
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name="Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Display(Name="Movie description")]
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }

        [Display(Name="Price in $")]
        [Required(ErrorMessage ="Price is required")]
        public double Price { get; set; }

        [Display(Name="Movie poster URL")]
        [Required(ErrorMessage ="Movie poster URL is required")]
        public string ImageUrl { get; set; }

        [Display(Name="Start date")]
        [Required(ErrorMessage ="Movie start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name ="End date")]
        [Required(ErrorMessage ="Movie end date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name="Select a category")]
        [Required(ErrorMessage ="Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name="Select actor(s)")]
        [Required(ErrorMessage ="Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name="Select a cinema")]
        [Required(ErrorMessage ="Movie cinema is required")]
        public int CinemaID { get; set; }

        [Display(Name="Select a producer")]
        [Required(ErrorMessage ="Movie producer is required")]
        public int ProducerID { get; set; }
        
    }
}
