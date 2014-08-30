using System;

class Problem2
{
    struct Order
    {
        public int PacketsCount;
        public int BooksPerPacket;
        public decimal PricePerBook;
    }

    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        Order[] orders = new Order[numberOfOrders];

        for (int order = 0; order < numberOfOrders; order++)
        {
            orders[order].PacketsCount = int.Parse(Console.ReadLine());
            orders[order].BooksPerPacket = int.Parse(Console.ReadLine());
            orders[order].PricePerBook = decimal.Parse(Console.ReadLine());
        }

        long totalBooks = 0;
        decimal totalPrice = 0;
        decimal discountedTotalPrice = 0;

        foreach (Order order in orders)
        {
            long booksPerOrder = 0;
            decimal pricePerOrder = 0;

            booksPerOrder = order.BooksPerPacket * order.PacketsCount;
            pricePerOrder = booksPerOrder * order.PricePerBook;

            totalBooks += booksPerOrder;
            totalPrice += booksPerOrder * order.PricePerBook;

            discountedTotalPrice += pricePerOrder - CalculateDiscount(order.PacketsCount, pricePerOrder);
        }

        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:0.00}", discountedTotalPrice, 2);
    }

    static decimal CalculateDiscount(int packets, decimal price)
    {
        decimal discountPercent;

        if (packets >= 110)
        {
            discountPercent = 0.15m;
        }
        else if (packets >= 100)
        {
            discountPercent = 0.14m;
        }
        else if (packets >= 90)
        {
            discountPercent = 0.13m;
        }
        else if (packets >= 80)
        {
            discountPercent = 0.12m;
        }
        else if (packets >= 70)
        {
            discountPercent = 0.11m;
        }
        else if (packets >= 60)
        {
            discountPercent = 0.10m;
        }
        else if (packets >= 50)
        {
            discountPercent = 0.09m;
        }
        else if (packets >= 40)
        {
            discountPercent = 0.08m;
        }
        else if (packets >= 30)
        {
            discountPercent = 0.07m;
        }
        else if (packets >= 20)
        {
            discountPercent = 0.06m;
        }
        else if (packets >= 10)
        {
            discountPercent = 0.05m;
        }
        else
        {
            discountPercent = 0m;
        }

        return price * discountPercent;
    }
}