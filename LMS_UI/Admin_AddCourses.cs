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
    public partial class Admin_AddCourses : Form
    {
        public Admin_AddCourses()
        {
            InitializeComponent();
            departmentCombobox.SelectedIndex = 0;
            InitializeGridBox();
        }

        private void InitializeGridBox()
        {
            coursesGridView.Rows.Clear();

            SqlConnector.GetData sql = new SqlConnector.GetData();
            List<CourseModel> cm = sql.GetCourses(departmentCombobox.SelectedItem.ToString());
            foreach(CourseModel c in cm)
            {
                coursesGridView.Rows.Add(c.CourseCode, c.Title, c.Department);
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                CourseModel cur = new CourseModel();
                if (courseIdTextBox.Text.Length != 0 || courseTittleTextbox.Text.Length > 5 ||
                    departmentCombobox.SelectedIndex != -1)
                {

                    cur.Title = courseTittleTextbox.Text;
                    cur.CourseCode = courseIdTextBox.Text;
                    cur.Department = departmentCombobox.SelectedItem.ToString();

                    SqlConnector.InsertData sql = new SqlConnector.InsertData();
                    sql.AddCourse(cur);
                    InitializeGridBox();
                }
                else
                    throw new Exception("Invalid Input");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_AddCourses_Load(object sender, EventArgs e)
        {

        }

        private void coursesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                courseIdTextBox.Text = coursesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                courseTittleTextbox.Text = coursesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    departmentCombobox.SelectedItem = coursesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CCodeTextBox.Text = coursesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            try
            {
                CourseModel cur = new CourseModel();
                if (courseIdTextBox.Text.Length != 0 || courseTittleTextbox.Text.Length > 5 ||
                    departmentCombobox.SelectedIndex != -1)
                {
                    string code = CCodeTextBox.Text;
                    cur.Title = courseTittleTextbox.Text;
                    cur.CourseCode = courseIdTextBox.Text;
                    cur.Department = departmentCombobox.SelectedItem.ToString();

                    SqlConnector.Update sql = new SqlConnector.Update();
                    if (sql.UpdateCourse(cur, code))
                        MessageBox.Show("UPDATED");
                    else
                        MessageBox.Show("Failed to Update");

                    InitializeGridBox();
                }
                else
                    throw new Exception("Invalid Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                CourseModel cur = new CourseModel();
                if (courseIdTextBox.Text.Length != 0 || courseTittleTextbox.Text.Length > 5 ||
                    departmentCombobox.SelectedIndex != -1)
                {

                    string code = CCodeTextBox.Text;
                    SqlConnector.Update sql = new SqlConnector.Update();
                    if (sql.DeleteCourse(code))
                        MessageBox.Show("deleted");
                    else
                        MessageBox.Show("failed to update");

                    InitializeGridBox();
                }
                else
                    throw new Exception("Invalid Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeGridBox();
        }
    }
}
