using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAdapterPattern.Models
{
    public class Orange : IPeelable
    {
        public void Peel()
        {
            Console.WriteLine("Peel an orange");
        }
    }
}
