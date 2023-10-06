using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        { 
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPasswordCf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtUsername.Text+"\n"+txtMail.Text+"\n"+txtPassword.Text+"\n"+txtPasswordCf.Text,"Thong tin dang ky");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Ban phai nhap username");
            else
                this.errorProvider1.Clear();
        }
        private bool IsValidEmail(string email)
        {
            //
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0 && !IsValidEmail(email))
                this.errorProvider1.SetError(ctr, "Ban phai nhap email hop le");
            else
                this.errorProvider1.Clear();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Ban phai nhap username");
            else
                this.errorProvider1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban muon thoat chuong trinh", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
