using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace igis2._0
{
    public partial class AdmForm : Form
    {
        public AdmForm()
        {
            InitializeComponent();
        }
        private SQLiteConnection DB;
        private async void AdmForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connection);
            await DB.OpenAsync();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=igis.db;Version=3;";
            string query = "SELECT SUM(kolp) FROM bus;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Подсчет суммы
                    int sum = Convert.ToInt32(command.ExecuteScalar());

                    // Умножение на 30
                    int result = sum * 30;

                    // Отображение результата в MessageBox
                    MessageBox.Show($"Результат: {result}");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=igis.db;Version=3;";
            string query = "SELECT SUM(kolp) FROM tram;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Подсчет суммы
                    int sum = Convert.ToInt32(command.ExecuteScalar());

                    // Умножение на 30
                    int result = sum * 30;

                    // Отображение результата в MessageBox
                    MessageBox.Show($"Результат: {result}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=igis.db;Version=3;";
            string query = "SELECT SUM(kolp) FROM trol;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Подсчет суммы
                    int sum = Convert.ToInt32(command.ExecuteScalar());

                    // Умножение на 30
                    int result = sum * 30;

                    // Отображение результата в MessageBox
                    MessageBox.Show($"Результат: {result}");
                }
            }
        }
    }
    
}
