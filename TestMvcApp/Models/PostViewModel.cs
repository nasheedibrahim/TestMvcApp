using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvcApp.Models
{
    public class PostViewModel
    {
        [Required(ErrorMessage = "Enter pledge name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter a Slugs")]
        public string Slug { get; set; }
        [Required(ErrorMessage = "Write a breif description of the pledge")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Choose a banner image")]
        public IFormFile BannerImage { get; set; }
    }
}
