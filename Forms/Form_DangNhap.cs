using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FinalProject_17521061.Classes;

namespace FinalProject_17521061.Forms
{
    public partial class Form_DangNhap : Form
    {
        private LinkLabel currLinkLabel;
        private Form activeForm;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QuenMatKhau(), sender);
        }

        private void ActivateButton(object objSender)
        {
            if (objSender is LinkLabel)
            {
                if (currLinkLabel != (LinkLabel)objSender)
                {
                    currLinkLabel = (LinkLabel)objSender;
                }
            }
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenForm1(Form childForm, object btnSender)
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string dateformat = "SET DATEFORMAT dmy\n";
                string querry = "SELECT *\nFROM THONGTINTAIKHOAN AS TT, TAIKHOAN AS TK\nWHERE TK.MATT = TT.MATT AND EMAIL = '" + txt_Email.Text + "' AND PASS = '" + txt_MatKhau.Text + "'";
                SqlCommand cmd = new SqlCommand(dateformat + querry, conn);
                conn.Open();
                SqlDataReader dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    GlobalProperties.curUsername = txt_Email.Text;
                    GlobalProperties.curName = dt[1].ToString();
                    GlobalProperties.curUserPassword = txt_MatKhau.Text;
                    GlobalProperties.maTK = (int)dt[4];
                    GlobalProperties.isLoggedIn = true;

                    OpenChildForm(new Form_Main(), sender);
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
