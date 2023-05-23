namespace Exercise007
{
    using System;
    using System.Collections.Generic;

    public class Organism : IMovable
    {
        public int x;
        public int y;

        public Organism(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int dx, int dy)
        {
            this.x = this.x + dx;
            this.y = this.y + dy;
        }

        public override string ToString()
        {
            return "x: " + this.x + "; y: " + this.y;
        }
    }
}