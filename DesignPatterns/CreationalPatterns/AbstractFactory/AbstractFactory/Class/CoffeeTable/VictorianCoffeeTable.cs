using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.CoffeeTable
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public string InformationAboutCoffeeTable()
        {
            return "I'm a victorian coffe table";
        }
    }
}
