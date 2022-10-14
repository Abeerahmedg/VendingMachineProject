namespace VendingMachine2
{
    public interface IVending
    {
        void Purchase(int ProductId);
        void ShowAll();
        void InsertMoney(bool valid);
        void EndTransaction();

    }
}