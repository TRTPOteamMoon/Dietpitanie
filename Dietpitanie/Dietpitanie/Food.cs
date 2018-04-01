using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietpitanie
{
    class Food
    {
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
        public double Weight { get; set; }

        public Food(string name, double proteins, double fats, double carbohydrates)
        {
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Weight = 0;
        }

        public Food(string name, double proteins, double fats, double carbohydrates, double weight)
        {
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Weight = weight;
        }
    }
}
