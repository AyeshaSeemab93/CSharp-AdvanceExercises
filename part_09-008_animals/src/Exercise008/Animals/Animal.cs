namespace Exercise008
{
    using System;

    //parent class is mostly abstract class bec it has concept but missing components
    public abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }
        public Animal()
        {

        }
        //abstract metods can be normal methods or just declared
        // public abstract void Eat();

        public void Eat()
        {
            Console.WriteLine(this.name + " eats");
        }
        public void Sleep()
        {
            Console.WriteLine(this.name + " sleeps");
        }
    }

}