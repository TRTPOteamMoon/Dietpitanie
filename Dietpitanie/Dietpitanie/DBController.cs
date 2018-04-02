using System;
using System.Data.SQLite;

namespace Dietpitanie
{
    public class DBController
    {
        public SQLiteConnection Db;

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

        public string[] DishType = new[]
        {
            "0",
            "1",
            "2",
            "3",
            "4"
        };

        public int GetFoodTypeLength()
        {
            return FoodType.Length;
        }

        public void ConnectDb()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            location = location.Remove(location.Length - 25);
            Db = new SQLiteConnection(@"Data source =" + location + "Database.db; Version = 3");
            Db.Open();
        }

        public void DisconnectDb()
        {
            Db.Close();
        }

        public FoodList GetFoodList()
        {
            FoodList foodList= new FoodList(FoodType.Length);
            SQLiteCommand CMD = Db.CreateCommand();
            for (int i = 0; i < FoodType.Length; i++)
            {

                if (i == 0)
                {
                    CMD.CommandText = "select * from Food";
                }
                else
                {
                    CMD.CommandText = "select * from Food where type ='" + FoodType[i].ToUpper() + "'";
                }
                SQLiteDataReader reader = CMD.ExecuteReader();
                while (reader.Read())
                {
                    Food food = new Food(reader["Name"].ToString(), Convert.ToDouble(reader["Proteins"]), Convert.ToDouble(reader["Fats"]), Convert.ToDouble(reader["Carbohydrates"]), Convert.ToDouble(reader["Calories"]));
                    foodList.AddFood(food, i);
                }
                reader.Close();
            }
            return foodList;
        }

        public DishList GeDishList()
        {
            DishList dishList = new DishList(DishType.Length);
            SQLiteCommand CMD = Db.CreateCommand();
            for (int i = 0; i < DishType.Length; i++)
            {
                CMD.CommandText = "select * from Food where type ='" + FoodType[i] + "'";
                SQLiteDataReader reader = CMD.ExecuteReader();
                while (reader.Read())
                {
                    Dish dish = new Dish(reader["Name"].ToString(), Convert.ToDouble(reader["Proteins"]), Convert.ToDouble(reader["Fats"]), Convert.ToDouble(reader["Carbohydrates"]), Convert.ToDouble(reader["Calories"]));
                    dishList.AddDish(dish,i);
                }
                reader.Close();
            }
            return dishList;
        }

    }
}
