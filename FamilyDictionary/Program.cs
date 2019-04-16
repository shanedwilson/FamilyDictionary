using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily =
                new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("wife", new Dictionary<string, string>() {
                { "name", "Stacye" }, { "age", "54" } });

            myFamily.Add("son", new Dictionary<string, string>() {
                { "name", "Nazz" }, { "age", "15" } });

            myFamily.Add("sister-in-law", new Dictionary<string, string>() {
                { "name", "Jennifer" }, { "age", "41" } });

            //myFamily.Add("sister-in-law", new Dictionary<string, string>() {
            //    { "name", "Dana" }, { "age", "43" } });

            myFamily.Add("sister", new Dictionary<string, string>() {
                { "name", "Krista" }, { "age", "46" } });

            //foreach (var member in myFamily)
            //{
            //    foreach (var set in member.Value)
            //    {
            //        Console.WriteLine($"{set.Value} is my {member.Key} and is {set.Value} years old.");
            //    }
            //}

            foreach (var (key, value) in myFamily)
            {
                Console.WriteLine($"{myFamily[key]["name"]} is my {key} and is " +
                    $"{myFamily[key]["age"]} years old.");
            }
            Console.ReadKey();
        }
    }
}
