using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Data_Access_Layer_DAL
{

    public class DatabaseContext
    {
        /// <summary>
        /// Deklarera variabler
        /// </summary>
        public static string connectionString = "SERVER=195.178.232.16;port=3306;DATABASE=ag6479;UID=AG6479;PASSWORD=Assignment3";
        private MySqlConnection connection = new MySqlConnection(connectionString);
        private MySqlDataAdapter adapter;

        /// <summary>
        /// exekverar mysql kommando
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(String query)
        {
            try
            {
                adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }
    }
}
