using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Helpers;
using DevReach2019.MobileAppService.Models;

namespace DevReach2019.MobileAppService.Tests.Mocks
{
    public class MockSpeakersRepository : IRepository<Speaker>
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
