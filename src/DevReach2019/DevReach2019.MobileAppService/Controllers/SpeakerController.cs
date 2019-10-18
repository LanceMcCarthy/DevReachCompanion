using System.Collections.Generic;
using System.Linq;
using DevReach2019.MobileAppService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevReach2019.MobileAppService.Controllers
{
    [Route("api/speaker")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly IRepository<Speaker> speakerRepository;

        public SpeakerController(IRepository<Speaker> repository)
        {
            this.speakerRepository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Speaker>> List()
        {
            return speakerRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Speaker> GetItem(string id)
        {
            Speaker item = speakerRepository.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }
    }
}
