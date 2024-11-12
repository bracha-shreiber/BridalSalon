namespace Bridal_salon
{
    public class OrderService
    {
        List<Order> orders = new List<Order>()
        {
            new Order() {OrdNum=1, AttachTulle=true, BrideId="234567", Comments="so nice",DressId=23,DressmakerId="456743234",TotalPrice=2800,DateOfOrder=new DateTime(),MeasurementDate=new DateTime(),TheWeddingTime=new DateTime()}
        };

        public List<Order> GetOrders()
        {
            return orders;
        }

        public Order GetOrderByNum(int OrdNum)
        {
            var item = orders.Find(item => item.OrdNum == OrdNum);
            return item;
        }

        public bool PostOrder(Order order)
        {
            orders.Add(order);
            return true;
        }

        public bool PutOrder(int OrdNum,Order order)
        {
          var item=orders.Find(item=>item.OrdNum==order.OrdNum);
          if(item!=null)
            {
                item.DressId = order.DressId;
                item.BrideId = order.BrideId;
                item.TotalPrice = order.TotalPrice;
                item.DressmakerId = order.DressmakerId;
                item.TheWeddingTime=order.TheWeddingTime;
                item.MeasurementDate = order.MeasurementDate;
                item.AttachTulle=order.AttachTulle;
                item.Comments=order.Comments;
                item.DateOfOrder=order.DateOfOrder;
                return true;
            }
            return false;
        }
        public bool DeleteOrder(int OrdNum)
        {
            var item=orders.Find(item=>item.OrdNum==OrdNum);
            if (item != null)
            {
                orders.Remove(item);
                return true;
            }
            return false;
            
        }

        public Order GetByBride(string BrideId)
        {
            var item = orders.Find(item => item.BrideId == BrideId);
            return item;
        }

        public List<Order> DateRange(DateTime BeginDate,DateTime EndDate)
        {
            List<Order> o = new List<Order>();
            foreach(var item in orders)
            {
                if(item.TheWeddingTime>=BeginDate&&item.TheWeddingTime<=EndDate)
                    o.Add(item);
            }
            return o;
        }

    }
}
