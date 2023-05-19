namespace Exercise009
{
    using System;
    using System.Collections.Generic;

    public class StorageFacility
    {
        private Dictionary<string, List<string>> dict;

        public StorageFacility()
        {
            this.dict = new Dictionary<string, List<string>>();
        }
        public void Add(string unit, string item)
        {
            if (!this.dict.ContainsKey(unit))
            {
                this.dict.Add(unit, new List<string>());
            }
            this.dict[unit].Add(item);

            // if (this.dict.ContainsKey(unit))
            // {
            //     this.dict[unit].Add(item); //list.add(item)
            // }
            // else
            // {
            //     // an empty list has to be added for a new user if key has not already been added
            //     this.dict.Add(unit, new List<string>());
            //     dict[unit].Add(item);
            // }

        }
        public List<string> Contents(string storageUnit)
        {
            if (dict.ContainsKey(storageUnit))
            {
                return dict[storageUnit];
            }
            else
            {
                //add the key to dictionary and return its emptty list
                dict.Add(storageUnit, new List<string>());
                return dict[storageUnit];
            }

        }
        public void Remove(string storageUnit, string item)
        {
            //removing only 1 item from list

            if (this.dict.ContainsKey(storageUnit))
            {
                dict[storageUnit].Remove(item);


            }

            if (this.dict[storageUnit].Count == 0) //list count is zero
            {
                this.dict.Remove(storageUnit);

            }

        }
        public List<string> StorageUnits()
        {
            List<string> storageUnits = new List<string>();
            foreach (KeyValuePair<string, List<string>> kpv in this.dict)
            {
                storageUnits.Add(kpv.Key);
            }
            return storageUnits; //returning list


            // //method 2 going only through the keys not whole dictionary
            // Dictionary<string, List<string>>.KeyCollection keys = this.dict.Keys;
            // List<string> storageUnits = new List<string>();
            // foreach (string key in keys)
            // {
            //     storageUnits.Add(key);
            // }
            // return storageUnits;
        }



    }
}