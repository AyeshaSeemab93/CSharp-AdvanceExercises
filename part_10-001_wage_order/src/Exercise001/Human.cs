namespace Exercise001
{
    using System;

    public class Human : IComparable<Human>
    {
        public int wage { get; }
        public string name { get; }

        public Human(string name, int wage)
        {
            this.name = name;
            this.wage = wage;
        }

        public int CompareTo(Human another)
        {
            // return this.wage - another.wage;  arrage wage from small to big          but we need biggest wage first so!!

            return another.wage - this.wage;



        }


        public override string ToString()
        {
            return name + " " + wage;
        }
    }
}