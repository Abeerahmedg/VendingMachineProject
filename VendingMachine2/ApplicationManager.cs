namespace VendingMachine2
{
    internal class ApplicationManager
    {


        public void ShowMenu(VendingMachine vendingMachine)
        {
            //if (vendingMachine.Basket.Count > 0)
            //{
            //    vendingMachine.ShowBasket();
            //}


            Console.WriteLine("--Options--");
            Console.WriteLine();
            Console.WriteLine("Write the number you want");
            Console.WriteLine("1) Insert Money");
            Console.WriteLine("2) Show Products");
            Console.WriteLine("3) buy Products");
            Console.WriteLine("4) show basket");
            Console.WriteLine("5) return change");
            Console.WriteLine("6) Exit");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":

                    vendingMachine.InsertMoney();
                    break;

                case "2":
                    vendingMachine.ShowAll();
                    break;
                case "3":
                    vendingMachine.Purchase();
                    //if (vendingMachine.AvilableMoney != 0)
                    //{


                    //    Console.WriteLine("Select the proudct you want to buy, by the product Id:");
                    //    var answer = Convert.ToInt32(Console.ReadLine());

                    //    if (answer.Equals(productId))
                    //    {
                    //        vendingMachine.Purchase();

                    //    }
                    //    else Console.WriteLine("Enter a valid Id");
                    //}
                    //else Console.WriteLine("Please insert money");
                    break;
                case "4":
                    vendingMachine.ShowBasket();
                    break;
                case "5":
                    vendingMachine.ReturnChange();
                    Console.WriteLine();
                    //Environment.Exit(0);
                    break;
                case "6":
                    vendingMachine.EndTransaction();
                    break;
                default:
                    Console.WriteLine("Enter a valid option!");
                    break;
            }
        }
    }
}

