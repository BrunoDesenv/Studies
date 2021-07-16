using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAdapterPattern.Models
{
    public class Apple : ISkinnable
    {

        public void Skin()
        {
            Console.WriteLine("Skin an apple.");
        }
    }
}
