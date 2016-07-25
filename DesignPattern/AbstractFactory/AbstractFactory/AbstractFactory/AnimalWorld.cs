using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        private Grass _grass;
        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
            _grass = factory.CreateGrass();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
            _herbivore.Eat(_grass);
            //Todo treat herbivore's menu
        }
    }
}
