using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public void Reset()
        {
            this._house = new House();
        }

        public void buildDoors()
        {
            this._house.Add("Door");
        }

        public void buildGarage()
        {
            this._house.Add("Garage");
        }

        public void buildRoof()
        {
            this._house.Add("Roof");
        }

        public void buildWalls()
        {
            this._house.Add("Wall");
        }

        public void buildWindows()
        {
            this._house.Add("Window");
        }

        public void buildSwimmingPool()
        {
            this._house.Add("Swimming Pool");
        }

        public void buildFancyStatues()
        {
            this._house.Add("Fancy Statues");
        }

        public void buildGarden()
        {
            this._house.Add("Garden");
        }

        public House GetHouse()
        {
            House result = this._house;

            this.Reset();

            return result;
        }
    }
}
