using System;

namespace DemoAdapterPattern.Models
{
    public class Pear : ISkinnable
    {
        public void Skin()
        {
            Console.WriteLine("Skin a pear.");
        }
    }
}
