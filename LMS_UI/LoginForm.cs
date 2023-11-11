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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            usertypeDropDown.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string usertype = usertypeDropDown.SelectedItem.ToString();
            if (usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {

                SqlConnector.InsertData s = new LMS_Library.SqlConnector.InsertData();
                int ID = s.login(username, password, usertype);
                LoginModel lm = new LoginModel();
                lm.loginID = ID;
                lm.username = username;
                lm.password = password;
                lm.type = usertype;
                if (ID != 0)
                {
                    if(usertype == "Admin")
                    {
                        this.Hide();
                        new AdminForm().Show();
                    }
                    else if(usertype == "Teacher")
                    {
                        this.Hide();
                        new Teacher_Profile(lm).Show();
                    }
                    else
                    {
                        this.Hide();
                        new Student_Profile(lm).Show();
                    }
                }
                else
                {
                     MessageBox.Show("Invalid Username or Password");
                }
            }
            
        }

            //ClassModel cm = new ClassModel();
            //cm.Section = 'A';
            //cm.Semester = 2;
            //cm.Department = "Computer Science";
            //new SqlConnector.InsertData().AddClass(cm);

            //StudentModel sm = new StudentModel();
            //sm.FirstName = "Muhammad";
            //sm.LastName = "Jawad";
            //sm.FatherName = "Idrees";
            //sm.Contact = "0310 5202695";
            //sm.Email = "m32jawad@gmail.com";
            //CourseModel sm = new CourseModel();
            //sm.Department = "Computer Science";
            //sm.CourseCode = "CS-322";
            //sm.Title = "OOP";
            //new SqlConnector.InsertData().AddCourse(sm);

            //new SqlConnector.InsertData().AllocateCourse(3, 2, "CS-322");
            //this.Hide();
            //new Admin_AddTeacherForm();
            //tableView tb = new tableView();
            //tb.Show();
            // tb.Show();


        private void usertypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
