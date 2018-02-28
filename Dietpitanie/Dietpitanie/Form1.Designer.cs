namespace Dietpitanie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            //Height TextBox 
            //
            this.height.Location = new System.Drawing.Point(115, 35);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Name = "Height";
            this.height.Size = new System.Drawing.Size(169, 28);
            this.height.TabIndex = 1;
            //this.height.MouseClick += new System.Windows.Forms.MouseEventHandler(this.height_MouseClick);
            //this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            //
            //Weight TextBox 
            //
            this.weight.Location = new System.Drawing.Point(115, 95);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.Name = "Weight";
            this.weight.Size = new System.Drawing.Size(169, 28);
            this.weight.TabIndex = 1;
            //this.height.MouseClick += new System.Windows.Forms.MouseEventHandler(this.height_MouseClick);
            //this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            //
            //heightText Label 
            //
            this.heightText.AutoSize = true;
            this.heightText.Location = new System.Drawing.Point(115, 5);
            this.heightText.Margin = new System.Windows.Forms.Padding(4);
            this.heightText.Name = "heightText";
            this.heightText.Text = "Input height(in centimetres):";
            this.heightText.Size = new System.Drawing.Size(0, 22);
            this.heightText.TabIndex = 3;
            //this.heightText.Click += new System.EventHandler(this.Status_Click);
            //
            //heightText Label 
            //
            this.weightText.AutoSize = true;
            this.weightText.Location = new System.Drawing.Point(115, 65);
            this.weightText.Margin = new System.Windows.Forms.Padding(4);
            this.weightText.Name = "weightText";
            this.weightText.Text = "Input weight:";
            this.weightText.Size = new System.Drawing.Size(0, 22);
            this.weightText.TabIndex = 3;
            //this.heightText.Click += new System.EventHandler(this.Status_Click);
            //
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(115, 125);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(172, 28);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            //
            //result Label 
            //
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(115, 185);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Text = "Пупа и Лупа устроились на работу. Проработали целый месяц, трудились не покладая рук и не жалея живота своего. В итоге Лупа получил зарплату за Пупу, а Пупа получил за Лупу.";
            this.result.Size = new System.Drawing.Size(0, 22);
            this.result.TabIndex = 3;
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(result);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label heightText;
        private System.Windows.Forms.Label weightText;
    }
}

