using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bridal_salon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrideController : ControllerBase
    {
       
        private static BrideService brideServers = new BrideService();

        public static Checks<string> checks = new Checks<string>(); 
        // GET: BrideController
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(brideServers.GetBrides());
        }
        // GET api/<BrideController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpGet("{id}")]
        public ActionResult GetBrideById(string id)
        {
            if(brideServers.GetBrideById(id) == null)
                return NotFound();
            return Ok(true);
        }
        [HttpGet("{BeginHeight}/{LastHeight}")]
        public ActionResult GetByHeight(int BeginHeight, int LastHeight)
        {
            return Ok(brideServers.GetByHeight(BeginHeight, LastHeight));
        }
        // POST api/<BrideController>
        [HttpPost]
        public ActionResult Post([FromBody] Bride value)
        {
            if (value == null || !checks.IsIsraeliIdNumber(value.Id) || !checks.IsValidEmail(value.Email))
                return BadRequest();
            brideServers.PostBride(value);
            return Ok(true);
        }

        // PUT api/<BrideController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Bride value)
        {
            if (value == null || !checks.IsIsraeliIdNumber(value.Id) || !checks.IsValidEmail(value.Email))
                return BadRequest();
            if (!brideServers.PutBride(id, value))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<dressmaBridekerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if (!brideServers.DeleteBride(id))
                return NotFound();
            return Ok(true);
        }

       
    }
}
