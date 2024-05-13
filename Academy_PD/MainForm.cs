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
        ////SqlCommand command;
        //SqlDataReader reader;
        //DataTable table;

        public FormMy()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            if (AllocConsole())
            {
                Console.WriteLine(connectionString);
                //FreeConsole();
            }
            //connection = new SqlConnection(connectionString);
            //command = new SqlCommand(connection);
            LoadStudents();
            FormDataLoad.LoadGroupsCB("Groups", "group_name", cbGroups, null, "Все");
            FormDataLoad.LoadGroupsCB("Directions", "direction_name", cbStud, null, "Все");
            
            CountStudent();
            CountGroups();
            
        }
        
        void LoadStudents(string condition = null)
        {
            //            connection.Open();
            //            string cmd = $@" 
            //Select
            //    [Ф.И.О] = FORMATMESSAGE ('%s %s %s', last_name, first_name, middle_name),
            //    [Дата рождения] = birth_date,
            //    [Группа] = group_name,
            //    [Направление обучения] = direction_name,
            //    [Телефон] = phone

            //FROM Students
            //JOIN Groups ON [group] = group_id
            //JOIN Directions ON direction= direction_id";
            //            if (condition != null && !condition.Contains("Все"))
            //            {
            //                cmd += $" WHERE {condition}";
            //            }

            //            SqlCommand command = new SqlCommand(cmd, connection);
            //            reader = command.ExecuteReader();
            //            table = new DataTable();
            //            for (int i = 0; i<reader.FieldCount; i++) 
            //            { 
            //                table.Columns.Add(reader.GetName(i));
            //            }
            //            while (reader.Read())
            //            {
            //                DataRow row = table.NewRow();
            //                for (int i = 0; i < reader.FieldCount;i++) row[i] = reader[i];
            //                table.Rows.Add(row);    

            //            }
            //            dataGridViewStud.DataSource = table; 
            //            connection.Close();
            string columns = $@"
                [ID] = stud_id,
                [Ф.И.О] = FORMATMESSAGE ('%s %s %s', last_name, first_name, middle_name),
                [Дата рождения] = birth_date,
                [Группа] = group_name,
                [Направление обучения] = direction_name,
                [Телефон] = phone                
";
            string tables = "students, groups, directions";
            string relation = "Students.[group]=group_id AND direction=direction_id";
            if (condition != null && !condition.Contains("Все")) condition = $"{relation} AND {condition}";
            else condition = relation;
            Connector connector = new Connector();
            dataGridViewStud.DataSource = connector.LoadTableBase(columns, tables, condition);
            dataGridViewStud.Columns[0].Visible = false;// скрываем первую колонку
        }

        //void LoadGroupsCB(string table, string colume, ComboBox box,string condition=null)
        //{
        //    box.Items.Clear();
        //    box.Items.Add("Все");
        //    box.SelectedIndex = 0;
        //    //string cmd = $"Select {colume} From {table}";
        //    //if (condition != null) 
        //    //{
        //    //    cmd += $" WHERE {condition}";
        //    //}
        //    //Console.WriteLine(cmd);
        //    //connection.Open();
        //    //SqlCommand command = new SqlCommand(cmd, connection);
        //    //reader = command.ExecuteReader();
        //    //while (reader.Read())
        //    //{
        //    //    box.Items.Add(reader[0]);// reader - указывает на строку(строк состоит из полей)
        //    //}
        //    //connection.Close();
        //    Connector connector = new Connector();
        //    connector.LoadTableBase(colume, table, condition);
        //    string[] items = new string[connector.Datatable.Rows.Count];
        //    for(int i  = 0; i < items.Length;i++)
        //    {
        //        items[i] = connector.Datatable.Rows[i][0].ToString();    
        //    }
        //    box.Items.AddRange(items);
        //}

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole(); 
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

                      
        private void cbStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbGroups.Items.Clear();
            //if (cbStud.SelectedIndex>0)
            //{
            //    string condition = $"direction = direction_id AND direction_name = '{cbStud.SelectedItem.ToString()}'";
            //    LoadGroupsCB("Groups, Directions", "group_name", cbGroups, condition);
            //}
            //else
            //{
            //    LoadGroupsCB("Groups", "group_name", cbGroups);
            //}
            FormDataLoad.GroupsFilter(cbStud, cbGroups);
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
            label1.Text = $"Количество студентов: {(dataGridViewStud.RowCount).ToString()}"; 
        }

        void CountGroups()
        {
            label2.Text = $"Количество групп: {(cbGroups.Items.Count).ToString()}"; 
        }
                
        private void labelDirectionStud_Click(object sender, EventArgs e)
        {

        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            FormStud formStud = new FormStud();
            DialogResult result = formStud.ShowDialog();
            if (result == DialogResult.OK) LoadStudents();
            CountStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DataTable table = new DataTable("Students");
                SqlCommand cmd = new SqlCommand("Select * From Students WHERE last_name = @stud_id or last_name LIKE  @last_name", connection);
                cmd.Parameters.AddWithValue("stud_id", richTextBox.Text);
                cmd.Parameters.AddWithValue("last_name", string.Format("%0%", richTextBox));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dataGridViewStud.DataSource = table;
                                
                connection.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
           btnSearch.PerformClick();
        }

        private void dataGridViewStud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //form.InitForm(dataGridViewStud.SelectedRows[0])
            int id = Convert.ToInt32(dataGridViewStud.SelectedCells[0].Value);
            Console.WriteLine($"Id:{id}");
            Connector connector = new Connector();
            connector.LoadTableBase("*", "Students", $"stud_id ={id}");
            FormStud form = new FormStud();
            form.InitForm(connector.Datatable);
            form.ShowDialog();

        }

        //public void  UpdateTable()
        //{
        //    connection.Open();
        //    DataTable table = new DataTable("Students");
        //    SqlCommand cmd = new SqlCommand($"Select * From Students");
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    adapter.Fill(table);
        //    dataGridViewStud.DataSource = table;
        //    connection.Close();
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    UpdateTable();
        //    timer1.Start();
        //}

        //private void FormMy_Load(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}
    }

}

