using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal doggy = new Dog();
            Animal birdi = new Bird();

            Console.WriteLine($"Dog : {doggy.TryToFly()}");
            Console.WriteLine($"Bird : {birdi.TryToFly()}");

            //set new flying strategy to bird
            birdi.SetFlyingType(new ItCantFly());
            Console.WriteLine($"Bird : {birdi.TryToFly()}");

            Console.ReadKey();
        }
    }
}
