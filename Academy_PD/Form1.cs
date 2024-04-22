using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Academy_PD
{
    public partial class FormMy : Form
    {
        string connectionString;
        SqlConnection connection;
        //SqlCommand command;
        SqlDataReader reader;
        DataTable table;

        public FormMy()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            if (AllocConsole())
            {
                Console.WriteLine(connectionString);
                //FreeConsole();
            }
            connection = new SqlConnection(connectionString);
            //command = new SqlCommand(connection);
            LoadStudents();
        }
        
        void LoadStudents()
        {
            connection.Open();
            string cmd = $@" 
Select
    [Ф.И.О] = FORMATMESSAGE ('%s %s %s', last_name, first_name, middle_name),
    [Дата рождения] = birth_date,
    [Группа] = group_name,
    [Направление обучения] = direction_name,
    [Телефон] = phone
    
FROM Students
JOIN Groups ON [group] = group_id
JOIN Directions ON direction= direction_id";
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i =0; i<reader.FieldCount; i++) 
            { 
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i =0; i < reader.FieldCount;i++) row[i] = reader[i];
                table.Rows.Add(row);    

            }
            dataGridViewStud.DataSource = table; 
            connection.Close();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole(); 
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
    }

}

