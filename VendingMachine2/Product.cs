namespace VendingMachine2
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        // private static int _index = 0;
        public abstract void Show(Product Products);
        public abstract void Use(Product Products);
        public Product(string name, int price, string description)
        {

            Name = name;
            Price = price;
            Description = description;
        }
    }
}