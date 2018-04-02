using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietpitanie
{
    public class MenuMaker
    {
        public DishList DishList;
        public DishList MenuList;
        private Human Human;
        private double[] KashaWeight = {200, 600};
        private double[] ZakuskaWeight = {50, 200};
        private double[] FirstWeight = {200, 600};
        private double[] SecondWeight = {200, 350};
        private double[] GarnirWeight = {150, 350};


        public MenuMaker(DishList dishList,Human human)
        {
            Human = human;
            DishList = dishList;
            MenuList = new DishList(3);
        }

        public void CreateBreakfast()
        {
            int good = 0;
            while (good==0)
            {
                Dish dish1, dish2;
                Random rnd = new Random();
                int first = rnd.Next(0, 10000000);
                first = first % DishList.LengthListDish(0);
                dish1 = DishList.GetDish(0, first);
                int second = rnd.Next(0, 10000000);
                second = second % DishList.LengthListDish(1);
                dish2 = DishList.GetDish(1, second);
                double calories = 0.85 * 3 / 8 * Human.Calories;
                double proteins = 0.85 * 3 / 8 * Human.Proteins;
                double fats = 0.85 * 3 / 8 * Human.Fats;
                double carbohydrates = 0.85 * 3 / 8 * Human.Carbohydrates;
                double weight1, weight2;
                double calories1, calories2;
                double carbo1, carbo2;
                weight1 = calories * 0.7 / dish1.Calories * 100;
                weight2 = calories * 0.3 / dish2.Calories * 100;
                calories1 = weight1 / 100 * dish1.Calories;
                calories2 = weight2 / 100 * dish2.Calories;
                carbo1 = weight1 / 100 * dish1.Carbohydrates;
                carbo2 = weight2 / 100 * dish2.Carbohydrates;
                if ((weight1 < KashaWeight[1]) && (weight1 > KashaWeight[0]) && (weight2 < ZakuskaWeight[1]) &&
                    (weight2 > ZakuskaWeight[0]))
                {
                    good = 1;
                    dish1.Weight = weight1;
                    dish2.Weight = weight2;
                    MenuList.AddDish(dish1,0);
                    MenuList.AddDish(dish1, 0);
                }
            }
        }

        public void CreateLunch()
        {
            int good = 0;
            while (good == 0)
            {
                Dish dish1, dish2;
                Random rnd = new Random();
                int first = rnd.Next(0, 10000000);
                first = first % DishList.LengthListDish(2);
                dish1 = DishList.GetDish(2, first);
                int second = rnd.Next(0, 10000000);
                second = second % DishList.LengthListDish(3);
                dish2 = DishList.GetDish(3, second);
                double calories = 0.85 * 3 / 8 * Human.Calories;
                double proteins = 0.85 * 3 / 8 * Human.Proteins;
                double fats = 0.85 * 3 / 8 * Human.Fats;
                double carbohydrates = 0.85 * 3 / 8 * Human.Carbohydrates;
                double weight1, weight2;
                double calories1, calories2;
                double carbo1, carbo2;
                weight1 = calories * 0.3 / dish1.Calories * 100;
                weight2 = calories * 0.7 / dish2.Calories * 100;
                calories1 = weight1 / 100 * dish1.Calories;
                calories2 = weight2 / 100 * dish2.Calories;
                carbo1 = weight1 / 100 * dish1.Carbohydrates;
                carbo2 = weight2 / 100 * dish2.Carbohydrates;
                if ((weight1 < FirstWeight[1]) && (weight1 > FirstWeight[0]) && (weight2 < SecondWeight[1]) &&
                    (weight2 > SecondWeight[0]))
                {
                    good = 1;
                    dish1.Weight = weight1;
                    dish2.Weight = weight2;
                    MenuList.AddDish(dish1, 1);
                    MenuList.AddDish(dish1, 1);
                }
            }
        }

        public void CreateSupper()
        {
            int good = 0;
            while (good == 0)
            {
                Dish dish1, dish2;
                Random rnd = new Random();
                int first = rnd.Next(0, 10000000);
                first = first % DishList.LengthListDish(4);
                dish1 = DishList.GetDish(4, first);
                int second = rnd.Next(0, 10000000);
                second = second % DishList.LengthListDish(1);
                dish2 = DishList.GetDish(1, second);
                double calories = 0.85 * 3 / 8 * Human.Calories;
                double proteins = 0.85 * 3 / 8 * Human.Proteins;
                double fats = 0.85 * 3 / 8 * Human.Fats;
                double carbohydrates = 0.85 * 3 / 8 * Human.Carbohydrates;
                double weight1, weight2;
                double calories1, calories2;
                double carbo1, carbo2;
                weight1 = calories * 0.7 / dish1.Calories * 100;
                weight2 = calories * 0.3 / dish2.Calories * 100;
                calories1 = weight1 / 100 * dish1.Calories;
                calories2 = weight2 / 100 * dish2.Calories;
                carbo1 = weight1 / 100 * dish1.Carbohydrates;
                carbo2 = weight2 / 100 * dish2.Carbohydrates;
                if ((weight1 < GarnirWeight[1]) && (weight1 > GarnirWeight[0]) && (weight2 < ZakuskaWeight[1]) &&
                    (weight2 > ZakuskaWeight[0]))
                {
                    good = 1;
                    dish1.Weight = weight1;
                    dish2.Weight = weight2;
                    MenuList.AddDish(dish1, 2);
                    MenuList.AddDish(dish1, 2);
                }
            }
        }
    }
}
