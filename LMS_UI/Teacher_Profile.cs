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
    public partial class Teacher_Profile : Form
    {
        public Teacher_Profile()
        {
            InitializeComponent();
        }
        public Teacher_Profile(LoginModel lm)
        {
            InitializeComponent();
            TeacherModel tm = new SqlConnector.GetData().GetTeacher_GetByLoginID(lm.loginID);
            tm.username = lm.username;
            tm.password = lm.password;
            tm.loginID = lm.loginID;

            populateData(tm);
        }
        private void Teacher_Profile_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populateData(TeacherModel tm)
        {
            try
            {
                
                idTextBox.Text = Convert.ToString(tm.ID);
                nameTextBOx.Text = tm.FirstName;
                cnicTextBox.Text = tm.CNIC;
                emailTextBox.Text = tm.Email;
                contactTextBox.Text = tm.Contact;
                addressTextBox.Text = tm.Address;
                QualificationTextBox.Text = tm.Qualification;
                usernameTextBox.Text = tm.username;
                passwordTextBox.Text = tm.password;
                loginIDTB.Text = tm.loginID+"";

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_Courses(int.Parse(idTextBox.Text)).Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            LoginModel lm = new LoginModel();
            lm.loginID = int.Parse(loginIDTB.Text);
            lm.username = usernameTextBox.Text;
            lm.password = passwordTextBox.Text;
            changePasswordForm cpf = new changePasswordForm(lm);
            cpf.Show();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loginIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cnicTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QualificationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBOx_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
