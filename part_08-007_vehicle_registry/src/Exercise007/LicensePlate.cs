namespace Exercise007
{
    using System;
    public class LicensePlate
    {
        public string liNumber { get; }
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }


        public override string ToString()
        {
            return country + " " + liNumber;
        }

    }
}
