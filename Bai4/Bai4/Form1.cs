using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProgramname_Click(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {            
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int ucln = TimUocChungLonNhat(a, b);
            txtUocChung.Text = ucln.ToString();
            int bcnn = (a * b) / TimUocChungLonNhat(a, b);
            txtBoiChung.Text = bcnn.ToString();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban xac nhan dong form chu?");
            this.Close();
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length>0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Bạn phải nhập kí tự số");
            else
                this.errorProvider1.Clear();

        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Bạn phải nhập kí tự số");
            else
                this.errorProvider1.Clear();
        }

        private void txtUocChung_TextChanged(object sender, EventArgs e)
        {
           
        }
        private static int TimUocChungLonNhat(int a,int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtBoiChung.Clear();
            txtUocChung.Clear();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(txtA.Text,out a)&&int.TryParse(txtB.Text,out b))
            {
                if (b < a)
                {
                    txtB.ForeColor = Color.Red;
                    txtA.Focus();
                } else
                {
                    txtB.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}
