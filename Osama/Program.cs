namespace Osama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car idreesCar = new Car();
            idreesCar.NumberOfCupHolder = 2;
            idreesCar.DriveShaft = "Gold";
            idreesCar.LicenseNumber = "20-30209";
            idreesCar.NumberOfDoors = 4;
            idreesCar.Accelerate();

            Bike omarBike = new Bike();
            omarBike.PlateNumber = "10-50207";
            omarBike.ChainLength = "1";
            omarBike.Accelerate();

            Vehicle v1 = new Vehicle();
        }
    }
}