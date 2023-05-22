namespace Exercise003
{

    public class Warehouse
    {
        public int balance { get; set; }
        public int capacity { get; set; }

        public Warehouse(int capacity)
        {
            if (capacity > 0)
            {
                this.capacity = capacity;
            }
            else
            {
                this.capacity = 0;
            }

            this.balance = 0;
        }

        public int HowMuchSpaceLeft()
        {
            return this.capacity - this.balance;
        }

        virtual public void AddToWarehouse(int amount)
        {
            if (amount < 0)
            {
                return;
            }
            if (amount <= HowMuchSpaceLeft())
            {
                this.balance += amount;
            }
            else
            {
                this.balance = this.capacity; //warehouse is filled up and the rest is "thrown away".
            }
        }

        virtual public int TakeFromWarehouse(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            if (amount > this.balance)
            { //we get all there is to take and the warehouse is emptied.
                int allThatWeCan = this.balance;
                this.balance = 0;
                return allThatWeCan;
            }
            this.balance -= amount;
            return amount;  // The method returns what we actually get.
        }

        public override string ToString()
        {
            return "balance: " + this.balance + ", space left " + HowMuchSpaceLeft();
        }
    }
}
