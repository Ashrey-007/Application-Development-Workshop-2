using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };


        fruits.Add("Orange");


        fruits.Remove("Mango"); 


        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

   
        fruitDictionary.Add(4, "Orange");


        Console.WriteLine("\nFruit Dictionary:");
        foreach (KeyValuePair<int, string> kvp in fruitDictionary)
        {
            Console.WriteLine("ID: " + kvp.Key + ", Name: " + kvp.Value);
        }
    }
}