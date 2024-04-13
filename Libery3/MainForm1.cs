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
            for(int i = 0; i < reader.FieldCount;i++ )table.Columns.Add(reader.GetName(i)); 
            while(reader.Read()) 
            { 
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;

            connection.Close(); 
        }
    }
}
