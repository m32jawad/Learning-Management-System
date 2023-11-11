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
    public partial class Teacher_Classes : Form
    {
        List<MaterialModel> lmm = new List<MaterialModel>();
        public Teacher_Classes()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public Teacher_Classes(int id)
        {
            InitializeComponent();
            SqlConnector.GetData obj = new SqlConnector.GetData();
            List<TeacherCourseModel> tcm = obj.GetTeacherCourses(id);
            //vScrollBar1.Controls.Clear();
            populateDataGridView(tcm);

        }
        private void populateDataGridView(List<TeacherCourseModel> tcm)
        {
            List<Panel> lp = new List<Panel>();
            foreach (TeacherCourseModel t in tcm)
            {
                TeacherCoursesDataGridView.Rows.Add(t.Course.CourseCode, t.Course.Title,
                    t.Class.Semester + " " + t.Class.Section + " " + t.Class.Department, t.CCID);

                GroupBox p = new GroupBox();
                //p = groupBox1;
                List<Control> lc = new List<Control>();
                foreach (Control c in groupBox1.Controls)
                {

                    Control control = c;
                    //p.Controls.Add(control);
                    lc.Add(control);
                }
                p.BackColor = Color.Blue;
                //      p.Controls[2].Text = t.Course.Title;
                //    p.Controls[1].Text = t.Class.Semester + " " + t.Class.Section + " " + t.Class.Department;
                //   p.Controls[0].Text = t.CCID.ToString();
                this.flowLayoutPanel1.Controls.Add(p);



            }
            //foreach(Panel p in lp)
            //{
            //   // flowLayoutPanel1.Controls.Add(p);
            //}
            /*    Classes frm= new Classes();
                frm.setVals(t.Course.Title, t.Class.Semester + " " + t.Class.Section + " " + t.Class.Department, t.CCID);
                //   listView1.Items.Add(c);
                //  c.Show();
                //vScrollBar1.Controls.Add(c.panel1);
                //c.Show();
                //panel3.Controls.Add(c);

                frm.TopLevel = false;
                frm.TopMost = true;

                frm.FormBorderStyle = (FormBorderStyle.None);
                //this.flowLayoutPanel2.Controls.Add(ViewTeacherButton);
                tableLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
                //flowLayoutPanel2.Dock = DockStyle.Bottom;
                this.tableLayoutPanel1.Controls.Add(frm);
                frm.Show();
            */


        }
        private void populateMaterialDataGrid(List<MaterialModel> lmm)
        {
            materialDataGridView.Rows.Clear();
            foreach (MaterialModel m in lmm)
            {
                materialDataGridView.Rows.Add(m.Material_ID, m.Name, m.Description);
            }
        }

        private void TeacherCoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ccid = int.Parse(TeacherCoursesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            SqlConnector.GetData obj = new SqlConnector.GetData();
            lmm = obj.GetMaterial(ccid);
            populateMaterialDataGrid(lmm);
        }

        private void Teacher_Classes_Load(object sender, EventArgs e)
        {

        }
    }
}
