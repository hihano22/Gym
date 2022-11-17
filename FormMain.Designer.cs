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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.gym_banner1;
            this.pictureBox1.Location = new System.Drawing.Point(90, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.AutoSize = true;
            this.button_DangXuat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_DangXuat.Location = new System.Drawing.Point(12, 304);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(84, 38);
            this.button_DangXuat.TabIndex = 10;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = false;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // FormMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 369);
            this.Controls.Add(this.button_DangXuat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = " Gym Managemanet";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_DangXuat;
    }
}