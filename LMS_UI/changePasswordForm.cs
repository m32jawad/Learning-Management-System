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
    public partial class changePasswordForm : Form
    {
        LoginModel lm = new LoginModel();
        public changePasswordForm()
        {
            InitializeComponent();
        }
        public changePasswordForm(LoginModel l)
        {
            lm = l;
            loginIDTB.Text = l.loginID+"";
        }
        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Panel p = new Panel();
                

                if (currentTB.Text.Length > 5 && createNewTB.Text.Length > 5 &&
                    confirmNewTB.Text == createNewTB.Text)
                {

                    if (new SqlConnector.Update().UpdatePassword(lm, createNewTB.Text))
                    {
                        MessageBox.Show("Password Updated");
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
