namespace Exercise003
{
    using System;

    public class ProductWarehouseWithHistory : ProductWarehouse
    {
        public ChangeHistory history;
        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
        {
            base.balance = initialBalance;
            this.history = new ChangeHistory();
            this.history.Add(initialBalance);

        }
        public string History()
        {
            return history.ToString();
        }
        new public void AddToWarehouse(int amount)
        {

            base.AddToWarehouse(amount);
            history.Add(base.balance);

        }
        new public int TakeFromWarehouse(int amount)
        {
            //recieve what we get out of warehouse and return it
            int recieved = base.TakeFromWarehouse(amount);
            history.Add(base.balance);

            return recieved;
        }



    }
}