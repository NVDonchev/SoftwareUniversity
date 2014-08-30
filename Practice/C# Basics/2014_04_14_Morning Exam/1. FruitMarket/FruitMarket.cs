using System;

class FruitMarket
{
    struct ProductInfo
    {
        public string type;
        public decimal quantity;
        public decimal price;
    }

    static void Main()
    {
        ProductInfo[] products = new ProductInfo[3];

        string dayOfWeek = Console.ReadLine();
        for (int count = 0; count < products.Length; count++)
        {
            products[count].quantity = decimal.Parse(Console.ReadLine());
            products[count].type = Console.ReadLine();

            switch (products[count].type)
            {
                case "banana":
                    products[count].price = 1.80m;
                    break;
                case "cucumber":
                    products[count].price = 2.75m;
                    break;
                case "tomato":
                    products[count].price = 3.20m;
                    break;
                case "orange":
                    products[count].price = 1.60m;
                    break;
                case "apple":
                    products[count].price = 0.86m;
                    break;
                default:
                    break;

            }
        }

        switch (dayOfWeek)
        {
            case "Tuesday":
                products = ManageTuesdayDiscount(products);
                break;
            case "Wednesday":
                products = ManageWednesdayDiscount(products);
                break;
            case "Thursday":
                products = ManageThursdayDiscount(products);
                break;
            case "Friday":
                products = ManageFridayDiscount(products);
                break;
            case "Sunday":
                products = ManageSundayDiscount(products);
                break;
            default:
                break;
        }

        decimal totalPrice = 0;

        foreach (ProductInfo product in products)
        {
            totalPrice += product.price * product.quantity;
        }

        Console.WriteLine(Math.Round(totalPrice, 2));
    }

    static ProductInfo[] ManageTuesdayDiscount(ProductInfo[] products)
    {
        for (int count = 0; count < products.Length; count++)
        {
            if (products[count].type == "banana" || products[count].type == "orange" || products[count].type == "apple")
            {
                products[count].price -= products[count].price * 0.20m;
            }
        }

        return products;
    }

    static ProductInfo[] ManageWednesdayDiscount(ProductInfo[] products)
    {
        for (int count = 0; count < products.Length; count++)
        {
            if (products[count].type == "cucumber" || products[count].type == "tomato")
            {
                products[count].price -= products[count].price * 0.10m;
            }
        }

        return products;
    }

    static ProductInfo[] ManageThursdayDiscount(ProductInfo[] products)
    {
        for (int count = 0; count < products.Length; count++)
        {
            if (products[count].type == "banana")
            {
                products[count].price -= products[count].price * 0.30m;
            }
        }

        return products;
    }

    static ProductInfo[] ManageFridayDiscount(ProductInfo[] products)
    {
        for (int count = 0; count < products.Length; count++)
        {
            products[count].price -= products[count].price * 0.10m;
        }

        return products;
    }

    static ProductInfo[] ManageSundayDiscount(ProductInfo[] products)
    {
        for (int count = 0; count < products.Length; count++)
        {
            products[count].price -= products[count].price * 0.05m;
        }

        return products;
    }
}
