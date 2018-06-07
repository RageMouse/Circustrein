using Circustrein.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.DAL.Interfaces
{
    public interface IAnimalRepository
    {
        List<Animal> GetAllAnimals();
        void AddAnimal(Animal animal);
    }
}
