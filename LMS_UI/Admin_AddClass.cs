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
    public partial class Admin_AddClass : Form
    {
        public Admin_AddClass()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex != -1 || addSemesterTextBox.Text.Length != 0 || addSectionTextBox.Text.Length != 0)
            {
                try
                {
                    char sec = addSectionTextBox.Text.ToUpper()[0];
                    ClassModel cls = new ClassModel();
                    cls.Department = departmentComboBox.SelectedItem.ToString();
                    if (sec >= 'A' && sec <= 'E')
                        cls.Section = sec;
                    else
                        throw new Exception("Invlaid Section Input");

                    if (int.Parse(addSemesterTextBox.Text) <= 8 || int.Parse(addSemesterTextBox.Text) >= 1)
                        cls.Semester = int.Parse(addSemesterTextBox.Text);
                    else
                        throw new Exception("Invalid Semester");
                    SqlConnector.InsertData cls1 = new SqlConnector.InsertData();

                    if (cls1.AddClass(cls))
                        MessageBox.Show("DATA INSERTED");
                    else
                        MessageBox.Show("FAILED TO INSERT");

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classesGridView.Rows.Clear();
            SqlConnector.GetData obj = new SqlConnector.GetData();
            List<ClassModel> cm = obj.GetClasses(departmentComboBox.SelectedItem.ToString());

            foreach(ClassModel c in cm)
            {
                classesGridView.Rows.Add(c.ID, c.Semester, c.Section, c.Department);
            }
        }
    }
}
