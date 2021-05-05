using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Sofa
{
    public class ModernSofa : ISofa
    {
        public string InformationAboutSofa()
        {
            return "I'm a modern sofa";
        }
    }
}
