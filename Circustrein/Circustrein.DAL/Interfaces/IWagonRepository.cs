using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Domain.Models;

namespace Circustrein.DAL.Interfaces
{
    public interface IWagonRepository
    {
        void AddAnimal(Animal animal);
    }
}
