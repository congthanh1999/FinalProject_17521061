using System.Drawing;
using System.Drawing.Text;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_NavigationBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pnl_DichVu = new System.Windows.Forms.Panel();
            this.btn_DichVu = new System.Windows.Forms.Button();
            this.pnl_VeChungToi = new System.Windows.Forms.Panel();
            this.btn_VeChungToi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_VeChungToi = new System.Windows.Forms.Timer(this.components);
            this.timer_DichVu = new System.Windows.Forms.Timer(this.components);
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pnl_DichVu_Dropdown = new System.Windows.Forms.Panel();
            this.btn_NoiTro = new System.Windows.Forms.Button();
            this.btn_NauAn = new System.Windows.Forms.Button();
            this.btn_GiatUi = new System.Windows.Forms.Button();
            this.btn_DiCho = new System.Windows.Forms.Button();
            this.btn_LauNha = new System.Windows.Forms.Button();
            this.pnl_VeChungToi_Dropdown = new System.Windows.Forms.Panel();
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.btn_PhanMem = new System.Windows.Forms.Button();
            this.pnl_NavigationBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_DichVu.SuspendLayout();
            this.pnl_VeChungToi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Main.SuspendLayout();
            this.pnl_DichVu_Dropdown.SuspendLayout();
            this.pnl_VeChungToi_Dropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_NavigationBar
            // 
            this.pnl_NavigationBar.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_NavigationBar.Controls.Add(this.panel1);
            this.pnl_NavigationBar.Controls.Add(this.btn_DangKy);
            this.pnl_NavigationBar.Controls.Add(this.btn_DangNhap);
            this.pnl_NavigationBar.Controls.Add(this.pnl_DichVu);
            this.pnl_NavigationBar.Controls.Add(this.pnl_VeChungToi);
            this.pnl_NavigationBar.Controls.Add(this.pictureBox1);
            this.pnl_NavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_NavigationBar.Name = "pnl_NavigationBar";
            this.pnl_NavigationBar.Size = new System.Drawing.Size(1225, 76);
            this.pnl_NavigationBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Location = new System.Drawing.Point(610, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 68);
            this.panel1.TabIndex = 8;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Username.Location = new System.Drawing.Point(0, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(300, 68);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Thông tin tài khoản";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKy.Location = new System.Drawing.Point(916, 4);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(150, 68);
            this.btn_DangKy.TabIndex = 6;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DangNhap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Location = new System.Drawing.Point(1072, 4);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(150, 68);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pnl_DichVu
            // 
            this.pnl_DichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_DichVu.Controls.Add(this.btn_DichVu);
            this.pnl_DichVu.Location = new System.Drawing.Point(378, 4);
            this.pnl_DichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_DichVu.MaximumSize = new System.Drawing.Size(150, 68);
            this.pnl_DichVu.MinimumSize = new System.Drawing.Size(150, 68);
            this.pnl_DichVu.Name = "pnl_DichVu";
            this.pnl_DichVu.Size = new System.Drawing.Size(150, 68);
            this.pnl_DichVu.TabIndex = 4;
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.BackColor = System.Drawing.SystemColors.Window;
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
            // pnl_VeChungToi
            // 
            this.pnl_VeChungToi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_VeChungToi.Controls.Add(this.btn_VeChungToi);
            this.pnl_VeChungToi.Location = new System.Drawing.Point(221, 4);
            this.pnl_VeChungToi.MaximumSize = new System.Drawing.Size(150, 68);
            this.pnl_VeChungToi.MinimumSize = new System.Drawing.Size(150, 68);
            this.pnl_VeChungToi.Name = "pnl_VeChungToi";
            this.pnl_VeChungToi.Size = new System.Drawing.Size(150, 68);
            this.pnl_VeChungToi.TabIndex = 3;
            // 
            // btn_VeChungToi
            // 
            this.btn_VeChungToi.BackColor = System.Drawing.SystemColors.Window;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject_17521061.Properties.Resources.housekeeping;
            this.pictureBox1.Location = new System.Drawing.Point(64, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer_VeChungToi
            // 
            this.timer_VeChungToi.Tick += new System.EventHandler(this.timer_Dropdown_Tick);
            // 
            // timer_DichVu
            // 
            this.timer_DichVu.Tick += new System.EventHandler(this.time_DichVu_Tick);
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.Controls.Add(this.pnl_DichVu_Dropdown);
            this.panel_Main.Controls.Add(this.pnl_VeChungToi_Dropdown);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 76);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1225, 827);
            this.panel_Main.TabIndex = 4;
            // 
            // pnl_DichVu_Dropdown
            // 
            this.pnl_DichVu_Dropdown.Controls.Add(this.btn_NoiTro);
            this.pnl_DichVu_Dropdown.Controls.Add(this.btn_NauAn);
            this.pnl_DichVu_Dropdown.Controls.Add(this.btn_GiatUi);
            this.pnl_DichVu_Dropdown.Controls.Add(this.btn_DiCho);
            this.pnl_DichVu_Dropdown.Controls.Add(this.btn_LauNha);
            this.pnl_DichVu_Dropdown.Location = new System.Drawing.Point(378, 0);
            this.pnl_DichVu_Dropdown.MaximumSize = new System.Drawing.Size(150, 200);
            this.pnl_DichVu_Dropdown.MinimumSize = new System.Drawing.Size(150, 0);
            this.pnl_DichVu_Dropdown.Name = "pnl_DichVu_Dropdown";
            this.pnl_DichVu_Dropdown.Size = new System.Drawing.Size(150, 0);
            this.pnl_DichVu_Dropdown.TabIndex = 6;
            // 
            // btn_NoiTro
            // 
            this.btn_NoiTro.BackColor = System.Drawing.Color.Orange;
            this.btn_NoiTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NoiTro.FlatAppearance.BorderSize = 0;
            this.btn_NoiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NoiTro.Location = new System.Drawing.Point(0, 160);
            this.btn_NoiTro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NoiTro.Name = "btn_NoiTro";
            this.btn_NoiTro.Size = new System.Drawing.Size(150, 40);
            this.btn_NoiTro.TabIndex = 10;
            this.btn_NoiTro.Text = "Nội trợ";
            this.btn_NoiTro.UseVisualStyleBackColor = false;
            this.btn_NoiTro.Click += new System.EventHandler(this.btn_NoiTro_Click);
            // 
            // btn_NauAn
            // 
            this.btn_NauAn.BackColor = System.Drawing.Color.Orange;
            this.btn_NauAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NauAn.FlatAppearance.BorderSize = 0;
            this.btn_NauAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NauAn.Location = new System.Drawing.Point(0, 120);
            this.btn_NauAn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NauAn.Name = "btn_NauAn";
            this.btn_NauAn.Size = new System.Drawing.Size(150, 40);
            this.btn_NauAn.TabIndex = 9;
            this.btn_NauAn.Text = "Nấu ăn";
            this.btn_NauAn.UseVisualStyleBackColor = false;
            this.btn_NauAn.Click += new System.EventHandler(this.btn_NauAn_Click);
            // 
            // btn_GiatUi
            // 
            this.btn_GiatUi.BackColor = System.Drawing.Color.Orange;
            this.btn_GiatUi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GiatUi.FlatAppearance.BorderSize = 0;
            this.btn_GiatUi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiatUi.Location = new System.Drawing.Point(0, 80);
            this.btn_GiatUi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GiatUi.Name = "btn_GiatUi";
            this.btn_GiatUi.Size = new System.Drawing.Size(150, 40);
            this.btn_GiatUi.TabIndex = 8;
            this.btn_GiatUi.Text = "Giặt ủi";
            this.btn_GiatUi.UseVisualStyleBackColor = false;
            this.btn_GiatUi.Click += new System.EventHandler(this.btn_GiatUi_Click);
            // 
            // btn_DiCho
            // 
            this.btn_DiCho.BackColor = System.Drawing.Color.Orange;
            this.btn_DiCho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DiCho.FlatAppearance.BorderSize = 0;
            this.btn_DiCho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiCho.Location = new System.Drawing.Point(0, 40);
            this.btn_DiCho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DiCho.Name = "btn_DiCho";
            this.btn_DiCho.Size = new System.Drawing.Size(150, 40);
            this.btn_DiCho.TabIndex = 7;
            this.btn_DiCho.Text = "Đi chợ";
            this.btn_DiCho.UseVisualStyleBackColor = false;
            this.btn_DiCho.Click += new System.EventHandler(this.btn_DiCho_Click);
            // 
            // btn_LauNha
            // 
            this.btn_LauNha.BackColor = System.Drawing.Color.Orange;
            this.btn_LauNha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LauNha.FlatAppearance.BorderSize = 0;
            this.btn_LauNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LauNha.Location = new System.Drawing.Point(0, 0);
            this.btn_LauNha.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LauNha.Name = "btn_LauNha";
            this.btn_LauNha.Size = new System.Drawing.Size(150, 40);
            this.btn_LauNha.TabIndex = 6;
            this.btn_LauNha.Text = "Tổng vệ sinh";
            this.btn_LauNha.UseVisualStyleBackColor = false;
            this.btn_LauNha.Click += new System.EventHandler(this.btn_LauNha_Click);
            // 
            // pnl_VeChungToi_Dropdown
            // 
            this.pnl_VeChungToi_Dropdown.Controls.Add(this.btn_LienHe);
            this.pnl_VeChungToi_Dropdown.Controls.Add(this.btn_PhanMem);
            this.pnl_VeChungToi_Dropdown.Location = new System.Drawing.Point(221, 0);
            this.pnl_VeChungToi_Dropdown.MaximumSize = new System.Drawing.Size(150, 80);
            this.pnl_VeChungToi_Dropdown.MinimumSize = new System.Drawing.Size(150, 0);
            this.pnl_VeChungToi_Dropdown.Name = "pnl_VeChungToi_Dropdown";
            this.pnl_VeChungToi_Dropdown.Size = new System.Drawing.Size(150, 0);
            this.pnl_VeChungToi_Dropdown.TabIndex = 4;
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.BackColor = System.Drawing.Color.Orange;
            this.btn_LienHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LienHe.FlatAppearance.BorderSize = 0;
            this.btn_LienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LienHe.Location = new System.Drawing.Point(0, 40);
            this.btn_LienHe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(150, 40);
            this.btn_LienHe.TabIndex = 7;
            this.btn_LienHe.Text = "Liên hệ";
            this.btn_LienHe.UseVisualStyleBackColor = false;
            this.btn_LienHe.Click += new System.EventHandler(this.btn_LienHe_Click);
            // 
            // btn_PhanMem
            // 
            this.btn_PhanMem.BackColor = System.Drawing.Color.Orange;
            this.btn_PhanMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PhanMem.FlatAppearance.BorderSize = 0;
            this.btn_PhanMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhanMem.Location = new System.Drawing.Point(0, 0);
            this.btn_PhanMem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PhanMem.Name = "btn_PhanMem";
            this.btn_PhanMem.Size = new System.Drawing.Size(150, 40);
            this.btn_PhanMem.TabIndex = 6;
            this.btn_PhanMem.Text = "Phần mềm";
            this.btn_PhanMem.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1225, 903);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.pnl_NavigationBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go task!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_NavigationBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_DichVu.ResumeLayout(false);
            this.pnl_VeChungToi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.pnl_DichVu_Dropdown.ResumeLayout(false);
            this.pnl_VeChungToi_Dropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_NavigationBar;
        private System.Windows.Forms.Panel pnl_VeChungToi;
        private System.Windows.Forms.Button btn_VeChungToi;
        private System.Windows.Forms.Panel pnl_DichVu;
        private System.Windows.Forms.Button btn_DichVu;
        private System.Windows.Forms.Timer timer_VeChungToi;
        private System.Windows.Forms.Timer timer_DichVu;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel pnl_DichVu_Dropdown;
        private System.Windows.Forms.Button btn_NoiTro;
        private System.Windows.Forms.Button btn_NauAn;
        private System.Windows.Forms.Button btn_GiatUi;
        private System.Windows.Forms.Button btn_DiCho;
        private System.Windows.Forms.Button btn_LauNha;
        private System.Windows.Forms.Panel pnl_VeChungToi_Dropdown;
        private System.Windows.Forms.Button btn_LienHe;
        private System.Windows.Forms.Button btn_PhanMem;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Username;
    }
}

