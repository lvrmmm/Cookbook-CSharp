namespace Кулинарная_книга
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_breakfast = new System.Windows.Forms.Button();
            this.button2_dinner = new System.Windows.Forms.Button();
            this.button3_supper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_countRecipes = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_breakfast
            // 
            this.button1_breakfast.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1_breakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_breakfast.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_breakfast.Location = new System.Drawing.Point(26, 186);
            this.button1_breakfast.Name = "button1_breakfast";
            this.button1_breakfast.Size = new System.Drawing.Size(260, 62);
            this.button1_breakfast.TabIndex = 0;
            this.button1_breakfast.Text = "Завтрак";
            this.button1_breakfast.UseVisualStyleBackColor = false;
            this.button1_breakfast.Click += new System.EventHandler(this.button1_breakfast_Click);
            // 
            // button2_dinner
            // 
            this.button2_dinner.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2_dinner.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_dinner.Location = new System.Drawing.Point(341, 186);
            this.button2_dinner.Name = "button2_dinner";
            this.button2_dinner.Size = new System.Drawing.Size(260, 62);
            this.button2_dinner.TabIndex = 1;
            this.button2_dinner.Text = "Обед";
            this.button2_dinner.UseVisualStyleBackColor = false;
            this.button2_dinner.Click += new System.EventHandler(this.button2_dinner_Click);
            // 
            // button3_supper
            // 
            this.button3_supper.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3_supper.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_supper.Location = new System.Drawing.Point(655, 186);
            this.button3_supper.Name = "button3_supper";
            this.button3_supper.Size = new System.Drawing.Size(260, 62);
            this.button3_supper.TabIndex = 2;
            this.button3_supper.Text = "Ужин";
            this.button3_supper.UseVisualStyleBackColor = false;
            this.button3_supper.Click += new System.EventHandler(this.button3_supper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите приём пищи";
            // 
            // label2_countRecipes
            // 
            this.label2_countRecipes.AutoSize = true;
            this.label2_countRecipes.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_countRecipes.Location = new System.Drawing.Point(214, 284);
            this.label2_countRecipes.Name = "label2_countRecipes";
            this.label2_countRecipes.Size = new System.Drawing.Size(126, 50);
            this.label2_countRecipes.TabIndex = 4;
            this.label2_countRecipes.Text = "label2";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(248, 357);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(442, 370);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(946, 754);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2_countRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_supper);
            this.Controls.Add(this.button2_dinner);
            this.Controls.Add(this.button1_breakfast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Кулинарная книга";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_breakfast;
        private System.Windows.Forms.Button button2_dinner;
        private System.Windows.Forms.Button button3_supper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_countRecipes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

