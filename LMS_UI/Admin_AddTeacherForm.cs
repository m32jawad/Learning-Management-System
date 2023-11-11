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
    public partial class Admin_AddTeacherForm : Form
    {
        public Admin_AddTeacherForm()
        {
            InitializeComponent();
        }

        private void qualificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            // LMS_Library.TeacherModel tm = new LMS_Library.TeacherModel();

            // tm.FirstName = firstNameTextBox.Text;
            // tm.LastName = lastNameTextBox.Text;
            // //  tm.JoinDate = dateTimePicker1.Value;
            // tm.Qualification = qualificationTextBox.Text;
            //// tm.Salary = Decimal.Parse(salaryTextBox.Text);
            // tm.Address = addressTextBox.Text;
            // tm.Contact = contactTextBox.Text;
            // tm.Email = emailTextBox.Text;
            // tm.Department = departmentComboBox.SelectedItem.ToString();
            // tm.CNIC = cnicTextBox.Text;


            TeacherModel tm = new TeacherModel();
            try
            {
             
                if (new CheckFormats().checkName(firstNameTextBox.Text))
                    tm.FirstName = firstNameTextBox.Text;
                else { throw new Exception("Invalid First Name"); }

                if (new CheckFormats().checkName(lastNameTextBox.Text))
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

                if (departmentComboBox.SelectedIndex != -1)
                    tm.Department = departmentComboBox.SelectedItem.ToString();
                else { throw new Exception("Select Department"); }
                if (usernameTextBox.Text.Length > 5) 
                    tm.username = usernameTextBox.Text;
                else { throw new Exception("INVALID USERNAME"); }

                if (passwordTextBox.Text.Length >= 6)
                    tm.password = passwordTextBox.Text;
                else { throw new Exception("PASSWORD SHOULD BE ATLEAST 6 CHARACTERS Long"); }



                new SqlConnector.InsertData().AddTeacher(tm);
                MessageBox.Show("Data added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
