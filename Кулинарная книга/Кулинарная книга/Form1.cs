using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кулинарная_книга
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        /// <summary>
        /// Переход на форму "Завтрак"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_breakfast_Click(object sender, EventArgs e)
        {
            Breakfast breakfast = new Breakfast();
            breakfast.Show();
            this.Hide();
        }
        /// <summary>
        /// Переход на форму "Обед"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_dinner_Click(object sender, EventArgs e)
        {
            Dinner dinner = new Dinner();
            dinner.ShowDialog();
            this.Hide();

        }
        /// <summary>
        /// Переход на форму "Ужин"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_supper_Click(object sender, EventArgs e)
        {
            Supper supper = new Supper();
            supper.Show();
            this.Hide();
        }
        /// <summary>
        /// Загрузка основной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshMainForm();
        }
        /// <summary>
        /// Метод, обновляющий строку с выводом количества рецептов и диаграмму, отображающую соотношение количества рецептов в категориях
        /// </summary>
        private void RefreshMainForm()
        {
            List<Recipes> recipes = Recipes.ReadFromDataBase();

            int count = recipes.Count();
            label2_countRecipes.Text = "Всего рецептов в книге: " + count.ToString();

            List<string> categories = recipes.Select(r => r.Type).Distinct().ToList();

            chart1.Series[0].Points.Clear();
            foreach (string ctg in categories)
            {
                decimal total = recipes.Where(q => q.Type == ctg).Count();
                if (total != 0)
                {
                    chart1.Series[0].Points.AddXY(ctg, total);
                }
            }
        }
    }
}
