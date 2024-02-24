using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numEntries = int.Parse(Console.ReadLine().Trim());

        Dictionary<string, Dictionary<string, HashSet<string>>> cityDictionary = new Dictionary<string, Dictionary<string, HashSet<string>>>();

        for (int i = 0; i < numEntries; i++)
        {
            string[] input = Console.ReadLine().Trim().Split();
            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!cityDictionary.ContainsKey(continent))
            {
                cityDictionary[continent] = new Dictionary<string, HashSet<string>>();
            }

            if (!cityDictionary[continent].ContainsKey(country))
            {
                cityDictionary[continent][country] = new HashSet<string>();
            }

            cityDictionary[continent][country].Add(city);
        }

        PrintCityDictionary(cityDictionary);
    }

    static void PrintCityDictionary(Dictionary<string, Dictionary<string, HashSet<string>>> cityDictionary)
    {
        foreach (var continentCountries in cityDictionary)
        {
            Console.WriteLine($"{continentCountries.Key}:");
            foreach (var countryCities in continentCountries.Value)
            {
                Console.WriteLine($"  {countryCities.Key} -> {string.Join(", ", countryCities.Value)}");
            }
        }
    }
}
