using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bridal_salon.Controllers
{
    public class DressController : ControllerBase
    {
        private static DressService dressService = new DressService();
      
        // GET: DressController
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dressService.GetDresses());
        }

        // GET: DressController/Details/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            if (dressService.GetDressById(id) == null)
                return NotFound();
            return Ok(true);
        }
        
        // POST: DressController/Create
        [HttpPost]
        public ActionResult Post([FromBody] Dress value)
        {
            dressService.PostDress(value);
            return Ok(true);
        }

        // PUT api/<DressController>
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Dress value)
        {
            if (!dressService.PutDress(id, value))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(!dressService.DeleteDress(id))
                return NotFound();
            return Ok(true);
        }

        public ActionResult GetNewDresses()
        {
            return Ok(dressService.GetNewDresses());
        }

    }
}
