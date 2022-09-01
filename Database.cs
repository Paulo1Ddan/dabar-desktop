using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cetdabar
{
    public class Database
    {
        public static string dbinfo = "SERVER=localhost;USER=root;DATABASE=dabar";

        public static MySqlConnection conn;

        public static void StartConn()
        {
            try
            {
                conn = new MySqlConnection(dbinfo);
                conn.Open();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConn()
        {
            try
            {
                conn = new MySqlConnection(dbinfo);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
