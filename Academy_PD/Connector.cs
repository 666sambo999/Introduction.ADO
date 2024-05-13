using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using System.IO;



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
            Console.WriteLine("				CONNECTOR:");
            Console.WriteLine(query);
            Console.WriteLine("----------------------------------------------");

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
            string command = $"Insert INTO {table}({column}) VALUES ({values})";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        
        }
        public int GetIdByVales(string table, string columns, string values) 
        { 
            //int id = 0;
            string command = $"Select {columns.Split(',')[0]} From  {table} WHERE {columns.Split(',')[1]}='{values}'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            //cmd.ExecuteNonQuery();

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();
            return id;
        }

        public void UpdateBase(string table, string columns, string values, string condition)
        {
            string[] column_split = columns.Split(',');
            string[] values_split = values.Split(',');
            string[] expresions_split = new string[column_split.Length];
            string expresion = "";
            for (int i = 0; i < column_split.Length; i++)
            {
                expresions_split[i] = $"{column_split[i]} = {values_split[i]}";
                expresion += $"{expresions_split[i]},";
            }
            expresion = expresion.Remove(expresion.Length - 1);
            Console.WriteLine(expresion);
            string command = $"UPDATE {table} Set {expresion}  WHERE {condition}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateImage(string table, string field, byte[] bytes, string condition)
        {
            string command = $"UPDATE {table} SET {field} = @image";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = bytes;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public Image LoadImage(string table, string field, string condition) 
        {
            string image_string = "";
            string command = $"Select {field} FROM {table} WHERE {condition}";
            SqlCommand cmd = new SqlCommand(command , connection);
            connection.Open();
            byte[] bytes = Encoding.ASCII.GetBytes(image_string);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) 
            {
                //image_string = reader[0].ToString();
                if(!reader.IsDBNull(0))
                bytes = (byte[])reader.GetValue(0);
            }
            //reader.Read();
            connection.Close();
            Image image = null;
            if(bytes != null) 
            { 
                MemoryStream stream = new MemoryStream(bytes);
                image = Image.FromStream(stream);
            }
            return image;
        }
        public int GetMaxId(string table, string column) 
        {
            string command = $"SELECT MAX({column}) FROM {table}";
            SqlCommand cms = new SqlCommand(command, connection);
            connection.Open();
            int max = (int) cms.ExecuteScalar();

            connection.Close();
            return max;
        }


    }
}
