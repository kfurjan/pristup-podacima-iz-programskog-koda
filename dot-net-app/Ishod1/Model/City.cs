namespace Ishod1.Model
{
    class City
    {
        public int IDCity { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string County { get; set; }
        public string Capital { get; set; }
        public int? Population { get; set; }
        public int? PopulationProper { get; set; }

        public City(string name, double latitude, double longitude, string country, string countryCode,
            string county, string capital, int? population, int? populationProper)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Country = country;
            CountryCode = countryCode;
            County = county;
            Capital = capital;
            Population = population;
            PopulationProper = populationProper;
        }

        public City(int idCity, string name, double latitude, double longitude, string country, string countryCode,
            string county, string capital, int? population, int? populationProper)
            : this(name, latitude, longitude, country, countryCode, county, capital, population, populationProper)
            => IDCity = idCity;

        public City() { }

        public override string ToString() => $"{Name}";
    }
}
