namespace Exercise004
{
    using System;
    using System.Collections.Generic;

    public class OneItemBox : Box
    {

        public List<Item> oneitemBox;
        public OneItemBox()
        {
            this.oneitemBox = new List<Item>();
        }

        public override bool IsInBox(Item item)
        {
            if (oneitemBox.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Add(Item item)
        {
            if (oneitemBox.Count == 0)
            {
                oneitemBox.Add(item);
            }

        }



    }
}
