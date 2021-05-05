using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Class.Chair
{
    public class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return false;
        }

        public string InformationAboutChair()
        {
            return "I'm a modern chair.";
        }

        public bool SitOn()
        {
            return false;
        }
    }
}
