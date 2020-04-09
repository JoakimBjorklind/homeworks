using System;
using System.Collections.Generic;

namespace Exercise
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (owners.ContainsKey(licensePlate))
            {
                return false;
            }
            else
            {
                this.owners.Add(licensePlate, owner);
                return true;
            }
        }
        public string Get(LicensePlate licensePlate)
        {
            if (owners.ContainsKey(licensePlate))
            {
                return owners[licensePlate];
            }
            else
            {
                return "No such license";
            }
        }

        public bool Remove(LicensePlate licensePlate)
        {
            if (owners.ContainsKey(licensePlate))
            {
                return owners.Remove(licensePlate);
            }
            else
            {
                return false;
            }
        }

        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> kvp in owners)
            {
                System.Console.WriteLine(kvp.Key);
            }
        }

        public void PrintOwners()
        {
            List<string> ownersList = new List<string>();
            foreach (KeyValuePair<LicensePlate, string> kvp in owners)
            {
                if (!ownersList.Contains(kvp.Value))
                    ownersList.Add(kvp.Value);
            }
            foreach (string ownersName in ownersList)
            {
                System.Console.WriteLine(ownersName);
            }

        }
    }
}