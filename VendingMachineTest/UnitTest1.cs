using VendingMachine2;
namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        VendingMachine vending = new VendingMachine();
        public Product Snack = new Snacks("Mars", 15, "Chocolate bar");

        [Fact]
        public void PurchaseTest()
        {


            Assert.Equal("Mars", Snack.Name);

        }
        public void PurchaseTest1()
        {
            vending.Products.Add(Snack);
            vending.AvilableMoney = 50;
            Snack.ProductId = 1;
            int index = vending.AvilableMoney - Snack.Price;
            vending.AvilableMoney = index;

            vending.Purchase(1);
            Assert.Equal(35, vending.AvilableMoney);


        }

        [Fact]
        public void BasketTest()
        {
            vending.Basket.Add(Snack);
           
            Assert.True(vending.Basket != null);
        }


        [Fact]
        public void InsertMoneyTest()
        {
            Assert.True(vending.CheckInput(500));
            Assert.False(vending.CheckInput(300));

          
        }


    }
}