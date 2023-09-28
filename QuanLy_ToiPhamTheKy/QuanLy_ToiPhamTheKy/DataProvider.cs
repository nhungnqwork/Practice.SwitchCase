using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_ToiPhamTheKy
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) ; instance = new DataProvider(); return instance; }

            private set => instance = value;
        }
        public DataProvider() { }

        private string connectionString = @"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
    }
}
