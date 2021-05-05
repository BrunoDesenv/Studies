using AbstractFactory.Class.Chair;
using AbstractFactory.Class.Chair;
using AbstractFactory.Class.CoffeeTable;
using AbstractFactory.Class.Sofa;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
