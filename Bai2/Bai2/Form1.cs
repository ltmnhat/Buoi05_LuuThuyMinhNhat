using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Day khong phai la so!!");
            else
                this.errorProvider1.Clear();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Day khong phai la so!!");
            else
                this.errorProvider1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban muon dong chuong trinh", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double Tong = 0;
            Tong = Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text);
            txtKetQua.Text = Tong.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double Hieu = 0;
            Hieu = Convert.ToDouble(txtA.Text) - Convert.ToDouble(txtB.Text);
            txtKetQua.Text = Hieu.ToString();

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double Tich = 0;
            Tich = Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text);
            txtKetQua.Text = Tich.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double Thuong = 0.0;
            Thuong = Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text);
            txtKetQua.Text = Thuong.ToString();
        }
    }
}
