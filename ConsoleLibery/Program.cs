using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleLibery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = @"Data Source=DESKTOP-NN9KQGU;
                                        Initial Catalog=LiberyPD_321;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=False;
                                        TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connection_string); // создали содинкения
            connection.Open();

            // вставка
            //string insert_string = @"INSERT INTO Authors (first_name, last_name)
            //                         VALUES ('Grady', 'Booch')";
            //SqlCommand cmd = new SqlCommand(insert_string, connection);
            //string delete_string = @"Delete From Authors Where author_id = ";
            //cmd.CommandText = delete_string;

            //cmd.ExecuteNonQuery();

            // выборка данных 
            string last_name = "'Cameron'";
            string select_condition = "";//$" WHERE author = (SELECT author_id FROM dbo.Authors WHERE last_name = {last_name})";
            string select_string = $@"
                        SELECT * FROM Books {select_condition};
                        Select SUM (price) From Books;";
            SqlCommand cmd = new SqlCommand(select_string, connection);
            //cmd.CommandText = select_string;
            //double totalprice = 0;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + "\t");
                    if (reader.GetName(i) == "title") Console.Write("".ToString().PadRight(24));
                }
                Console.WriteLine();
                
                while (reader.Read())
                {
                    //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetName(i) == "title") Console.Write(reader[i].ToString().PadRight(38));
                        else Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                    //totalprice += Convert.ToDouble(reader["price"]);
                }
            reader.NextResult();
            reader.Read();
            Console.WriteLine($"Общая стоимость всех книг: \t{reader[0]}");
         
            //Console.WriteLine($"Общая стоимость всех книг: \t${totalprice}");
            //Console.ReadLine();
            Console.WriteLine();
            reader.Close();
            
            last_name = "'Cameron'";
            select_condition = $"Where author = (SELECT author_id FROM Authors WHERE last_name = {last_name})";
            select_string = $@"
                        SELECT * FROM Books {select_condition};
                        Select SUM(price) From Books;";
            //SqlCommand cmd = new SqlCommand(select_string, connection);
            Console.WriteLine("James Cameron books:");
            cmd.CommandText = select_string; //" WHERE author = (SELECT author_id FROM dbo.Authors WHERE last_name = 'Cameron')";

            double total_price_Cameron = 0;
            reader = cmd.ExecuteReader();
            //cmd.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
                if (reader.GetName(i) == "title") Console.Write("".PadRight(24));
            }
            Console.WriteLine();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == "title") Console.Write(reader[i].ToString().PadRight(32));
                    else
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    if (reader.GetName(i) == "price") total_price_Cameron += Convert.ToDouble(reader[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Cameron total price: {total_price_Cameron}");
            connection.Close();
        }
    }
}
