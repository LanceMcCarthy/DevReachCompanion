using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevReach2019.MobileAppService.Models
{
    public class Speaker
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public List<string> SocialUrls { get; set; }
    }
}
