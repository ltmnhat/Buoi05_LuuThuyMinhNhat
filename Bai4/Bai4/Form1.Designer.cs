
namespace Bai4
{
    partial class Form1
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
            this.lbProgramname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUocChung = new System.Windows.Forms.TextBox();
            this.txtBoiChung = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.BtnTiepTuc = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProgramname
            // 
            this.lbProgramname.AutoSize = true;
            this.lbProgramname.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramname.Location = new System.Drawing.Point(82, 9);
            this.lbProgramname.Name = "lbProgramname";
            this.lbProgramname.Size = new System.Drawing.Size(375, 32);
            this.lbProgramname.TabIndex = 0;
            this.lbProgramname.Text = "Ước Số Chung -Bội Số Chung";
            this.lbProgramname.Click += new System.EventHandler(this.lbProgramname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(159, 78);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(219, 22);
            this.txtA.TabIndex = 3;
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(159, 124);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(219, 22);
            this.txtB.TabIndex = 4;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ước số chung lớn nhất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bội số chung nhỏ nhất:";
            // 
            // txtUocChung
            // 
            this.txtUocChung.Location = new System.Drawing.Point(230, 176);
            this.txtUocChung.Name = "txtUocChung";
            this.txtUocChung.Size = new System.Drawing.Size(110, 22);
            this.txtUocChung.TabIndex = 7;
            this.txtUocChung.TextChanged += new System.EventHandler(this.txtUocChung_TextChanged);
            // 
            // txtBoiChung
            // 
            this.txtBoiChung.Location = new System.Drawing.Point(233, 219);
            this.txtBoiChung.Name = "txtBoiChung";
            this.txtBoiChung.Size = new System.Drawing.Size(110, 22);
            this.txtBoiChung.TabIndex = 8;
            this.txtBoiChung.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(67, 295);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(98, 55);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // BtnTiepTuc
            // 
            this.BtnTiepTuc.Location = new System.Drawing.Point(242, 296);
            this.BtnTiepTuc.Name = "BtnTiepTuc";
            this.BtnTiepTuc.Size = new System.Drawing.Size(98, 55);
            this.BtnTiepTuc.TabIndex = 10;
            this.BtnTiepTuc.Text = "Tiếp Tục";
            this.BtnTiepTuc.UseVisualStyleBackColor = true;
            this.BtnTiepTuc.Click += new System.EventHandler(this.BtnTiepTuc_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(405, 296);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(90, 56);
            this.BtnThoat.TabIndex = 11;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 374);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBoiChung);
            this.Controls.Add(this.txtUocChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProgramname);
            this.Name = "Form1";
            this.Text = "Ước số - Bội số";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProgramname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUocChung;
        private System.Windows.Forms.TextBox txtBoiChung;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button BtnTiepTuc;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

