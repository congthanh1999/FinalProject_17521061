namespace FinalProject_17521061
{
    partial class UC_LichSuGD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rate_DanhGia = new Bunifu.UI.WinForms.BunifuRating();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_GoiDichVu = new System.Windows.Forms.Label();
            this.lbl_TenDV = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.lbl_Ngay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rate_DanhGia);
            this.panel1.Controls.Add(this.lbl_ThanhTien);
            this.panel1.Controls.Add(this.lbl_DiaChi);
            this.panel1.Controls.Add(this.lbl_GoiDichVu);
            this.panel1.Controls.Add(this.lbl_TenDV);
            this.panel1.Controls.Add(this.lbl_ThoiGian);
            this.panel1.Controls.Add(this.lbl_Ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 126);
            this.panel1.TabIndex = 0;
            // 
            // rate_DanhGia
            // 
            this.rate_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.rate_DanhGia.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate_DanhGia.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.rate_DanhGia.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate_DanhGia.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rate_DanhGia.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate_DanhGia.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate_DanhGia.InnerRadius = 2F;
            this.rate_DanhGia.Location = new System.Drawing.Point(597, 74);
            this.rate_DanhGia.Name = "rate_DanhGia";
            this.rate_DanhGia.OuterRadius = 10F;
            this.rate_DanhGia.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate_DanhGia.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rate_DanhGia.ReadOnly = false;
            this.rate_DanhGia.RightClickToClear = true;
            this.rate_DanhGia.Size = new System.Drawing.Size(121, 22);
            this.rate_DanhGia.TabIndex = 6;
            this.rate_DanhGia.Text = "bunifuRating1";
            this.rate_DanhGia.Value = 2;
            this.rate_DanhGia.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs>(this.rate_DanhGia_ValueChanged);
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(331, 25);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(99, 20);
            this.lbl_ThanhTien.TabIndex = 5;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(165, 25);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(72, 20);
            this.lbl_DiaChi.TabIndex = 4;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_GoiDichVu
            // 
            this.lbl_GoiDichVu.AutoSize = true;
            this.lbl_GoiDichVu.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoiDichVu.Location = new System.Drawing.Point(3, 74);
            this.lbl_GoiDichVu.Name = "lbl_GoiDichVu";
            this.lbl_GoiDichVu.Size = new System.Drawing.Size(108, 20);
            this.lbl_GoiDichVu.TabIndex = 3;
            this.lbl_GoiDichVu.Text = "Gói dịch vụ";
            // 
            // lbl_TenDV
            // 
            this.lbl_TenDV.AutoSize = true;
            this.lbl_TenDV.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDV.Location = new System.Drawing.Point(3, 25);
            this.lbl_TenDV.Name = "lbl_TenDV";
            this.lbl_TenDV.Size = new System.Drawing.Size(108, 20);
            this.lbl_TenDV.TabIndex = 2;
            this.lbl_TenDV.Text = "Tên dịch vụ";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGian.Location = new System.Drawing.Point(780, 25);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(36, 20);
            this.lbl_ThoiGian.TabIndex = 1;
            this.lbl_ThoiGian.Text = "Giờ";
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.Location = new System.Drawing.Point(583, 25);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(45, 20);
            this.lbl_Ngay.TabIndex = 0;
            this.lbl_Ngay.Text = "Ngày";
            // 
            // UC_LichSuGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_LichSuGD";
            this.Size = new System.Drawing.Size(967, 126);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuRating rate_DanhGia;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_GoiDichVu;
        private System.Windows.Forms.Label lbl_TenDV;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Label lbl_Ngay;
    }
}
