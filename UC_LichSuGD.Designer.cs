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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
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
            this.panel1.Size = new System.Drawing.Size(980, 325);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.rate_DanhGia.Location = new System.Drawing.Point(35, 270);
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
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(430, 70);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(105, 25);
            this.lbl_ThanhTien.TabIndex = 5;
            this.lbl_ThanhTien.Text = "Thành tiền";
            this.lbl_ThanhTien.Click += new System.EventHandler(this.lbl_ThanhTien_Click);
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(30, 170);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(71, 25);
            this.lbl_DiaChi.TabIndex = 4;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_GoiDichVu
            // 
            this.lbl_GoiDichVu.AutoSize = true;
            this.lbl_GoiDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoiDichVu.Location = new System.Drawing.Point(230, 70);
            this.lbl_GoiDichVu.Name = "lbl_GoiDichVu";
            this.lbl_GoiDichVu.Size = new System.Drawing.Size(109, 25);
            this.lbl_GoiDichVu.TabIndex = 3;
            this.lbl_GoiDichVu.Text = "Gói dịch vụ";
            this.lbl_GoiDichVu.Click += new System.EventHandler(this.lbl_GoiDichVu_Click);
            // 
            // lbl_TenDV
            // 
            this.lbl_TenDV.AutoSize = true;
            this.lbl_TenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDV.Location = new System.Drawing.Point(30, 70);
            this.lbl_TenDV.Name = "lbl_TenDV";
            this.lbl_TenDV.Size = new System.Drawing.Size(114, 25);
            this.lbl_TenDV.TabIndex = 2;
            this.lbl_TenDV.Text = "Tên dịch vụ";
            this.lbl_TenDV.Click += new System.EventHandler(this.lbl_TenDV_Click);
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGian.Location = new System.Drawing.Point(830, 70);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(42, 25);
            this.lbl_ThoiGian.TabIndex = 1;
            this.lbl_ThoiGian.Text = "Giờ";
            this.lbl_ThoiGian.Click += new System.EventHandler(this.lbl_ThoiGian_Click);
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.Location = new System.Drawing.Point(630, 70);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(58, 25);
            this.lbl_Ngay.TabIndex = 0;
            this.lbl_Ngay.Text = "Ngày";
            this.lbl_Ngay.Click += new System.EventHandler(this.lbl_Ngay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gói dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đánh giá";
            // 
            // UC_LichSuGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_LichSuGD";
            this.Size = new System.Drawing.Size(980, 325);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
