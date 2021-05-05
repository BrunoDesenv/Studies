using AbstractFactory.Class.Chair;
using AbstractFactory.Class.CoffeeTable;
using AbstractFactory.Class.Sofa;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
