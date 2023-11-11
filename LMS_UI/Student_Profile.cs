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
    public partial class Student_Profile : Form
    {
        public Student_Profile()
        {
            InitializeComponent();
        }
        public Student_Profile(LoginModel lm)
        {
            InitializeComponent();
            StudentModel sm = new SqlConnector.GetData().Student_GetByLoginID(lm.loginID);
            sm.username = lm.username;
            sm.password = lm.password;
            sm.LoginID = lm.loginID;

            populateData(sm);
        }
        private void populateData(StudentModel sm)
        {
            try
            {

                idTextBox.Text = Convert.ToString(sm.LoginID);
                nameTextBOx.Text = sm.FirstName + sm.LastName;
              /*  cnicTextBox.Text = 
                emailTextBox.Text = =sm.Email;
                contactTextBox.Text = sm.Contact;
                addressTextBox.Text = sm.Address;
                QualificationTextBox.Text = sm.Qualification;*/

                usernameTextBox.Text = sm.username;
                passwordTextBox.Text = sm.password;
                loginIDTB.Text = sm.LoginID + "";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
