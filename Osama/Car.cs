namespace Osama
{
    public class Car : Vehicle
    {
        public string DriveShaft { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfCupHolder { get; set; }
        public bool IsTrunkOpen { get; set; }


        public void OpenDoor()
        {
            Console.WriteLine("The door is open");
        }
    }
}
