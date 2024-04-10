using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Libery2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем класс 
            string connection_string = @"
                                    Data Source=DESKTOP-NN9KQGU;
                                    Initial Catalog=LiberyPD_321;
                                    Integrated Security=True;
                                    Connect Timeout=30;
                                    Encrypt=False;
                                    TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";
            Libery libery = new Libery(connection_string);
            libery.InsertBooks("31", "Герой нашего времени", "256", "150");
            libery.Insertuthors("Michail", "Lermontov");
            libery.SelectAuthors();
            libery.SelectBooks();

        }




    }
}
