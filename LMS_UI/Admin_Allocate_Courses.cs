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
    public partial class Admin_Allocate_Courses : Form
    {
        List<int> classes = new List<int>();
        public Admin_Allocate_Courses()
        {
            InitializeComponent();
            departmentTcComboBox.SelectedIndex = 0;
            DepartmentComboBox.SelectedIndex = 0;
            addCourses();
            addClass();
        }
        private void addClass()
        {
            SectionComboBox.Items.Clear();
            SemesterComboBox.Items.Clear();
            classes.Clear();
            SqlConnector.GetData sql = new SqlConnector.GetData();
            List<ClassModel> cm = sql.GetClasses(DepartmentComboBox.SelectedItem.ToString());
            foreach(ClassModel c in cm)
            {
                SectionComboBox.Items.Add(c.Section);
                SemesterComboBox.Items.Add(c.Semester);
                classes.Add(c.ID);
            }
        }
        private void addCourses()
        {
            CourseCodeComboBox.Items.Clear();
            CourseTitleComboBox.Items.Clear();
            SqlConnector.GetData sql = new SqlConnector.GetData();
            List<CourseModel> cm =  sql.GetCourses(departmentTcComboBox.SelectedItem.ToString());
            foreach(CourseModel c in cm)
            {
                CourseCodeComboBox.Items.Add(c.CourseCode);
                CourseTitleComboBox.Items.Add(c.Title);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int teacherID = int.Parse(TeacherIDComboBox.SelectedItem.ToString());
            int classID = classes[SemesterComboBox.SelectedIndex];
            string courseCode = CourseCodeComboBox.SelectedItem.ToString();
            SqlConnector.InsertData sql = new SqlConnector.InsertData();
            sql.AllocateCourse(teacherID, classID, courseCode);
        }

        private void Admin_Allocate_Courses_Load(object sender, EventArgs e)
        {

        }

        private void departmentTcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCourses();
            TeacherIDComboBox.Items.Clear();
            TeacherNameComboBox.Items.Clear();
            SqlConnector.GetData sql = new SqlConnector.GetData();
            List<TeacherModel> tm = sql.GetTeacher(departmentTcComboBox.SelectedItem.ToString());

            foreach(TeacherModel t in tm)
            {
                TeacherIDComboBox.Items.Add(t.ID);
                TeacherNameComboBox.Items.Add(t.FirstName + " " + t.LastName);
            }
        }

        private void TeacherIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherNameComboBox.SelectedIndex = TeacherIDComboBox.SelectedIndex;
        }

        private void TeacherNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherIDComboBox.SelectedIndex = TeacherNameComboBox.SelectedIndex;
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addClass();
        }

        private void CourseCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseTitleComboBox.SelectedIndex = CourseCodeComboBox.SelectedIndex;
        }

        private void CourseTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseCodeComboBox.SelectedIndex = CourseTitleComboBox.SelectedIndex;
        }
    }
}
