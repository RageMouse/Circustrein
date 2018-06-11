using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.DAL;
using Circustrein.DAL.Interfaces;
using Circustrein.Domain.Models;
using Circustrein.Logic.Interfaces;

namespace Circustrein.Logic
{
    public class WagonLogic : IWagonLogic
    {
        private IWagonRepository _context { get; set; }

        public WagonLogic()
        {
            _context = new WagonRepository();
        }

        public void AddAnimal(Animal animal)
        {
            _context.AddAnimal(animal);
        }
    }
}
