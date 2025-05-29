using System;

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Aba, Abia
        Address address1 = new Address("12 Brass Street", "Aba", "Abia", "Nigeria");
        Customer customer1 = new Customer("Ngozi Nwachukwu", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Adire Fabric", "TX001", 20.00, 3));
        order1.AddProduct(new Product("Needle Set", "TX002", 2.50, 5));

        // Order 2 - Ikeja, Lagos
        Address address2 = new Address("45 Allen Avenue", "Ikeja", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Tunde Balogun", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Scissors", "TX003", 5.00, 2));
        order2.AddProduct(new Product("Thread Roll", "TX004", 1.50, 10));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ₦{order1.GetTotalPrice():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ₦{order2.GetTotalPrice():0.00}");
    }
}
