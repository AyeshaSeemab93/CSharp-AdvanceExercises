namespace Exercise006
{
    using System;
    using System.Collections.Generic;

    public class Furniture : IPackable
    {
        public string furnitureType;
        public string color;

        public int weight;
        public Furniture(string furniture, string color, int weight)
        {
            this.furnitureType = furniture;
            this.color = color;
            this.weight = weight;

        }

        public int Weight()
        {
            return this.weight;
        }
        public override string ToString()
        {
            return this.color + " " + this.furnitureType + " - weight " + this.weight + " kg";
        }
    }
}