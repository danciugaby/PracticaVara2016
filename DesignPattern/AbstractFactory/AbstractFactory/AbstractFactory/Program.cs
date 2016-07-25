using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalWorld> worlds = new List<AnimalWorld>();
            List<ContinentFactory> list = new List<ContinentFactory>();
            list.Add( new AfricaFactory());
            worlds.Add( new AnimalWorld(list[0]));
            
            list.Add(new AmericaFactory());
            worlds.Add( new AnimalWorld(list[1]));

            worlds[0].RunFoodChain();
            worlds[1].RunFoodChain();
        }
    }
}
