namespace Ishod1.Model
{
    class TravelWarrant
    {
        public int IDTravelWarrant { get; set; }
        public Driver Driver { get; set; }
        public Car Car { get; set; }
        public TravelWarrantType TravelWarrantType { get; set; }
        public Fuel Fuel { get; set; }
        public Route Route { get; set; }

        public TravelWarrant() { }

        public TravelWarrant(Driver driver, Car car, TravelWarrantType travelWarrantType, Fuel fuel, Route route)
        {
            Driver = driver;
            Car = car;
            TravelWarrantType = travelWarrantType;
            Fuel = fuel;
            Route = route;
        }

        public TravelWarrant(int idTravelWarrant, Driver driver, Car car, TravelWarrantType travelWarrantType, Fuel fuel, Route route)
            : this(driver, car, travelWarrantType, fuel, route) => IDTravelWarrant = idTravelWarrant;

        public override string ToString() => $"{Driver} - {Car}";
    }
}
