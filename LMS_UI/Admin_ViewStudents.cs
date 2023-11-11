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
    public partial class Admin_ViewStudents : Form
    {
        
        public Admin_ViewStudents()
        {
            InitializeComponent();
        }

        private void departmentComnoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnector.GetData obj = new SqlConnector.GetData();
            classComboBox.Items.Clear();
            classIDComboBox.Items.Clear();
            List<ClassModel> lcm = obj.GetClasses(departmentComnoBox.SelectedItem.ToString());
            foreach(ClassModel c in lcm)
            {
                classComboBox.Items.Add(c.Semester +" "+ c.Section);
                classIDComboBox.Items.Add(c.ID);
            }
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classIDComboBox.SelectedIndex = classComboBox.SelectedIndex;

            fillDataGrid();
        }

        private void classIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classComboBox.SelectedIndex = classIDComboBox.SelectedIndex;
           // fillDataGrid();
        }

        private void fillDataGrid()
        {
            studentViewGridBox.Rows.Clear();
            SqlConnector.GetData obj = new SqlConnector.GetData();
           List<StudentModel> lsm = obj.GetStudentByClass(int.Parse(classIDComboBox.SelectedItem.ToString()));

            foreach(StudentModel s in lsm)
            {
                studentViewGridBox.Rows.Add(s.ID, s.FirstName, s.LastName, s.ClassID,
                    s.Semester + " " + s.Section + " " + s.Department, "View Details");
            }
        }
    }
}
