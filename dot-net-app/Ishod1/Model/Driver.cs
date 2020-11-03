namespace Ishod1.Model
{
    class Driver
    {
        public int IDDriver { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public int DrivingLicenceNumber { get; set; }

        public Driver(string firstName, string lastName, string telephone, int drivingLicenceNumber)
        {
            Firstname = firstName;
            Lastname = lastName;
            Telephone = telephone;
            DrivingLicenceNumber = drivingLicenceNumber;
        }

        public Driver(int idDriver, string firstName, string lastName, string telephone, int drivingLicenceNumber)
            : this(firstName, lastName, telephone, drivingLicenceNumber)
            => IDDriver = idDriver;

        public override string ToString() => $"{Firstname} {Lastname}";
    }
}
