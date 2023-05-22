namespace Exercise002
{
    using System;

    public class Student : Person
    {
        public int credits;

        public Student(string name, string address) : base(name, address)
        {
            this.credits = 0;
        }

        public void Study()
        {
            credits++;
        }
        public override string ToString()
        {
            return base.ToString() + " credits: " + this.credits;
        }

    }
}