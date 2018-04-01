using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Dietpitanie
{
    class DBController
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

    }
}
