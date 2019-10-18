using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Helpers;

namespace DevReach2019.MobileAppService.Models
{
    // TODO Replace with DataBase
    public class SpeakerRepository : IRepository<Speaker>
    {
        public IEnumerable<Speaker> GetAll()
        {
            return SpeakerDataHelper.Speakers;
        }

        public Speaker Get(string id)
        {
            return SpeakerDataHelper.Speakers.FirstOrDefault(s => s.Id == id);
        }
    }
}
