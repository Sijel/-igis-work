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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 oldForm = new Form1();
            oldForm.Show();
            Close();
        }
        #region sql
        private SQLiteConnection DB;

        private async void BusForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connection);
            await DB.OpenAsync();

            SQLiteCommand command = new SQLiteCommand("SELECT id, nm, kol, kmh, ost, price, kolm, kolp, np, kp, km FROM bus", DB);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.Columns.Add("nm", "nm");
            dataGridView1.Columns.Add("kol", "kol");
            dataGridView1.Columns.Add("kmh", "kmh");
            dataGridView1.Columns.Add("ost", "ost");
            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns.Add("kolm", "kolm");
            dataGridView1.Columns.Add("kolp", "kolp");
            dataGridView1.Columns.Add("np", "np");
            dataGridView1.Columns.Add("kp", "kp");
            dataGridView1.Columns.Add("km", "km");



            // Переименование названий столбцов
            dataGridView1.Columns["nm"].HeaderText = "Номер маршрута";
            dataGridView1.Columns["kol"].HeaderText = "Кол-во машин в парке";
            dataGridView1.Columns["kmh"].HeaderText = "Км/ч";
            dataGridView1.Columns["ost"].HeaderText = "Остановки";
            dataGridView1.Columns["price"].HeaderText = "Цена";
            dataGridView1.Columns["kolm"].HeaderText = "Кол-во на маршруте";
            dataGridView1.Columns["kolp"].HeaderText = "Кол-во пассажиров";
            dataGridView1.Columns["np"].HeaderText = "Начальный пункт";
            dataGridView1.Columns["kp"].HeaderText = "Конечный пункт";
            dataGridView1.Columns["km"].HeaderText = "Км пути";

            foreach (DataRow row in dataTable.Rows)
            {

                dataGridView1.Rows.Add(row["nm"], row["kol"], row["kmh"], row["ost"], row["price"], row["kolm"], row["kolp"], row["np"], row["kp"], row["km"]);
            }

            DB.Close();
        }
        #endregion
    }
}
