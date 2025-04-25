using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;


namespace Кулинарная_книга
{
    public partial class Breakfast : Form
    {
        /// <summary>
        /// Форма взаимодействия пользователя с разделом "Завтраки"
        /// </summary>
        public Breakfast()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        /// <summary>
        /// Загрузка формы "Завтрак"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Breakfast_Load(object sender, EventArgs e)
        {
            GetColumns();
            RefreshData(dataGridView1);
        }

        /// <summary>
        /// Создание колонок в DataGridView с нужными заголовками
        /// </summary>
        public void GetColumns()
        {
            dataGridView1.Columns.Add("id", "Номер");
            dataGridView1.Columns.Add("name", "Блюдо");
            dataGridView1.Columns.Add("time", "Время приготовления");
            dataGridView1.Columns.Add("calories", "Калорийность на 100г");
            dataGridView1.Columns.Add("type", "Приём пищи");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        /// <summary>
        /// Метод, обновляющий информацию в DataGridView и строке вывода количества рецептов
        /// </summary>
        /// <param name="dataGridView"></param>
        private void RefreshData(DataGridView dataGridView)
        {
            List<Recipes> recipes = Recipes.ReadFromDataBase();
            List < Recipes> breakfasts = (from p in recipes where p.Type == "Завтрак" select p).ToList();
            dataGridView.Rows.Clear();
            foreach (Recipes br in breakfasts)
            {
                dataGridView.Rows.Add(br.ID, br.Name, br.Time, br.Calories, br.Type);
            }

            int countbr = breakfasts.Count();
            label2_countBreakfast.Text = "Всего рецептов завтраков: " + countbr.ToString(); // Отображаем количество завтраков
        }
        /// <summary>
        /// Метод, отображающий в dataGridView рецепты по выбранной категории, заданной в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Recipes> recipes = Recipes.ReadFromDataBase();
            List<Recipes> breakfasts = (from p in recipes where p.Type == "Завтрак" select p).ToList();

            dataGridView1.Rows.Clear();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    foreach (Recipes br in breakfasts) { dataGridView1.Rows.Add(br.ID, br.Name, br.Time, br.Calories, br.Type); }
                    break;
                case 1:
                    foreach (Recipes br in (from p in breakfasts where p.Calories >=  225 select p).ToList()) { dataGridView1.Rows.Add(br.ID, br.Name, br.Time, br.Calories, br.Type); }
                    break;
                case 2:
                    foreach (Recipes br in (from p in breakfasts where p.Time <= 25  select p).ToList()) { dataGridView1.Rows.Add(br.ID, br.Name, br.Time, br.Calories, br.Type); }
                    break;
                case 3:
                    foreach (Recipes br in (from p in breakfasts where p.Calories <= 130 select p).ToList()) { dataGridView1.Rows.Add(br.ID, br.Name, br.Time, br.Calories, br.Type); }
                    break;

            }
        }
        /// <summary>
        /// Метод, добавляющий в базу данных новый рецепт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Add_Click(object sender, EventArgs e)
        {

            var name = textBox1_Name.Text;
            var time = textBox2_Time.Text;
            var calories = textBox3_Calories.Text;
            string type = "Завтрак";

            if (name == "" || time == "" || calories == "")
            {
                MessageBox.Show("Введиите данные");
                return;
            }
            

            decimal Calories;
            if (!decimal.TryParse(calories, out Calories))
            {

                MessageBox.Show("Введите корректное значение для калорийности блюда!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Calories < 0)
            {
                MessageBox.Show("Введите корректное значение для калорийности блюда!" + "Вводимая  калорийность блюда должна быть больше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Time;
            if(!int.TryParse(time, out Time))
            {
                MessageBox.Show("Введите корректное значение для времени приготовления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Time  < 0)
            {
                MessageBox.Show("Введите корректное значение для времени приготовления!" + "Вводимое время в минутах должно быть больше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Book_of_recipes.db;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string insertingquery = $"insert into Recipes(name, time, calories, type) values('{name}','{Time}','{Calories}', '{type}')";
                    command.CommandText = insertingquery;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Рецепт добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData(dataGridView1);

        }
        /// <summary>
        /// Удаление выбранного рецепта из базы данных Book_of_recipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления! \n" +
                                "Выберите для этого крайнюю левую ячейку в строке нужной задачи!", "Укажите строку!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }


            string connectionString = "Data Source=Book_of_recipes.db;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["id"].Value);
                        string deletingstring = $"DELETE FROM Recipes WHERE id = '{selectedId}'";
                        command.CommandText = deletingstring;
                        command.ExecuteNonQuery();
                    }

                }

                connection.Close();
            }

            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            RefreshData(dataGridView1);
        }
        /// <summary>
        /// Метод, который очищает все поля ввода при нажатии на кнопку "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1_Name.Text = "";
            textBox2_Time.Text = "";
            textBox3_Calories.Text = "";
        }
        /// <summary>
        /// Метод, возврающий на главную форму при нажатии на текст-ссылку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

    }
}
