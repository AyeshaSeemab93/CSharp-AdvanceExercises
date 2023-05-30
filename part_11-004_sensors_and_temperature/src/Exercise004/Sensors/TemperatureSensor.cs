namespace Exercise004
{
    using System;

    public class TemperatureSensor : ISensor
    {
        public bool SensorOn;
        public Random random;
        public TemperatureSensor()
        {
            this.SensorOn = false;
            this.random = new Random();
        }
        public bool IsOn()
        {
            return SensorOn;
        }

        public void SetOn()
        {
            SensorOn = true;
        }
        public void SetOff()
        {
            SensorOn = false;
        }
        public int Read()
        {
            if (SensorOn)
            {

                int temp = random.Next(-30, 31);
                return temp;
            }

            throw new InvalidOperationException("Sensor is not on");


        }




    }
}