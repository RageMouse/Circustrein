using Circustrein.Domain.Models;
using Circustrein.Logic;
using Circustrein.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        private IAnimalLogic _context { get; set; }

        public Form1()
        {
            InitializeComponent();

            _context = new AnimalLogic();
            lvWagon.Visible = false;
            cbSize.DataSource = Enum.GetValues(typeof(AnimalSize));
            cbFood.DataSource = Enum.GetValues(typeof(FoodType));
        }

        private void btnAddAnimals_Click(object sender, EventArgs e)
        {
            if (numAmountOfAnimals.Value > 0)
            {
                AnimalSize size = (AnimalSize)Enum.Parse(typeof(AnimalSize), cbSize.SelectedValue.ToString());
                FoodType foodtype = (FoodType)Enum.Parse(typeof(FoodType), cbFood.SelectedValue.ToString());
                int points = (int)size;

                //Aantal animals aanmaken
                for (int i = 0; i < numAmountOfAnimals.Value; i++)
                {
                    Animal a = new Animal();
                    a.animalSize = size;
                    a.foodType = foodtype;
                    a.points = points;
                    _context.AddAnimal(a);

                    //Toevoegen aan listview
                    var item = new ListViewItem(new[] { cbSize.SelectedValue.ToString(), cbFood.SelectedValue.ToString(), points.ToString() });
                    lvAnimals.Items.Add(item);
                }
            }
        }

        private void RefreshWagonList()
        {
            lvWagon.Items.Clear();

            Stopwatch time = new Stopwatch();
            time.Start();
            Trein trein = _context.PerformAlghoritm();
            time.Stop();

            Debug.Write(time.Elapsed);

            foreach (Wagon w in trein.wagons.OrderByDescending(w => w.FreePoints))
            {
                var item = new ListViewItem(new[] { w.FreePoints.ToString(), w.animals.ToString() });
                lvWagon.Items.Add(item);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lvAnimals.Visible = false;
            lvWagon.Visible = true;

            RefreshWagonList();
        }
    }
}
