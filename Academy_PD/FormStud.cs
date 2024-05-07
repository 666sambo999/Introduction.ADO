using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academy_PD
{
    public partial class FormStud : Form
    {
        public FormStud()
        {
            InitializeComponent();
            Connector connector = new Connector();
            FormDataLoad.LoadGroupsCB("Directions", "direction_name", comboBoxDirection, null, "Все");
            FormDataLoad.LoadGroupsCB("Groups", "group_name", comboBoxGroups);
            //comboBoxGroups.Items.Remove("Все");
            //comboBoxGroups.SelectedIndex = -1;
        }

        private void lbMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFirstName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            connector.InsertDataToBase
                (
                "Students",
                "last_name, first_name,middle_name, email, phone, photo,group",
                $"" +
                $"{richTextBoxLast.Text}," +
                $"{richTextBoxFirst.Text}," +
                $"{richTextBoxMiddle.Text}," +
                $"{dateTimePicker1.Value}," +
                $"{richTextBoxEmail.Text}," +
                $"{richTextBoxContact}," +
                $"{pictureBoxStud.Image}," +
                $"{connector.GetIdByVales("Groups", "group_id, group_name", comboBoxGroups.SelectedItem.ToString())}"
                );
        }

        private void btnBrauw_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog(this);
            string filename = open.FileName;
            pictureBoxStud.Image = Image.FromFile(filename);
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDataLoad.GroupsFilter(comboBoxDirection, comboBoxGroups);
            
        }
    }
}
