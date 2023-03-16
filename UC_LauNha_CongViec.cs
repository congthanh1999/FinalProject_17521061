using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061
{
    public partial class UC_LauNha_CongViec : UserControl
    {
        public event EventHandler Btn_Click;
        private Button currentButton;
        private UserControl activeUsercontrol;

        public UC_LauNha_CongViec()
        {
            InitializeComponent();
        }

        private void btn_CongViecChung_Click(object sender, EventArgs e)
        {
            Btn_Click?.Invoke(this, e);

            OpenChildForm(new Tabs.UC_Tab_CongViecChung(), sender);

            btn_CongViecChung.BackColor = Color.FromArgb(255, 130, 40);
            btn_NhaBep.BackColor = Color.Transparent;
            btn_PhongNgu.BackColor = Color.Transparent;
            btn_NhaTam.BackColor = Color.Transparent;
            btn_TuyChonThem.BackColor = Color.Transparent;

            btn_CongViecChung.ForeColor = Color.White;
            btn_NhaBep.ForeColor = Color.Black;
            btn_PhongNgu.ForeColor = Color.Black;
            btn_NhaTam.ForeColor = Color.Black;
            btn_TuyChonThem.ForeColor = Color.Black;
        }

        private void btn_NhaBep_Click(object sender, EventArgs e)
        {
            Btn_Click?.Invoke(this, e);

            OpenChildForm(new Tabs.UC_Tab_NhaBep(), sender);

            btn_CongViecChung.BackColor = Color.Transparent;
            btn_NhaBep.BackColor = Color.FromArgb(255, 130, 40);
            btn_PhongNgu.BackColor = Color.Transparent;
            btn_NhaTam.BackColor = Color.Transparent;
            btn_TuyChonThem.BackColor = Color.Transparent;

            btn_CongViecChung.ForeColor = Color.Black;
            btn_NhaBep.ForeColor = Color.White;
            btn_PhongNgu.ForeColor = Color.Black;
            btn_NhaTam.ForeColor = Color.Black;
            btn_TuyChonThem.ForeColor = Color.Black;
        }

        private void btn_PhongNgu_Click(object sender, EventArgs e)
        {
            Btn_Click?.Invoke(this, e);

            OpenChildForm(new Tabs.UC_Tab_PhongNgu(), sender);

            btn_CongViecChung.BackColor = Color.Transparent;
            btn_NhaBep.BackColor = Color.Transparent;
            btn_PhongNgu.BackColor = Color.FromArgb(255, 130, 40);
            btn_NhaTam.BackColor = Color.Transparent;
            btn_TuyChonThem.BackColor = Color.Transparent;

            btn_CongViecChung.ForeColor = Color.Black;
            btn_NhaBep.ForeColor = Color.Black;
            btn_PhongNgu.ForeColor = Color.White;
            btn_NhaTam.ForeColor = Color.Black;
            btn_TuyChonThem.ForeColor = Color.Black;
        }

        private void btn_NhaTam_Click(object sender, EventArgs e)
        {
            Btn_Click?.Invoke(this, e);

            OpenChildForm(new Tabs.UC_Tab_NhaTam(), sender);

            btn_CongViecChung.BackColor = Color.Transparent;
            btn_NhaBep.BackColor = Color.Transparent;
            btn_PhongNgu.BackColor = Color.Transparent;
            btn_NhaTam.BackColor = Color.FromArgb(255, 130, 40);
            btn_TuyChonThem.BackColor = Color.Transparent;

            btn_CongViecChung.ForeColor = Color.Black;
            btn_NhaBep.ForeColor = Color.Black;
            btn_PhongNgu.ForeColor = Color.Black;
            btn_NhaTam.ForeColor = Color.White;
            btn_TuyChonThem.ForeColor = Color.Black;
        }

        private void btn_TuyChonThem_Click(object sender, EventArgs e)
        {
            Btn_Click?.Invoke(this, e);

            OpenChildForm(new Tabs.UC_Tab_TuyChon(), sender);

            btn_CongViecChung.BackColor = Color.Transparent;
            btn_NhaBep.BackColor = Color.Transparent;
            btn_PhongNgu.BackColor = Color.Transparent;
            btn_NhaTam.BackColor = Color.Transparent;
            btn_TuyChonThem.BackColor = Color.FromArgb(255, 130, 40);

            btn_CongViecChung.ForeColor = Color.Black;
            btn_NhaBep.ForeColor = Color.Black;
            btn_PhongNgu.ForeColor = Color.Black;
            btn_NhaTam.ForeColor = Color.Black;
            btn_TuyChonThem.ForeColor = Color.White;
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
        }

        private void OpenChildForm(UserControl UC, object btnSender)
        {
            //if (activeUsercontrol != null)
            //{
            //    activeUsercontrol.Close();
            //}
            ActivateButton(btnSender);
            activeUsercontrol = UC;
            //UC.TopLevel = false;
            //UC.FormBorderStyle = FormBorderStyle.None;
            UC.Dock = DockStyle.Fill;
            //UC.Size = new Size(1192, 490);
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(UC);
            this.panel3.Tag = UC;
            UC.SendToBack();
            UC.Show();
        }

        private void InitChildForm(UserControl UC)
        {
            //if (activeUsercontrol != null)
            //{
            //    activeUsercontrol.Close();
            //}
            //ActivateButton(btnSender);
            activeUsercontrol = UC;
            //UC.TopLevel = false;
            //UC.FormBorderStyle = FormBorderStyle.None;
            UC.Dock = DockStyle.Fill;
            //UC.Size = new Size(1192, 490);
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(UC);
            this.panel3.Tag = UC;
            UC.BringToFront();
            UC.Show();
        }

        private void UC_LauNha_CongViec_Load(object sender, EventArgs e)
        {
            InitChildForm(new Tabs.UC_Tab_CongViecChung());
            btn_CongViecChung.BackColor = Color.FromArgb(255, 130, 40);
            btn_CongViecChung.ForeColor = Color.White;
        }
    }
}
