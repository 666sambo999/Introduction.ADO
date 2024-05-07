using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;



namespace Academy_PD
{
    internal class Connector
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        public DataTable Datatable { get; set; }
        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public DataTable LoadTableBase(string columns, string tables, string condition = null)
        {
             connection.Open();
             string query = $"Select {columns} From {tables}";
             if (condition != null && !condition.Contains("Все")) 
             {
                 query += $" WHERE {condition}";
             }
             SqlCommand command = new SqlCommand(query, connection);
             reader = command.ExecuteReader();
             Datatable = new DataTable();
             for (int i = 0; i < reader.FieldCount; i++) Datatable.Columns.Add(reader.GetName(i));
             while (reader.Read()) 
             {
                 DataRow row = Datatable.NewRow();
                 for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                 Datatable.Rows.Add(row);
             }
             connection.Close();
             // возвращaем таблицу
             return Datatable;
        }
        public void InsertDataToBase(string table, string column, string values) 
        { 
            string command = $"Insert INTO {table}({column}) VALUES {values}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        
        }
        public int GetIdByVales(string table, string columns, string values) 
        { 
            //int id = 0;
            string command = $"Select {columns.Split()[0]} From {table.Split()[1]} = '{values}'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            //cmd.ExecuteNonQuery();

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();
            return id;
        }
                
          

    }
}
