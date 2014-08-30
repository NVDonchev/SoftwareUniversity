//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Problem2
//{
//    struct Order
//    {
//        public long Packets;
//        public long BooksInPacket;
//        public decimal PriceOfBook;
//    }

//    static void Main()
//    {
//        long numberOfOrders = long.Parse(Console.ReadLine());
//        Order[] orders = new Order[numberOfOrders];

//        long totalBooks = 0;
//        decimal totalPrice = 0;

//        for (long order = 0; order < numberOfOrders; order++)
//        {
//            orders[order].Packets = long.Parse(Console.ReadLine());
//            orders[order].BooksInPacket = long.Parse(Console.ReadLine());
//            orders[order].PriceOfBook = decimal.Parse(Console.ReadLine());

//            CalculateDiscount(orders, order);

//            long totalBooksInOrder = 0;
//            for (long packet = 0; packet < orders[order].Packets; packet++)
//            {
//                totalBooks += orders[order].BooksInPacket;
//                totalBooksInOrder += orders[order].BooksInPacket;
//            }

//            totalPrice += totalBooksInOrder * orders[order].PriceOfBook;
//            totalBooksInOrder = 0;
//        }

//        Console.WriteLine(totalBooks);
//        Console.WriteLine(Math.Round(totalPrice, 2));
//    }

//    private static void CalculateDiscount(Order[] orders, long order)
//    {
//        if (orders[order].Packets >= 10 && orders[order].Packets <= 19)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.05m;
//        }
//        else if (orders[order].Packets >= 20 && orders[order].Packets <= 29)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.06m;
//        }
//        else if (orders[order].Packets >= 30 && orders[order].Packets <= 39)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.07m;
//        }
//        else if (orders[order].Packets >= 40 && orders[order].Packets <= 49)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.08m;
//        }
//        else if (orders[order].Packets >= 50 && orders[order].Packets <= 59)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.09m;
//        }
//        else if (orders[order].Packets >= 60 && orders[order].Packets <= 69)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.10m;
//        }
//        else if (orders[order].Packets >= 70 && orders[order].Packets <= 79)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.11m;
//        }
//        else if (orders[order].Packets >= 80 && orders[order].Packets <= 89)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.12m;
//        }
//        else if (orders[order].Packets >= 90 && orders[order].Packets <= 99)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.13m;
//        }
//        else if (orders[order].Packets >= 100 && orders[order].Packets <= 109)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.14m;
//        }
//        else if (orders[order].Packets >= 110)
//        {
//            orders[order].PriceOfBook -= orders[order].PriceOfBook * 0.15m;
//        }
//    }
//}