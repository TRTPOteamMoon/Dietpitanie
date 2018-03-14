using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dietpitanie
{
    public partial class Form1 : Form
    {

        private Human human;
        private double proteins, fats, carbohydrates, calories,BMR;
        private SQLiteConnection DB;
        public Form1()
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
            if (height.Text.Length > 0 && weight.Text.Length > 0 && age.Text.Length > 0 && (gender_female.Checked || gender_male.Checked))
            {
                human = new Human(float.Parse(height.Text), float.Parse(weight.Text));
                human.CalcuteIndex();
                result.Text = human.CompareIndex();
                BMR = 9.99 * Convert.ToDouble(weight.Text) + 
                      6.25 * Convert.ToDouble(height.Text) -
                      4.95 * Convert.ToDouble(age.Text);
                if (gender_male.Checked)
                {
                    BMR += 5;
                }
                else
                {
                    BMR -= 161;
                }

                string activity1_type = activity1.Text;
                switch (activity1_type)
                {
                    case "сидячая работа, отсутствие спорта":
                        BMR = BMR * 1.2;
                        break;
                    case "легкие физические упражнения около 3 раз за неделю, ежедневная утренняя зарядка, пешие прогулки":
                        BMR = BMR * 1.35;
                        break;
                    case "спорт до 5 раз за неделю":
                        BMR = BMR * 1.55;
                        break;
                    case "активный образ жизни вкупе с ежедневными интенсивными тренировками":
                        BMR = BMR * 1.75;
                        break;
                    case "спортивный образ жизни, тяжелый физический труд, длительные тяжелые тренировки каждый день":
                        BMR = BMR * 1.95;
                        break;
                }

                string activity2_type = activity2.Text;
                double time;
                if (activity2_time.Text.Length == 0)
                {
                    time = 0;
                }
                else
                {
                    time = Convert.ToDouble(activity2_time.Text);
                }
                switch (activity2_type)
                {
                    case "ничего":
                        break;
                    case "велоспорт":
                        BMR += 660 * time / 60;
                        break;
                    case "бег трусцой":
                        BMR += 600 * time / 60;
                        break;
                    case "волейбол":
                        BMR += 350 * time / 60;
                        break;
                    case "гимнастика":
                        BMR += 440 * time / 60;
                        break;
                    case "катание на коньках":
                        BMR += 400 * time / 60;
                        break;
                    case " плавние":
                        BMR += 350 * time / 60;
                        break;
            }

                double proteins, fats, carbohydrates;
                proteins = Convert.ToDouble(weight.Text) * 1.2 ;
                fats = Convert.ToDouble(weight.Text) * 0.5 ;
                carbohydrates = (BMR - proteins * 4 - fats * 9) / 4;
                textBox2.Text = proteins.ToString()+" г. белков";
                textBox5.Text = fats.ToString() + " г. жиров";
                textBox7.Text = carbohydrates.ToString()+" г. углеводов";
                textBox9.Text = BMR.ToString() + " ккал";
                result_calories.Text = BMR.ToString()+" ккал";
                
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
