
namespace Bai1
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_yearofbirth = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txt_YearOfBirth = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(100, 84);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(104, 23);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Your Name";
            // 
            // label_yearofbirth
            // 
            this.label_yearofbirth.AutoSize = true;
            this.label_yearofbirth.Location = new System.Drawing.Point(100, 150);
            this.label_yearofbirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_yearofbirth.Name = "label_yearofbirth";
            this.label_yearofbirth.Size = new System.Drawing.Size(115, 23);
            this.label_yearofbirth.TabIndex = 1;
            this.label_yearofbirth.Text = "Year of birth";
            // 
            // txtYourName
            // 
            this.txtYourName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYourName.Location = new System.Drawing.Point(259, 84);
            this.txtYourName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(459, 30);
            this.txtYourName.TabIndex = 2;
            this.txtYourName.Leave += new System.EventHandler(this.txtYourName_Leave);
            // 
            // txt_YearOfBirth
            // 
            this.txt_YearOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_YearOfBirth.Location = new System.Drawing.Point(259, 150);
            this.txt_YearOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_YearOfBirth.Name = "txt_YearOfBirth";
            this.txt_YearOfBirth.Size = new System.Drawing.Size(459, 30);
            this.txt_YearOfBirth.TabIndex = 3;
            this.txt_YearOfBirth.TextChanged += new System.EventHandler(this.txt_YearOfBirth_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(104, 270);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(118, 54);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(334, 268);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(568, 268);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(841, 377);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txt_YearOfBirth);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.label_yearofbirth);
            this.Controls.Add(this.label_name);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_yearofbirth;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txt_YearOfBirth;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

