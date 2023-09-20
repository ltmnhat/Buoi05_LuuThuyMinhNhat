
namespace Bai2
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
            this.LB_A = new System.Windows.Forms.Label();
            this.LB_B = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_A
            // 
            this.LB_A.AutoSize = true;
            this.LB_A.Location = new System.Drawing.Point(34, 30);
            this.LB_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_A.Name = "LB_A";
            this.LB_A.Size = new System.Drawing.Size(34, 23);
            this.LB_A.TabIndex = 0;
            this.LB_A.Text = "a=";
            // 
            // LB_B
            // 
            this.LB_B.AutoSize = true;
            this.LB_B.Location = new System.Drawing.Point(347, 30);
            this.LB_B.Name = "LB_B";
            this.LB_B.Size = new System.Drawing.Size(35, 23);
            this.LB_B.TabIndex = 1;
            this.LB_B.Text = "b=";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 33);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(204, 29);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(388, 30);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(204, 29);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(121, 133);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(471, 29);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(58, 205);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 39);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(231, 205);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 38);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(388, 205);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 38);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(517, 206);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 38);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 282);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.LB_B);
            this.Controls.Add(this.LB_A);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cộng trừ nhân chia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_A;
        private System.Windows.Forms.Label LB_B;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

