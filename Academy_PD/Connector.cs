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
             if (condition != null) 
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
                
          

    }
}
