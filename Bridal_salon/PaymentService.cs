
namespace Bridal_salon
{
    public class PaymentService
    {
        List<Payment> paymentList = new List<Payment>()
        {
           new Payment() {Id=1, EmailForSendingReception="fdgh@gmail",OrderId=12,PaymentCount=2,PaymentMethod="creditcard",Price=123,Reception=true} 
        };

        public List<Payment> GetPayments()
        {
            return paymentList;
        }

        public Payment GetPaymentById(int id)
        {
            var item = paymentList.Find(x => x.Id == id);
            return item;
        }

        public bool PostPayment(Payment p)
        {
            paymentList.Add(p);
            return true;
        }

        public bool PutPayment(int id,Payment p)
        {
            var item = paymentList.Find(x => x.Id == id);
            if (item != null)
            {
                item.Reception = p.Reception;
                item.OrderId = p.OrderId;
                item.EmailForSendingReception = p.EmailForSendingReception;
                item.PaymentCount = p.PaymentCount;
                item.PaymentMethod = p.PaymentMethod;
                item.Price = p.Price;
                return true;
            }
            return false;
        }

        public bool DeletePayment(int id)
        {
            var item = paymentList.Find(x => x.Id == id);
            if (item != null)
            {
                paymentList.Remove(item);
                return true;
            }
            return false;
        }

        public List<Payment> GetPaymentsWithReception()
        {
            List<Payment> result = new List<Payment>();
            foreach(var item in paymentList)
            {
                if(item.Reception)
                    result.Add(item);
            }
            return result;  
        }
    }
}
