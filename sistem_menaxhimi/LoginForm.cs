using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem_menaxhimi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            Login();

        }
        private void Login()
        {

            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            if (id == "ruxhino" && pass == "123456")
            {
                this.Close();

                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("ID or Password eshte keq");
            }
        }
        private void ResetMyForm()
        {

            txtUserID.Text = "";
            txtPassword.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetMyForm();
            }
        }
    }
}
