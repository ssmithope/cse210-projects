// I put a comment on the default program at the bottom.
using System;
public class Program
{
    public static void Main(string[] args)
    {
        var orders = new List<Order>
        {
            new Order(
                new List<Product>
                {
                    new Product("Product 1", 101, 3, 5),
                    new Product("Product 2", 102, 4, 2)
                },
                new Customer("Smith Zephirin", new Address("123 Main St", "Saint Charles", "MO", "USA"))
            ),
            new Order(
                new List<Product>
                {
                    new Product("Product 3", 103, 5, 1),
                    new Product("Product 4", 104, 6, 3)
                },
                new Customer("Wilka Zephirin", new Address("456 Elm St", "Edmonton", "AL", "Canada"))
            )
        };

        foreach (var order in orders)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Total Price: ${order.TotalPrice()}\n");
        }
    }
}




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }