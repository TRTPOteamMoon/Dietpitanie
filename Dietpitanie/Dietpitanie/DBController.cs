using System;
using System.Data.SQLite;

namespace Dietpitanie
{
    public class DbController
    {
        public SQLiteConnection Db;

        public string[] FoodType = {
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

        public string[] DishType = {
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

        public int GetDishTypeLength()
        {
            return DishType.Length;
        }

        public void ConnectDb()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Db = new SQLiteConnection(@"Data Source = Database.db; Version = 3");
            Db.Open();
        }

        public void DisconnectDb()
        {
            Db.Close();
        }

        public FoodList GetFoodList()
        {
            FoodList foodList= new FoodList(FoodType.Length);
            SQLiteCommand cmd = Db.CreateCommand();
            for (int i = 0; i < FoodType.Length; i++)
            {

                if (i == 0)
                {
                    cmd.CommandText = "select * from Food";
                }
                else
                {
                    cmd.CommandText = "select * from Food where type ='" + FoodType[i].ToUpper() + "'";
                }
                SQLiteDataReader reader = cmd.ExecuteReader();
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
            SQLiteCommand cmd = Db.CreateCommand();
            for (int i = 0; i < DishType.Length; i++)
            {
                cmd.CommandText = "select * from Dish where type ='" + DishType[i] + "'";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dish dish = new Dish(reader["Name"].ToString().ToUpper(), Convert.ToDouble(reader["Proteins"]), Convert.ToDouble(reader["Fats"]), Convert.ToDouble(reader["Carbohydrates"]), Convert.ToDouble(reader["Calories"]));
                    dishList.AddDish(dish,i);
                }
                reader.Close();
            }
            return dishList;
        }

        public void AddFood(Food food,int index)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Food (Name, Proteins, Fats, Carbohydrates, Calories, Type) VALUES (@a,@b,@c,@d,@e,@f)", Db);
            cmd.Parameters.Add(new SQLiteParameter("@a",food.Name));
            cmd.Parameters.Add(new SQLiteParameter("@b",food.Proteins));
            cmd.Parameters.Add(new SQLiteParameter("@c",food.Fats));
            cmd.Parameters.Add(new SQLiteParameter("@d",food.Carbohydrates));
            cmd.Parameters.Add(new SQLiteParameter("@e",food.Calories));
            cmd.Parameters.Add(new SQLiteParameter("@f",FoodType[1+index].ToUpper()));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddDish(Dish dish, int index)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Dish (Name, Proteins, Fats, Carbohydrates, Calories, Type) VALUES (@a,@b,@c,@d,@e,@f)", Db);
            cmd.Parameters.Add(new SQLiteParameter("@a", dish.Name));
            cmd.Parameters.Add(new SQLiteParameter("@b", dish.Proteins));
            cmd.Parameters.Add(new SQLiteParameter("@c", dish.Fats));
            cmd.Parameters.Add(new SQLiteParameter("@d", dish.Carbohydrates));
            cmd.Parameters.Add(new SQLiteParameter("@e", dish.Calories));
            cmd.Parameters.Add(new SQLiteParameter("@f", DishType[index].ToUpper()));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
