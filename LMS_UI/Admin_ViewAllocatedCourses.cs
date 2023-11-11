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
    
    public partial class Admin_ViewAllocatedCourses : Form
    {
        SqlConnector.GetData obj;
        public Admin_ViewAllocatedCourses()
        {
            InitializeComponent();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CousesDataGridView.Rows.Clear();
            obj = new SqlConnector.GetData();
            List<TeacherCourseModel> ltcm = obj.GetAllAlocCourses(departmentComboBox.SelectedItem.ToString(), 
                "dep");
            foreach(TeacherCourseModel tm in ltcm)
            {
                CousesDataGridView.Rows.Add(tm.Course.CourseCode, tm.Course.Title,
                    tm.Class.ID, tm.Class.Semester + " "+tm.Class.Section + tm.Class.Department,
                    tm.teacher.ID, tm.teacher.FirstName + " " + tm.teacher.LastName);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchByComboBox.SelectedIndex == -1)
            {

            }
            else
            {
                if (searchTextBox.Text.Length > 0) {
                    string sb = "";
                    if (searchByComboBox.SelectedIndex == 0)
                        sb = "CourseID";
                    else if (searchByComboBox.SelectedIndex == 1)
                        sb = "ClassID";
                    else
                        sb = "TeacherID";

                    CousesDataGridView.Rows.Clear();
                    obj = new SqlConnector.GetData();

                    List<TeacherCourseModel> ltcm = obj.GetAllAlocCourses(searchTextBox.Text, sb);
                    foreach (TeacherCourseModel tm in ltcm)
                    {
                        CousesDataGridView.Rows.Add(tm.Course.CourseCode, tm.Course.Title,
                            tm.Class.ID, tm.Class.Semester + " " + tm.Class.Section + tm.Class.Department,
                            tm.teacher.ID, tm.teacher.FirstName + " " + tm.teacher.LastName);
                    }
                }
                
            }
        }
    }
}
