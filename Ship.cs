using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Ship
    {
        public string ShipName;
        public int ShipSpeed;
        public int CargoCap;


        public static void SpaceShip()
        {
            var spaceship = new Ship();
            spaceship.ShipName = "Phoenix";
            spaceship.CargoCap = 1000;
            spaceship.ShipSpeed = 90;
        }
    }
}
