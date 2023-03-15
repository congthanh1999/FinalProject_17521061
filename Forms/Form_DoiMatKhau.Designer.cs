namespace FinalProject_17521061.Forms
{
    partial class Form_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DoiMatKhau));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.e = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txt_XacNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.e);
            this.panel1.Controls.Add(this.txt_XacNhan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_MatKhauCu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_MatKhauMoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_DangNhap);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(168, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 574);
            this.panel1.TabIndex = 1;
            // 
            // e
            // 
            this.e.AllowAnimations = true;
            this.e.AllowMouseEffects = true;
            this.e.AllowToggling = false;
            this.e.AnimationSpeed = 200;
            this.e.AutoGenerateColors = false;
            this.e.AutoRoundBorders = false;
            this.e.AutoSizeLeftIcon = true;
            this.e.AutoSizeRightIcon = true;
            this.e.BackColor = System.Drawing.Color.Transparent;
            this.e.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("e.BackgroundImage")));
            this.e.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.e.ButtonText = "Đổi mật khẩu";
            this.e.ButtonTextMarginLeft = 0;
            this.e.ColorContrastOnClick = 45;
            this.e.ColorContrastOnHover = 45;
            this.e.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.e.CustomizableEdges = borderEdges2;
            this.e.DialogResult = System.Windows.Forms.DialogResult.None;
            this.e.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.e.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.e.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.e.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.e.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.ForeColor = System.Drawing.Color.White;
            this.e.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.e.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.e.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.e.IconMarginLeft = 11;
            this.e.IconPadding = 10;
            this.e.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.e.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.e.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.e.IconSize = 25;
            this.e.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.IdleBorderRadius = 30;
            this.e.IdleBorderThickness = 1;
            this.e.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.IdleIconLeftImage = null;
            this.e.IdleIconRightImage = null;
            this.e.IndicateFocus = false;
            this.e.Location = new System.Drawing.Point(344, 517);
            this.e.Name = "e";
            this.e.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.e.OnDisabledState.BorderRadius = 30;
            this.e.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.e.OnDisabledState.BorderThickness = 1;
            this.e.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.e.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.e.OnDisabledState.IconLeftImage = null;
            this.e.OnDisabledState.IconRightImage = null;
            this.e.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.onHoverState.BorderRadius = 30;
            this.e.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.e.onHoverState.BorderThickness = 1;
            this.e.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.onHoverState.ForeColor = System.Drawing.Color.White;
            this.e.onHoverState.IconLeftImage = null;
            this.e.onHoverState.IconRightImage = null;
            this.e.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.OnIdleState.BorderRadius = 30;
            this.e.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.e.OnIdleState.BorderThickness = 1;
            this.e.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.e.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.e.OnIdleState.IconLeftImage = null;
            this.e.OnIdleState.IconRightImage = null;
            this.e.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.e.OnPressedState.BorderRadius = 30;
            this.e.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.e.OnPressedState.BorderThickness = 1;
            this.e.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.e.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.e.OnPressedState.IconLeftImage = null;
            this.e.OnPressedState.IconRightImage = null;
            this.e.Size = new System.Drawing.Size(150, 39);
            this.e.TabIndex = 11;
            this.e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.e.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.e.TextMarginLeft = 0;
            this.e.TextPadding = new System.Windows.Forms.Padding(0);
            this.e.UseDefaultRadiusAndThickness = true;
            this.e.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // txt_XacNhan
            // 
            this.txt_XacNhan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_XacNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XacNhan.Location = new System.Drawing.Point(205, 354);
            this.txt_XacNhan.Margin = new System.Windows.Forms.Padding(40);
            this.txt_XacNhan.Name = "txt_XacNhan";
            this.txt_XacNhan.Size = new System.Drawing.Size(210, 31);
            this.txt_XacNhan.TabIndex = 10;
            this.txt_XacNhan.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xác nhận mật khẩu mới";
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauCu.Location = new System.Drawing.Point(205, 142);
            this.txt_MatKhauCu.Margin = new System.Windows.Forms.Padding(40);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(210, 31);
            this.txt_MatKhauCu.TabIndex = 6;
            this.txt_MatKhauCu.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(205, 243);
            this.txt_MatKhauMoi.Margin = new System.Windows.Forms.Padding(40);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(210, 31);
            this.txt_MatKhauMoi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu mới";
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.Location = new System.Drawing.Point(3, 0);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(104, 28);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Thông tin";
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1191, 713);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "Form_DoiMatKhau";
            this.Text = "Form_DangNhap";
            this.Load += new System.EventHandler(this.Form_ThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_XacNhan;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton e;
    }
}