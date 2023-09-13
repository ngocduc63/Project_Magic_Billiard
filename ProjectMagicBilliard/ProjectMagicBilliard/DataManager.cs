using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard
{
    class DataManager
    {
        string strConnect = @"Data Source=LAPTOP-IU6UCJSL;Initial Catalog=MagicBilliard;Integrated Security=True";
        private static DataManager instance;

        public static DataManager Instance
        {
            get { if (instance == null) instance = new DataManager(); return DataManager.instance; }
            private set { DataManager.instance = value; }
        }

        public DataTable ExecuteOuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConnect))
            {

                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

               adapter.Fill(data);

                conn.Close();
            }

            return data;
        }

    }
}
