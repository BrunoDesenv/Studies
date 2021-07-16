using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAdapterPattern.Models
{
    public class Banana : IPeelable
    {
        public void Peel()
        {
            Console.WriteLine("Peel a banana");
        }
    }
}
