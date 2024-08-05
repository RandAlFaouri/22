using System.Net.Sockets;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var delivery = new Delivery { Id = 15, CustomerName = "Rand F.",Address = "123 Street"  };
        Console.WriteLine(delivery);
      /*  try
        {
            var result = BadMethod();
            Console.WriteLine(result);
        }
        catch(DivideByZeroException ex)   
        {
            //handle the exception 
            Console.WriteLine("you can not divide by zero");
        }
        finally
        {
            Console.WriteLine("End");
        }
       */
    }
}