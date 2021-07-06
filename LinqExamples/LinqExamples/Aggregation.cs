using System;
using System.Linq;

namespace LinqExamples
{
    public static class Aggregation
    {
        //This Lambda Expression sample aggregates numbers in array by multiplication.
        public static void Aggregate(int[] numbers)
        {
            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample aggregates numbers in array by addition, using a seed (seed is an initial value).
        public static void AggregateSeed(int[] numbers)
        {
            var result = numbers.Aggregate(10, (a, b) => a + b);

            Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample calculates the average of values in array.
        public static void Average(int[] numbers)
        {
            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample counts names in array.
        public static void Count(string[] names)
        {
            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample counts elements in array larger than Int32.MaxValue.
        public static void LongCount()
        {
            var largeArr = Enumerable.Range(0, int.MaxValue).Concat(Enumerable.Range(0, 5));

            long result = largeArr.LongCount();

            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample finds the highest number in array.
        public static void Max(int[] numbers)
        {
            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

        //This Lambda Expression sample finds the lowest number in array.
        public static void Min(int[] numbers)
        {
            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }

        //	This Lambda Expression sample sums three numbers in array.
        public static void Sum(int[] numbers)
        {
            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }
    }
}
