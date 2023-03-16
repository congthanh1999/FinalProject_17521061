namespace FinalProject_17521061
{
    partial class UC_Carousel
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_Slider = new System.Windows.Forms.PictureBox();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_TomTat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Slider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_Slider
            // 
            this.pic_Slider.BackColor = System.Drawing.SystemColors.Window;
            this.pic_Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Slider.Location = new System.Drawing.Point(0, 0);
            this.pic_Slider.Name = "pic_Slider";
            this.pic_Slider.Size = new System.Drawing.Size(876, 514);
            this.pic_Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Slider.TabIndex = 0;
            this.pic_Slider.TabStop = false;
            this.pic_Slider.MouseEnter += new System.EventHandler(this.pic_Slider_MouseEnter);
            this.pic_Slider.MouseLeave += new System.EventHandler(this.pic_Slider_MouseLeave);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Prev.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Prev.BackgroundImage = global::FinalProject_17521061.Properties.Resources._211689_left_arrow_icon;
            this.btn_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Prev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.Location = new System.Drawing.Point(0, 247);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(29, 90);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Next.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Next.BackgroundImage = global::FinalProject_17521061.Properties.Resources._211689_right_arrow_icon;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(847, 247);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(29, 90);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Những tiện ích mà gia đình bạn cần";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_TomTat);
            this.panel2.Controls.Add(this.btn_Prev);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.pic_Slider);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 514);
            this.panel2.TabIndex = 4;
            // 
            // lbl_TomTat
            // 
            this.lbl_TomTat.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_TomTat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_TomTat.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TomTat.ForeColor = System.Drawing.Color.White;
            this.lbl_TomTat.Location = new System.Drawing.Point(0, 429);
            this.lbl_TomTat.Name = "lbl_TomTat";
            this.lbl_TomTat.Size = new System.Drawing.Size(876, 85);
            this.lbl_TomTat.TabIndex = 3;
            this.lbl_TomTat.Visible = false;
            // 
            // UC_Carousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Carousel";
            this.Size = new System.Drawing.Size(876, 514);
            this.Load += new System.EventHandler(this.UC_Carousel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.PictureBox pic_Slider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_TomTat;
    }
}
