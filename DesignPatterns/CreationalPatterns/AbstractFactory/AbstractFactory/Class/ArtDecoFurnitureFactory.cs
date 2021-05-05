using AbstractFactory.Class.Chair;
using AbstractFactory.Class.CoffeeTable;
using AbstractFactory.Class.Sofa;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
