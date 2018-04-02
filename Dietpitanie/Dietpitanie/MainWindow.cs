using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dietpitanie
{
    public partial class MainWindow : Form
    {
        private FoodList _foodList;
        private DishList _dishList;
        private Food _food;
        private Dish _dish;
        private Human _human;
        private DBController _dbController;
        private MenuMaker _menuMaker;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void MainWindowLoad(object sender, EventArgs e)
        {
            suggestNameLabel.Text = "";
            suggestWeightLabel.Text = "";
            weightLabel.Text = "";
            heightLabel.Text = "";
            ageLabel.Text = "";
            resultLabel.Text = "";
            caloriesLabel.Text = "";
            checkToEatWeight.Text = "";
            buttonCalculate.Enabled = true;
            _human =new Human();
            _dbController = new DBController();
            _dbController.ConnectDb();
            _foodList = new FoodList(_dbController.GetFoodTypeLength());
            _foodList = _dbController.GetFoodList();
            _dishList = new DishList(_dbController.GetDishTypeLength());
            _dishList = _dbController.GeDishList();
            for (int i = 0; i < _foodList.LengthListFood(0); i++)
            {
                
                ListViewItem item = new ListViewItem(_foodList.GetFood(0, i).Name);
                item.SubItems.Add(_foodList.GetFood(0, i).Proteins.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Fats.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Carbohydrates.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Calories.ToString());
                toEatListView.Items.Add(item);
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
                    _human.Height = double.Parse(height.Text);
                    _human.Weight = double.Parse(weight.Text);
                    _human.Age = double.Parse(age.Text);
                    if (gender_male.Checked)
                    {
                        _human.Sex = 1;
                    }
                    else
                    {
                        _human.Sex = 0;
                    }
                    _human.Count();

                    eatProteins.Text = _human.EatProteins.ToString();
                    eatFats.Text = _human.EatFats.ToString();
                    eatCarbohydrates.Text = _human.EatCarbohydrates.ToString();
                    eatCalories.Text = _human.EatCalories.ToString();
                    toEatWeight.Clear();

                    toNormCalories.Text = _human.LeftCalories.ToString();
                    toNormProteins.Text = _human.LeftProteins.ToString();
                    toNormFats.Text = _human.LeftFats.ToString();
                    toNormCarbohydrates.Text = _human.LeftCarbohydrates.ToString();

                    _human.CalcuteIndex();
                    _human.CalculateBmr(activity1.Text, activity2.Text, activity2Time.Text);
                    _human.CalculateMacroelemnts();
                    resultLabel.Text = _human.CompareIndex();
                    normProteins.Text = _human.Proteins.ToString();
                    normFats.Text = _human.Fats.ToString();
                    normCarbohydrates.Text = _human.Carbohydrates.ToString();
                    normCalories.Text = _human.Bmr.ToString();
                    caloriesLabel.Text = _human.Bmr.ToString();

                    _human.Count();

                    eatProteins.Text = _human.EatProteins.ToString();
                    eatFats.Text = _human.EatFats.ToString();
                    eatCarbohydrates.Text = _human.EatCarbohydrates.ToString();
                    eatCalories.Text = _human.EatCalories.ToString();
                    toEatWeight.Clear();

                    toNormCalories.Text = _human.LeftCalories.ToString();
                    toNormProteins.Text = _human.LeftProteins.ToString();
                    toNormFats.Text = _human.LeftFats.ToString();
                    toNormCarbohydrates.Text = _human.LeftCarbohydrates.ToString();
                    _menuMaker = new MenuMaker(_dishList,_human);
                    _menuMaker.CreateBreakfast();
                    _menuMaker.CreateLunch();
                    _menuMaker.CreateSupper();


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
            this.suggestList.Items.Clear();
            List<Food> suggestList = new List<Food>();
            for (int i = 0; i < _foodList.LengthListFood(0); i++)
            {

                ListViewItem item = new ListViewItem(_foodList.GetFood(0, i).Name);
                item.SubItems.Add(_foodList.GetFood(0, i).Proteins.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Fats.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Carbohydrates.ToString());
                item.SubItems.Add(_foodList.GetFood(0, i).Calories.ToString());
                if (Convert.ToDouble(item.SubItems[4].Text) <= _human.LeftCalories&&
                Convert.ToDouble(item.SubItems[3].Text) <= _human.LeftCarbohydrates)
                {
                    suggestList.Add(_foodList.GetFood(0, i));
                    this.suggestList.Items.Add(item);
                }
            }
            _human.SuggestFoodList = suggestList;
        }

        private void ToEatListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (toEatListView.SelectedItems.Count == 1)
            {
                toEatFoodLabel.Text = toEatListView.Items[toEatListView.SelectedIndices[0]].SubItems[0].Text;
            }
        }

        private void ToRejectListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (toRejectListView.SelectedItems.Count == 1)
            {
                toRejectFoodLabel.Text = toRejectListView.Items[toRejectListView.SelectedIndices[0]].SubItems[0].Text;
            }
        }

        private void MainWindowClosed(object sender, FormClosedEventArgs e)
        {
            _dbController.DisconnectDb();
        }

        private void foodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            toEatListView.Items.Clear();
            string type = foodType.Text;
            int index = _foodList.IndexListFood(type);
            for (int i = 0; i < _foodList.LengthListFood(index); i++)
            {
                ListViewItem item = new ListViewItem(_foodList.GetFood(index, i).Name);
                item.SubItems.Add(_foodList.GetFood(index, i).Proteins.ToString());
                item.SubItems.Add(_foodList.GetFood(index, i).Fats.ToString());
                item.SubItems.Add(_foodList.GetFood(index, i).Carbohydrates.ToString());
                item.SubItems.Add(_foodList.GetFood(index, i).Calories.ToString());
                toEatListView.Items.Add(item);
            }
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            try
            {
                Regex pattern = new Regex(@"^([0-9]*[1-9][0-9]*(\.[0-9]+)?|[0]+\.[0-9]*[1-9][0-9]*)$");
                if (toEatListView.SelectedItems.Count == 1 &&
                    toEatWeight.Text.Length != 0 &&
                    (pattern.IsMatch(toEatWeight.Text)))
                {
                    var position = toEatListView.SelectedIndices[0];
                    string type = foodType.Text;
                    int index = _foodList.IndexListFood(type);
                    _food = _foodList.GetFood(index,position);
                    _food.Weight = Convert.ToDouble(toEatWeight.Text);
                    _human.EatSomeFood(_food);
                    eatProteins.Text = _human.EatProteins.ToString();
                    eatFats.Text = _human.EatFats.ToString();
                    eatCarbohydrates.Text = _human.EatCarbohydrates.ToString();
                    eatCalories.Text = _human.EatCalories.ToString();
                    toEatWeight.Clear();

                    ListViewItem item = new ListViewItem(_food.Name);
                    item.SubItems.Add(_food.Weight.ToString());
                    item.SubItems.Add((_food.Calories * _food.Weight * 0.01).ToString());
                    item.SubItems.Add((_food.Proteins * _food.Weight * 0.01).ToString());
                    item.SubItems.Add((_food.Fats * _food.Weight * 0.01).ToString());
                    item.SubItems.Add((_food.Carbohydrates * _food.Weight * 0.01).ToString());
                    toRejectListView.Items.Add(item);

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
                if (toRejectListView.SelectedItems.Count == 1)
                {
                    var position = toRejectListView.SelectedIndices[0];
                    string type = foodType.Text;
                    toRejectListView.Items.Remove(toRejectListView.Items[position]);
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

                    toRejectFoodLabel.Text = "";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void suggestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suggestList.SelectedItems.Count == 1)
            {
                var position = suggestList.SelectedIndices[0];
                List<Food> foodlist = new List<Food>(0);
                   foodlist = _human.SuggestFoodList;
                Food food = foodlist[position];
                double weight1 = _human.LeftCalories / food.Calories * 100;
                double weight2 = _human.LeftCarbohydrates / food.Carbohydrates * 100;
                if (weight1 > weight2)
                {
                    suggestNameLabel.Text = food.Name;
                    suggestWeightLabel.Text = @"100 - " + weight2.ToString() + @" г.";
                }
                else
                {
                    suggestNameLabel.Text = food.Name;
                    suggestWeightLabel.Text = @"100 - " + weight1.ToString() + @" г.";
                }

            }
        }
    }
}
