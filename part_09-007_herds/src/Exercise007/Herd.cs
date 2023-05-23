namespace Exercise007
{
    using System;
    using System.Collections.Generic;

    public class Herd : IMovable
    {
        List<IMovable> list;


        public Herd()
        {
            this.list = new List<IMovable>();

        }
        public void AddToHerd(IMovable animal)
        {
            list.Add(animal);

        }

        public void Move(int dx, int dy)
        {
            foreach (IMovable item in list)
            {
                item.Move(dx, dy);

            }
        }
        public override string ToString()
        {
            string result = "";
            foreach (IMovable item in list)
            {
                result = result + item.ToString() + "\n";
            }
            return result;
        }


    }
}