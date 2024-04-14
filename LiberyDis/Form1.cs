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
using System.Management;
using System.Configuration;
using System.Data.Common;

namespace LiberyDis
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet set;
        SqlCommandBuilder builder;
        
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(connectionString);
            set = new DataSet();

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.Text = "Select * From Authors";
            LoadTablesFromBase();
        }
        
        void LoadTablesFromBase()
        {
            string query = @"SELECT table_name FROM information_schema.tables";
            adapter = new SqlDataAdapter(query,connection);
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "tables");
            DataRow[] tableNames = new DataRow[set.Tables["tables"].Rows.Count];
            set.Tables["tables"].Rows.CopyTo(tableNames, 0);
            for (int i = 0; i < tableNames.Length; i++)
            {
                string tableName = tableNames[i].ItemArray[0].ToString();
                query = $@"Select * From {tableName}";
                adapter.SelectCommand.CommandText = query; 
                adapter.Fill(set, tableName);
                cbTable.Items.Add(tableName);
            }
            
            
        }
       
        private void btnFill_Click(object sender, EventArgs e)
        {
                set = new DataSet();
                string query = richTextBox1.Text;
                adapter = new SqlDataAdapter(query,connection);
                builder = new SqlCommandBuilder(adapter);
                adapter.Fill(set, "myTable");
                dataGridView1.DataSource = set.Tables["myTable"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(set, "myTable");// заливаем данные в сервер 
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = set.Tables[cbTable.SelectedItem.ToString()];
        }
    }
}
