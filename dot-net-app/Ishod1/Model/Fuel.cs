using System;

namespace Ishod1.Model
{
    class Fuel
    {
        public int IDFuel { get; set; }
        public DateTime Time { get; set; }
        public Driver Driver { get; set; }
        public City FuelCity { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public Fuel(DateTime time, Driver driver, City city, int amount, int price)
        {
            Time = time;
            Driver = driver;
            FuelCity = city;
            Amount = amount;
            Price = price;
        }

        public Fuel(int idFuel, DateTime time, Driver driver, City city, int amount, int price)
            : this(time, driver, city, amount, price) => IDFuel = idFuel;

        public override string ToString() => $"{FuelCity}, {Amount}L, {Price}$";
    }
}
