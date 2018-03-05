using System.ComponentModel;
using System.Windows.Forms;

namespace Dietpitanie
{
    partial class Form1
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
            this.result = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.activity1 = new System.Windows.Forms.ComboBox();
            this.genderbox = new System.Windows.Forms.GroupBox();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.heightText = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.activity2 = new System.Windows.Forms.ComboBox();
            this.activity2_time = new System.Windows.Forms.TextBox();
            this.result_calories = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.genderbox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(413, 67);
            this.result.Margin = new System.Windows.Forms.Padding(3);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 465);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.result_calories);
            this.tabPage1.Controls.Add(this.activity2_time);
            this.tabPage1.Controls.Add(this.activity2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.age);
            this.tabPage1.Controls.Add(this.activity1);
            this.tabPage1.Controls.Add(this.genderbox);
            this.tabPage1.Controls.Add(this.heightText);
            this.tabPage1.Controls.Add(this.result);
            this.tabPage1.Controls.Add(this.height);
            this.tabPage1.Controls.Add(this.weightText);
            this.tabPage1.Controls.Add(this.weight);
            this.tabPage1.Controls.Add(this.buttonCalculate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // activity1
            // 
            this.activity1.FormattingEnabled = true;
            this.activity1.Items.AddRange(new object[] {
            "сидячая работа, отсутствие спорта",
            "легкие физические упражнения около 3 раз за неделю, ежедневная утренняя зарядка, " +
                "пешие прогулки",
            "спорт до 5 раз за неделю",
            "активный образ жизни вкупе с ежедневными интенсивными тренировками",
            "спортивный образ жизни, тяжелый физический труд, длительные тяжелые тренировки ка" +
                "ждый день"});
            this.activity1.Location = new System.Drawing.Point(39, 242);
            this.activity1.Name = "activity1";
            this.activity1.Size = new System.Drawing.Size(529, 21);
            this.activity1.TabIndex = 12;
            this.activity1.Text = "сидячая работа, отсутствие спорта";
            // 
            // genderbox
            // 
            this.genderbox.Controls.Add(this.gender_male);
            this.genderbox.Controls.Add(this.gender_female);
            this.genderbox.Location = new System.Drawing.Point(194, 43);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(200, 100);
            this.genderbox.TabIndex = 11;
            this.genderbox.TabStop = false;
            this.genderbox.Text = "Пол";
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.Location = new System.Drawing.Point(18, 24);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(71, 17);
            this.gender_male.TabIndex = 9;
            this.gender_male.TabStop = true;
            this.gender_male.Text = "Мужской";
            this.gender_male.UseVisualStyleBackColor = true;
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.Location = new System.Drawing.Point(18, 51);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(72, 17);
            this.gender_female.TabIndex = 10;
            this.gender_female.TabStop = true;
            this.gender_female.Text = "Женский";
            this.gender_female.UseVisualStyleBackColor = true;
            // 
            // heightText
            // 
            this.heightText.AutoSize = true;
            this.heightText.Location = new System.Drawing.Point(39, 43);
            this.heightText.Margin = new System.Windows.Forms.Padding(3);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(137, 13);
            this.heightText.TabIndex = 7;
            this.heightText.Text = "Input height(in centimetres):";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(39, 67);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(128, 20);
            this.height.TabIndex = 4;
            // 
            // weightText
            // 
            this.weightText.AutoSize = true;
            this.weightText.Location = new System.Drawing.Point(39, 92);
            this.weightText.Margin = new System.Windows.Forms.Padding(3);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(68, 13);
            this.weightText.TabIndex = 8;
            this.weightText.Text = "Input weight:";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(39, 116);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(128, 20);
            this.weight.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(42, 200);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(129, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox6, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 51);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(845, 152);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(3, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(290, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(290, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(272, 20);
            this.textBox8.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(290, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(272, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 117);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(281, 20);
            this.textBox9.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(568, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Извлечь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 38);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(568, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(290, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Съесть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "все виды",
            "мясопродукты и яйца",
            "рыба и морепродукты",
            "молочные продукты",
            "зерновые и хлебо-булочные",
            "фрукты, овощи, ягоды",
            "масла, соусы",
            "напитки",
            "кондитерские изделия"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "все виды";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4396F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 209);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 222);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 216);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 140;
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
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ккал";
            this.columnHeader5.Width = 55;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView2.Location = new System.Drawing.Point(431, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(414, 216);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название";
            this.columnHeader6.Width = 211;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Масса";
            this.columnHeader7.Width = 99;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input age:";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(42, 162);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(128, 20);
            this.age.TabIndex = 13;
            // 
            // activity2
            // 
            this.activity2.FormattingEnabled = true;
            this.activity2.Items.AddRange(new object[] {
            "ничего",
            "велоспорт",
            "бег трусцой",
            "волейбол",
            "гимнастика",
            "катание на коньках",
            "плавние"});
            this.activity2.Location = new System.Drawing.Point(39, 278);
            this.activity2.Name = "activity2";
            this.activity2.Size = new System.Drawing.Size(256, 21);
            this.activity2.TabIndex = 15;
            this.activity2.Text = "ничего";
            // 
            // activity2_time
            // 
            this.activity2_time.Location = new System.Drawing.Point(313, 279);
            this.activity2_time.Name = "activity2_time";
            this.activity2_time.Size = new System.Drawing.Size(255, 20);
            this.activity2_time.TabIndex = 16;
            // 
            // result_calories
            // 
            this.result_calories.AutoSize = true;
            this.result_calories.Location = new System.Drawing.Point(413, 107);
            this.result_calories.Margin = new System.Windows.Forms.Padding(3);
            this.result_calories.Name = "result_calories";
            this.result_calories.Size = new System.Drawing.Size(0, 13);
            this.result_calories.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.genderbox.ResumeLayout(false);
            this.genderbox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label result;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label heightText;
        private TextBox height;
        private Label weightText;
        private TextBox weight;
        private Button buttonCalculate;
        private TabPage tabPage2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox8;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox9;
        private Button button2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private GroupBox genderbox;
        private RadioButton gender_male;
        private RadioButton gender_female;
        private ComboBox activity1;
        private Label label1;
        private TextBox age;
        private TextBox activity2_time;
        private ComboBox activity2;
        private Label result_calories;
    }
}

