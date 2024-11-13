using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bridal_salon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static OrderService orderServers { get; set; }
        // GET: OrderController
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(orderServers.GetOrders());
        }
        // GET api/<dressmakerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpGet("{id}")]
        public ActionResult GetByOrdNum(int OrdNum)
        {
            if(orderServers.GetOrderByNum(OrdNum)==null)
                return NotFound();
            return Ok(true);
        }
       
        [HttpGet("{BrideId}")]
        public ActionResult GetByBride(string BrideId)
        {
            return Ok(orderServers.GetByBride(BrideId));
        }
        [HttpGet("{BeginDate}/{EndDate}")]
        public ActionResult DateRange(DateTime BeginDate, DateTime EndDate)
        {
            return Ok(orderServers.DateRange(BeginDate, EndDate));
        }
        // POST api/<OrderController>
        [HttpPost]
        public ActionResult Post([FromBody] Order value)
        {
            orderServers.PostOrder(value);
            return Ok(true);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int OrdNum, [FromBody] Order value)
        {
            if (!orderServers.PutOrder(OrdNum, value))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int OrdNum)
        {
            if (!orderServers.DeleteOrder(OrdNum))
                return NotFound();
            return Ok(true);
        }
       

       

    }
}
