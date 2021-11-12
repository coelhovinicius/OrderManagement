using System;
using System.Globalization;
using Aula123_ExProposto.Entities;
using Aula123_ExProposto.Entities.Enums;

namespace Aula123_ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment / Processing / Shipped / Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client); // Classe Order instanciada para que nao seja "null"

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, price);
                OrderItem item = new OrderItem(product, quantity, price);

                order.AddItem(item);

            }

            Console.WriteLine();

            // ORDER SUMMARY -EXIBIR O OVERRIDE DE ORDER
            
           // Product product = new Product(prodName, price);

            Console.WriteLine(order);

        }
    }
}
