namespace Exercise007
{
    using System;
    using System.Collections.Generic;
    public class VehicleRegistry
    {
        public Dictionary<LicensePlate, string> dict;
        public VehicleRegistry()
        {

            this.dict = new Dictionary<LicensePlate, string>();
        }

        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (this.dict.ContainsKey(licensePlate))
            {
                if (dict[licensePlate] == null)
                {
                    dict[licensePlate] = owner;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                dict[licensePlate] = owner; // == dict.Add(licenseplate, owner);
            return true;
        }

        public string Get(LicensePlate licensePlate)
        {
            if (dict.ContainsKey(licensePlate))
            {
                return this.dict[licensePlate];
            }
            else
            {
                return "Not registered!";
            }
        }
        public bool Remove(LicensePlate licensePlate)
        {
            if (this.dict.ContainsKey(licensePlate))
            {
                this.dict.Remove(licensePlate);
                return true;
            }
            else
            { return false; }
        }

        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> kpv in this.dict)
            {
                Console.WriteLine(kpv.Key);
            }
            // Dictionary<LicensePlate, String>.KeyCollection key = dict.Keys;
            // foreach(LicensePlate plates in key)
            // {
            //     Console.WriteLine(plates.ToString());
            // }
        }

        public void PrintOwners()
        {
            List<string> already = new List<string>();
            foreach (KeyValuePair<LicensePlate, string> kpv in dict)
            {
                if (!already.Contains(kpv.Value))
                {
                    Console.WriteLine(kpv.Value);
                }
                already.Add(kpv.Value);
            }

        }




    }
}
