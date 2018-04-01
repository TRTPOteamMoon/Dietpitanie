using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dietpitanie
{
    public partial class MainWindow : Form
    {
        private FoodList foodList;
        private Food food;
        private Human _human;
        private double proteins, fats, carbohydrates, calories, BMR;
        private DBController dbController;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void MainWindowLoad(object sender, EventArgs e)
        {

            weightLabel.Text = "";
            heightLabel.Text = "";
            ageLabel.Text = "";
            resultLabel.Text = "";
            caloriesLabel.Text = "";
            checkToEatWeight.Text = "";
            chekEatLabel.Text = "";
            buttonCalculate.Enabled = true;

            dbController = new DBController();
            dbController.ConnectDb();
            foodList = new FoodList(dbController.GetFoodTypeLength());
            foodList = dbController.GetFoodList();
            for (int i = 0; i < foodList.LengthListFood(0); i++)
            {
                
                ListViewItem item = new ListViewItem(foodList.GetFood(0, i).Name);
                item.SubItems.Add(foodList.GetFood(0, i).Proteins.ToString());
                item.SubItems.Add(foodList.GetFood(0, i).Fats.ToString());
                item.SubItems.Add(foodList.GetFood(0, i).Carbohydrates.ToString());
                item.SubItems.Add(foodList.GetFood(0, i).Calories.ToString());
                listView1.Items.Add(item);
            }        
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
                if (height.Text.Length > 0 && weight.Text.Length > 0 && age.Text.Length > 0 &&
                    (gender_female.Checked || gender_male.Checked) &&
                    (pattern.IsMatch(height.Text)) &&
                    (pattern.IsMatch(weight.Text)) &&
                    (pattern.IsMatch(age.Text)))
                {
                    if (gender_male.Checked)
                    {
                        _human = new Human(double.Parse(height.Text), double.Parse(weight.Text), double.Parse(age.Text), 1);
                    }
                    else
                    {
                        _human = new Human(double.Parse(height.Text), double.Parse(weight.Text), double.Parse(age.Text), 0);
                    }
                    _human.CalcuteIndex();
                    _human.CalculateBmr(activity1.Text, activity2.Text, activity2Time.Text);
                    _human.CalculateMacroelemnts();
                    resultLabel.Text = _human.CompareIndex();
                    normProteins.Text = _human.Proteins.ToString();
                    normFats.Text = _human.Fats.ToString();
                    normCarbohydrates.Text = _human.Carbohydrates.ToString();
                    normCalories.Text = _human.Bmr.ToString();
                    caloriesLabel.Text = _human.Bmr.ToString();

                }
                else resultLabel.Text = @"Введите данные ещё раз";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
            if (pattern.IsMatch(height.Text)||height.Text.Length==0)
            {
                heightLabel.Text = @"";
            }
            else
            {
                heightLabel.Text = @"Данные введены неправильно";
            }
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
            if (pattern.IsMatch(weight.Text) || weight.Text.Length == 0)
            {
                weightLabel.Text = @"";
            }
            else
            {
                weightLabel.Text = @"Данные введены неправильно";
            }
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
            if (pattern.IsMatch(age.Text) || age.Text.Length == 0)
            {
                ageLabel.Text = @"";
            }
            else
            {
                ageLabel.Text = @"Данные введены неправильно";
            }
        }

        private void toEatWeight_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
            if (pattern.IsMatch(toEatWeight.Text) || toEatWeight.Text.Length == 0)
            {
                checkToEatWeight.Text = @"";
            }
            else
            {
                checkToEatWeight.Text = @"Данные введены неправильно";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            // DB UPDATED
            //if (_human != null)
            //{
            //    listView3.Items.Clear();
            //    SQLiteCommand CMD = DB.CreateCommand();
            //    string type = foodType.Text;
            //    if (type == "все виды")
            //    {
            //        CMD.CommandText = "select * from Food";
            //    }
            //    else
            //    {
            //        CMD.CommandText = "select * from Food where type ='" + type.ToUpper() + "'";
            //    }
            //    SQLiteDataReader reader = CMD.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        ListViewItem item = new ListViewItem(reader["Name"].ToString());
            //        item.SubItems.Add(reader["Proteins"].ToString());
            //        item.SubItems.Add(reader["Fats"].ToString());
            //        item.SubItems.Add(reader["Carbohydrates"].ToString());
            //        item.SubItems.Add(reader["Calories"].ToString());
            //        if (Convert.ToDouble(item.SubItems[1].Text) <= _human.Proteins - proteins && Convert.ToDouble(item.SubItems[2].Text) <= _human.Fats - fats &&
            //            Convert.ToDouble(item.SubItems[3].Text) <= _human.Carbohydrates - carbohydrates)
            //        {
            //            listView3.Items.Add(item);
            //        }
            //    }
            //
            //}

        }

        private void MainWindowClosed(object sender, FormClosedEventArgs e)
        {
            dbController.DisconnectDb();
        }

        private void foodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string type = foodType.Text;
            int index = foodList.IndexListFood(type);
            for (int i = 0; i < foodList.LengthListFood(index); i++)
            {
                ListViewItem item = new ListViewItem(foodList.GetFood(index, i).Name);
                item.SubItems.Add(foodList.GetFood(index, i).Proteins.ToString());
                item.SubItems.Add(foodList.GetFood(index, i).Fats.ToString());
                item.SubItems.Add(foodList.GetFood(index, i).Carbohydrates.ToString());
                item.SubItems.Add(foodList.GetFood(index, i).Calories.ToString());
                listView1.Items.Add(item);
            }
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            try
            {
                Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
                if (listView1.SelectedItems.Count == 1 && toEatWeight.Text.Length != 0 && (pattern.IsMatch(toEatWeight.Text)))
                {
                    var position = listView1.SelectedIndices[0];
                    string type = foodType.Text;
                    int index = foodList.IndexListFood(type);
                    food = foodList.GetFood(index,position);
                    food.Weight = Convert.ToDouble(toEatWeight.Text);
                    _human.EatSomeFood(food);
                    eatProteins.Text = _human.EatProteins.ToString();
                    eatFats.Text = _human.EatFats.ToString();
                    eatCarbohydrates.Text = _human.EatCarbohydrates.ToString();
                    eatCalories.Text = _human.EatCalories.ToString();
                    toEatWeight.Clear();

                    ListViewItem item = new ListViewItem(food.Name);
                    item.SubItems.Add(food.Weight.ToString());
                    item.SubItems.Add((food.Calories * food.Weight * 0.01).ToString());
                    item.SubItems.Add((food.Proteins * food.Weight * 0.01).ToString());
                    item.SubItems.Add((food.Fats * food.Weight * 0.01).ToString());
                    item.SubItems.Add((food.Carbohydrates * food.Weight * 0.01).ToString());
                    listView2.Items.Add(item);

                    toNormCalories.Text = _human.LeftCalories.ToString();
                    toNormProteins.Text = _human.LeftProteins.ToString();
                    toNormFats.Text = _human.LeftFats.ToString();
                    toNormCarbohydrates.Text = _human.LeftCarbohydrates.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            } 
        }

        private void buttonEject_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count == 1)
                {
                    var position = listView2.SelectedIndices[0];
                    string type = foodType.Text;
                    listView2.Items.Remove(listView2.Items[position]);
                    _human.RejectEatSomeFood(position);

                    eatProteins.Text = _human.EatProteins.ToString();
                    eatFats.Text = _human.EatFats.ToString();
                    eatCarbohydrates.Text = _human.EatCarbohydrates.ToString();
                    eatCalories.Text = _human.EatCalories.ToString();
                    toEatWeight.Clear();

                    toNormCalories.Text = _human.LeftCalories.ToString();
                    toNormProteins.Text = _human.LeftProteins.ToString();
                    toNormFats.Text = _human.LeftFats.ToString();
                    toNormCarbohydrates.Text = _human.LeftCarbohydrates.ToString();

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
