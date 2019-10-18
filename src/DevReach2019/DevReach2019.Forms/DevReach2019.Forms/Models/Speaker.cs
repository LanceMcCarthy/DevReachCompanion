using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevReach2019.Forms.Common;
using Newtonsoft.Json;

namespace DevReach2019.Forms.Models
{
    public class Speaker : BindableBase, IDataItem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        public string Bio { get; set; }

        public string ImageUrl { get; set; }

        public List<string> SocialUrls { get; set; }

        [JsonIgnore]
        public ObservableCollection<Session> Sessions { get; } = new ObservableCollection<Session>();
    }
}
