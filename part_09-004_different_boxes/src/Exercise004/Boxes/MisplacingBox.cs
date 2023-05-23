namespace Exercise004
{
    using System;
    using System.Collections.Generic;

    public class MisplacingBox : Box
    {
        //no need for list or any method bec we are not saving/adding any item
        public MisplacingBox()
        {

        }
        public override void Add(Item item)
        {


        }
        public override bool IsInBox(Item item)
        {
            return false;
        }

    }
}