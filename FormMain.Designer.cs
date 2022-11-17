namespace Gym
{
    partial class FormMain
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
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_HoiVien = new System.Windows.Forms.TabPage();
            this.tabPage_SanPham = new System.Windows.Forms.TabPage();
            this.tabPage_ThietBi = new System.Windows.Forms.TabPage();
            this.tabPage_ThongTin = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.AutoSize = true;
            this.button_DangXuat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_DangXuat.Location = new System.Drawing.Point(4, 388);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(84, 38);
            this.button_DangXuat.TabIndex = 10;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = false;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.gym_banner_main;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_HoiVien);
            this.tabControl.Controls.Add(this.tabPage_SanPham);
            this.tabControl.Controls.Add(this.tabPage_ThietBi);
            this.tabControl.Controls.Add(this.tabPage_ThongTin);
            this.tabControl.Location = new System.Drawing.Point(0, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(896, 282);
            this.tabControl.TabIndex = 11;
            // 
            // tabPage_HoiVien
            // 
            this.tabPage_HoiVien.Location = new System.Drawing.Point(4, 22);
            this.tabPage_HoiVien.Name = "tabPage_HoiVien";
            this.tabPage_HoiVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HoiVien.Size = new System.Drawing.Size(888, 256);
            this.tabPage_HoiVien.TabIndex = 0;
            this.tabPage_HoiVien.Text = "Hội viên";
            this.tabPage_HoiVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_SanPham
            // 
            this.tabPage_SanPham.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SanPham.Name = "tabPage_SanPham";
            this.tabPage_SanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SanPham.Size = new System.Drawing.Size(888, 256);
            this.tabPage_SanPham.TabIndex = 1;
            this.tabPage_SanPham.Text = "Sản phẩm";
            this.tabPage_SanPham.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThietBi
            // 
            this.tabPage_ThietBi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThietBi.Name = "tabPage_ThietBi";
            this.tabPage_ThietBi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThietBi.Size = new System.Drawing.Size(888, 256);
            this.tabPage_ThietBi.TabIndex = 2;
            this.tabPage_ThietBi.Text = "Thiết bị";
            this.tabPage_ThietBi.UseVisualStyleBackColor = true;
            this.tabPage_ThietBi.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage_ThongTin
            // 
            this.tabPage_ThongTin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThongTin.Name = "tabPage_ThongTin";
            this.tabPage_ThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongTin.Size = new System.Drawing.Size(888, 256);
            this.tabPage_ThongTin.TabIndex = 3;
            this.tabPage_ThongTin.Text = "Thông tin";
            this.tabPage_ThongTin.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 428);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_DangXuat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = " Gym Managemanet";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_HoiVien;
        private System.Windows.Forms.TabPage tabPage_SanPham;
        private System.Windows.Forms.TabPage tabPage_ThietBi;
        private System.Windows.Forms.TabPage tabPage_ThongTin;
    }
}