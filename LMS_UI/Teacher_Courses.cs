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
using System.IO;

namespace LMS_UI
{
    public partial class Teacher_Courses : Form
    {
        int ccid = 0;
        string courseTitle, code, cls;
        private List<MaterialModel> lmm = new List<MaterialModel>();
        public Teacher_Courses()
        {
            InitializeComponent();
        }
        public Teacher_Courses(int id)
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



                Panel myPanel = new Panel();
                //myPanel.Location = new Point(25, 25);
                Control[] controls = new Control[classesPanel.Controls.Count];
                classesPanel.Controls.CopyTo(controls, 0);
                foreach (Control c in controls)
                    myPanel.Controls.Add(c);


                flowLayoutPanel1.Controls.Add(myPanel);
                // Panel p = new Panel();
                //p = groupBox1;
          //      Panel cp = classesPanel;
          //      List<Control> lc = new List<Control>();
          //      foreach(Control c in classesPanel.Controls)
          //      {
                    
          //        //  Control control = c;
          //          p.Controls.Add(c);
          //        //  lc.Add(control);
          //      }
          //      p.BackColor = Color.Blue;
          ////      p.Controls[2].Text = t.Course.Title;
          //  //    p.Controls[1].Text = t.Class.Semester + " " + t.Class.Section + " " + t.Class.Department;
          //   //   p.Controls[0].Text = t.CCID.ToString();
          //        this.flowLayoutPanel1.Controls.Add(p);
          //      classesPanel = cp;

                
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
            foreach(MaterialModel m in lmm)
            {
                materialDataGridView.Rows.Add(m.Material_ID, m.Name, m.Description);
            }
        }
        private void TeacherCoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            code = TeacherCoursesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            courseTitle = TeacherCoursesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cls = TeacherCoursesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ccid = int.Parse(TeacherCoursesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            
            SqlConnector.GetData obj = new SqlConnector.GetData();
            lmm = obj.GetMaterial(ccid);
            populateMaterialDataGrid(lmm);
        }

        private void Teacher_Courses_Load(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Select File to Upload";
            openFD.Filter = "PDF FILES|*.pdf";
            openFD.FileName = "";

            if(openFD.ShowDialog() == DialogResult.OK)
            {

                string path = openFD.FileName;
                string fileName = Path.GetFileName(path);
                byte[] bytes = File.ReadAllBytes(path);
                // string contentType = "";

                string type = Path.GetExtension(fileName);

                MaterialModel m = new MaterialModel();

                m.Name = fileName;
                m.type = Path.GetExtension(path);
                m.data = bytes;
                m.Description = "";
                m.class_ID = ccid;
                try
                {
                    if (new SqlConnector.InsertData().UploadMaterial(m))
                        MessageBox.Show("Uploaded");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save File";
                sfd.Filter = "PDF FILES|*.pdf";
                sfd.FileName = lmm[e.RowIndex].Name + ".pdf";
                
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream stream;
                    stream = sfd.OpenFile();
                    stream.Write(lmm[e.RowIndex].data, 0, lmm[e.RowIndex].data.Length);
                    stream.Close();
                }
            }
        }
        private void downloadFile(int materialID)
        {

        }

        private void CCIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            List<StudentModel> sm = new SqlConnector.GetData().GetStudents_ByCCID(ccid);
            new Teacher_ViewStudents(sm,courseTitle, code, cls).Show();
        }
    }
}
