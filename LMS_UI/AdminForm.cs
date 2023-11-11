using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTeacherButton.Visible = true;
            addTeacherButton.Visible = false;
         //   ViewTeacherButton.Show();
            flowLayoutPanel2.Controls.Clear();
            Admin_AddTeacherForm frm = new Admin_AddTeacherForm();
                frm.TopLevel = false;
                frm.TopMost = true;

            frm.FormBorderStyle = (FormBorderStyle.None);
            //this.flowLayoutPanel2.Controls.Add(ViewTeacherButton);
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            //flowLayoutPanel2.Dock = DockStyle.Bottom;
            this.flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

        }

        private void allocateCourseButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_Allocate_Courses frm = new Admin_Allocate_Courses();
            frm.TopLevel = false;
            frm.TopMost = true;

            frm.FormBorderStyle = (FormBorderStyle.None);
            this.flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = false;

        }

        private void ViewTeacherButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_ViewTeachersForm frm = new Admin_ViewTeachersForm();
            frm.TopLevel = false;
            frm.TopMost = true;

            frm.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();
            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = true;
            viewAllocatedCoursesButton.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_AddCourses frm = new Admin_AddCourses();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;

            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = true;
        }

        private void viewAllocatedCoursesButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_ViewAllocatedCourses frm = new Admin_ViewAllocatedCourses();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;

            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_AddClass frm = new Admin_AddClass();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;

            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_AddStudentForm frm = new Admin_AddStudentForm();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;

            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = false;
            ViewStudentsButton.Visible = true;

        }

        private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Admin_ViewStudents frm = new Admin_ViewStudents();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;

            flowLayoutPanel2.Controls.Add(frm);
            frm.Show();

            ViewTeacherButton.Visible = false;
            addTeacherButton.Visible = false;
            viewAllocatedCoursesButton.Visible = false;

        }
    }
}
