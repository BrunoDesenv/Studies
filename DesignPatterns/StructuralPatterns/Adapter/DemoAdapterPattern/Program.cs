using DemoAdapterPattern.Adapters;
using DemoAdapterPattern.Models;
using System;
using System.Collections.Generic;

namespace DemoAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execute client
            ExecuteClient();
        }

        private static void ExecuteClient()
        {
            var bagOdPeelableFruit = new List<IPeelable>();

            bagOdPeelableFruit.Add(new Orange());

            bagOdPeelableFruit.Add(new Banana());

            bagOdPeelableFruit.Add(new SkinnableToPeelableAdapter(new Apple()));

            bagOdPeelableFruit.Add(new SkinnableToPeelableAdapter(new Pear()));

            //peel all fruit in our bag
            foreach (var fruit in bagOdPeelableFruit)
            {
                fruit.Peel();
            }
        }
    }
}
