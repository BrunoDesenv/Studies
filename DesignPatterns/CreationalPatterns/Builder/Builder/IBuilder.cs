using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void buildWalls();
        void buildDoors();
        void buildWindows();
        void buildRoof();
        void buildGarage();
        void buildSwimmingPool();
        void buildFancyStatues();
        void buildGarden();
    }
}
