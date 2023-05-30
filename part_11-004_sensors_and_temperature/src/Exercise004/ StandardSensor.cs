namespace Exercise004
{
    using System;

    public class StandardSensor : ISensor
    {

        public int num;
        public StandardSensor(int num)
        {
            this.num = num;
        }
        public bool IsOn()
        {
            return true;
        }

        public void SetOn()
        {

        }
        public void SetOff()
        {

        }
        public int Read()
        {
            return this.num;
        }

    }
}