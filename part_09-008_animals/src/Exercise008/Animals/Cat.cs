namespace Exercise008
{
    using System;


    public class Cat : Animal, INoiseCapable
    {


        public Cat(string name) : base(name)
        {


        }
        public Cat() : this("Cat")
        {

        }
        public void Purr()
        {
            Console.WriteLine(this.name + " purrs");
        }

        public void MakeNoise()
        {
            this.Purr();
        }




    }
}