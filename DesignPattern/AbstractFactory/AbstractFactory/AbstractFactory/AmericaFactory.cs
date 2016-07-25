using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete factory
    class AmericaFactory : ContinentFactory
    {
        
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Grass CreateGrass()
        {
            return new Stepe();
        }
    }
}
