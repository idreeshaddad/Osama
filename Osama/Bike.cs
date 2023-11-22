namespace Osama
{
    public class Bike : Vehicle
    {
        public string ChainLength { get; set; }
        public bool IsHandClutchOn { get; set; }
        public string JackType { get; set; }

        public void DoAWheely()
        {
            Console.WriteLine("Doing a wheely");
        }
    }
}
