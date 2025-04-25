using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Кулинарная_книга
{
    /// <summary>
    /// класс, определящий каждый из рецептов
    /// </summary>
    public class Recipes
    {
        private int id;
        private string name;
        private int time;
        private decimal calories;
        private string type;

        public Recipes(int id, string name, int time, decimal calories, string type)
        {
            this.id = id;
            this.name = name;
            this.time = time;
            this.calories = calories;
            this.type = type;
        }

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public int Time { get { return time; } }
        public decimal Calories { get { return calories; } }
        public string Type { get { return type; } }
        /// <summary>
        /// Статический метод, который определяет  List<Recipes> recipes, содержащий в себе все рецепты из базы данных Book_of_Recipes
        /// </summary>
        /// <returns></returns>
        public static List<Recipes> ReadFromDataBase()
        {
            List<Recipes> recipes = new List<Recipes>();

            string connectionString = "Data Source=Book_of_recipes.db;";
            string query = "SELECT * FROM Recipes";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int time = reader.GetInt32(2);
                            decimal calories = reader.GetDecimal(3) ;
                            string type = reader.GetString(4);

                            Recipes newTask = new Recipes(id,name,time,calories,type);
                            recipes.Add(newTask);
                        }
                    }
                }

            }

            return recipes;
        }

    }


}
