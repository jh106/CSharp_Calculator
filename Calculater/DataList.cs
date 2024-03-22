using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Calculater
{
    public partial class DataList : Form
    {
        int ab = 0;
        public DataList()
        {
            InitializeComponent();
        }

        private void ListData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem Item;
            string connStr = ConfigurationManager.AppSettings["DbConnectionString"];
            string sql = @"select Result from tbl;";
            string Res;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            MySqlDataReader Reader = cmd.ExecuteReader();

            ListData.Columns.Add("Result");

            while (Reader.Read())
            {
                if (ab > 1000) break;
                Res = Reader["Result"].ToString();
                
                Item = new ListViewItem(Res);
                ListData.Items.Add(Item);
                ab++;
            }
            Reader.Close();
            conn.Close();

            Console.WriteLine("Done.");
        }
    }
}
