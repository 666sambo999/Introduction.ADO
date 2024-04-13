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


namespace Libery3
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            MessageBox.Show(this, connectionString, "ConnectionString", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBoxQiery.SelectAll();
            richTextBoxQiery.SelectionAlignment = HorizontalAlignment.Center;
            LoadTables();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string cmdLine = richTextBoxQiery.Text;
            SqlCommand cmd = new SqlCommand(cmdLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;

            connection.Close();
        }
        public void LoadTables()
        {
            string commandLine = @"SELECT table_name FROM information_schema.tables";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxTable.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
    
            //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            //{

            //}
    
    }
           
}

