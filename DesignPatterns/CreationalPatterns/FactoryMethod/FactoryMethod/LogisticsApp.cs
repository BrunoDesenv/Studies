using System;

namespace FactoryMethod
{
    public static class LogisticsApp
    {
        public static void TransportCode(Logistics logistic)
        {
            Console.WriteLine("I'm not aware of the creator's class," +
                "but it still works.\n" + logistic.SomeOperation());
        }
    }
}
