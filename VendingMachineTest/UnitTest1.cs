using VendingMachine2;
namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        VendingMachine vending = new VendingMachine();

        [Fact]
        public void InsertCorrectMoneyTest()
        {
            Assert.(vending.InsertMoney(100));

        }
    }
}