using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bridal_salon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dressmakerController : ControllerBase
    {
        private DressmakerServers dressmakerServers = new DressmakerServers();
        // GET: api/<dressmakerController>
        [HttpGet]
        public List<dressmaker> Get()
        {
            return dressmakerServers.GetDressmakers();
        }
        // GET api/<dressmakerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<dressmakerController>
        [HttpPost]
        public dressmaker Post([FromBody] dressmaker value)
        {
            var item = dressmakerServers.PostDressmaker(value);
            return item;
        }

        // PUT api/<dressmakerController>/5
        [HttpPut("{id}")]
        public dressmaker Put(int id, [FromBody] dressmaker value)
        {
            var item = dressmakerServers.PutDressmaker(id, value);
            return item;
        }

        // DELETE api/<dressmakerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dressmakerServers.DeleteDressmaker(id);
        }
    }
}
