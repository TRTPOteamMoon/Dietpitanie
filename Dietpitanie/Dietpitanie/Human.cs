using System;
using System.Collections.Generic;

namespace Dietpitanie
{
    public class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
        public int Sex { get; set; }
        public double Index { get; set; }
        public double Bmr { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Calories { get; set; }
        public double Carbohydrates { get; set; }
        public List<Food> EatFood { get; set; }
        public List<Dish> EatDish { get; set; }
        public double EatProteins { get; set; }
        public double EatFats { get; set; }
        public double EatCarbohydrates { get; set; }
        public double EatCalories { get; set; }
        public double LeftProteins { get; set; }
        public double LeftFats { get; set; }
        public double LeftCarbohydrates { get; set; }
        public double LeftCalories { get; set; }
        public List<Dish> MenuList { get; set; }
        public List<Food> SuggestFoodList { get; set; }
        public int Correction { get; set; }

        public Human (double height, double weight, double age, int sex)
        {
            Height = height;
            Weight = weight;
            Age = age;
            Sex = sex;
            EatFood = new List<Food>();
            EatDish = new List<Dish>();
            MenuList = new List<Dish>();
            SuggestFoodList = new List<Food>();
            EatCalories = 0;
            EatCarbohydrates = 0;
            EatFats = 0;
            EatProteins = 0;
            Correction = 1;
        }

        public Human()
        {
            Height = 0;
            Weight = 0;
            Age = 0;
            Sex = 0;
            EatFood = new List<Food>();
            EatDish = new List<Dish>();
            MenuList = new List<Dish>();
            SuggestFoodList = new List<Food>();
            EatCalories = 0;
            EatCarbohydrates = 0;
            EatFats = 0;
            EatProteins = 0;
            Correction = 1;
        }

        public void CalcuteIndex()
        {
            Index = Weight / (Height/100 * Height/100);
        }

        public string CompareIndex()
        {
            if (Index < 16)
                return "Выраженный дефицит массы тела";
            if (Index < 18.5 && Index > 16)
                return "Дефицит массы тела";
            if (Index >= 18.5 && Index < 25)
                return "Нормальный вес";
            if (Index >= 25 && Index < 30)
                return "Предожирение";
            if (Index >= 30 && Index < 35)
                return "Ожирение 1 степени";
            if (Index >= 35 && Index < 40)
                return "Ожирение 2 степени";
            return "Ожирение 3 степени";
        }

        public void CalculateBmr(string activity1Type,string activity2Type, string timer)
        {
            Bmr = 9.99 * Weight + 6.25 * Height - 4.95 * Age;
            if (Sex==1)
            {
                Bmr += 5;
            }
            else
            {
                Bmr -= 161;
            }

            switch (activity1Type)
            {
                case "сидячая работа, отсутствие спорта":
                    Bmr = Bmr * 1.2;
                    break;
                case "легкие физические упражнения около 3 раз за неделю, ежедневная утренняя зарядка, пешие прогулки":
                    Bmr = Bmr * 1.35;
                    break;
                case "спорт до 5 раз за неделю":
                    Bmr = Bmr * 1.55;
                    break;
                case "активный образ жизни вкупе с ежедневными интенсивными тренировками":
                    Bmr = Bmr * 1.75;
                    break;
                case "спортивный образ жизни, тяжелый физический труд, длительные тяжелые тренировки каждый день":
                    Bmr = Bmr * 1.95;
                    break;
            }

            var time = timer.Length == 0 ? 0 : double.Parse(timer); 

            if (time > 0)
            {
                switch (activity2Type)
                {
                    case "ничего":
                        break;
                    case "велоспорт":
                        Bmr += 660 * time / 60;
                        break;
                    case "бег трусцой":
                        Bmr += 600 * time / 60;
                        break;
                    case "волейбол":
                        Bmr += 350 * time / 60;
                        break;
                    case "гимнастика":
                        Bmr += 440 * time / 60;
                        break;
                    case "катание на коньках":
                        Bmr += 400 * time / 60;
                        break;
                    case " плавние":
                        Bmr += 350 * time / 60;
                        break;
                }
            }

            Calories = Math.Round(Bmr,2);
        }

        public void CalculateMacroelemnts()
        {
            Proteins = Math.Round(Weight * 1.3,2);
            Fats = Math.Round(Weight * 0.5,2);
            Carbohydrates = Math.Round((Bmr - Proteins * 4 - Fats * 9) / 4,2);
        }

        public void Count()
        {
            EatCalories = 0;
            EatCarbohydrates = 0;
            EatFats = 0;
            EatProteins = 0;
            if (EatFood.Count == 0 && EatDish.Count == 0)
            {
                LeftCalories = 0;
                LeftProteins = 0;
                LeftFats = 0;
                LeftCarbohydrates = 0;
                return;
            }

            foreach (var t in EatFood)
            {
                EatCalories += t.Calories * t.Weight*0.01;
                EatProteins += t.Proteins * t.Weight*0.01;
                EatFats += t.Fats * t.Weight*0.01;
                EatCarbohydrates += t.Carbohydrates * t.Weight*0.01;

            }
            foreach (var t in EatDish)
            {
                EatCalories += t.Calories * t.Weight * 0.01;
                EatProteins += t.Proteins * t.Weight * 0.01;
                EatFats += t.Fats * t.Weight * 0.01;
                EatCarbohydrates += t.Carbohydrates * t.Weight * 0.01;
            }

            EatCalories = Math.Round(EatCalories, 2);
            EatCarbohydrates = Math.Round(EatCarbohydrates, 2);
            EatProteins = Math.Round(EatProteins, 2);
            EatFats = Math.Round(EatFats, 2);

            LeftCalories = Math.Round(Calories - EatCalories,2);
            LeftProteins = Math.Round(Proteins - EatProteins,2);
            LeftFats = Math.Round(Fats - EatFats,2);
            LeftCarbohydrates = Math.Round(Carbohydrates - EatCarbohydrates,2);


        }

        public void RejectEatSomeFood(int i)
        {
            EatFood.RemoveAt(i);
            Count();
        }

        public void EatSomeFood(Food food)
        {
            EatFood.Add(food);
            Count();
        }

        public void RejectEatSomeDish(int i)
        {
            EatDish.RemoveAt(i);
            Count();
        }

        public void EatSomeDish(Dish dish)
        {
            EatDish.Add(dish);
            Count();
        }
    }
}
