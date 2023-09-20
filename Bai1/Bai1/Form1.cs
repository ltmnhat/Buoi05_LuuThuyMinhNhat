using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            age = DateTime.Now.Year - Convert.ToInt32(txt_YearOfBirth.Text);
            s = "My name is: " + txtYourName.Text + "\n"+ "Age: " +age.ToString();
            MessageBox.Show(s);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txt_YearOfBirth.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name");
            else
                this.errorProvider1.Clear();
        }

        private void txt_YearOfBirth_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }
    }
}
