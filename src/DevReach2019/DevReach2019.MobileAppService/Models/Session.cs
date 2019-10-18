using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevReach2019.MobileAppService.Models
{
    public class Session
    {
        public string Id { get; set; }

        [Required]
        public List<string> SpeakerIds { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public List<string> Technology { get; set; }

        [Required]
        public string SessionType { get; set; }

        [Required]
        public List<string> Topic { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string Room { get; set; }
    }
}
