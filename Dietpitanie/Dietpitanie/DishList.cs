using System.Collections.Generic;

namespace Dietpitanie
{
    public class DishList
    {
        public List<Dish>[] DishCatalog { get; set; }

        public void AddDish(Dish dish, int type)
        {
            DishCatalog[type].Add(dish);
        }

        public DishList(int size)
        {
            DishCatalog = new List<Dish>[size];
            for (int i = 0; i < size; i++)
            {
                DishCatalog[i] = new List<Dish>();
            }
        }

        public int LengthListDish(int i)
        {
            return DishCatalog[i].Count;
        }

        public Dish GetDish(int i, int j)
        {
            return DishCatalog[i][j];
        }
        
    }
}
