using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace igis2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connection);
            await DB.OpenAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region butons
        private void button1_Click(object sender, EventArgs e)
        {
            BusForm newForm = new BusForm();
            newForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrolForm newForm = new TrolForm();
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TramForm newForm = new TramForm();
            newForm.Show();
            Hide();
        }
		#endregion
		#region короткий маршрут
		private SQLiteConnection DB;
        private async void button5_Click(object sender, EventArgs e)
        {
            double result = 63 / 18;
			MessageBox.Show("Самый оптимальный маршрут автобус №22, дорога займёт " + result.ToString() + " часа.");
		}
		#endregion
	}
}
