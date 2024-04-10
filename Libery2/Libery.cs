using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libery2
{
    internal class Libery
    {
        string connectionString;
        SqlConnection connection;

        public SqlCommand cmd {  get; set; }

        public Libery(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection (connectionString);
        }
        ~Libery() { connection.Close(); }

        public void Insertuthors(string last_name, string first_name)
        {
            try 
            {
                connection.Open();
                string command = $@" 
                    IF NOT EXISTS ( SELECT author_id From Authors 
                                    Where last_name = '{last_name}'
                                    And first_name = '{first_name}') 
                        BEGIN 
                            INSERT INTO Authors 
                                (last_name, first_name)
                            VALUES ('{last_name}','{first_name}')
                        END";
                cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();  
            }
            finally 
            { 
                if (connection != null) { connection.Close(); }
            }
        }
        public void SelectAuthors()
        {
            try
            {
                connection.Open();
                string command = $@"Select * From Authors";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine($"{reader.GetName(0).PadRight(10)} {reader.GetName(1).PadRight(15)} {reader.GetName(2).PadRight(15)}");
                while (reader.Read()) 
                {
                    Console.WriteLine($"{reader[0].ToString().PadRight(10)} {reader[1].ToString().PadRight(15)} {reader[2].ToString().PadRight(20)}");
                }
            }
            finally { if(connection != null)connection.Close();}

        }
        //public void SelectBooks()
        //{
        //    try
        //    {
        //        connection.Open();
        //        string command = $@"Select title AS Title, [author]= FORMATMESSAGE ('%s %s', first_name, last_name)
        //                        From Books 
        //                       JOIN Authors ON author = author_id";
        //        cmd = new SqlCommand(command, connection);
        //        SqlDataReader reader2 = cmd.ExecuteReader();
        //        Console.WriteLine($@"{reader2.GetName(0).ToString().PadRight(32)}{reader2.GetName(1).ToString().PadRight(32)}");
        //        while (reader2.Read())
        //        {
        //            Console.WriteLine($@"{reader2[0].ToString().PadRight(32)}{reader2[1].ToString().PadRight(32)}");
        //        }
        //    }
        //    finally {if(connection != null)connection.Close(); }
     
        //}
        public void InsertBooks(string author, string title, string pages, string price)
        {
            try
            {
                connection.Open();
                string command = $@" 
                        IF NOT EXISTS (SELECT books_id From Books
                               Where author = '{author}'
                                    And title = '{title}'
                                    AND pages = '{pages}'
                                    AND price = '{price}')
                        BEGIN
                            INSERT INTO Books
                                (author, title, pages,price)
                            VALUES('{author}', '{title}', '{pages}', '{price}')
                        END";
                cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();    
            }
            finally 
            { 
                if(connection != null) connection.Close(); }
        }
        public void SelectBooks()
        {
            try
            {
                connection.Open();
                string command = $@"Select title AS Title, 
                                [author]= FORMATMESSAGE ('%s %s', first_name, last_name)
                                From Books, Authors
                                Where author = author_id
                                AND author_id = 3";
                cmd = new SqlCommand(command, connection);
                SqlDataReader reader2 = cmd.ExecuteReader();
                Console.WriteLine($@"{reader2.GetName(0).ToString().PadRight(32)}{reader2.GetName(1).ToString().PadRight(32)}");
                while (reader2.Read())
                {
                    Console.WriteLine($@"{reader2[0].ToString().PadRight(32)}{reader2[1].ToString().PadRight(32)}");
                }
            }
            finally { if (connection != null) connection.Close(); }

        }
    }
}
