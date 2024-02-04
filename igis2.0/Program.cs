using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igis2._0
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogForm());
        }
        
    }
    static class Database
    {
        public static string connection = @"Data Source=igis.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    #region table
    static class bus_table
    {
        public static string main = "bus";
        public static string id = "id";
        public static string nm = "nm";
        public static string kol = "kol";
        public static string kmh = "kmh";
        public static string ost = "ost";
        public static string price = "price";
        public static string kolm = "kolm";
        public static string kolp = "kolp";
        public static string np = "np";
        public static string kp = "kp";
        public static string km = "km";


    }
    static class tram_table
    {
        public static string main = "tram";
        public static string id = "id";
        public static string nm = "nm";
        public static string kol = "kol";
        public static string kmh = "kmh";
        public static string ost = "ost";
        public static string price = "price";
        public static string kolm = "kolm";
        public static string kolp = "kolp";
        public static string np = "np";
        public static string kp = "kp";
        public static string km = "km";


    }
    static class trol_table
    {
        public static string main = "trol";
        public static string id = "id";
        public static string nm = "nm";
        public static string kol = "kol";
        public static string kmh = "kmh";
        public static string ost = "ost";
        public static string price = "price";
        public static string kolm = "kolm";
        public static string kolp = "kolp";
        public static string np = "np";
        public static string kp = "kp";
        public static string km = "km";


    }
    #endregion
}
