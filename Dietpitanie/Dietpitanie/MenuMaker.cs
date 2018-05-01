using System;

namespace Dietpitanie
{
    public class MenuMaker
    {
        public DishList DishList;
        public DishList MenuList;
        private Human _human;
        private double[] _kashaWeight = {200, 600};
        private double[] _zakuskaWeight = {50, 200};
        private double[] _firstWeight = {200, 600};
        private double[] _secondWeight = {200, 350};
        private double[] _garnirWeight = {150, 350};


        public MenuMaker(DishList dishList,Human human)
        {
            _human = human;
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
                double calories = 0.85 * 3 / 8 * _human.Calories;
                double weight1, weight2;
                weight1 = calories * 0.7 / dish1.Calories * 100;
                weight2 = calories * 0.3 / dish2.Calories * 100;
                if ((weight1 < _kashaWeight[1]) && (weight1 > _kashaWeight[0]) && (weight2 < _zakuskaWeight[1]) &&
                    (weight2 > _zakuskaWeight[0]))
                {
                    good = 1;
                    dish1.Weight = Math.Round(weight1,MidpointRounding.AwayFromZero);
                    dish2.Weight = Math.Round(weight2, MidpointRounding.AwayFromZero);
                    MenuList.AddDish(dish1,0);
                    MenuList.AddDish(dish2, 0);
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
                double calories = 0.85 * 3 / 8 * _human.Calories;
                double weight1, weight2;
                weight1 = calories * 0.3 / dish1.Calories * 100;
                weight2 = calories * 0.7 / dish2.Calories * 100;
                if ((weight1 < _firstWeight[1]) && (weight1 > _firstWeight[0]) && (weight2 < _secondWeight[1]) &&
                    (weight2 > _secondWeight[0]))
                {
                    good = 1;
                    dish1.Weight = Math.Round(weight1, MidpointRounding.AwayFromZero);
                    dish2.Weight = Math.Round(weight2, MidpointRounding.AwayFromZero);
                    MenuList.AddDish(dish1, 1);
                    MenuList.AddDish(dish2, 1);
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
                double calories = 0.85 * 3 / 8 * _human.Calories;
                double weight1, weight2;
                weight1 = calories * 0.7 / dish1.Calories * 100;
                weight2 = calories * 0.3 / dish2.Calories * 100;
                if ((weight1 < _garnirWeight[1]) && (weight1 > _garnirWeight[0]) && (weight2 < _zakuskaWeight[1]) &&
                    (weight2 > _zakuskaWeight[0]))
                {
                    good = 1;
                    dish1.Weight = Math.Round(weight1, MidpointRounding.AwayFromZero);
                    dish2.Weight = Math.Round(weight2, MidpointRounding.AwayFromZero);
                    MenuList.AddDish(dish1, 2);
                    MenuList.AddDish(dish2, 2);
                }
            }
        }
    }
}
