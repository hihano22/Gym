namespace Gym
{
    partial class QuenMatKhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.button_LayMK = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.linkLabel_TroLaiDN = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.gym_banner1;
            this.pictureBox1.Location = new System.Drawing.Point(137, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email đăng ký:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(311, 194);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(277, 20);
            this.textBox_Email.TabIndex = 2;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(174, 252);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(70, 18);
            this.label_KetQua.TabIndex = 3;
            this.label_KetQua.Text = "Kết quả:";
            this.label_KetQua.Click += new System.EventHandler(this.label_KetQua_Click);
            // 
            // button_LayMK
            // 
            this.button_LayMK.AutoSize = true;
            this.button_LayMK.BackColor = System.Drawing.Color.BurlyWood;
            this.button_LayMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LayMK.Location = new System.Drawing.Point(311, 337);
            this.button_LayMK.Name = "button_LayMK";
            this.button_LayMK.Size = new System.Drawing.Size(153, 36);
            this.button_LayMK.TabIndex = 4;
            this.button_LayMK.Text = "Lấy mật khẩu";
            this.button_LayMK.UseVisualStyleBackColor = false;
            this.button_LayMK.Click += new System.EventHandler(this.button_LayMK_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.AutoSize = true;
            this.button_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_Exit.Location = new System.Drawing.Point(177, 337);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(98, 36);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel_TroLaiDN
            // 
            this.linkLabel_TroLaiDN.AutoSize = true;
            this.linkLabel_TroLaiDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_TroLaiDN.LinkColor = System.Drawing.Color.ForestGreen;
            this.linkLabel_TroLaiDN.Location = new System.Drawing.Point(470, 348);
            this.linkLabel_TroLaiDN.Name = "linkLabel_TroLaiDN";
            this.linkLabel_TroLaiDN.Size = new System.Drawing.Size(194, 16);
            this.linkLabel_TroLaiDN.TabIndex = 11;
            this.linkLabel_TroLaiDN.TabStop = true;
            this.linkLabel_TroLaiDN.Text = "Trở lại màn hình đăng nhập";
            this.linkLabel_TroLaiDN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TroLaiDN_LinkClicked);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_TroLaiDN);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_LayMK);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMatKhau";
            this.Text = "Lấy lại mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.Button button_LayMK;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.LinkLabel linkLabel_TroLaiDN;
    }
}