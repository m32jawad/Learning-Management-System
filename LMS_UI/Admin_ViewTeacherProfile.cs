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
    public partial class Admin_ViewTeacherProfile : Form
    {
        public Admin_ViewTeacherProfile()
        {
            InitializeComponent();
        }
        public Admin_ViewTeacherProfile(int teacherID)
        {
            InitializeComponent();

            SqlConnector.GetData obj = new SqlConnector.GetData();
            TeacherModel tm = obj.SearchTeacher(teacherID.ToString(),"ID")[0];

            IDTextBox.Text = tm.ID.ToString();
            firstNameTextBox.Text = tm.FirstName;
            lastNameTextBox.Text = tm.LastName;
            addressTextBox.Text = tm.Address;
            emailTextBox.Text = tm.Email;
            contactTextBox.Text = tm.Contact;
            departmentTextBox.Text = tm.Department;
            qualificationTextBox.Text = tm.Qualification;
            cnicTextBox.Text = tm.CNIC;
            usernameTextBox.Text = tm.username;
            passwordTextBox.Text = tm.password;
            loginIDTextBox.Text = tm.loginID.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            TeacherModel tm = new TeacherModel();
            try
            {
                tm.ID = int.Parse(IDTextBox.Text);
                if(new CheckFormats().checkName(firstNameTextBox.Text)) 
                    tm.FirstName = firstNameTextBox.Text;
                else { throw new Exception("Invalid First Name"); }

                if(new CheckFormats().checkName(lastNameTextBox.Text)) 
                    tm.LastName = lastNameTextBox.Text;
                else { throw new Exception("Invalid Last Name"); }

                if (new CheckFormats().checkContact(contactTextBox.Text))
                    tm.Contact = contactTextBox.Text;
                else { throw new Exception("Invalid Contact # "); }

                if (new CheckFormats().checkCNIC(cnicTextBox.Text))
                    tm.CNIC = cnicTextBox.Text;
                else { throw new Exception("Invalid CNIC Format"); }

                if (new CheckFormats().checkEmail(emailTextBox.Text))
                    tm.Email = emailTextBox.Text;
                else { throw new Exception("Invalid EMIAL"); }
                
                
                tm.Qualification = qualificationTextBox.Text;

                if (addressTextBox.Text.Length > 10)
                    tm.Address = addressTextBox.Text;
                else { throw new Exception("Invalid Address"); }


                if (usernameTextBox.Text.Length>5)tm.username = usernameTextBox.Text;
                else { throw new Exception("INVALID USERNAME"); }

                if(passwordTextBox.Text.Length>=6)
                    tm.password = passwordTextBox.Text;
                else { throw new Exception("PASSWORD SHOULD BE ATLEAST 6 CHARACTERS Long"); }

                tm.loginID = int.Parse(loginIDTextBox.Text);


                new SqlConnector.Update().UpdateTeacher(tm);
                MessageBox.Show("Information Updated Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_ViewTeacherProfile_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = MessageBox.Show("Are You Sure to Delete Teacher\r\n" +
                "Remember that all the information including class and material will be deleted",
                "Delete Teacher", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlConnector.Update obj = new SqlConnector.Update();
                try
                {

                    obj.DeleteTeacher(int.Parse(IDTextBox.Text), int.Parse(loginIDTextBox.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            TeacherModel tm = new TeacherModel();
            tm.ID = int.Parse(IDTextBox.Text);
            tm.FirstName = firstNameTextBox.Text;
            tm.LastName = lastNameTextBox.Text;
            tm.Department = departmentTextBox.Text;

            new Admin_ViewTeacherCourses(tm).Show();
        }
    }
}
