using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ISofa CreateSofa();
    }
}
