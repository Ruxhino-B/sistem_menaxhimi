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
    public partial class SignUP : Form
    {
        public static string fName;
        public static string lName;
        public static string emailAddress;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();

        public SignUP()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();

            fName = textFirstName.Text;
            lName = textLastName.Text;
            emailAddress = textEmail.Text;

            c.Show();
        }

        private void chkSms_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSms.Checked)
            {
                sms = true;
                lblSMSMessage.Text = "Services Changes may apply.";
            }
            else
            {
                sms = false;
                lblSMSMessage.Text = ".....";             
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }
        }

        private void chkTransReport_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTransReport.Checked)
            {
                transactions = true;
                lblTransReportMessage.Text = "Service charges may Aplay for Transactions";
            }
            else
            {
                transactions = false;
                lblTransReportMessage.Text = ".....";
            }
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
    }
}
