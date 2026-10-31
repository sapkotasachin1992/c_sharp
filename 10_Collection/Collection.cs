using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace LearnCollection
{
    internal class Collection
    {
        // 1.Array is also collection type ,which we have already learned
        // 2.List is the another collection type
        void LearnLists()
        {
            List<byte> ages = new List<byte>();

            ages.Add(1);
            ages.Add(2);
            ages.Add(3);
            ages.Add(4);

            List<Country> countries = new List<Country>();
            //as we know while adding the value ,contries list expect Conuntry ojbect so create it 
            Country country = new Country();
            countries.Add(country);
            //here is shortcut too
            // countries.Add(new Country());   //means no need to assign object 


        }
        //3.Dictionary collection type
        internal void LearnDictionary()
        {
            //we have a condition eg we need to store country's name as well as capitial we use dictionary
            //In simple key value
            Dictionary<string, string> countryDetails = new Dictionary<string, string>();
            countryDetails.Add("Nepal", "Kathmandu");
            countryDetails.Add("India", "New Delhi");

            //if you already know the collections then you can do
            Dictionary<string, int> contacts = new Dictionary<string, int>
            {
                ["John"] = 1232,
                ["Maria"] = 2323,
                ["Roman"] = 23232,

            };

            //now to print the contents we will use contry captial example written above
            foreach (var country in countryDetails)
            {
                Console.WriteLine($"{country.Key}-{country.Value}");
            }



        }
    }

    public class Country
    {
        public string Name { get; set; }
    }
}