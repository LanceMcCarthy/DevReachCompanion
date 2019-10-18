using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevReach2019.MobileAppService.Controllers
{
    [Route("api/session")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IRepository<Session> sessionRepository;

        public SessionController(IRepository<Session> repository)
        {
            this.sessionRepository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Session>> List()
        {
            return sessionRepository.GetAll().OrderBy(session => session.StartTime).ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Session> GetItem(string id)
        {
            Session item = sessionRepository.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
