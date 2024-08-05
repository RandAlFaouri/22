internal partial class Program
{
    /*static int BadMethod()
    {
        var x = 2;
        var y = 0;
        return x / y;
    }*/
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public override string ToString()
        {
            return $"{{ \n Id: { Id}, \nCustomer: {CustomerName }, \nAddress : {Address},  \nStatus: {DeliveryStatus}}}" ;
        }
    }
}