namespace Ishod1.Model
{
    class Car
    {
        public int IDCar { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int InitialMileage { get; set; }

        public Car(string brand, string model, int year, int initialMileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            InitialMileage = initialMileage;
        }

        public Car(int idCar, string brand, string model, int year, int initialMileage) : this(brand, model, year, initialMileage)
            => IDCar = idCar;

        public override string ToString() => $"{Brand} {Model}";
    }
}
