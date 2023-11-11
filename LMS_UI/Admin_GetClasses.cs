using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library;

namespace LMS_UI
{
    public partial class Admin_GetClasses : Form
    {
        public Admin_GetClasses()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep = comboBox2.SelectedItem.ToString();
            SqlConnector.GetData sql = new SqlConnector.GetData();

            List<ClassModel> lcm = new List<ClassModel>();
            lcm = sql.GetClasses("Computer Science");
            for(int i= 0; i < lcm.Count; i++)
            {
                dataGridView1.Rows.Add(lcm[i].Semester, lcm[i].Section);
            }
        }
    }
}
