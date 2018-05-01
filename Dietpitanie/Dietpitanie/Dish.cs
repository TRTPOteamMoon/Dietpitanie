namespace Dietpitanie
{
    public class Dish
    {
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
        public double Weight { get; set; }
        public double Calories { get; set; }

        public Dish()
        {

        }

        public Dish(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Calories = calories;
            Weight = 0;
        }

        public Dish(string name, double proteins, double fats, double carbohydrates, double calories, double weight)
        {
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Calories = calories;
            Weight = weight;
        }
    }
}
