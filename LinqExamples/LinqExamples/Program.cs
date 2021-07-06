using System.Collections.Generic;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] names = { "Bruno", "Rafael", "Amanda", "Lucas", "Renato" };
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            //Aggregation.Aggregate(numbers);
            //Aggregation.AggregateSeed(numbers);
            //Aggregation.Average(numbers);
            //Aggregation.Count(names);
            //Aggregation.Max(numbers);
            //Aggregation.LongCount();

           // Conversion.AsEnumerable(names);
            Conversion.Cast(vegetables);
        }

    }
}
