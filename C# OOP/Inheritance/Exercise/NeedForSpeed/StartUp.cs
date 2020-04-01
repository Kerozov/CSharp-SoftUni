namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var skdc = new Vehicle(2,5);
            var sportCar = new SportCar(2,4);
            sportCar.Drive(1);
        }
    }
}
