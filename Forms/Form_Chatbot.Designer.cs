namespace FinalProject_17521061.Forms
{
    partial class Form_Chatbot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chatbot));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_Close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Send = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txt_Message = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.pnl_Header.Controls.Add(this.lbl_Status);
            this.pnl_Header.Controls.Add(this.label1);
            this.pnl_Header.Controls.Add(this.bunifuPictureBox1);
            this.pnl_Header.Controls.Add(this.btn_Close);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(378, 88);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.lbl_Status.Location = new System.Drawing.Point(83, 45);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(57, 20);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Online";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trợ lý ảo";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 32;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(11, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(65, 65);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btn_Close
            // 
            this.btn_Close.ActiveImage = null;
            this.btn_Close.AllowAnimations = true;
            this.btn_Close.AllowBuffering = false;
            this.btn_Close.AllowToggling = false;
            this.btn_Close.AllowZooming = true;
            this.btn_Close.AllowZoomingOnFocus = false;
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.ErrorImage")));
            this.btn_Close.FadeWhenInactive = false;
            this.btn_Close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Close.Image = global::FinalProject_17521061.Properties.Resources._211651_close_round_icon;
            this.btn_Close.ImageActive = null;
            this.btn_Close.ImageLocation = null;
            this.btn_Close.ImageMargin = 10;
            this.btn_Close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Close.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btn_Close.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.InitialImage")));
            this.btn_Close.Location = new System.Drawing.Point(345, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Rotation = 0;
            this.btn_Close.ShowActiveImage = true;
            this.btn_Close.ShowCursorChanges = true;
            this.btn_Close.ShowImageBorders = true;
            this.btn_Close.ShowSizeMarkers = false;
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.ToolTipText = "";
            this.btn_Close.WaitOnLoad = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.ZoomSpeed = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Send);
            this.panel2.Controls.Add(this.txt_Message);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 100);
            this.panel2.TabIndex = 1;
            // 
            // btn_Send
            // 
            this.btn_Send.ActiveImage = null;
            this.btn_Send.AllowAnimations = true;
            this.btn_Send.AllowBuffering = false;
            this.btn_Send.AllowToggling = false;
            this.btn_Send.AllowZooming = true;
            this.btn_Send.AllowZoomingOnFocus = false;
            this.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Send.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Send.ErrorImage")));
            this.btn_Send.FadeWhenInactive = false;
            this.btn_Send.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Send.Image = global::FinalProject_17521061.Properties.Resources._8687639_ic_fluent_send_regular_icon;
            this.btn_Send.ImageActive = null;
            this.btn_Send.ImageLocation = null;
            this.btn_Send.ImageMargin = 5;
            this.btn_Send.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_Send.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_Send.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Send.InitialImage")));
            this.btn_Send.Location = new System.Drawing.Point(326, 24);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Rotation = 0;
            this.btn_Send.ShowActiveImage = true;
            this.btn_Send.ShowCursorChanges = true;
            this.btn_Send.ShowImageBorders = true;
            this.btn_Send.ShowSizeMarkers = false;
            this.btn_Send.Size = new System.Drawing.Size(50, 50);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.ToolTipText = "";
            this.btn_Send.WaitOnLoad = false;
            this.btn_Send.Zoom = 5;
            this.btn_Send.ZoomSpeed = 10;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.AcceptsReturn = false;
            this.txt_Message.AcceptsTab = false;
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.AnimationSpeed = 200;
            this.txt_Message.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Message.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Message.BackColor = System.Drawing.Color.White;
            this.txt_Message.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Message.BackgroundImage")));
            this.txt_Message.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Message.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Message.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Message.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Message.BorderRadius = 1;
            this.txt_Message.BorderThickness = 2;
            this.txt_Message.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Message.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_Message.DefaultText = "";
            this.txt_Message.FillColor = System.Drawing.Color.White;
            this.txt_Message.HideSelection = true;
            this.txt_Message.IconLeft = null;
            this.txt_Message.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Message.IconPadding = 10;
            this.txt_Message.IconRight = null;
            this.txt_Message.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Message.Lines = new string[0];
            this.txt_Message.Location = new System.Drawing.Point(3, 6);
            this.txt_Message.MaxLength = 32767;
            this.txt_Message.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Message.Modified = false;
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Message.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Message.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Message.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Message.OnIdleState = stateProperties4;
            this.txt_Message.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Message.PasswordChar = '\0';
            this.txt_Message.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Message.PlaceholderText = "Nhập tin nhắn";
            this.txt_Message.ReadOnly = false;
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Message.SelectedText = "";
            this.txt_Message.SelectionLength = 0;
            this.txt_Message.SelectionStart = 0;
            this.txt_Message.ShortcutsEnabled = true;
            this.txt_Message.Size = new System.Drawing.Size(317, 91);
            this.txt_Message.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_Message.TabIndex = 1;
            this.txt_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Message.TextMarginBottom = 0;
            this.txt_Message.TextMarginLeft = 3;
            this.txt_Message.TextMarginTop = 0;
            this.txt_Message.TextPlaceholder = "Nhập tin nhắn";
            this.txt_Message.UseSystemPasswordChar = false;
            this.txt_Message.WordWrap = true;
            this.txt_Message.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            this.txt_Message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Message_KeyUp);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(378, 17);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // pnl_Container
            // 
            this.pnl_Container.AutoScroll = true;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 88);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(378, 409);
            this.pnl_Container.TabIndex = 2;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.pnl_Header;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 597);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Chatbot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Chatbot";
            this.Shown += new System.EventHandler(this.Form_Chatbot_Shown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Close;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pnl_Container;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Message;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Send;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Timer timer1;
    }
}