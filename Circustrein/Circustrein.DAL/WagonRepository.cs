using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.DAL.Interfaces;
using Circustrein.Domain.Models;

namespace Circustrein.DAL
{
    public class WagonRepository : IWagonRepository
    {
        private List<Animal> animals;

        public WagonRepository()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
