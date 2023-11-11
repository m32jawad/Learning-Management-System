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
    public partial class Teacher_ViewStudents : Form
    {
        List<StudentModel> lsm = new List<StudentModel>();
        public Teacher_ViewStudents()
        {
            InitializeComponent();
        }
        public Teacher_ViewStudents(List<StudentModel> ls, string courseTitle, string code, string cls)
        {
            InitializeComponent();
            lsm = ls;
            courseTitleLabel.Text = courseTitle;
            classLabel.Text = cls;
            coursecodeLabel.Text = code;

            populateDataGridView();
        }
        private void populateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (StudentModel sm in lsm)
            {
                dataGridView1.Rows.Add(sm.ID, sm.FirstName, sm.LastName, sm.Contact, sm.Email);
            }
        }
        private void Teacher_ViewStudents_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string text = null;
            populateDataGridView();
            if (searchTextBox.Text.Length == 0)
            {
                populateDataGridView();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                    text = "StudentID";
                else if (comboBox1.SelectedIndex == 1)
                    text = "FirstName";
                else if (comboBox1.SelectedIndex == 2)
                    text = "lastName";
                else if (comboBox1.SelectedIndex == 3)
                    text = "Contact";
                else if (comboBox1.SelectedIndex == 4)
                    text = "Email";

                int j = 0;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[j].Cells[text].Value.ToString() == searchTextBox.Text)
                        j++;
                    else
                        dataGridView1.Rows.RemoveAt(j);
                }
            }

        }
    }
}

