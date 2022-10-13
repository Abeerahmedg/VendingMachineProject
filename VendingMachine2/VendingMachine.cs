namespace VendingMachine2
{
    public class VendingMachine : IVending
    {
        public VendingMachine()
        {
            Products = new List<Product>();
            AddProducts();
            AvilableMoney = 0;
        }
        

        private readonly int[] AllowedMoney = { 1, 5, 10, 20, 50, 100, 500 };
        public List<Product> Products;
        public List<Product> Basket = new();
        public int AvilableMoney { get; set; }


        public void AddProducts()
        {
            Drinks drinks = new("Pepsi", 20, "Cold soda.");
            Products.Add(drinks);
            drinks = new("Mountain Dew", 20, "citrus-flavored soda.");
            Products.Add(drinks);
            drinks = new("Water", 15, "A perfect way to hydrate your body");
            Products.Add(drinks);

            Snacks snacks = new("Snickers", 10, "nougat with caramel and peanuts encased in milk chocolate");
            Products.Add(snacks);
            snacks = new("Oreos", 10, "wafers with a sweet crème filling");
            Products.Add(snacks);
            snacks = new("Lays Chips", 30, "potato salted chip is perfectly crispy and potato taste");
            Products.Add(snacks);

            HealthySnacks healthySnacks = new("Dry Roasted Pistachios", 25, "Whole Pistachios makes perfect snack");
            Products.Add(healthySnacks);
            healthySnacks = new("Almonds with Cranberries", 45, "whole almonds and cranberries,toasted sesame seeds");
            Products.Add(healthySnacks);
            healthySnacks = new("Crunchy Apple Chips", 30, "crunchy and sweet healthy chips");
            Products.Add(healthySnacks);
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].ProductId = i + 1;
            }
        }
        public void ShowAll()
        {
            Console.Clear();
            Console.WriteLine("Products available for purchase:\n");
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].Show(Products[i]);
                // Console.WriteLine($"Id:{item.ProductId} Name: {item.Name}.\tPrice: {item.Price} SEK.\tDescription: {item.Description}");
                Console.WriteLine();
            }
        }

        public void Purchase()
        {
            Console.Clear();
            if (AvilableMoney == 0)
            {
                Console.WriteLine("Please insert money first!");

            }
            else
            {
                Console.WriteLine("Please Enter the Id for the product you want to buy: ");
                int ProductId = Convert.ToInt32(Console.ReadLine());
                if (ProductId > Products.Count)
                {
                    Console.WriteLine("Not a valid Id");
                }
                foreach (var item in Products)
                {
                    if ((ProductId == item.ProductId))
                    {
                        if ((AvilableMoney > item.Price))
                        {
                            Basket.Add(item);
                            AvilableMoney -= item.Price;
                            Console.WriteLine($"The {item.Name} added to your basket!");

                            Console.WriteLine();
                            Console.WriteLine($"You still have {AvilableMoney} to spend ");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money for that , insert more...");
                        }
                    }
                }
            }
        }

        public void InsertMoney(int avilable)
        {
            Console.Clear();
            bool valid = false;
            Console.WriteLine("Insert Money to purchase..");
             avilable = int.Parse(Console.ReadLine());


            //AllowedMoney.Length;
            for (int i = 0; i < AllowedMoney.Length; i++)
            {


                if (avilable == AllowedMoney[i])
                {
                    valid = true;
                    AvilableMoney += avilable;
                    Console.WriteLine($"You have in your wallet {AvilableMoney} to spend.");
                    break;
                    //

                }

            }
            if (!valid)
            {
                // valid = false;
                Console.WriteLine("Not allowed money , Allowed are : 1,5,10,20,50,100,500,100");

            }

        }

        public void ShowBasket()
        {
            Console.Clear();

            if (Basket.Count == 0)
            {
                Console.WriteLine("You have not buy anything yet!");
            }
            else
            {
                Console.WriteLine("You have in your basket: ");
                Console.WriteLine();
                foreach (var item in Basket)
                {
                    Console.WriteLine("-" + item.Name);
                    item.Use(item);
                    Console.WriteLine();
                    //foreach (var _item in Basket)
                    //{
                    //    _item.Use(item);

                    //    Console.WriteLine();
                    //}

                }

            }




        }

        public void ReturnChange()
        {
            Console.Clear();
            Console.WriteLine($"Thank you for purchasing here are your change : {AvilableMoney}");
            Console.WriteLine();
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
            Environment.Exit(0);

        }


        public void EndTransaction()
        {
            Console.Clear();


            Environment.Exit(0);
            // int change1 = AvilableMoney;
            // AvilableMoney = 0;
            //int change = new();
            // if (change1 == 0)
            // {
            //     Console.WriteLine("Thank you for purchasing!");
            // }
            // //for (int i = AllowedMoney.Length - 1; i >= 0; i--)
            // //{
            // //    if (change1 > 0)
            // //    {
            // //        int count = change1 / AllowedMoney[i];

            // //        if (count > 0)
            // //        {
            // //            change[AllowedMoney[i]] = count;
            // //            change1 %= AllowedMoney[i];
            // //        }
            // //    }
            // //}
            // else if (change1 > 0)
            // {
            //     foreach(var item in Basket)
            //     {
            //         change = item.Price - AvilableMoney; 
            //     }


        }


    }
}
