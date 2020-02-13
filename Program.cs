﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            
            
            Planets();
            SpaceStation();   
        }

        public static void Planets()
        {
            var planetA = new Planet();
            planetA.Name = "Earth : Trade Station Terra ";
            planetA.PlanetCoord = "longitude: 179° 56′ 39.4 : latitude: +0° 2′ 46.2";
            planetA.Size = "Diameter 4,196 MILES (6,752 KM)";
            planetA.DistancefromStar = "141,635,350 Miles (227,940,00 KM)";
            planetA.Population = "7.6B Terrains";
            planetA.Climate = "Ranges from extreme cold at the poles to tropical heat at the Equator";
            planetA.Atmoshphere = "78% Nitrogen,  21% Oxygen, 0.93% Argon, 0.04% Carbon Dioxide";
            planetA.TradeSupply = "FoodRations, Fuel, Medical Supplies, Mining Equipment, Luxury Items, Water";
            planetA.TradeDemand = "Mineral Ores, Metals, Energy Batteries";

            var planetB = new Planet();
            planetB.Name = "Mars : Trade Port Aries";
            planetB.PlanetCoord = "longitude: 179° 56′ 39.4 : latitude: +0° 2′ 46.2";
            planetB.Size = "Diameter 8,000 MILES (13,000 KM)";
            planetB.DistancefromStar = "141,635,350 Miles (227,940,00 KM)";
            planetB.Population = "120K Colonists";
            planetB.Climate = "Average temperature -80F";
            planetB.Atmoshphere = "95% Carbon Dioxide, 3% Nitrogen, 1.6% Argon";
            planetB.TradeSupply = "Metals, Mineral Ores, Water, Medical Supplies";
            planetB.TradeDemand = "Food Rations, Fuel, Equipment Parts";

            var planetC = new Planet();
            planetC.Name = "Moon : Mining Station Arklay";
            planetB.PlanetCoord = "longitude: 179° 56′ 39.4 : latitude: +0° 2′ 46.2";
            planetB.Size = "Diameter 2900 Miles (4600 kilometres)";
            planetB.DistancefromStar = "150,245,120 Miles (241,796,082 KM)";
            planetB.Population = "10K Colonists";
            planetB.Climate = "Average temperature : -300F";
            planetB.Atmoshphere = "95% Carbon Dioxide, 3% Nitrogen, 1.6% Argon";
            planetB.TradeSupply = "Water, Food Rations, Mineral Ore";
            planetB.TradeDemand = "Seeds, Medical Supplies, Fuel, Food Rations";
        }

        public static void SpaceStation()
        {
            var spacestationA = new SpaceStation();
            spacestationA.StationName = "Trade Station : Hadley's Hope";
            spacestationA.StationCoord = ;
            spacestationA.Size = "2900 Miles (4600 kilometres)";
            spacestationA.Population = "8,000 Stationers";
            spacestationA.TradeSupply = "Food Rations, Mineral Ore";
            spacestationA.TradeDemand = "Seeds, Medical Supplies, Fuel, Food Rations";
        }
        




    }

   
    


}
    