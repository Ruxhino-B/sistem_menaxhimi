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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFName.Text = SignUP.fName;
            lblLName.Text = SignUP.lName;
            lblEmailAdd.Text = SignUP.emailAddress;

            if(SignUP.sms)
            {
                lblSms.Text = "yes";
            }
            {
                lblReports.Text = "yes";
            }
            {
                lblTransRep.Text = "yes";
            }
        }
    }
}
