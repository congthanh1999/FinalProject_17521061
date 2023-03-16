using FinalProject_17521061.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        private Button currentButton;
        private Form activeForm;
        private Label currentLabel;
        private PictureBox currentPicture;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DichVu_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_DichVu.Size = this.pnl_DichVu.MinimumSize;
        }

        private void timer_Dropdown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.pnl_VeChungToi_Dropdown.Height += 20;
                if (this.pnl_VeChungToi_Dropdown.Size == this.pnl_VeChungToi_Dropdown.MaximumSize)
                {
                    timer_VeChungToi.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.pnl_VeChungToi_Dropdown.Height -= 20;
                if (this.pnl_VeChungToi_Dropdown.Size == this.pnl_VeChungToi_Dropdown.MinimumSize)
                {
                    timer_VeChungToi.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void time_DichVu_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.pnl_DichVu_Dropdown.Height += 20;
                if (this.pnl_DichVu_Dropdown.Size == this.pnl_DichVu_Dropdown.MaximumSize)
                {
                    timer_DichVu.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.pnl_DichVu_Dropdown.Height -= 20;
                if (this.pnl_DichVu_Dropdown.Size == this.pnl_DichVu_Dropdown.MinimumSize)
                {
                    timer_DichVu.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn_DichVu_MouseHover(object sender, EventArgs e)
        {
            timer_DichVu.Start();
        }

        private void btn_VeChungToi_MouseHover(object sender, EventArgs e)
        {
            timer_VeChungToi.Start();
        }

        private void btn_VeChungToi_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_DichVu.Size = this.pnl_DichVu.MinimumSize;
        }

        private void ActivateButton(object objSender)
        {
            if (objSender is Button)
            {
                if (currentButton != (Button)objSender)
                {
                    currentButton = (Button)objSender;
                }
            }
            else if (objSender is PictureBox)
            {
                if (currentPicture != (PictureBox)objSender)
                {
                    currentPicture = (PictureBox)objSender;
                }
            }
            else if(objSender is Label)
            {
                if(currentLabel != (Label)objSender)
                {
                    currentLabel = (Label)objSender;
                }
            }
        }

        private void DisableButton(object btnSender)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Main.Controls.Add(childForm);
            this.panel_Main.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void OpenMainForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Main.Controls.Add(childForm);
            this.panel_Main.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void btn_LienHe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_LienHe(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenMainForm(new Forms.Form_Main(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Main(), sender);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_DangNhap(), sender);
        }

        private void btn_LauNha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_LauNha(), sender);
        }

        private void btn_DiCho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_DiCho(), sender);
        }

        private void btn_GiatUi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_GiatUi(), sender);
        }

        private void btn_NauAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_NauAn(), sender);
        }

        private void btn_NoiTro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_NoiTro(), sender);
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_DangKy(), sender);
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_ThongTinTaiKhoan(), sender);
        }
    }
}
