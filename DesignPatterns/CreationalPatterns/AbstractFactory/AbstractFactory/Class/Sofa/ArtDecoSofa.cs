using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Sofa
{
    public class ArtDecoSofa : ISofa
    {
        public string InformationAboutSofa()
        {
            return "I'm an art deco sofa";
        }
    }
}
