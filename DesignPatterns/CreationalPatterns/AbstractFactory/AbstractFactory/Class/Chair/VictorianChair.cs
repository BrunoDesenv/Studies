using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Chair
{
    public class VictorianChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public string InformationAboutChair()
        {
            return "I'm a victorian chair";
        }

        public bool SitOn()
        {
            return true;
        }
    }
}
