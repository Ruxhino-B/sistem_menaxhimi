namespace sistem_menaxhimi
{
    partial class SignUP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSms = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkTransReport = new System.Windows.Forms.CheckBox();
            this.lblSMSMessage = new System.Windows.Forms.Label();
            this.lblTransReportMessage = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(253, 86);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(350, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emër:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mbiemër:";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(253, 136);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(350, 20);
            this.textLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Address:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(253, 183);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(350, 20);
            this.textEmail.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransReportMessage);
            this.groupBox1.Controls.Add(this.lblSMSMessage);
            this.groupBox1.Controls.Add(this.chkTransReport);
            this.groupBox1.Controls.Add(this.chkReports);
            this.groupBox1.Controls.Add(this.chkSms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opsione";
            // 
            // chkSms
            // 
            this.chkSms.AutoSize = true;
            this.chkSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSms.Location = new System.Drawing.Point(167, 43);
            this.chkSms.Name = "chkSms";
            this.chkSms.Size = new System.Drawing.Size(130, 21);
            this.chkSms.TabIndex = 0;
            this.chkSms.Text = "SMS Nofification";
            this.chkSms.UseVisualStyleBackColor = true;
            this.chkSms.CheckedChanged += new System.EventHandler(this.chkSms_CheckedChanged);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReports.Location = new System.Drawing.Point(167, 75);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(77, 21);
            this.chkReports.TabIndex = 1;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            this.chkReports.CheckedChanged += new System.EventHandler(this.chkReports_CheckedChanged);
            // 
            // chkTransReport
            // 
            this.chkTransReport.AutoSize = true;
            this.chkTransReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransReport.Location = new System.Drawing.Point(167, 105);
            this.chkTransReport.Name = "chkTransReport";
            this.chkTransReport.Size = new System.Drawing.Size(163, 21);
            this.chkTransReport.TabIndex = 2;
            this.chkTransReport.Text = "Transactions Reports";
            this.chkTransReport.UseVisualStyleBackColor = true;
            this.chkTransReport.CheckedChanged += new System.EventHandler(this.chkTransReport_CheckedChanged);
            // 
            // lblSMSMessage
            // 
            this.lblSMSMessage.AutoSize = true;
            this.lblSMSMessage.Location = new System.Drawing.Point(398, 41);
            this.lblSMSMessage.Name = "lblSMSMessage";
            this.lblSMSMessage.Size = new System.Drawing.Size(29, 20);
            this.lblSMSMessage.TabIndex = 3;
            this.lblSMSMessage.Text = ".....";
            // 
            // lblTransReportMessage
            // 
            this.lblTransReportMessage.AutoSize = true;
            this.lblTransReportMessage.Location = new System.Drawing.Point(398, 106);
            this.lblTransReportMessage.Name = "lblTransReportMessage";
            this.lblTransReportMessage.Size = new System.Drawing.Size(29, 20);
            this.lblTransReportMessage.TabIndex = 4;
            this.lblTransReportMessage.Text = ".....";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(630, 363);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(131, 48);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Regjistrohu";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFirstName);
            this.Name = "SignUP";
            this.Text = "SignUP";
            this.Load += new System.EventHandler(this.SignUP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTransReportMessage;
        private System.Windows.Forms.Label lblSMSMessage;
        private System.Windows.Forms.CheckBox chkTransReport;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkSms;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}