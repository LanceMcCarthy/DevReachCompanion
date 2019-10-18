using System;
using System.Collections.Generic;
using DevReach2019.Forms.Common;

namespace DevReach2019.Forms.Models
{
    public class Session : BindableBase, IDataItem
    {
        public string Id { get; set; }

        public List<string> SpeakerIds { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<string> Technology { get; set; }

        public string SessionType { get; set; }

        public List<string> Topic { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Room { get; set; }
    }
}
