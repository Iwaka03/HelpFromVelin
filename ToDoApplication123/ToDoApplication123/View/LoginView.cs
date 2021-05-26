using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApplication.Controller;

namespace ToDoApplication.View
{
    public partial class LoginView : Form
    {
        LoginController loginContoller = new LoginController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }


        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
          

        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '\0')
            {
                btnUnhide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
