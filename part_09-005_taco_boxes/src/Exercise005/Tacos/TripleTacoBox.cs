namespace Exercise005
{
    using System;
    using System.Collections.Generic;

    public class TripleTacoBox : ITacoBox //implementing ITACOBOX interface
    {

        private int tacos;
        public TripleTacoBox()
        {
            this.tacos = 3;
        }

        public int TacosRemaining()
        {
            return this.tacos;
        }
        public void Eat()
        {
            if (this.tacos > 0)
            {
                this.tacos--;
                //or this.tacos -= 1;
            }

        }
    }


}