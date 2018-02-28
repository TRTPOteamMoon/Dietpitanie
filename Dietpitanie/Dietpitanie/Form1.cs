using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietpitanie
{
    public partial class Form1 : Form
    {

        private Human human;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = true;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (height.Text.Length > 0 && weight.Text.Length > 0)
            {
                human = new Human(float.Parse(height.Text), float.Parse(weight.Text));
                human.CalcuteIndex();
                result.Text = human.CompareIndex();
            }
            else result.Text = "Input data again";
        }
    }
}
