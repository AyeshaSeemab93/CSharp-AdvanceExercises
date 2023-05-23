namespace Exercise005
{
    using System;
    using System.Collections.Generic;

    public class CustomTacoBox : ITacoBox
    {
        private int customTacos;

        public CustomTacoBox(int tacos)
        {
            this.customTacos = tacos;
        }

        public int TacosRemaining()
        {
            return this.customTacos;

        }
        public void Eat()
        {
            if (this.customTacos > 0)
            {
                this.customTacos--;
            }
        }
    }
}
