using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy_PD
{
    static class FormDataLoad
    {
        
        public static void LoadGroupsCB(string table, string colume, ComboBox box, string condition = null, string default_value = null)
        {
            box.Items.Clear();
            if (default_value != null)
            {
                box.Items.Add(default_value);
                box.SelectedIndex = 0;
            }
            Connector connector = new Connector();
            connector.LoadTableBase(colume, table, condition);
            string[] items = new string[connector.Datatable.Rows.Count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = connector.Datatable.Rows[i][0].ToString();
            }
            box.Items.AddRange(items);
        }
        public static void GroupsFilter(ComboBox main, ComboBox combo)
        {
            if (main.SelectedIndex > 0)
            {
                string condition = $"direction = direction_id AND direction_name = '{main.SelectedItem.ToString()}'";
                LoadGroupsCB("Groups, Directions", "group_name", combo, condition);
            }
            else
            {
                LoadGroupsCB("Groups", "group_name", combo);
            }

        }
    }
}
