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
    public partial class tableView : Form
    {
        public tableView()
        {
            InitializeComponent();
        }

        private void tableView_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnector.GetData cd = new SqlConnector.GetData();
            List<TeacherCourseModel> lcm = new List<TeacherCourseModel>();
            ClassModel cm = new ClassModel();
            cm.Department = "Computer Science";
            cm.Semester = 1;
            cm.Section = 'A';
            lcm = cd.GetTeacherCourses(3);
            if (lcm.Count > 0)
            {

                foreach (TeacherCourseModel c in lcm)
                {
                    dataGridView1.Rows.Add(c.Class.Department, c.Class.Semester, 
                        c.Class.Section,c.Course.CourseCode,c.Course.Title,c.Course.Department);
                }
            }
            else
                MessageBox.Show("FAILED");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
