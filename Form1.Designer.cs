namespace FinalProject_17521061
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
            this.pnl_NavigationBar = new System.Windows.Forms.Panel();
            this.pnl_VeChungToi = new System.Windows.Forms.Panel();
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.btn_PhanMem = new System.Windows.Forms.Button();
            this.btn_VeChungToi = new System.Windows.Forms.Button();
            this.pnl_DichVu = new System.Windows.Forms.Panel();
            this.btn_NoiTro = new System.Windows.Forms.Button();
            this.btn_NauAn = new System.Windows.Forms.Button();
            this.btn_TrongTre = new System.Windows.Forms.Button();
            this.btn_DiCho = new System.Windows.Forms.Button();
            this.btn_LauNha = new System.Windows.Forms.Button();
            this.btn_DichVu = new System.Windows.Forms.Button();
            this.timer_VeChungToi = new System.Windows.Forms.Timer(this.components);
            this.timer_DichVu = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_NavigationBar.SuspendLayout();
            this.pnl_VeChungToi.SuspendLayout();
            this.pnl_DichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_NavigationBar
            // 
            this.pnl_NavigationBar.Controls.Add(this.pnl_DichVu);
            this.pnl_NavigationBar.Controls.Add(this.pictureBox1);
            this.pnl_NavigationBar.Controls.Add(this.pnl_VeChungToi);
            this.pnl_NavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_NavigationBar.Name = "pnl_NavigationBar";
            this.pnl_NavigationBar.Size = new System.Drawing.Size(1143, 76);
            this.pnl_NavigationBar.TabIndex = 3;
            // 
            // pnl_VeChungToi
            // 
            this.pnl_VeChungToi.Controls.Add(this.btn_LienHe);
            this.pnl_VeChungToi.Controls.Add(this.btn_PhanMem);
            this.pnl_VeChungToi.Controls.Add(this.btn_VeChungToi);
            this.pnl_VeChungToi.Location = new System.Drawing.Point(144, 3);
            this.pnl_VeChungToi.MaximumSize = new System.Drawing.Size(150, 148);
            this.pnl_VeChungToi.MinimumSize = new System.Drawing.Size(150, 68);
            this.pnl_VeChungToi.Name = "pnl_VeChungToi";
            this.pnl_VeChungToi.Size = new System.Drawing.Size(150, 68);
            this.pnl_VeChungToi.TabIndex = 3;
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.BackColor = System.Drawing.Color.Orange;
            this.btn_LienHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LienHe.FlatAppearance.BorderSize = 0;
            this.btn_LienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LienHe.Location = new System.Drawing.Point(0, 108);
            this.btn_LienHe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(150, 40);
            this.btn_LienHe.TabIndex = 5;
            this.btn_LienHe.Text = "Liên hệ";
            this.btn_LienHe.UseVisualStyleBackColor = false;
            // 
            // btn_PhanMem
            // 
            this.btn_PhanMem.BackColor = System.Drawing.Color.Orange;
            this.btn_PhanMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PhanMem.FlatAppearance.BorderSize = 0;
            this.btn_PhanMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhanMem.Location = new System.Drawing.Point(0, 68);
            this.btn_PhanMem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PhanMem.Name = "btn_PhanMem";
            this.btn_PhanMem.Size = new System.Drawing.Size(150, 40);
            this.btn_PhanMem.TabIndex = 4;
            this.btn_PhanMem.Text = "Phần mềm";
            this.btn_PhanMem.UseVisualStyleBackColor = false;
            // 
            // btn_VeChungToi
            // 
            this.btn_VeChungToi.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_VeChungToi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VeChungToi.FlatAppearance.BorderSize = 0;
            this.btn_VeChungToi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VeChungToi.Location = new System.Drawing.Point(0, 0);
            this.btn_VeChungToi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_VeChungToi.Name = "btn_VeChungToi";
            this.btn_VeChungToi.Size = new System.Drawing.Size(150, 68);
            this.btn_VeChungToi.TabIndex = 3;
            this.btn_VeChungToi.Text = "Về chúng tôi";
            this.btn_VeChungToi.UseVisualStyleBackColor = false;
            this.btn_VeChungToi.MouseLeave += new System.EventHandler(this.btn_VeChungToi_MouseLeave);
            this.btn_VeChungToi.MouseHover += new System.EventHandler(this.btn_VeChungToi_MouseHover);
            // 
            // pnl_DichVu
            // 
            this.pnl_DichVu.Controls.Add(this.btn_NoiTro);
            this.pnl_DichVu.Controls.Add(this.btn_NauAn);
            this.pnl_DichVu.Controls.Add(this.btn_TrongTre);
            this.pnl_DichVu.Controls.Add(this.btn_DiCho);
            this.pnl_DichVu.Controls.Add(this.btn_LauNha);
            this.pnl_DichVu.Controls.Add(this.btn_DichVu);
            this.pnl_DichVu.Location = new System.Drawing.Point(301, 3);
            this.pnl_DichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_DichVu.MaximumSize = new System.Drawing.Size(150, 268);
            this.pnl_DichVu.MinimumSize = new System.Drawing.Size(150, 68);
            this.pnl_DichVu.Name = "pnl_DichVu";
            this.pnl_DichVu.Size = new System.Drawing.Size(150, 68);
            this.pnl_DichVu.TabIndex = 4;
            // 
            // btn_NoiTro
            // 
            this.btn_NoiTro.BackColor = System.Drawing.Color.Orange;
            this.btn_NoiTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NoiTro.FlatAppearance.BorderSize = 0;
            this.btn_NoiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NoiTro.Location = new System.Drawing.Point(0, 228);
            this.btn_NoiTro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NoiTro.Name = "btn_NoiTro";
            this.btn_NoiTro.Size = new System.Drawing.Size(150, 40);
            this.btn_NoiTro.TabIndex = 5;
            this.btn_NoiTro.Text = "Nội trợ";
            this.btn_NoiTro.UseVisualStyleBackColor = false;
            // 
            // btn_NauAn
            // 
            this.btn_NauAn.BackColor = System.Drawing.Color.Orange;
            this.btn_NauAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NauAn.FlatAppearance.BorderSize = 0;
            this.btn_NauAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NauAn.Location = new System.Drawing.Point(0, 188);
            this.btn_NauAn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NauAn.Name = "btn_NauAn";
            this.btn_NauAn.Size = new System.Drawing.Size(150, 40);
            this.btn_NauAn.TabIndex = 4;
            this.btn_NauAn.Text = "Nấu ăn";
            this.btn_NauAn.UseVisualStyleBackColor = false;
            // 
            // btn_TrongTre
            // 
            this.btn_TrongTre.BackColor = System.Drawing.Color.Orange;
            this.btn_TrongTre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TrongTre.FlatAppearance.BorderSize = 0;
            this.btn_TrongTre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrongTre.Location = new System.Drawing.Point(0, 148);
            this.btn_TrongTre.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrongTre.Name = "btn_TrongTre";
            this.btn_TrongTre.Size = new System.Drawing.Size(150, 40);
            this.btn_TrongTre.TabIndex = 3;
            this.btn_TrongTre.Text = "Trông trẻ";
            this.btn_TrongTre.UseVisualStyleBackColor = false;
            // 
            // btn_DiCho
            // 
            this.btn_DiCho.BackColor = System.Drawing.Color.Orange;
            this.btn_DiCho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DiCho.FlatAppearance.BorderSize = 0;
            this.btn_DiCho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiCho.Location = new System.Drawing.Point(0, 108);
            this.btn_DiCho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DiCho.Name = "btn_DiCho";
            this.btn_DiCho.Size = new System.Drawing.Size(150, 40);
            this.btn_DiCho.TabIndex = 2;
            this.btn_DiCho.Text = "Đi chợ";
            this.btn_DiCho.UseVisualStyleBackColor = false;
            // 
            // btn_LauNha
            // 
            this.btn_LauNha.BackColor = System.Drawing.Color.Orange;
            this.btn_LauNha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LauNha.FlatAppearance.BorderSize = 0;
            this.btn_LauNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LauNha.Location = new System.Drawing.Point(0, 68);
            this.btn_LauNha.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LauNha.Name = "btn_LauNha";
            this.btn_LauNha.Size = new System.Drawing.Size(150, 40);
            this.btn_LauNha.TabIndex = 1;
            this.btn_LauNha.Text = "Lau Nhà";
            this.btn_LauNha.UseVisualStyleBackColor = false;
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_DichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DichVu.FlatAppearance.BorderSize = 0;
            this.btn_DichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DichVu.Location = new System.Drawing.Point(0, 0);
            this.btn_DichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DichVu.Name = "btn_DichVu";
            this.btn_DichVu.Size = new System.Drawing.Size(150, 68);
            this.btn_DichVu.TabIndex = 0;
            this.btn_DichVu.Text = "Dịch Vụ";
            this.btn_DichVu.UseVisualStyleBackColor = false;
            this.btn_DichVu.MouseLeave += new System.EventHandler(this.btn_DichVu_MouseLeave);
            this.btn_DichVu.MouseHover += new System.EventHandler(this.btn_DichVu_MouseHover);
            // 
            // timer_VeChungToi
            // 
            this.timer_VeChungToi.Tick += new System.EventHandler(this.timer_Dropdown_Tick);
            // 
            // timer_DichVu
            // 
            this.timer_DichVu.Tick += new System.EventHandler(this.time_DichVu_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject_17521061.Properties.Resources.housekeeping;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 903);
            this.Controls.Add(this.pnl_NavigationBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_NavigationBar.ResumeLayout(false);
            this.pnl_VeChungToi.ResumeLayout(false);
            this.pnl_DichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_NavigationBar;
        private System.Windows.Forms.Panel pnl_VeChungToi;
        private System.Windows.Forms.Button btn_LienHe;
        private System.Windows.Forms.Button btn_PhanMem;
        private System.Windows.Forms.Button btn_VeChungToi;
        private System.Windows.Forms.Panel pnl_DichVu;
        private System.Windows.Forms.Button btn_NoiTro;
        private System.Windows.Forms.Button btn_NauAn;
        private System.Windows.Forms.Button btn_TrongTre;
        private System.Windows.Forms.Button btn_DiCho;
        private System.Windows.Forms.Button btn_LauNha;
        private System.Windows.Forms.Button btn_DichVu;
        private System.Windows.Forms.Timer timer_VeChungToi;
        private System.Windows.Forms.Timer timer_DichVu;
    }
}

