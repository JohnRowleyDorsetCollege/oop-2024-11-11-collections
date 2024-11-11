using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_11_11_collections.models
{
    public static class DictionaryDriver
    {
        public static void Run()
        {
            CountWords();
            CapitalCities();
            SimpleDictionary();
        }

        public static void SimpleDictionary()
        {
            // Key value 
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>()
            {
                {"Alice", 25 },
                {"Bob", 30 },
                {"Charlie", 38 },
            };

            int aliceAge = ageDictionary["Alice"]; // Alice is the key

            Console.WriteLine($"Alice's age is {aliceAge}");
            //Iterate over the keys and values
            foreach(KeyValuePair<string, int> kvp in ageDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key} : {kvp.Value}");
            }
        }

        public static void CountWords()
        {
            string[] words = { "apple", "banana", "orange", "banana", "apple", "banana", "BANANA" };
            //  Console.WriteLine("")
            Dictionary<string, int> wordCounts = new();
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word.ToLower()))
                {
                    wordCounts[word.ToLower()]++;
                }
                else // first time it occurs
                {
                    wordCounts[word.ToLower()] = 1;
                   
                }
            }
            // output
            foreach(KeyValuePair<string,int> kvp in wordCounts)
            {
                Console.WriteLine($"{kvp.Key} appears {kvp.Value} times");
            }
         }


        public static void CapitalCities()
        {
            // Key value : string key, string value
            Dictionary<string, string> capitalDictionary = new Dictionary<string, string>()
            {
               
                { "UK", "London" },
                { "France", "Paris" },
                { "Germany", "Berlin"  },
                { "Ireland","Dublin"  }
            };

            string ukCapital = capitalDictionary["UK"]; //UK is the key
           
            Console.WriteLine($"{ukCapital}");
            //Iterate over the keys and values
            foreach (KeyValuePair<string, string> kvp in capitalDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key} : {kvp.Value}");
            }

            // output a list of countries
            foreach (string country in capitalDictionary.Keys)
            {
                Console.WriteLine($"Country: {country}");
            }

            foreach (string capital in capitalDictionary.Values)
            {
             
                Console.WriteLine($"Capital:  {capital}");
            }
            // You can test for a key
            if(capitalDictionary.ContainsKey("Ireland"))
            {
                string irelandCapital = capitalDictionary["Ireland"]; //UK is the key

                Console.WriteLine($"The capital of Ireland is {capitalDictionary["Ireland"]}");
            }

           
        }

    }
}
