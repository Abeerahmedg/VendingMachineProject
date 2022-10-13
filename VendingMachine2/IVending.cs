namespace VendingMachine2
{
    internal interface IVending
    {
        void Purchase();
        void ShowAll();
        void InsertMoney(int v);
        void EndTransaction();

    }
}