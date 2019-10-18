using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Helpers;
using DevReach2019.MobileAppService.Models;

namespace DevReach2019.MobileAppService.Tests.Mocks
{
    public class MockSessionsRepository : IRepository<Session>
    {
        public IEnumerable<Session> GetAll()
        {
            return SessionDataHelper.Sessions;
        }

        public Session Get(string id)
        {
            return SessionDataHelper.Sessions.FirstOrDefault(s => s.Id == id);
        }
    }
}
