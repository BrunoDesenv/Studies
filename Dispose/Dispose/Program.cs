using System;

namespace Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DisposableTest obj = new DisposableTest())
            {
                Console.WriteLine("DisposableTest object is created..");
                obj.Print("Good Morning..");
            }
            Console.WriteLine("Assigned null..  Object is destructing..");
            Console.ReadLine();
        }
    }
}
