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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World Again";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been Canceled";
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUP regjistrohu = new SignUP();
            regjistrohu.Show();
        }
    }
}
