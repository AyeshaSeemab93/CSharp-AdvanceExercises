namespace Exercise006
{
    using System;
    using System.Collections.Generic;

    public class Box : IPackable
    {
        public int capacity;
        List<IPackable> items;
        public int totalWeight;


        public Box(int maxCapacity)
        {
            this.capacity = maxCapacity;
            this.items = new List<IPackable>();

        }
        public void Add(IPackable material)
        {
            //if weight of list + new item weight is less than capacity then add to list
            if (Weight() + material.Weight() <= this.capacity)
            {
                items.Add(material);

            }
        }
        public int Weight()
        {
            //calculate the weight of items in list
            int sum = 0;
            foreach (IPackable item in items)
            {
                sum = sum + item.Weight();
            }
            return sum;
        }
        public override string ToString()
        {
            return this.items.Count + " items, total weight " + Weight() + " kg";
        }
    }
}
