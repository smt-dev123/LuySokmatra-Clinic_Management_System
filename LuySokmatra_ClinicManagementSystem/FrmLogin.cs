using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuySokmatra_ClinicManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter Username!", "Enter Username");
                    txtUserName.Focus(); //ឱ្យសញ្ញា Cursor ចូលទៅកាន់ textbox username
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter Password!", "Enter Password");
                    txtPassword.Focus(); //ឱ្យសញ្ញា Cursor ចូលទៅកាន់ textbox Password
                }
                if (txtUserName.Text == "SMT" && txtPassword.Text == "123")
                {
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    MessageBox.Show("Login Success", "Login Success");
                    frmMainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username & Password!", "Invalid Username & Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
