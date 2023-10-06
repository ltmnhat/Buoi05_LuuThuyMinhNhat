using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai6_SoThanhChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDaySo.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon thoat chuong trinh!!");
            this.Close();
        }
        private int check(int so)
        {
            if(so<100)
                return 2;
            else if(so<10)
                return 1;
            return 3;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtDaySo.Text);
            int ht, hc, hdv;
            string[] docso= { "Không","Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín"};
            string[] docsoch = { "Không","Mốt", "Hai", "Ba", "Bốn", "Lăm", "Sáu", "Bảy", "Tám", "Chín" };
            if (check(so) == 3)
            {
                ht = so / 100;
                hc = (so / 10) % 10;
                hdv = so % 10;
                for (int i = 0; i < docso.Length; i++)
                { 
                    if (hdv != 1 || hdv != 5)
                    {
                        txtKetQua.Text = docso[ht] + " Trăm " + docso[hc] + " Mươi " + docso[hdv - 1];
                    } else
                        txtKetQua.Text = docso[ht] + " Trăm " + docso[hc] + " Mươi " + docsoch[hdv - 1];
                }
            } 
            if (check(so) == 2)
            {
                hc = (so / 10) % 10;
                hdv = so % 10;
                for (int i = 0; i < docso.Length; i++)
                {
                    if (hc != 1)
                    {
                        txtKetQua.Text = docso[hc-1] + " Mươi " + docso[hdv - 1];
                    } else
                        txtKetQua.Text = "Mười " + docso[hdv - 1];
                }
            }
            //if (check(so) == 1)
            //{

            //    for (int i = 0; i < docso.Length; i++)
            //    {
            //        if(so==i)
            //        txtKetQua.Text = docso[i];
            //    }
            //}
        }

        private void txtDaySo_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && (Int32.Parse(ctr.Text) < 1 || Int32.Parse(ctr.Text) > 999))
                this.errorProvider1.SetError(ctr, "Chương tình chỉ hỗ trợ chuyển đổi số thành chữ trong khoảng 1 - 999");
            else
                this.errorProvider1.Clear();
        }
    }
}
