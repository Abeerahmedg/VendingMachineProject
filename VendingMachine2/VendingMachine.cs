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


        public readonly int[] AllowedMoney = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<Product> Products;
        public List<Product> Basket = new();
        public int AvilableMoney { get; set; }


        public void AddProducts()
        {
            Drinks drinks = new("Pepsi", 20, "Cold soda.");
            Products.Add(drinks);
            drinks = new("Orange Juice", 20, "The pressing of the natural liquid contained in Orange");
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

        public void Purchase(int ProductId)
        {
            ShowAll();
            if (AvilableMoney == 0)
            {
                Console.WriteLine("Please insert money first!");

            }
            else
            {
                Console.WriteLine($"you have in your wallet {AvilableMoney} to spend");
                Console.WriteLine("Please Enter the Id for the product you want to buy: ");
                ProductId = Convert.ToInt32(Console.ReadLine());

                if (ProductId > Products.Count)
                {
                    Console.WriteLine("Not a valid Id");
                }
                foreach (var item in Products)
                {
                    if (ProductId == item.ProductId)
                    {
                        if (AvilableMoney > item.Price)
                        {
                            Basket.Add(item);
                            AvilableMoney -= item.Price;
                            Console.WriteLine($"The {item.Name} added to your basket!");
                        }

                        Console.WriteLine();
                        Console.WriteLine($"You still have {AvilableMoney} to spend ");
                        Console.WriteLine("Do you wish to add more ! (y : Yes / n: No)");
                        string input = Console.ReadLine();

                        switch (input)
                        {
                            case "y":
                                ShowAll();
                                Console.WriteLine("Please Enter the Id for the product you want to buy: ");
                                ProductId = Convert.ToInt32(Console.ReadLine());

                                if (ProductId > Products.Count)
                                {
                                    Console.WriteLine("Not a valid Id");
                                }
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Not a valid option!");
                                break;
                        }

                        if (ProductId > Products.Count)
                        {
                            Console.WriteLine("Not a valid Id");
                        }
                        else if (AvilableMoney < item.Price)
                        {
                            Console.WriteLine("Not enough money for that , insert more...");
                        }
                    }
                }
            }
        }

        public void InsertMoney(bool valid)
        {

            int avilable = 0;

            Console.WriteLine("Insert Money to purchase..");
            avilable = int.Parse(Console.ReadLine());



            for (int i = 0; i < AllowedMoney.Length; i++)
            {


                if (avilable == AllowedMoney[i])
                {
                    valid = true;
                    AvilableMoney += avilable;
                    Console.WriteLine($"You have in your wallet {AvilableMoney} to spend.");





                    Console.WriteLine("Do you wish to insert more ! (y : Yes / n: No)");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "y":

                            Console.WriteLine("Insert Money to purchase..");
                            avilable = int.Parse(Console.ReadLine());
                            AvilableMoney += avilable;
                            Console.WriteLine($"You have in your wallet {AvilableMoney} to spend.");
                            break;
                        case "n":
                            break;
                        default:
                            Console.WriteLine("Not valid input!");
                            break;
                    }
                }
            }
            if (!valid)
            {

                Console.WriteLine("Not allowed money , Allowed are : 1,5,10,20,50,100,500,100");

            }




        }
        public bool CheckInput(int args)
        {
            foreach (int index in AllowedMoney)
            {
                if (args == index) { return true; }
            }
            return false;
        }

        public void ShowBasket()
        {


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

                }

            }




        }

        public void ReturnChange()
        {


            Console.WriteLine($"Thank you for purchasing here are your change : {AvilableMoney} SEK");
            Console.WriteLine("You will get :");
            int change = AvilableMoney;
            int i, a, b, c, d, e, f,g, h;
            while (change >= AllowedMoney[7])
            {
                a = change / AllowedMoney[7];
                change = change % AllowedMoney[7];
                for (i = 1; i <= a; i++) Console.WriteLine("1000 bil" + " ");

            }
            while (change >= AllowedMoney[6])
            {
                b = change / AllowedMoney[6];
                change = change % AllowedMoney[7];
                for (i = 1; i <= b; i++) Console.WriteLine("500 bil" + " ");

            }
            while (change >= AllowedMoney[5])
            {
                c = change / AllowedMoney[5];
                change = change % AllowedMoney[5];
                for (i = 1; i <= c; i++) Console.WriteLine("100 bil" + " ");

            }
            while (change >= AllowedMoney[4])
            {
                d = change / AllowedMoney[4];
                change = change % AllowedMoney[4];
                for (i = 1; i <= d; i++) Console.WriteLine("50 bil" + " ");

            }
            while (change >= AllowedMoney[3])
            {
                e = change / AllowedMoney[3];
                change = change % AllowedMoney[3];
                for (i = 1; i <= e; i++) Console.WriteLine("20 bil" + " ");

            }
            while (change >= AllowedMoney[2])
            {
                f = change / AllowedMoney[2];
                change = change % AllowedMoney[2];
                for (i = 1; i <= f; i++) Console.WriteLine("10 coins" + " ");

            }
            while (change >= AllowedMoney[1])
            {
                g = change / AllowedMoney[1];
                change = change % AllowedMoney[1];
                for (i = 1; i <= g; i++) Console.WriteLine("5 coins" + " ");

            }
            while (change >= AllowedMoney[0])
            {
                f = change / AllowedMoney[0];
                change = change % AllowedMoney[0];
                for (i = 1; i <= f; i++) Console.WriteLine("1 coin" + " ");

            }

           Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
           Environment.Exit(0);

        }


        public void EndTransaction()
        {



            Environment.Exit(0);


        }


    }
}
