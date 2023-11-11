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
    public partial class Admin_ViewTeachersForm : Form
    {
        public Admin_ViewTeachersForm()
        {
            InitializeComponent();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnector.GetData sql = new SqlConnector.GetData();
            List<TeacherModel> tm =
            sql.GetTeacher(departmentComboBox.SelectedItem.ToString());
            TeacherDataGridView.Rows.Clear();
            foreach (TeacherModel t in tm)
            {
                TeacherDataGridView.Rows.Add(t.ID, t.FirstName, t.LastName,
                    t.Department, t.Contact, t.CNIC,"View Details");
            }
        }

        private void TeacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(TeacherDataGridView.CurrentCell.ColumnIndex.Equals(6)&&
                TeacherDataGridView.CurrentCell.RowIndex != -1)
            {
                DataGridViewRow row = TeacherDataGridView.Rows[e.RowIndex];
                
                int teacherID = int.Parse(TeacherDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                new Admin_ViewTeacherProfile(teacherID).Show();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchByComboBox.SelectedIndex<0)
            {

            }
            else
            {
                if (searchTextBox.Text.Length != 0)
                {
                    List<TeacherModel> ltm = new SqlConnector.GetData().SearchTeacher(
                        searchTextBox.Text, searchByComboBox.SelectedItem.ToString());
                    if (ltm.Count == 0)
                        MessageBox.Show("NO Data Found");
                    else
                    {
                        TeacherDataGridView.Rows.Clear();
                        foreach (TeacherModel t in ltm)
                        {
                            TeacherDataGridView.Rows.Add(t.ID, t.FirstName, t.LastName,
                                t.Department, t.Contact, t.CNIC, "VIEW");
                        }
                    }
                }
            }
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
