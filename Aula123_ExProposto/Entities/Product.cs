namespace Aula123_ExProposto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //OVERRIDE
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
