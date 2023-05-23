namespace Exercise004
{
    using System;
    using System.Collections.Generic;

    public class BoxWithMaxWeight : Box
    {

        public int maxCapacity;
        List<Item> items;
        public int totalweight = 0;
        public BoxWithMaxWeight(int capacity)
        {
            this.maxCapacity = capacity;
            //create a list of items that it contains.
            this.items = new List<Item>();
        }
        public override void Add(Item item)
        {
            totalweight = totalweight + item.weight;
            if (totalweight <= this.maxCapacity)
            {
                this.items.Add(item);
            }

        }
        public override bool IsInBox(Item item)
        {
            if (items.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}