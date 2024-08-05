using static Program;

namespace CAExceptions
{
    public class DeliveryServiceBase
    {
        public void Start(Delivery delivery)
        {
            Process(delivery);
            Ship(delivery);
            Transit(delivery);
            Deliver(delivery);
        }
    }
}