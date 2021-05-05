using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Sofa
{
    public class VictorianSofa : ISofa
    {
        public string InformationAboutSofa()
        {
            return "I'm a victorian sofa";
        }
    }
}
