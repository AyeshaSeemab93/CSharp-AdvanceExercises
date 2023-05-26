namespace Exercise005
{
    using System;
    using System.Collections.Generic;
    public class Hand : IComparable<Hand>
    {
        public List<Card> cards { get; }
        public Hand()
        {
            this.cards = new List<Card>();
        }
        public void Add(Card card)
        {
            if (cards.Contains(card))
            {
                return;
            }
            else
                this.cards.Add(card);

        }
        public void Print()
        {
            foreach (Card item in cards)
            {
                Console.WriteLine(item);
            }
        }
        public void Sort()
        {
            //calls compareTo method of Cards class
            this.cards.Sort();
        }

        public int CompareTo(Hand another)
        {

            int sum1 = 0;
            int sum2 = 0;
            foreach (Card item in this.cards)
            {
                sum1 = sum1 + item.value;
            }
            foreach (Card item in another.cards) //another.cards is list of another
            {
                sum2 = sum2 + item.value;
            }


            return sum1.CompareTo(sum2);


        }



    }
}