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

namespace Police_base
{
    public partial class Police : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet set;
        //SqlCommand cmd;

        public Police()
        {
            InitializeComponent();
            btnAlter.Enabled = false;
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            set = new DataSet();
            LoadVialation();
        }

        void LoadVialation()
        {
            string query = @"Select * From Violations";
            adapter = new SqlDataAdapter(query, connection);
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "Violations");
            dataGridViolation.DataSource = set.Tables[0];
            query = @"Select * From Responsibility_types";
            builder.DataAdapter.SelectCommand.CommandText = query;
            adapter.Fill(set, "Responsibility_types");
            cbViolation.Items.Add("Все типы");
            for (int i =0; i < set.Tables[1].Rows.Count; i++) 
            {
                cbViolation.Items.Add(set.Tables[1].Rows[i].ItemArray[1].ToString());
            }
            cbViolation.SelectedIndex = 0;
            builder.DataAdapter.SelectCommand.CommandText = "Select * From ViolationsRelation";
            adapter.Fill(set, "ViolationsRelation");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adapter.Update(set, "Violations");
        }

        private void cbViolation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbViolation.SelectedIndex == 0)
            {
                dataGridViolation.DataSource = set.Tables[0];
            }
            else
            {
                //string filter = $@"Select Violations, ViolationsRelation, Responsibility_types,
                //                    From  ViolationsRelation.violation = Violations.violation_id 
                //                   AND ViolationsRelation.responsibility = Responsibility_types.type_id
                //                    AND Responsibility_types.type_id = {cbViolation.SelectedIndex}";
                //DataRow[] result =  set.Tables[0].Select(filter);
                //dataGridViolation.DataSource = result;
                builder.DataAdapter.SelectCommand.CommandText = $@"Select violation_description, penality, duration 
                From Violations
                JOIN ViolationsRelation ON violation = violation_id
                WHERE responsibility = {cbViolation.SelectedIndex}";
                set.Tables["Violations"]?.Clear();
                adapter.Fill(set, "Violations");
                dataGridViolation.DataSource = set.Tables["Violations"];
            }
            //DataViewManager manager = new DataViewManager(set);
            //manager.DataViewSettings["Violations"].RowFilter = $"ViolationsRelation.responsibility = {cbViolation.SelectedIndex}";
            //DataView view = manager.CreateDataView(set.Tables["Violations"]);
            //dataGridViolation.DataSource = view;

        }
    }
}
