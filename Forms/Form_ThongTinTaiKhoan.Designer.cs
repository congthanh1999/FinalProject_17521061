namespace FinalProject_17521061.Forms
{
    partial class Form_ThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongTinTaiKhoan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DoiMatKhau = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_ChinhSua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_DoiMatKhau);
            this.panel1.Controls.Add(this.btn_ChinhSua);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_HoTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_DangNhap);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(168, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 574);
            this.panel1.TabIndex = 1;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(495, 243);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(40);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(210, 31);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(495, 142);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(40);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(210, 31);
            this.txt_SDT.TabIndex = 10;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "SĐT";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(205, 142);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(40);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.Size = new System.Drawing.Size(210, 31);
            this.txt_HoTen.TabIndex = 6;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(205, 243);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(40);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(210, 31);
            this.txt_Email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject_17521061.Properties.Resources._6457546_history_order_page_time_track_icon;
            this.pictureBox1.Location = new System.Drawing.Point(804, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.AllowAnimations = true;
            this.btn_DoiMatKhau.AllowMouseEffects = true;
            this.btn_DoiMatKhau.AllowToggling = false;
            this.btn_DoiMatKhau.AnimationSpeed = 200;
            this.btn_DoiMatKhau.AutoGenerateColors = false;
            this.btn_DoiMatKhau.AutoRoundBorders = false;
            this.btn_DoiMatKhau.AutoSizeLeftIcon = true;
            this.btn_DoiMatKhau.AutoSizeRightIcon = true;
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btn_DoiMatKhau.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.BackgroundImage")));
            this.btn_DoiMatKhau.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_DoiMatKhau.ButtonText = "Đổi mật khẩu";
            this.btn_DoiMatKhau.ButtonTextMarginLeft = 0;
            this.btn_DoiMatKhau.ColorContrastOnClick = 45;
            this.btn_DoiMatKhau.ColorContrastOnHover = 45;
            this.btn_DoiMatKhau.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_DoiMatKhau.CustomizableEdges = borderEdges1;
            this.btn_DoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_DoiMatKhau.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_DoiMatKhau.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_DoiMatKhau.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_DoiMatKhau.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoiMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_DoiMatKhau.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_DoiMatKhau.IconMarginLeft = 11;
            this.btn_DoiMatKhau.IconPadding = 10;
            this.btn_DoiMatKhau.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DoiMatKhau.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_DoiMatKhau.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_DoiMatKhau.IconSize = 25;
            this.btn_DoiMatKhau.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.IdleBorderRadius = 30;
            this.btn_DoiMatKhau.IdleBorderThickness = 1;
            this.btn_DoiMatKhau.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.IdleIconLeftImage = null;
            this.btn_DoiMatKhau.IdleIconRightImage = null;
            this.btn_DoiMatKhau.IndicateFocus = false;
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(498, 517);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_DoiMatKhau.OnDisabledState.BorderRadius = 30;
            this.btn_DoiMatKhau.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_DoiMatKhau.OnDisabledState.BorderThickness = 1;
            this.btn_DoiMatKhau.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_DoiMatKhau.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_DoiMatKhau.OnDisabledState.IconLeftImage = null;
            this.btn_DoiMatKhau.OnDisabledState.IconRightImage = null;
            this.btn_DoiMatKhau.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.onHoverState.BorderRadius = 30;
            this.btn_DoiMatKhau.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_DoiMatKhau.onHoverState.BorderThickness = 1;
            this.btn_DoiMatKhau.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.onHoverState.IconLeftImage = null;
            this.btn_DoiMatKhau.onHoverState.IconRightImage = null;
            this.btn_DoiMatKhau.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.OnIdleState.BorderRadius = 30;
            this.btn_DoiMatKhau.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_DoiMatKhau.OnIdleState.BorderThickness = 1;
            this.btn_DoiMatKhau.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_DoiMatKhau.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.OnIdleState.IconLeftImage = null;
            this.btn_DoiMatKhau.OnIdleState.IconRightImage = null;
            this.btn_DoiMatKhau.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_DoiMatKhau.OnPressedState.BorderRadius = 30;
            this.btn_DoiMatKhau.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_DoiMatKhau.OnPressedState.BorderThickness = 1;
            this.btn_DoiMatKhau.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_DoiMatKhau.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.OnPressedState.IconLeftImage = null;
            this.btn_DoiMatKhau.OnPressedState.IconRightImage = null;
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(150, 39);
            this.btn_DoiMatKhau.TabIndex = 12;
            this.btn_DoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DoiMatKhau.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_DoiMatKhau.TextMarginLeft = 0;
            this.btn_DoiMatKhau.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_DoiMatKhau.UseDefaultRadiusAndThickness = true;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.AllowAnimations = true;
            this.btn_ChinhSua.AllowMouseEffects = true;
            this.btn_ChinhSua.AllowToggling = false;
            this.btn_ChinhSua.AnimationSpeed = 200;
            this.btn_ChinhSua.AutoGenerateColors = false;
            this.btn_ChinhSua.AutoRoundBorders = false;
            this.btn_ChinhSua.AutoSizeLeftIcon = true;
            this.btn_ChinhSua.AutoSizeRightIcon = true;
            this.btn_ChinhSua.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChinhSua.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChinhSua.BackgroundImage")));
            this.btn_ChinhSua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ChinhSua.ButtonText = "Sửa thông tin";
            this.btn_ChinhSua.ButtonTextMarginLeft = 0;
            this.btn_ChinhSua.ColorContrastOnClick = 45;
            this.btn_ChinhSua.ColorContrastOnHover = 45;
            this.btn_ChinhSua.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_ChinhSua.CustomizableEdges = borderEdges2;
            this.btn_ChinhSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ChinhSua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ChinhSua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ChinhSua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ChinhSua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_ChinhSua.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChinhSua.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChinhSua.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChinhSua.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_ChinhSua.IconMarginLeft = 11;
            this.btn_ChinhSua.IconPadding = 10;
            this.btn_ChinhSua.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChinhSua.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChinhSua.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_ChinhSua.IconSize = 25;
            this.btn_ChinhSua.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.IdleBorderRadius = 30;
            this.btn_ChinhSua.IdleBorderThickness = 1;
            this.btn_ChinhSua.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.IdleIconLeftImage = null;
            this.btn_ChinhSua.IdleIconRightImage = null;
            this.btn_ChinhSua.IndicateFocus = false;
            this.btn_ChinhSua.Location = new System.Drawing.Point(265, 517);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ChinhSua.OnDisabledState.BorderRadius = 30;
            this.btn_ChinhSua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ChinhSua.OnDisabledState.BorderThickness = 1;
            this.btn_ChinhSua.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ChinhSua.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ChinhSua.OnDisabledState.IconLeftImage = null;
            this.btn_ChinhSua.OnDisabledState.IconRightImage = null;
            this.btn_ChinhSua.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.onHoverState.BorderRadius = 30;
            this.btn_ChinhSua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ChinhSua.onHoverState.BorderThickness = 1;
            this.btn_ChinhSua.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.onHoverState.IconLeftImage = null;
            this.btn_ChinhSua.onHoverState.IconRightImage = null;
            this.btn_ChinhSua.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.OnIdleState.BorderRadius = 30;
            this.btn_ChinhSua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ChinhSua.OnIdleState.BorderThickness = 1;
            this.btn_ChinhSua.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btn_ChinhSua.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.OnIdleState.IconLeftImage = null;
            this.btn_ChinhSua.OnIdleState.IconRightImage = null;
            this.btn_ChinhSua.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ChinhSua.OnPressedState.BorderRadius = 30;
            this.btn_ChinhSua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ChinhSua.OnPressedState.BorderThickness = 1;
            this.btn_ChinhSua.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ChinhSua.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.OnPressedState.IconLeftImage = null;
            this.btn_ChinhSua.OnPressedState.IconRightImage = null;
            this.btn_ChinhSua.Size = new System.Drawing.Size(150, 39);
            this.btn_ChinhSua.TabIndex = 11;
            this.btn_ChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChinhSua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ChinhSua.TextMarginLeft = 0;
            this.btn_ChinhSua.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_ChinhSua.UseDefaultRadiusAndThickness = true;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // Form_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1191, 713);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "Form_ThongTinTaiKhoan";
            this.Text = "Form_DangNhap";
            this.Load += new System.EventHandler(this.Form_ThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_ChinhSua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_DoiMatKhau;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}