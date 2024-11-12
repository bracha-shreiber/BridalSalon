using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bridal_salon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dressmakerController : ControllerBase
    {
        private static DressmakerService dressmakerServers = new DressmakerService();
        public static Checks<string> checks { get; set; }
        // GET: api/<dressmakerController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dressmakerServers.GetDressmakers());
        }
        // GET api/<dressmakerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpGet("{id}")]
        public ActionResult GetById(string id)
        {
            if(dressmakerServers.GetDressmakerById(id)==null)
                return NotFound();
            return Ok(true);
        }
        
        // POST api/<dressmakerController>
        [HttpPost]
        public ActionResult Post([FromBody] dressmaker value)
        {
            if (value == null || !checks.IsIsraeliIdNumber(value.Id) || !checks.IsValidEmail(value.Email))
                return BadRequest();
            dressmakerServers.PostDressmaker(value);
            return Ok(true);
        }

        // PUT api/<dressmakerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] dressmaker value)
        {
            if (value == null || !checks.IsIsraeliIdNumber(value.Id) || !checks.IsValidEmail(value.Email))
                return BadRequest();
            if (!dressmakerServers.PutDressmaker(id, value))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<dressmakerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if(!dressmakerServers.DeleteDressmaker(id))
                return NotFound();
            return Ok(true);
        }

        public ActionResult MaxExperience()
        {
            return Ok(dressmakerServers.MaxExperience());
        }

        public ActionResult MinPrice()
        {
            return Ok(dressmakerServers.MinPrice());
        }
    }
}
