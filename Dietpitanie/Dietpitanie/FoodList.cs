using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietpitanie
{
    public class FoodList
    {
        public string[] FoodType = new[]
        {
            "все виды",
            "мясопродукты и яйца",
            "рыба и морепродукты",
            "молочные продукты",
            "зерновые и хлебо-булочные",
            "фрукты, овощи, ягоды",
            "масла, соусы",
            "напитки",
            "кондитерские изделия"
        };

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

        public int LengthListFood(int i)
        {
            return FoodCatalog[i].Count;
        }

        public int IndexListFood(string type)
        {
            int t = 0;
            for (int i = 0; i < FoodType.Length; i++)
            {
                if (type == FoodType[i])
                    t = i;
            }

            return t;
        }

        public Food GetFood(int i, int j)
        {
            return FoodCatalog[i][j];
        }
    }
}
