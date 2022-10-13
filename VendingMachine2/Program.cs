using VendingMachine2;


bool alive = true;
VendingMachine vending = new();
//P.AddProducts();
vending.AvilableMoney = 0;
ApplicationManager application = new();
Console.WriteLine("Welcome to my project");
while (alive)
{
    application.ShowMenu(vending);
}

