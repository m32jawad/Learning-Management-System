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
    public partial class Admin_ViewTeacherCourses : Form
    {
        public Admin_ViewTeacherCourses()
        {
            InitializeComponent();
        }
        public Admin_ViewTeacherCourses(TeacherModel tm)
        {
            InitializeComponent();

            teacherNameLabel.Text = tm.FirstName + " " + tm.LastName;
            idLabel.Text = tm.ID.ToString();
            depLabel.Text = tm.Department;

            List<TeacherCourseModel> ltm = new SqlConnector.GetData().GetTeacherCourses(tm.ID);
            foreach(TeacherCourseModel t in ltm)
            {
                teacherCoursesGridView.Rows.Add(t.Course.CourseCode, t.Course.Title,
                    t.Class.Semester, t.Class.Section, t.Class.Department, "Dealocate");
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacherCoursesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != 0 &&  teacherCoursesGridView.CurrentCell.ColumnIndex==5)
            {
                DialogResult d = MessageBox.Show("Are You Sure to De alocate course\r\n remember data related" +
                    "to the course and class will not accessed ", "Confirmation", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    //DataGridViewRow row = teacherCoursesGridView.Rows[e.RowIndex];
                    TeacherCourseModel tm = new TeacherCourseModel();
                    tm.Course.CourseCode = teacherCoursesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tm.Class.Semester = int.Parse(teacherCoursesGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    tm.Class.Section = teacherCoursesGridView.Rows[e.RowIndex].Cells[3].Value.ToString()[0];
                    tm.Class.Department = teacherCoursesGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    if (new SqlConnector.Update().DeleteTeacherCourse(tm))
                    {
                        MessageBox.Show("Deleted Successfully");
                    }
                    else
                        MessageBox.Show("Not Deleted \r\nTry Again");
                }
            }
        }
    }
}
