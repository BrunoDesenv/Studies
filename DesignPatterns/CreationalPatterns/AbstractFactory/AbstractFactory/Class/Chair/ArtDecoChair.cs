using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Chair
{
    public class ArtDecoChair : IChair
    {
        public bool HasLegs()
        {
            return false;
        }

        public string InformationAboutChair()
        {
            return "I'm an art deco chair.";
        }

        public bool SitOn()
        {
            return true;
        }
    }
}
