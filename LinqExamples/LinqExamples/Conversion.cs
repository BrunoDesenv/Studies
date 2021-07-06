using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    public static class Conversion
    {
        //This Lambda Expression sample casts array of strings to its corresponding IEnumerable.
        public static void AsEnumerable(string[] names)
        {
            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
        }

        //This Lambda Expression sample casts list of strings to a simple string array.
        public static void Cast(List<string> vegetables)
        {
            var result = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
        }
    }
}
