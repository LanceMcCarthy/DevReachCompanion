using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Helpers;

namespace DevReach2019.MobileAppService.Models
{
    // TODO Replace with DataBase
    public class SessionRepository : IRepository<Session>
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
