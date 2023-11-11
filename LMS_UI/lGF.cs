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
    public partial class lGF : Form
    {
        public lGF()
        {
            InitializeComponent();
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text, password = passwordTextBox.Text;
            new SqlConnector.InsertData().login(username,password,"admin");

        }
    }
}
