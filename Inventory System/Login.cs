using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmLogin : Form
    {
        string uName, pass;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmMain frmMain = new frmMain();

            if (uName == "admin" && pass == "123")
            {
                frmMain.btnUsers.Visible = true;
            }
            else
            {
                frmMain.btnUsers.Visible = false;
            }

            frmMain.ShowDialog();
            frmLogin.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            uName = txtUsername.Text.Trim();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pass = txtPassword.Text.Trim();
        }
    }
}
