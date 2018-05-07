using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Dietpitanie
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ageLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.GroupBox();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.heightText = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activity1Label = new System.Windows.Forms.Label();
            this.activity2Time = new System.Windows.Forms.TextBox();
            this.activity2 = new System.Windows.Forms.ComboBox();
            this.activity1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toRejectFoodLabel = new System.Windows.Forms.Label();
            this.toEatFoodLabel = new System.Windows.Forms.Label();
            this.checkToEatWeight = new System.Windows.Forms.Label();
            this.eatLabel = new System.Windows.Forms.Label();
            this.toEatLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.toNormFats = new System.Windows.Forms.TextBox();
            this.toNormProteins = new System.Windows.Forms.TextBox();
            this.toNormCarbohydrates = new System.Windows.Forms.TextBox();
            this.toNormCalories = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toRejectListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toEatListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEject = new System.Windows.Forms.Button();
            this.normCarbohydrates = new System.Windows.Forms.TextBox();
            this.normFats = new System.Windows.Forms.TextBox();
            this.eatFats = new System.Windows.Forms.TextBox();
            this.normProteins = new System.Windows.Forms.TextBox();
            this.eatProteins = new System.Windows.Forms.TextBox();
            this.eatCarbohydrates = new System.Windows.Forms.TextBox();
            this.eatCalories = new System.Windows.Forms.TextBox();
            this.normCalories = new System.Windows.Forms.TextBox();
            this.toEatWeight = new System.Windows.Forms.TextBox();
            this.buttonEat = new System.Windows.Forms.Button();
            this.foodType = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.suggestWeightLabel = new System.Windows.Forms.Label();
            this.suggestNameLabel = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.suggestList = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dAdd = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dishType2 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.foodType2 = new System.Windows.Forms.ComboBox();
            this.Fats = new System.Windows.Forms.TextBox();
            this.Proteins = new System.Windows.Forms.TextBox();
            this.Carbohydrates = new System.Windows.Forms.TextBox();
            this.Calories = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.buttonEatDish = new System.Windows.Forms.Button();
            this.makeMenuButton = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.genderbox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(51, 255);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(78, 16);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "indexResult";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 543);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Black;
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.login);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(974, 514);
            this.tabPage6.TabIndex = 56;
            this.tabPage6.Text = "Авторизация";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(305, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 16);
            this.label25.TabIndex = 4;
            this.label25.Text = "Логин";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(437, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Авторизоваться";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(305, 136);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(262, 22);
            this.login.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.ageLabel);
            this.tabPage1.Controls.Add(this.weightLabel);
            this.tabPage1.Controls.Add(this.heightLabel);
            this.tabPage1.Controls.Add(this.caloriesLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.age);
            this.tabPage1.Controls.Add(this.genderbox);
            this.tabPage1.Controls.Add(this.heightText);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.height);
            this.tabPage1.Controls.Add(this.weightText);
            this.tabPage1.Controls.Add(this.weight);
            this.tabPage1.Controls.Add(this.buttonCalculate);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(176, 162);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(69, 16);
            this.ageLabel.TabIndex = 20;
            this.ageLabel.Text = "checkAge";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(174, 116);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(86, 16);
            this.weightLabel.TabIndex = 19;
            this.weightLabel.Text = "checkWeight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(174, 67);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(83, 16);
            this.heightLabel.TabIndex = 18;
            this.heightLabel.Text = "checkHeight";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesLabel.ForeColor = System.Drawing.Color.White;
            this.caloriesLabel.Location = new System.Drawing.Point(51, 295);
            this.caloriesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(94, 16);
            this.caloriesLabel.TabIndex = 17;
            this.caloriesLabel.Text = "caloriesResult";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Возраст";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.Black;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.ForeColor = System.Drawing.Color.White;
            this.age.Location = new System.Drawing.Point(42, 162);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(128, 22);
            this.age.TabIndex = 13;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // genderbox
            // 
            this.genderbox.Controls.Add(this.gender_male);
            this.genderbox.Controls.Add(this.gender_female);
            this.genderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderbox.ForeColor = System.Drawing.Color.White;
            this.genderbox.Location = new System.Drawing.Point(393, 63);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(142, 93);
            this.genderbox.TabIndex = 11;
            this.genderbox.TabStop = false;
            this.genderbox.Text = "Пол";
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.ForeColor = System.Drawing.Color.White;
            this.gender_male.Location = new System.Drawing.Point(18, 24);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(84, 20);
            this.gender_male.TabIndex = 9;
            this.gender_male.TabStop = true;
            this.gender_male.Text = "Мужской";
            this.gender_male.UseVisualStyleBackColor = true;
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.ForeColor = System.Drawing.Color.White;
            this.gender_female.Location = new System.Drawing.Point(18, 51);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(85, 20);
            this.gender_female.TabIndex = 10;
            this.gender_female.TabStop = true;
            this.gender_female.Text = "Женский";
            this.gender_female.UseVisualStyleBackColor = true;
            // 
            // heightText
            // 
            this.heightText.AutoSize = true;
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightText.ForeColor = System.Drawing.Color.White;
            this.heightText.Location = new System.Drawing.Point(39, 43);
            this.heightText.Margin = new System.Windows.Forms.Padding(3);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(61, 16);
            this.heightText.TabIndex = 7;
            this.heightText.Text = "Рост, см";
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.Black;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.ForeColor = System.Drawing.Color.White;
            this.height.Location = new System.Drawing.Point(39, 67);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(128, 22);
            this.height.TabIndex = 4;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // weightText
            // 
            this.weightText.AutoSize = true;
            this.weightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightText.ForeColor = System.Drawing.Color.White;
            this.weightText.Location = new System.Drawing.Point(39, 92);
            this.weightText.Margin = new System.Windows.Forms.Padding(3);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(51, 16);
            this.weightText.TabIndex = 8;
            this.weightText.Text = "Вес, кг";
            // 
            // weight
            // 
            this.weight.BackColor = System.Drawing.Color.Black;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.ForeColor = System.Drawing.Color.White;
            this.weight.Location = new System.Drawing.Point(39, 116);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(128, 22);
            this.weight.TabIndex = 5;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Black;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(42, 200);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(129, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.activity1Label);
            this.tabPage2.Controls.Add(this.activity2Time);
            this.tabPage2.Controls.Add(this.activity2);
            this.tabPage2.Controls.Add(this.activity1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Активность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Время дневной активности, мин.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дневная активность";
            // 
            // activity1Label
            // 
            this.activity1Label.AutoSize = true;
            this.activity1Label.BackColor = System.Drawing.Color.Transparent;
            this.activity1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity1Label.ForeColor = System.Drawing.Color.White;
            this.activity1Label.Location = new System.Drawing.Point(27, 19);
            this.activity1Label.Name = "activity1Label";
            this.activity1Label.Size = new System.Drawing.Size(158, 16);
            this.activity1Label.TabIndex = 20;
            this.activity1Label.Text = "Недельная активность";
            // 
            // activity2Time
            // 
            this.activity2Time.BackColor = System.Drawing.Color.Black;
            this.activity2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity2Time.ForeColor = System.Drawing.Color.White;
            this.activity2Time.Location = new System.Drawing.Point(301, 82);
            this.activity2Time.Name = "activity2Time";
            this.activity2Time.Size = new System.Drawing.Size(255, 22);
            this.activity2Time.TabIndex = 19;
            // 
            // activity2
            // 
            this.activity2.BackColor = System.Drawing.Color.Black;
            this.activity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity2.ForeColor = System.Drawing.Color.White;
            this.activity2.FormattingEnabled = true;
            this.activity2.Items.AddRange(new object[] {
            "ничего",
            "велоспорт",
            "бег трусцой",
            "волейбол",
            "гимнастика",
            "катание на коньках",
            "плавние"});
            this.activity2.Location = new System.Drawing.Point(27, 81);
            this.activity2.Name = "activity2";
            this.activity2.Size = new System.Drawing.Size(256, 24);
            this.activity2.TabIndex = 18;
            this.activity2.Text = "ничего";
            // 
            // activity1
            // 
            this.activity1.BackColor = System.Drawing.Color.Black;
            this.activity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity1.ForeColor = System.Drawing.Color.White;
            this.activity1.FormattingEnabled = true;
            this.activity1.Items.AddRange(new object[] {
            "сидячая работа, отсутствие спорта",
            "легкие физические упражнения около 3 раз за неделю, ежедневная утренняя зарядка, " +
                "пешие прогулки",
            "спорт до 5 раз за неделю",
            "активный образ жизни вкупе с ежедневными интенсивными тренировками",
            "спортивный образ жизни, тяжелый физический труд, длительные тяжелые тренировки ка" +
                "ждый день"});
            this.activity1.Location = new System.Drawing.Point(27, 38);
            this.activity1.Name = "activity1";
            this.activity1.Size = new System.Drawing.Size(529, 24);
            this.activity1.TabIndex = 17;
            this.activity1.Text = "сидячая работа, отсутствие спорта";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.toRejectFoodLabel);
            this.tabPage3.Controls.Add(this.toEatFoodLabel);
            this.tabPage3.Controls.Add(this.checkToEatWeight);
            this.tabPage3.Controls.Add(this.eatLabel);
            this.tabPage3.Controls.Add(this.toEatLabel);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.toNormFats);
            this.tabPage3.Controls.Add(this.toNormProteins);
            this.tabPage3.Controls.Add(this.toNormCarbohydrates);
            this.tabPage3.Controls.Add(this.toNormCalories);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.toRejectListView);
            this.tabPage3.Controls.Add(this.toEatListView);
            this.tabPage3.Controls.Add(this.buttonEject);
            this.tabPage3.Controls.Add(this.normCarbohydrates);
            this.tabPage3.Controls.Add(this.normFats);
            this.tabPage3.Controls.Add(this.eatFats);
            this.tabPage3.Controls.Add(this.normProteins);
            this.tabPage3.Controls.Add(this.eatProteins);
            this.tabPage3.Controls.Add(this.eatCarbohydrates);
            this.tabPage3.Controls.Add(this.eatCalories);
            this.tabPage3.Controls.Add(this.normCalories);
            this.tabPage3.Controls.Add(this.toEatWeight);
            this.tabPage3.Controls.Add(this.buttonEat);
            this.tabPage3.Controls.Add(this.foodType);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(974, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Калькулятор";
            // 
            // toRejectFoodLabel
            // 
            this.toRejectFoodLabel.AutoSize = true;
            this.toRejectFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRejectFoodLabel.ForeColor = System.Drawing.Color.White;
            this.toRejectFoodLabel.Location = new System.Drawing.Point(641, 131);
            this.toRejectFoodLabel.Name = "toRejectFoodLabel";
            this.toRejectFoodLabel.Size = new System.Drawing.Size(67, 16);
            this.toRejectFoodLabel.TabIndex = 54;
            this.toRejectFoodLabel.Text = "Съесть г.";
            // 
            // toEatFoodLabel
            // 
            this.toEatFoodLabel.AutoSize = true;
            this.toEatFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toEatFoodLabel.ForeColor = System.Drawing.Color.White;
            this.toEatFoodLabel.Location = new System.Drawing.Point(641, 53);
            this.toEatFoodLabel.Name = "toEatFoodLabel";
            this.toEatFoodLabel.Size = new System.Drawing.Size(67, 16);
            this.toEatFoodLabel.TabIndex = 53;
            this.toEatFoodLabel.Text = "Съесть г.";
            // 
            // checkToEatWeight
            // 
            this.checkToEatWeight.AutoSize = true;
            this.checkToEatWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkToEatWeight.ForeColor = System.Drawing.Color.White;
            this.checkToEatWeight.Location = new System.Drawing.Point(796, 105);
            this.checkToEatWeight.Name = "checkToEatWeight";
            this.checkToEatWeight.Size = new System.Drawing.Size(123, 16);
            this.checkToEatWeight.TabIndex = 52;
            this.checkToEatWeight.Text = "checkToEatWeight";
            // 
            // eatLabel
            // 
            this.eatLabel.AutoSize = true;
            this.eatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatLabel.ForeColor = System.Drawing.Color.White;
            this.eatLabel.Location = new System.Drawing.Point(494, 225);
            this.eatLabel.Name = "eatLabel";
            this.eatLabel.Size = new System.Drawing.Size(66, 16);
            this.eatLabel.TabIndex = 51;
            this.eatLabel.Text = "Съедено";
            // 
            // toEatLabel
            // 
            this.toEatLabel.AutoSize = true;
            this.toEatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toEatLabel.ForeColor = System.Drawing.Color.White;
            this.toEatLabel.Location = new System.Drawing.Point(641, 81);
            this.toEatLabel.Name = "toEatLabel";
            this.toEatLabel.Size = new System.Drawing.Size(67, 16);
            this.toEatLabel.TabIndex = 50;
            this.toEatLabel.Text = "Съесть г.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(433, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "Осталось до нормы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(546, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 16);
            this.label15.TabIndex = 48;
            this.label15.Text = "г. углеводов";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(546, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "ккал.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(547, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 46;
            this.label17.Text = "г. жиров";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(547, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "г.белков";
            // 
            // toNormFats
            // 
            this.toNormFats.BackColor = System.Drawing.Color.Black;
            this.toNormFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toNormFats.ForeColor = System.Drawing.Color.White;
            this.toNormFats.Location = new System.Drawing.Point(433, 72);
            this.toNormFats.Name = "toNormFats";
            this.toNormFats.ReadOnly = true;
            this.toNormFats.Size = new System.Drawing.Size(107, 22);
            this.toNormFats.TabIndex = 41;
            this.toNormFats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toNormProteins
            // 
            this.toNormProteins.BackColor = System.Drawing.Color.Black;
            this.toNormProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toNormProteins.ForeColor = System.Drawing.Color.White;
            this.toNormProteins.Location = new System.Drawing.Point(433, 46);
            this.toNormProteins.Name = "toNormProteins";
            this.toNormProteins.ReadOnly = true;
            this.toNormProteins.Size = new System.Drawing.Size(107, 22);
            this.toNormProteins.TabIndex = 42;
            this.toNormProteins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toNormCarbohydrates
            // 
            this.toNormCarbohydrates.BackColor = System.Drawing.Color.Black;
            this.toNormCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toNormCarbohydrates.ForeColor = System.Drawing.Color.White;
            this.toNormCarbohydrates.Location = new System.Drawing.Point(433, 98);
            this.toNormCarbohydrates.Name = "toNormCarbohydrates";
            this.toNormCarbohydrates.ReadOnly = true;
            this.toNormCarbohydrates.Size = new System.Drawing.Size(107, 22);
            this.toNormCarbohydrates.TabIndex = 43;
            this.toNormCarbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toNormCalories
            // 
            this.toNormCalories.BackColor = System.Drawing.Color.Black;
            this.toNormCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toNormCalories.ForeColor = System.Drawing.Color.White;
            this.toNormCalories.Location = new System.Drawing.Point(433, 124);
            this.toNormCalories.Name = "toNormCalories";
            this.toNormCalories.ReadOnly = true;
            this.toNormCalories.Size = new System.Drawing.Size(107, 22);
            this.toNormCalories.TabIndex = 44;
            this.toNormCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(229, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Съедено";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Дневная норма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(342, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "г. углеводов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(342, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "ккал.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(343, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "г. жиров";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(343, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "г.белков";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(137, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "ккал.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "г. углеводов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(137, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "г. жиров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "г. белков";
            // 
            // toRejectListView
            // 
            this.toRejectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toRejectListView.BackColor = System.Drawing.Color.Black;
            this.toRejectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.toRejectListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRejectListView.ForeColor = System.Drawing.Color.White;
            this.toRejectListView.GridLines = true;
            this.toRejectListView.Location = new System.Drawing.Point(497, 241);
            this.toRejectListView.Name = "toRejectListView";
            this.toRejectListView.Size = new System.Drawing.Size(469, 241);
            this.toRejectListView.TabIndex = 30;
            this.toRejectListView.UseCompatibleStateImageBehavior = false;
            this.toRejectListView.View = System.Windows.Forms.View.Details;
            this.toRejectListView.SelectedIndexChanged += new System.EventHandler(this.ToRejectListViewSelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Масса";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ккал";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Белки";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Жиры";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Углеводы";
            this.columnHeader11.Width = 83;
            // 
            // toEatListView
            // 
            this.toEatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toEatListView.BackColor = System.Drawing.Color.Black;
            this.toEatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.toEatListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toEatListView.ForeColor = System.Drawing.Color.White;
            this.toEatListView.GridLines = true;
            this.toEatListView.Location = new System.Drawing.Point(8, 241);
            this.toEatListView.Name = "toEatListView";
            this.toEatListView.Size = new System.Drawing.Size(480, 241);
            this.toEatListView.TabIndex = 29;
            this.toEatListView.UseCompatibleStateImageBehavior = false;
            this.toEatListView.View = System.Windows.Forms.View.Details;
            this.toEatListView.SelectedIndexChanged += new System.EventHandler(this.ToEatListViewSelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Белки";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Жиры";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Углеводы";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ккал";
            this.columnHeader5.Width = 55;
            // 
            // buttonEject
            // 
            this.buttonEject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEject.BackColor = System.Drawing.Color.Black;
            this.buttonEject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEject.ForeColor = System.Drawing.Color.White;
            this.buttonEject.Location = new System.Drawing.Point(644, 158);
            this.buttonEject.Name = "buttonEject";
            this.buttonEject.Size = new System.Drawing.Size(146, 25);
            this.buttonEject.TabIndex = 28;
            this.buttonEject.Text = "Извлечь";
            this.buttonEject.UseVisualStyleBackColor = false;
            this.buttonEject.Click += new System.EventHandler(this.buttonEject_Click);
            // 
            // normCarbohydrates
            // 
            this.normCarbohydrates.BackColor = System.Drawing.Color.Black;
            this.normCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normCarbohydrates.ForeColor = System.Drawing.Color.White;
            this.normCarbohydrates.Location = new System.Drawing.Point(23, 98);
            this.normCarbohydrates.Name = "normCarbohydrates";
            this.normCarbohydrates.ReadOnly = true;
            this.normCarbohydrates.Size = new System.Drawing.Size(107, 22);
            this.normCarbohydrates.TabIndex = 23;
            this.normCarbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // normFats
            // 
            this.normFats.BackColor = System.Drawing.Color.Black;
            this.normFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normFats.ForeColor = System.Drawing.Color.White;
            this.normFats.Location = new System.Drawing.Point(23, 72);
            this.normFats.Name = "normFats";
            this.normFats.ReadOnly = true;
            this.normFats.Size = new System.Drawing.Size(107, 22);
            this.normFats.TabIndex = 22;
            this.normFats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eatFats
            // 
            this.eatFats.BackColor = System.Drawing.Color.Black;
            this.eatFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatFats.ForeColor = System.Drawing.Color.White;
            this.eatFats.Location = new System.Drawing.Point(229, 72);
            this.eatFats.Name = "eatFats";
            this.eatFats.ReadOnly = true;
            this.eatFats.Size = new System.Drawing.Size(107, 22);
            this.eatFats.TabIndex = 21;
            this.eatFats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // normProteins
            // 
            this.normProteins.BackColor = System.Drawing.Color.Black;
            this.normProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normProteins.ForeColor = System.Drawing.Color.White;
            this.normProteins.Location = new System.Drawing.Point(23, 46);
            this.normProteins.Name = "normProteins";
            this.normProteins.ReadOnly = true;
            this.normProteins.Size = new System.Drawing.Size(107, 22);
            this.normProteins.TabIndex = 20;
            this.normProteins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eatProteins
            // 
            this.eatProteins.BackColor = System.Drawing.Color.Black;
            this.eatProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatProteins.ForeColor = System.Drawing.Color.White;
            this.eatProteins.Location = new System.Drawing.Point(229, 46);
            this.eatProteins.Name = "eatProteins";
            this.eatProteins.ReadOnly = true;
            this.eatProteins.Size = new System.Drawing.Size(107, 22);
            this.eatProteins.TabIndex = 24;
            this.eatProteins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eatCarbohydrates
            // 
            this.eatCarbohydrates.BackColor = System.Drawing.Color.Black;
            this.eatCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatCarbohydrates.ForeColor = System.Drawing.Color.White;
            this.eatCarbohydrates.Location = new System.Drawing.Point(229, 98);
            this.eatCarbohydrates.Name = "eatCarbohydrates";
            this.eatCarbohydrates.ReadOnly = true;
            this.eatCarbohydrates.Size = new System.Drawing.Size(107, 22);
            this.eatCarbohydrates.TabIndex = 25;
            this.eatCarbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eatCalories
            // 
            this.eatCalories.BackColor = System.Drawing.Color.Black;
            this.eatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatCalories.ForeColor = System.Drawing.Color.White;
            this.eatCalories.Location = new System.Drawing.Point(229, 124);
            this.eatCalories.Name = "eatCalories";
            this.eatCalories.ReadOnly = true;
            this.eatCalories.Size = new System.Drawing.Size(107, 22);
            this.eatCalories.TabIndex = 26;
            this.eatCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // normCalories
            // 
            this.normCalories.BackColor = System.Drawing.Color.Black;
            this.normCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normCalories.ForeColor = System.Drawing.Color.White;
            this.normCalories.Location = new System.Drawing.Point(23, 124);
            this.normCalories.Name = "normCalories";
            this.normCalories.ReadOnly = true;
            this.normCalories.Size = new System.Drawing.Size(107, 22);
            this.normCalories.TabIndex = 27;
            this.normCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toEatWeight
            // 
            this.toEatWeight.BackColor = System.Drawing.Color.Black;
            this.toEatWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toEatWeight.ForeColor = System.Drawing.Color.White;
            this.toEatWeight.Location = new System.Drawing.Point(644, 101);
            this.toEatWeight.Name = "toEatWeight";
            this.toEatWeight.Size = new System.Drawing.Size(146, 22);
            this.toEatWeight.TabIndex = 9;
            this.toEatWeight.TextChanged += new System.EventHandler(this.toEatWeight_TextChanged);
            // 
            // buttonEat
            // 
            this.buttonEat.AutoSize = true;
            this.buttonEat.BackColor = System.Drawing.Color.Black;
            this.buttonEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEat.ForeColor = System.Drawing.Color.White;
            this.buttonEat.Location = new System.Drawing.Point(644, 22);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.Size = new System.Drawing.Size(146, 26);
            this.buttonEat.TabIndex = 8;
            this.buttonEat.Text = "Съесть";
            this.buttonEat.UseVisualStyleBackColor = false;
            this.buttonEat.Click += new System.EventHandler(this.buttonEat_Click);
            // 
            // foodType
            // 
            this.foodType.BackColor = System.Drawing.Color.Black;
            this.foodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodType.ForeColor = System.Drawing.Color.White;
            this.foodType.FormattingEnabled = true;
            this.foodType.Items.AddRange(new object[] {
            "все виды",
            "мясопродукты и яйца",
            "рыба и морепродукты",
            "молочные продукты",
            "зерновые и хлебо-булочные",
            "фрукты, овощи, ягоды",
            "масла, соусы",
            "напитки",
            "кондитерские изделия",
            "каши",
            "закуски",
            "первое",
            "второе",
            "гарниры"});
            this.foodType.Location = new System.Drawing.Point(8, 190);
            this.foodType.Name = "foodType";
            this.foodType.Size = new System.Drawing.Size(281, 24);
            this.foodType.TabIndex = 4;
            this.foodType.Text = "все виды";
            this.foodType.SelectedIndexChanged += new System.EventHandler(this.foodType_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.suggestWeightLabel);
            this.tabPage4.Controls.Add(this.suggestNameLabel);
            this.tabPage4.Controls.Add(this.buttonRefresh);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.suggestList);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(974, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Предложения";
            // 
            // suggestWeightLabel
            // 
            this.suggestWeightLabel.AutoSize = true;
            this.suggestWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suggestWeightLabel.ForeColor = System.Drawing.Color.White;
            this.suggestWeightLabel.Location = new System.Drawing.Point(427, 144);
            this.suggestWeightLabel.Name = "suggestWeightLabel";
            this.suggestWeightLabel.Size = new System.Drawing.Size(132, 16);
            this.suggestWeightLabel.TabIndex = 6;
            this.suggestWeightLabel.Text = "suggestWeightLabel";
            // 
            // suggestNameLabel
            // 
            this.suggestNameLabel.AutoSize = true;
            this.suggestNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suggestNameLabel.ForeColor = System.Drawing.Color.White;
            this.suggestNameLabel.Location = new System.Drawing.Point(427, 107);
            this.suggestNameLabel.Name = "suggestNameLabel";
            this.suggestNameLabel.Size = new System.Drawing.Size(127, 16);
            this.suggestNameLabel.TabIndex = 5;
            this.suggestNameLabel.Text = "suggestNameLabel";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Black;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(430, 48);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(113, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(16, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Предложенные блюда";
            // 
            // suggestList
            // 
            this.suggestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestList.BackColor = System.Drawing.Color.Black;
            this.suggestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.suggestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suggestList.ForeColor = System.Drawing.Color.White;
            this.suggestList.GridLines = true;
            this.suggestList.Location = new System.Drawing.Point(19, 48);
            this.suggestList.Name = "suggestList";
            this.suggestList.Size = new System.Drawing.Size(380, 417);
            this.suggestList.TabIndex = 0;
            this.suggestList.UseCompatibleStateImageBehavior = false;
            this.suggestList.View = System.Windows.Forms.View.Details;
            this.suggestList.SelectedIndexChanged += new System.EventHandler(this.suggestList_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Название";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Белки";
            this.columnHeader13.Width = 65;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Жиры";
            this.columnHeader14.Width = 65;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Углеводы";
            this.columnHeader15.Width = 76;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ккал";
            this.columnHeader16.Width = 65;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.dAdd);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.dishType2);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.foodType2);
            this.tabPage5.Controls.Add(this.Fats);
            this.tabPage5.Controls.Add(this.Proteins);
            this.tabPage5.Controls.Add(this.Carbohydrates);
            this.tabPage5.Controls.Add(this.Calories);
            this.tabPage5.Controls.Add(this.Name1);
            this.tabPage5.Controls.Add(this.bAdd);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(974, 514);
            this.tabPage5.TabIndex = 55;
            this.tabPage5.Text = "Добавление своих блюд";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(575, 268);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 16);
            this.label24.TabIndex = 75;
            this.label24.Text = "checkCalories";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(575, 229);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 16);
            this.label23.TabIndex = 74;
            this.label23.Text = "checkCarbohydrates";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(575, 190);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 16);
            this.label22.TabIndex = 73;
            this.label22.Text = "checkFats";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(575, 151);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 16);
            this.label21.TabIndex = 72;
            this.label21.Text = "checkProteins";
            // 
            // dAdd
            // 
            this.dAdd.BackColor = System.Drawing.Color.Black;
            this.dAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dAdd.ForeColor = System.Drawing.Color.White;
            this.dAdd.Location = new System.Drawing.Point(509, 288);
            this.dAdd.Name = "dAdd";
            this.dAdd.Size = new System.Drawing.Size(181, 23);
            this.dAdd.TabIndex = 71;
            this.dAdd.Text = "Добавить блюдо";
            this.dAdd.UseVisualStyleBackColor = false;
            this.dAdd.Click += new System.EventHandler(this.dAdd_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(509, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 70;
            this.label20.Text = "тип блюда";
            // 
            // dishType2
            // 
            this.dishType2.BackColor = System.Drawing.Color.Black;
            this.dishType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishType2.ForeColor = System.Drawing.Color.White;
            this.dishType2.FormattingEnabled = true;
            this.dishType2.Items.AddRange(new object[] {
            "каши",
            "закуски",
            "первое",
            "второе",
            "гарнир"});
            this.dishType2.Location = new System.Drawing.Point(509, 105);
            this.dishType2.Name = "dishType2";
            this.dishType2.Size = new System.Drawing.Size(181, 24);
            this.dishType2.TabIndex = 69;
            this.dishType2.Text = "каши";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(387, 50);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 16);
            this.label29.TabIndex = 63;
            this.label29.Text = "название";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(387, 207);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 16);
            this.label30.TabIndex = 64;
            this.label30.Text = "г. углеводов";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(387, 246);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 16);
            this.label31.TabIndex = 65;
            this.label31.Text = "ккал.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(387, 168);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 16);
            this.label32.TabIndex = 66;
            this.label32.Text = "г. жиров";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(387, 129);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 16);
            this.label33.TabIndex = 67;
            this.label33.Text = "г.белков";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(313, 89);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 16);
            this.label34.TabIndex = 68;
            this.label34.Text = "тип продукта";
            // 
            // foodType2
            // 
            this.foodType2.BackColor = System.Drawing.Color.Black;
            this.foodType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodType2.ForeColor = System.Drawing.Color.White;
            this.foodType2.FormattingEnabled = true;
            this.foodType2.Items.AddRange(new object[] {
            "мясопродукты и яйца",
            "рыба и морепродукты",
            "молочные продукты",
            "зерновые и хлебо-булочные",
            "фрукты, овощи, ягоды",
            "масла, соусы",
            "напитки",
            "кондитерские изделия"});
            this.foodType2.Location = new System.Drawing.Point(313, 105);
            this.foodType2.Name = "foodType2";
            this.foodType2.Size = new System.Drawing.Size(181, 24);
            this.foodType2.TabIndex = 57;
            this.foodType2.Text = "мясопродукты и яйца";
            this.foodType2.SelectedIndexChanged += new System.EventHandler(this.foodType_SelectedIndexChanged);
            // 
            // Fats
            // 
            this.Fats.BackColor = System.Drawing.Color.Black;
            this.Fats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fats.ForeColor = System.Drawing.Color.White;
            this.Fats.Location = new System.Drawing.Point(387, 184);
            this.Fats.Name = "Fats";
            this.Fats.Size = new System.Drawing.Size(181, 22);
            this.Fats.TabIndex = 59;
            this.Fats.TextChanged += new System.EventHandler(this.Fats_TextChanged);
            // 
            // Proteins
            // 
            this.Proteins.BackColor = System.Drawing.Color.Black;
            this.Proteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proteins.ForeColor = System.Drawing.Color.White;
            this.Proteins.Location = new System.Drawing.Point(387, 145);
            this.Proteins.Name = "Proteins";
            this.Proteins.Size = new System.Drawing.Size(181, 22);
            this.Proteins.TabIndex = 58;
            this.Proteins.TextChanged += new System.EventHandler(this.Proteins_TextChanged);
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.BackColor = System.Drawing.Color.Black;
            this.Carbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Carbohydrates.ForeColor = System.Drawing.Color.White;
            this.Carbohydrates.Location = new System.Drawing.Point(387, 223);
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.Size = new System.Drawing.Size(181, 22);
            this.Carbohydrates.TabIndex = 60;
            this.Carbohydrates.TextChanged += new System.EventHandler(this.Carbohydrates_TextChanged);
            // 
            // Calories
            // 
            this.Calories.BackColor = System.Drawing.Color.Black;
            this.Calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories.ForeColor = System.Drawing.Color.White;
            this.Calories.Location = new System.Drawing.Point(387, 262);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(181, 22);
            this.Calories.TabIndex = 62;
            this.Calories.TextChanged += new System.EventHandler(this.Calories_TextChanged);
            // 
            // Name1
            // 
            this.Name1.BackColor = System.Drawing.Color.Black;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.ForeColor = System.Drawing.Color.White;
            this.Name1.Location = new System.Drawing.Point(387, 66);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(181, 22);
            this.Name1.TabIndex = 56;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Black;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(316, 288);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(181, 23);
            this.bAdd.TabIndex = 63;
            this.bAdd.Text = "Добавить продукт";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Black;
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Controls.Add(this.groupBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(974, 514);
            this.tabPage7.TabIndex = 57;
            this.tabPage7.Text = "Коррекция фигуры";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Black;
            this.tabPage8.Controls.Add(this.buttonEatDish);
            this.tabPage8.Controls.Add(this.makeMenuButton);
            this.tabPage8.Controls.Add(this.menuList);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(974, 514);
            this.tabPage8.TabIndex = 58;
            this.tabPage8.Text = "Меню";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Black;
            this.tabPage9.Controls.Add(this.richTextBox1);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(974, 514);
            this.tabPage9.TabIndex = 59;
            this.tabPage9.Text = "Инструкция";
            // 
            // buttonEatDish
            // 
            this.buttonEatDish.BackColor = System.Drawing.Color.Black;
            this.buttonEatDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEatDish.ForeColor = System.Drawing.Color.White;
            this.buttonEatDish.Location = new System.Drawing.Point(196, 16);
            this.buttonEatDish.Name = "buttonEatDish";
            this.buttonEatDish.Size = new System.Drawing.Size(75, 23);
            this.buttonEatDish.TabIndex = 38;
            this.buttonEatDish.Text = "Съесть";
            this.buttonEatDish.UseVisualStyleBackColor = false;
            this.buttonEatDish.Click += new System.EventHandler(this.buttonEatDish_Click);
            // 
            // makeMenuButton
            // 
            this.makeMenuButton.BackColor = System.Drawing.Color.Black;
            this.makeMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeMenuButton.ForeColor = System.Drawing.Color.White;
            this.makeMenuButton.Location = new System.Drawing.Point(24, 16);
            this.makeMenuButton.Name = "makeMenuButton";
            this.makeMenuButton.Size = new System.Drawing.Size(141, 23);
            this.makeMenuButton.TabIndex = 37;
            this.makeMenuButton.Text = "Подобрать меню";
            this.makeMenuButton.UseVisualStyleBackColor = false;
            this.makeMenuButton.Click += new System.EventHandler(this.makeMenuButton_Click);
            // 
            // menuList
            // 
            this.menuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuList.BackColor = System.Drawing.Color.Black;
            this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.menuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuList.ForeColor = System.Drawing.Color.White;
            this.menuList.GridLines = true;
            this.menuList.Location = new System.Drawing.Point(24, 56);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(735, 256);
            this.menuList.TabIndex = 36;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Название";
            this.columnHeader17.Width = 313;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Масса";
            this.columnHeader18.Width = 99;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Ккал";
            this.columnHeader19.Width = 87;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Белки";
            this.columnHeader20.Width = 92;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Жиры";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Углеводы";
            this.columnHeader22.Width = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 140);
            this.button1.TabIndex = 36;
            this.button1.Text = "Жмак";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(112, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим коррекции";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 94);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 20);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Потолщение";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Баланс";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Похудение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(960, 500);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 543);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Dietpitanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindowClosed);
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.genderbox.ResumeLayout(false);
            this.genderbox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Label resultLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label heightText;
        private TextBox height;
        private Label weightText;
        private TextBox weight;
        private Button buttonCalculate;
        private TabPage tabPage2;
        private GroupBox genderbox;
        private RadioButton gender_male;
        private RadioButton gender_female;
        private Label label1;
        private TextBox age;
        private Label caloriesLabel;
        private TabPage tabPage3;
        private TextBox normCarbohydrates;
        private TextBox normFats;
        private TextBox eatFats;
        private TextBox normProteins;
        private TextBox eatProteins;
        private TextBox eatCarbohydrates;
        private TextBox eatCalories;
        private TextBox normCalories;
        private TextBox toEatWeight;
        private Button bAdd;
        private Button buttonEat;
        private ComboBox foodType;
        private ComboBox foodType2;
        private TextBox activity2Time;
        private ComboBox activity2;
        private ComboBox activity1;
        private ListView toRejectListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ListView toEatListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button buttonEject;
        private Label heightLabel;
        private Label ageLabel;
        private Label weightLabel;
        private Label label4;
        private Label label3;
        private Label activity1Label;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private TextBox toNormFats;
        private TextBox toNormProteins;
        private TextBox toNormCarbohydrates;
        private TextBox toNormCalories;
        private TextBox Name1;
        private TextBox Fats;
        private TextBox Proteins;
        private TextBox Carbohydrates;
        private TextBox Calories;
        private Label eatLabel;
        private Label toEatLabel;
        private Label checkToEatWeight;
        private TabPage tabPage4;
        private Button buttonRefresh;
        private Label label19;
        private ListView suggestList;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Label toRejectFoodLabel;
        private Label toEatFoodLabel;
        private Label suggestWeightLabel;
        private Label suggestNameLabel;
        private TabPage tabPage5;
        private Button dAdd;
        private Label label20;
        private ComboBox dishType2;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private TabPage tabPage6;
        private Label label25;
        private Button button3;
        private Button button2;
        private TextBox login;
        private TabPage tabPage7;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabPage tabPage8;
        private Button buttonEatDish;
        private Button makeMenuButton;
        private ListView menuList;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private TabPage tabPage9;
        private RichTextBox richTextBox1;
    }
}

