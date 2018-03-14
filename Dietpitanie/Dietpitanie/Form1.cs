using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dietpitanie
{
    public partial class MainWindow : Form
    {

        private Human _human;
        private double proteins, fats, carbohydrates, calories,BMR;
        private SQLiteConnection DB;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = true;
            DB = new SQLiteConnection(@"Data source =|DataDirectory|Database.db; Version = 3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Food";
            SQLiteDataReader reader = CMD.ExecuteReader();
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Name"].ToString());
                item.SubItems.Add(reader["Proteins"].ToString());
                item.SubItems.Add(reader["Fats"].ToString());
                item.SubItems.Add(reader["Carbohydrates"].ToString());
                item.SubItems.Add(reader["Calories"].ToString());
                listView1.Items.Add(item);
            }
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (height.Text.Length > 0 && weight.Text.Length > 0 && age.Text.Length > 0 &&
                (gender_female.Checked || gender_male.Checked))
            {
                if (gender_male.Checked)
                {
                    _human = new Human(double.Parse(height.Text), double.Parse(weight.Text), double.Parse(age.Text),1);
                }
                else
                {
                    _human = new Human(double.Parse(height.Text), double.Parse(weight.Text), double.Parse(age.Text), 0);
                }
                _human.CalcuteIndex();
                _human.CalculateBmr(activity1.Text,activity2.Text,double.Parse(activity2Time.Text));
                result.Text = _human.CompareIndex();
                textBox2.Text = _human.Proteins+" г. белков";
                textBox5.Text = _human.Fats + " г. жиров";
                textBox7.Text = _human.Carbohydrates+" г. углеводов";
                textBox9.Text = _human.Bmr + " ккал";
                result_calories.Text = _human.Bmr+" ккал";
                
            }
            else result.Text = "Input data again";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DB.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SQLiteCommand CMD = DB.CreateCommand();
            string type = comboBox1.Text;
            if (type == "все виды")
            {
                CMD.CommandText = "select * from Food";
            }
            else
            {
                CMD.CommandText = "select * from Food where type ='"+type.ToUpper()+"'";
            } 
            SQLiteDataReader reader = CMD.ExecuteReader();       
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Name"].ToString());
                item.SubItems.Add(reader["Proteins"].ToString());
                item.SubItems.Add(reader["Fats"].ToString());
                item.SubItems.Add(reader["Carbohydrates"].ToString());
                item.SubItems.Add(reader["Calories"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 && textBox1.Text.Length!=0)
            {
                ListViewItem item = new ListViewItem(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text);
                item.SubItems.Add(textBox1.Text);
                item.SubItems.Add(Convert.ToString(Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text) * Convert.ToDouble(textBox1.Text)/100));
                item.SubItems.Add(Convert.ToString(Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text) * Convert.ToDouble(textBox1.Text) / 100));
                item.SubItems.Add(Convert.ToString(Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text) * Convert.ToDouble(textBox1.Text) / 100));
                item.SubItems.Add(Convert.ToString(Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text) * Convert.ToDouble(textBox1.Text) / 100));
                listView2.Items.Add(item);
                proteins+= ((Convert.ToDouble(textBox1.Text)/100) * Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text));
                fats += ((Convert.ToDouble(textBox1.Text) / 100) * Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text));
                carbohydrates += ((Convert.ToDouble(textBox1.Text) / 100) * Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[3].Text));
                calories += ((Convert.ToDouble(textBox1.Text) / 100) * Convert.ToDouble(listView1.Items[listView1.SelectedIndices[0]].SubItems[4].Text));
                textBox8.Text = proteins.ToString() + " г. белков";
                textBox3.Text = fats.ToString() + " г. жиров";
                textBox4.Text = carbohydrates.ToString() + " г. углеводов";
                textBox6.Text = calories.ToString() + " ккал";
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                proteins = proteins - Convert.ToDouble(listView2.Items[listView2.SelectedIndices[0]].SubItems[3].Text);
                fats -= (Convert.ToDouble(listView2.Items[listView2.SelectedIndices[0]].SubItems[4].Text));
                carbohydrates -= (Convert.ToDouble(listView2.Items[listView2.SelectedIndices[0]].SubItems[5].Text));
                calories -= (Convert.ToDouble(listView2.Items[listView2.SelectedIndices[0]].SubItems[2].Text));
                listView2.Items.Remove(listView2.Items[listView2.SelectedIndices[0]]);
                textBox8.Text = proteins.ToString() + " г. белков";
                textBox3.Text = fats.ToString() + " г. жиров";
                textBox4.Text = carbohydrates.ToString() + " г. углеводов";
                textBox6.Text = calories.ToString() + " ккал";
            }
            
        }
    }
}
