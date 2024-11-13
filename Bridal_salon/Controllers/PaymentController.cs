using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bridal_salon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private static PaymentService _paymentService = new PaymentService();

        // GET: PaymentController
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_paymentService.GetPayments());
        }
        [HttpGet("{id}")]
        // GET: PaymentController/Details/5
        public ActionResult GetById(int id)
        {
            if(_paymentService.GetPaymentById(id)==null)
                return NotFound();
            return Ok(true);
        }
        //[HttpGet("PaymentsWithReception")]
        //public ActionResult GetPaymentsWithReception()
        //{
        //    return Ok(_paymentService.GetPaymentsWithReception());
        //}

        // POST: PaymentController/Create
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Post(Payment p)
        {
            _paymentService.PostPayment(p);
            return Ok(true);
        }

        // GET: PaymentController/Edit/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,Payment p)
        {
            if (!_paymentService.PutPayment(id, p))
                return NotFound();
            return Ok(true);
        }

        // GET: PaymentController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(!_paymentService.DeletePayment(id))
                return NotFound();
            return Ok(true);
        }

    }
}
