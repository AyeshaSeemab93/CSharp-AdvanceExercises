namespace Exercise002
{
    using System;
    using System.Collections.Generic;

    public class LotteryRow
    {
        public List<int> numbers { get; set; }


        public LotteryRow()
        {

            this.RandomizeNumbers();
        }
        public bool ContainsNumber(int number)
        {
            // Tests whether the number is already among the randomized numbers
            return numbers.Contains(number);

        }
        public void RandomizeNumbers()
        {
            // initialize the list for numbers
            this.numbers = new List<int>();
            int i = 0;
            while (i < 7)
            {
                Random random = new Random();
                int randomNo = random.Next(1, 40);
                if (!this.ContainsNumber(randomNo))
                {
                    numbers.Add(randomNo);
                    i++;
                }
            }
            numbers.Sort(); //to arrange list in ascending order.No need to write any method.

        }


    }
}