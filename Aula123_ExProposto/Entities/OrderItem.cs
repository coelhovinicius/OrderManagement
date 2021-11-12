using System.Text;
using System.Globalization;
namespace Aula123_ExProposto.Entities
{
    class OrderItem
    {
        public Product Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product name, int quantity, double price)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Order items:");
            sb.Append(Name);
            sb.Append(", $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
