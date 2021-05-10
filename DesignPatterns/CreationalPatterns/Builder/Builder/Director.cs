using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildHouse()
        {
            this._builder.buildWalls();
            this._builder.buildDoors();
            this._builder.buildWindows();
            this._builder.buildRoof();
        }

        public void BuildHouseWithGarage()
        {
            BuildHouse();
            this._builder.buildGarage();
        }

        public void BuildHouseWithSwimmingPool()
        {
            BuildHouse();
            this._builder.buildSwimmingPool();
        }

        public void BuildHouseWithFancyStatues()
        {
            BuildHouse();
            this._builder.buildFancyStatues();
        }

        public void BuildHouseWithGarden()
        {
            BuildHouse();
            this._builder.buildGarden();
        }
    }
}
