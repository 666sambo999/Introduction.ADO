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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Web;

namespace Academy_PD
{
    public partial class FormStud : Form
    {
        int id;
        public FormStud()
        {
            InitializeComponent();
            Connector connector = new Connector();
            FormDataLoad.LoadGroupsCB("Directions", "direction_name", comboBoxDirection, null, "Все");
            FormDataLoad.LoadGroupsCB("Groups", "group_name", comboBoxGroups);
            //comboBoxGroups.Items.Remove("Все");
            //comboBoxGroups.SelectedIndex = -1;
            //InitForm();
            int id =0;
            labelID.Enabled = false;
        }
        void InitForm()
        {
            richTextBoxLast.Text = "Грубиян";
            richTextBoxFirst.Text = "Андрей";
            richTextBoxMiddle.Text = "Павлович";
            dateTimePicker1.Value = new DateTime(1986, 07, 18);
        }
        public void InitForm(DataTable table)
        {
            DataRow row = table.Rows[0];
            id = Convert.ToInt32(row["stud_id"].ToString()); 
            richTextBoxLast.Text = row["last_name"].ToString();
            richTextBoxFirst.Text = row["first_name"].ToString();
            richTextBoxMiddle.Text = row["middle_name"].ToString();
            dateTimePicker1.Value = DateTime.Parse(row["birth_date"].ToString());
            Connector connector = new Connector();
            connector.LoadTableBase("group_name, direction", "Groups", $"group_id={row["group"]}");
            comboBoxGroups.SelectedIndex = comboBoxGroups.FindStringExact(connector.Datatable.Rows[0]["group_name"].ToString());
            connector.LoadTableBase("direction_name", "Directions", $"direction_id={connector.Datatable.Rows[0]["direction"]}");
            comboBoxDirection.SelectedIndex = comboBoxDirection.FindStringExact(connector.Datatable.Rows[0]["direction_name"].ToString());
            richTextBoxEmail.Text = row["email"].ToString();
            richTextBoxContact.Text = row["phone"].ToString();
            //pictureBoxStud.Image = Bitmap.FromHbitmap(row["photo"]).GetHbitmap();
            //byte[] imageDate = Encoding.Unicode.GetBytes(row["photo"].ToString());
            //MemoryStream stream = new MemoryStream(imageDate);
            //pictureBoxStud.Image = Image.FromStream(stream);
            pictureBoxStud.Image = connector.LoadImage("Students", "photo", $"stud_id = {id}");
            labelID.Text = $"id студента в базе: {id}";
            labelID.Enabled = true;
            //LoadFiels();
        }
        //void LoadFiels()
        //{
        //    richTextBoxLast.Enabled =false;
        //    richTextBoxFirst.Enabled = false;
        //    richTextBoxMiddle.Enabled = false;
        //    dateTimePicker1.Enabled = false;
        //    richTextBoxEmail.Enabled = false;
        //    richTextBoxContact.Enabled = false;

        //    comboBoxGroups.Enabled = false;
        //    comboBoxDirection.Enabled = false;
        //}
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
            MemoryStream stream = new MemoryStream();
            pictureBoxStud.Image.Save(stream, pictureBoxStud.Image.RawFormat);
            if(id<0)
            {
                connector.InsertDataToBase
                    (
                    "Students",
                    "last_name,first_name,middle_name,birth_date,[group],email,phone,photo",
                    $"" +
                    $"'{richTextBoxLast.Text}'," +
                    $"'{richTextBoxFirst.Text}'," +
                    $"'{richTextBoxMiddle.Text}'," +
                    $"'{dateTimePicker1.Value.ToString("yyyy.MM.dd")}'," +
                    $"{connector.GetIdByVales("Groups", "group_id,group_name", comboBoxGroups.SelectedItem.ToString())}," +
                    $"'{richTextBoxEmail.Text}'," +
                    $"'{richTextBoxContact.Text}'," +
                    $"'{null}'"
                    );
                connector.UpdateImage("Students", "photo", stream.ToArray(), $"stud_id={connector.GetMaxId("Students", "stud_id")}");

            }
            else
            {
                string table = "Students";
                string columns = "last_name,first_name,middle_name,birth_date,[group],email,phone,photo";
                string values = $"" +
                $"'{richTextBoxLast.Text}'," +
                $"'{richTextBoxFirst.Text}'," +
                $"'{richTextBoxMiddle.Text}'," +
                $"'{dateTimePicker1.Value}'," +
                $"{connector.GetIdByVales("Groups", "group_id,group_name", comboBoxGroups.SelectedItem.ToString())}," +
                $"'{richTextBoxEmail.Text}'," +
                $"'{richTextBoxContact.Text}',"+
                $"'{pictureBoxStud.Image}'";
                 string condition = $"stud_id = {id}";
                     connector.UpdateBase
                 (
                 table,
                 columns,
                 values,
                 condition
                 );
                connector.UpdateImage("Students", "photo", stream.ToArray(), $"stud_id={id}");
            }
            
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


//https://stackoverflow.com/questions/3676014/vertically-aligning-controls-in-a-tablelayoutpanel
//https://stackoverflow.com/questions/16822138/fit-image-into-picturebox
//https://www.c-sharpcorner.com/UploadFile/e628d9/inserting-retrieving-images-from-sql-server-database-without-using-stored-procedures/