using System;

namespace SpaceStationRecruitment
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("zefir", 11, "BG");
            var astronaut2 = new Astronaut("zefir", 13, "BG");
            var astronaut3 = new Astronaut("zefir", 14, "BG");
            var astronaut4 = new Astronaut("zefir", 15, "BG");
            var cosmos = new SpaceStation("Amfo",4);
            cosmos.Add(astronaut);
            cosmos.Add(astronaut);
            cosmos.Add(astronaut2);
            cosmos.Add(astronaut3);
            Console.WriteLine(cosmos.Count);
            Console.WriteLine(cosmos.Remove("zefir"));
            Console.WriteLine(cosmos.Report());
            Console.WriteLine(cosmos.GetOldestAstronaut());
            Console.WriteLine(cosmos.GetAstronaut("zefir"));
            
        }
    }
}
