namespace Exercise005
{
    using System;
    using System.Collections.Generic; //for list and dictionary

    public class IOU
    {
        Dictionary<string, int> debt;

        public IOU()
        {
            this.debt = new Dictionary<string, int>();
        }
        public void ChangeDebt(string toWhom, int amount)
        {

            if (debt.ContainsKey(toWhom))
            {
                int total = this.debt[toWhom];
                total = total + amount;
                if (total < 0)
                {
                    total = 0;
                }

                this.debt[toWhom] = total;


            }

            else
            {
                if (amount < 0)
                {
                    amount = 0;
                }
                debt.Add(toWhom, amount);
            }

        }
        public int HowMuchDoIOweTo(string toWhom)
        {
            if (this.debt.ContainsKey(toWhom))
            {
                return debt[toWhom];
            }
            else
            {
                return 0;
            }

        }

    }
}