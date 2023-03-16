namespace FinalProject_17521061.Forms
{
    partial class Form_LienHe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LienHe));
            this.btn_TroLyAo = new Bunifu.UI.WinForms.BunifuImageButton();
            this.uC_LienHeScreen1 = new FinalProject_17521061.UC_LienHeScreen();
            this.SuspendLayout();
            // 
            // btn_TroLyAo
            // 
            this.btn_TroLyAo.ActiveImage = null;
            this.btn_TroLyAo.AllowAnimations = true;
            this.btn_TroLyAo.AllowBuffering = false;
            this.btn_TroLyAo.AllowToggling = false;
            this.btn_TroLyAo.AllowZooming = true;
            this.btn_TroLyAo.AllowZoomingOnFocus = false;
            this.btn_TroLyAo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TroLyAo.BackColor = System.Drawing.Color.Transparent;
            this.btn_TroLyAo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TroLyAo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_TroLyAo.ErrorImage")));
            this.btn_TroLyAo.FadeWhenInactive = false;
            this.btn_TroLyAo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_TroLyAo.Image = global::FinalProject_17521061.Properties.Resources._4104737_chatbot_customer_e_wallet_live_chat_service_icon;
            this.btn_TroLyAo.ImageActive = null;
            this.btn_TroLyAo.ImageLocation = null;
            this.btn_TroLyAo.ImageMargin = 5;
            this.btn_TroLyAo.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_TroLyAo.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_TroLyAo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_TroLyAo.InitialImage")));
            this.btn_TroLyAo.Location = new System.Drawing.Point(991, 556);
            this.btn_TroLyAo.Name = "btn_TroLyAo";
            this.btn_TroLyAo.Rotation = 0;
            this.btn_TroLyAo.ShowActiveImage = true;
            this.btn_TroLyAo.ShowCursorChanges = true;
            this.btn_TroLyAo.ShowImageBorders = true;
            this.btn_TroLyAo.ShowSizeMarkers = false;
            this.btn_TroLyAo.Size = new System.Drawing.Size(50, 50);
            this.btn_TroLyAo.TabIndex = 1;
            this.btn_TroLyAo.ToolTipText = "";
            this.btn_TroLyAo.WaitOnLoad = false;
            this.btn_TroLyAo.Zoom = 5;
            this.btn_TroLyAo.ZoomSpeed = 10;
            this.btn_TroLyAo.Click += new System.EventHandler(this.btn_TroLyAo_Click);
            // 
            // uC_LienHeScreen1
            // 
            this.uC_LienHeScreen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uC_LienHeScreen1.BackColor = System.Drawing.SystemColors.Window;
            this.uC_LienHeScreen1.Location = new System.Drawing.Point(105, 35);
            this.uC_LienHeScreen1.Name = "uC_LienHeScreen1";
            this.uC_LienHeScreen1.Size = new System.Drawing.Size(834, 550);
            this.uC_LienHeScreen1.TabIndex = 0;
            // 
            // Form_LienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 618);
            this.Controls.Add(this.btn_TroLyAo);
            this.Controls.Add(this.uC_LienHeScreen1);
            this.Name = "Form_LienHe";
            this.Text = "Form_LienHe";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LienHeScreen uC_LienHeScreen1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_TroLyAo;
    }
}