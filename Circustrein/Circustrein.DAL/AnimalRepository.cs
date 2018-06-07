using Circustrein.DAL.Interfaces;
using Circustrein.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.DAL
{
    public class AnimalRepository : IAnimalRepository
    {
        private List<Animal> animals;

        public AnimalRepository()
        {
            animals = new List<Animal>();
        }

        public List<Animal> GetAllAnimals()
        {
            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
