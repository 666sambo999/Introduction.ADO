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
            LoadGroupsCB("Groups", "group_name", cbGroups);
            LoadGroupsCB("Directions", "direction_name", cbStud);
            CountStudent();
            CountGroups();
        }
        
        void LoadStudents(string condition = null)
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
            if (condition != null && !condition.Contains("Все"))
            {
                cmd += $" WHERE {condition}";
            }
            
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i<reader.FieldCount; i++) 
            { 
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount;i++) row[i] = reader[i];
                table.Rows.Add(row);    

            }
            dataGridViewStud.DataSource = table; 
            connection.Close();
        }

        void LoadGroupsCB(string table, string colume, ComboBox box,string condition=null)
        {
            box.Items.Clear();
            box.Items.Add("Все");
            box.SelectedIndex = 0;
            string cmd = $"Select {colume} From {table}";
            if (condition != null) 
            {
                cmd += $" WHERE {condition}";
            }
            Console.WriteLine(cmd);
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader[0]);// reader - указывает на строку(строк состоит из полей)
            }
            
            connection.Close();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole(); 
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

                      
        private void cbStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbGroups.Items.Clear();
            if (cbStud.SelectedIndex>0)
            {
                string condition = $"direction = direction_id AND direction_name = '{cbStud.SelectedItem.ToString()}'";
                LoadGroupsCB("Groups, Directions", "group_name", cbGroups, condition);
            }
            else
            {
                LoadGroupsCB("Groups", "group_name", cbGroups);
            }

            LoadStudents($"direction_name = '{cbStud.SelectedItem.ToString()}'");
            CountStudent();
            CountGroups();
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents($"group_name = '{cbGroups.SelectedItem.ToString()}'");
            CountStudent();
            CountGroups();
        }
        void CountStudent ()
        {
            label1.Text = $"Количество студентов: {(dataGridViewStud.RowCount-1).ToString()}"; 
        }

        void CountGroups()
        {
            label2.Text = $"Количество групп: {(cbGroups.Items.Count-1).ToString()}"; 
        }
        
        
        private void labelDirectionStud_Click(object sender, EventArgs e)
        {

        }
    }

}

