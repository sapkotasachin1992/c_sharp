using System;

enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered
}

class Program
{
    static void Main()
    {
        OrderStatus status = OrderStatus.Shipped;

        switch (status)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Your order is waiting.");
                break;

            case OrderStatus.Processing:
                Console.WriteLine("Your order is being prepared.");
                break;

            case OrderStatus.Shipped:
                Console.WriteLine("Your order is on the way.");
                break;

            case OrderStatus.Delivered:
                Console.WriteLine("Your order has arrived.");
                break;

            default:
                Console.WriteLine("Unknown status.");
                break;
        }
    }
}