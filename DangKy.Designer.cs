namespace Gym
{
    partial class DangKy
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_XNMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.linkLabel_TroLaiDN = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.gym_banner1;
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên tài khoản:";
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(313, 215);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(298, 20);
            this.textBox_TenTaiKhoan.TabIndex = 4;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(313, 261);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(298, 20);
            this.textBox_MatKhau.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_XNMatKhau
            // 
            this.textBox_XNMatKhau.Location = new System.Drawing.Point(313, 307);
            this.textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            this.textBox_XNMatKhau.PasswordChar = '*';
            this.textBox_XNMatKhau.Size = new System.Drawing.Size(298, 20);
            this.textBox_XNMatKhau.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xác nhận MK:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(313, 351);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(298, 20);
            this.textBox_Email.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // button_DangKy
            // 
            this.button_DangKy.AutoSize = true;
            this.button_DangKy.BackColor = System.Drawing.Color.BurlyWood;
            this.button_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKy.Location = new System.Drawing.Point(313, 386);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(118, 37);
            this.button_DangKy.TabIndex = 11;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.AutoSize = true;
            this.button_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_Exit.Location = new System.Drawing.Point(182, 386);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(89, 37);
            this.button_Exit.TabIndex = 12;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // linkLabel_TroLaiDN
            // 
            this.linkLabel_TroLaiDN.AutoSize = true;
            this.linkLabel_TroLaiDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_TroLaiDN.LinkColor = System.Drawing.Color.ForestGreen;
            this.linkLabel_TroLaiDN.Location = new System.Drawing.Point(450, 407);
            this.linkLabel_TroLaiDN.Name = "linkLabel_TroLaiDN";
            this.linkLabel_TroLaiDN.Size = new System.Drawing.Size(194, 16);
            this.linkLabel_TroLaiDN.TabIndex = 13;
            this.linkLabel_TroLaiDN.TabStop = true;
            this.linkLabel_TroLaiDN.Text = "Trở lại màn hình đăng nhập";
            this.linkLabel_TroLaiDN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TroLaiDN_LinkClicked);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_TroLaiDN);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_XNMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangKy";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_XNMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.LinkLabel linkLabel_TroLaiDN;
    }
}