﻿namespace Ishod1.Model
{
    class Route
    {
        public int IDRoute { get; set; }
        public int TimeHours { get; set; }
        public City CityA { get; set; }
        public City CityB { get; set; }
        public int Kilometers { get; set; }
        public int AvgSpeed { get; set; }
        public int FuelUsed { get; set; }

        public Route() { }

        public Route(int time, City cityA, City cityB, int kilometers, int avgSpeed, int fuelUsed)
        {
            TimeHours = time;
            CityA = cityA;
            CityB = cityB;
            Kilometers = kilometers;
            AvgSpeed = avgSpeed;
            FuelUsed = fuelUsed;
        }

        public Route(int idRoute, int time, City cityA, City cityB, int kilometers, int avgSpeed, int fuelUsed)
            : this(time, cityA, cityB, kilometers, avgSpeed, fuelUsed) => IDRoute = idRoute;

        public override string ToString() => $"{CityA} -> {CityB}";
    }
}
