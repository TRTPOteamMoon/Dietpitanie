using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietpitanie
{
    class FoodList
    {
        public List<Food>[] FoodCatalog { get; set; }

        public void AddFood(Food food,int type)
        {
            FoodCatalog[type].Add(food);
        }

        public FoodList(int size)
        {
            FoodCatalog = new List<Food>[size];
            for (int i = 0; i < size; i++)
            {
                FoodCatalog[i]= new List<Food>();
            }
        }
    }
}
