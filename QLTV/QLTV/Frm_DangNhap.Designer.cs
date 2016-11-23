namespace QLTV
{
    partial class Frm_DangNhap
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
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(233, 90);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(123, 20);
            this.txtU.TabIndex = 0;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(233, 125);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(123, 20);
            this.txtP.TabIndex = 1;
            this.txtP.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(130, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Wheat;
            this.btn_Thoat.Location = new System.Drawing.Point(233, 218);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 25);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Wheat;
            this.btn_DangNhap.Location = new System.Drawing.Point(57, 220);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label4
            // 
            this.label4.Image = global::QLTV.Properties.Resources.nhanvien;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 166);
            this.label4.TabIndex = 5;
            // 
            // Frm_DangNhap
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(368, 258);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Name = "Frm_DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label4;
    }
}