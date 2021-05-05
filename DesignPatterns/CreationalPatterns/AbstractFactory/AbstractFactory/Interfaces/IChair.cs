using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IChair
    {
        bool HasLegs();
        bool SitOn();

        string InformationAboutChair();
    }
}
