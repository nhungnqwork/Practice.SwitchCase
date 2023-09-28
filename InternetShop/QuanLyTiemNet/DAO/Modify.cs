using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet
{
    internal class Modify
    {
        public Modify() { }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        private static string stringConnection = @"Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public DataTable Table(string query) //tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
