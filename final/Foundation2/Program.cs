using System;

class Program
{
    static void Main(string[] args)
    {
        // order 1
        Address address1 = new Address("256 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Tristan", address1);
        Order order1 = new Order(customer1.GetCustomerName(), address1);

        // products for order 1
        Product product1a = new Product("Pen", "A20", 1.29, 5);
        order1.AddToProductList(product1a); // add to products list in Order
        Product product1b = new Product("10-Notecard pack", "A07", 0.1, 10);
        order1.AddToProductList(product1b); // add to products list in Order
        Product product1c = new Product("Scientific Calculator", "B11", 29.99, 1);
        order1.AddToProductList(product1c); // add to products list in Order

        Console.WriteLine($"Order1 Total Cost: ${order1.GetTotalPrice()}");
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        // order 2
        Address address2 = new Address("Flat A, 10/F, Tower 5, the Garden", "Tuen Mun", "New Territories", "Hong Kong");
        Customer customer2 = new Customer("Tristan", address2);
        Order order2 = new Order(customer2.GetCustomerName(), address2);

        // products for order 2
        Product product2a = new Product("Highlighter", "A47", 1.98, 2);
        order2.AddToProductList(product2a); // add to products list in Order
        Product product2b = new Product("Pencil", "A22", 0.49, 10);
        order2.AddToProductList(product2b); // add to products list in Order
        Product product2c = new Product("Rubber", "A26", 0.19, 2);
        order2.AddToProductList(product2c); // add to products list in Order

        Console.WriteLine($"Order2 Total Cost: ${order2.GetTotalPrice()}");
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
    }
}