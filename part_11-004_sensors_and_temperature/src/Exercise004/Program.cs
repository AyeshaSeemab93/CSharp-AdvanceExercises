namespace Exercise004
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperatureSensor temperatureSensor = new TemperatureSensor();

            Console.WriteLine(temperatureSensor.Read());
            temperatureSensor.SetOn();
            Console.WriteLine(temperatureSensor.Read());


        }
    }
}