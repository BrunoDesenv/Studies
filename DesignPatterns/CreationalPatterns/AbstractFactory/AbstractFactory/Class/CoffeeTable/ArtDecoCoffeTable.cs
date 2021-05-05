using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.CoffeeTable
{
    public class ArtDecoCoffeTable : ICoffeeTable
    {
        public string InformationAboutCoffeeTable()
        {
            return "I'm an art deco coffe table";
        }
    }
}
