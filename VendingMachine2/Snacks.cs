namespace VendingMachine2
{
    public class Snacks : Product
    {
        public Snacks(string name, int price, string description) : base(name, price, description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
        //public override string Name { get; set;  }
        //public override string Description { get; set;  }
        //public override int Price { get; set;  }
        public override void Use(Product Products)
        {
            Console.WriteLine($"Enjoy eating the {Name}");
        }
        public override void Show(Product Products)
        {
            Console.WriteLine($"Id: {ProductId} Name: {Name}. Price: {Price} SEK. Description: {Description}");
        }


    }
}