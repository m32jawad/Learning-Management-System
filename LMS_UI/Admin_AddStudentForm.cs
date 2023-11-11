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
    public partial class Admin_AddStudentForm : Form
    {
        public Admin_AddStudentForm()
        {
            InitializeComponent();
        }

        private void Admin_AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StudentModel std = new StudentModel();
            std.FirstName = FirstNameTextBox.Text;
            std.LastName = LastNameTextBox.Text;
            std.FatherName = FatherNameTextBox.Text;
            std.Contact = ContacTextBox.Text;
            std.Email = EmailTextBox.Text;
            std.Department = DepartmentComboBox.SelectedItem.ToString();
            std.Section = SectionComboBox.SelectedItem.ToString()[0];
            std.Semester = int.Parse(SemesterComboBox.SelectedItem.ToString());



        }
    }
}
