using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.CoffeeTable
{
    public class ModernCoffeeTable : ICoffeeTable
    {
        public string InformationAboutCoffeeTable()
        {
            return "I'm a modern coffe table";
        }
    }
}
