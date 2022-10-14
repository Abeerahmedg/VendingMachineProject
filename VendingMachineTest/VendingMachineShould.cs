using VendingMachine2;
namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        VendingMachine sut = new VendingMachine();
        public Product Snack = new Snacks("Mars", 15, "Chocolate bar");

        [Fact]
        public void PurchaseTest()
        {


            Assert.Equal("Mars", Snack.Name);

        }
        public void PurchaseTest1()
        {
            sut.Products.Add(Snack);
            sut.AvilableMoney = 50;
            Snack.ProductId = 1;
            int index = sut.AvilableMoney - Snack.Price;
            sut.AvilableMoney = index;

            sut.Purchase(1);
            Assert.Equal(35, sut.AvilableMoney);


        }

        [Fact]
        public void BasketTest()
        {
            sut.Basket.Add(Snack);

            Assert.True(sut.Basket != null);
        }


        [Fact]
        public void InsertMoneyTest()
        {
            Assert.True(sut.CheckInput(500));
            Assert.False(sut.CheckInput(300));


        }

        [Fact]
        public void AddToBasketTest()
        {
            sut.Basket.Add(Snack);
            Assert.True(sut.Basket.Contains(Snack));
        }


    }
}