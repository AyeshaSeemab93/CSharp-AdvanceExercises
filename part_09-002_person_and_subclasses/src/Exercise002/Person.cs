namespace Exercise002
{
    using System;

    public class Person
    {
        public string name;
        public string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public override string ToString()
        {
            return this.name + ", " + this.address;
        }
    }
}