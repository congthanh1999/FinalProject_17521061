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
using System.Windows.Forms.VisualStyles;

namespace FinalProject_17521061.Forms
{
    public partial class Form_DoiMatKhau : Form
    {
        private LinkLabel currLinkLabel;
        private Form activeForm;
        bool flag = false;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

        public Form_DoiMatKhau()
        {
            InitializeComponent();
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

        private void Form_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string querry = "UPDATE TAIKHOAN\n SET PASS = '"+txt_MatKhauMoi.Text+"'\nWHERE EMAIL = '" + GlobalProperties.curUsername + "'";
            //    SqlCommand cmd = new SqlCommand(querry, conn);
            //    conn.Open();
            //    SqlDataReader dt = cmd.ExecuteReader();

            //    if (dt.Read())
            //    {
            //        txt_MatKhauCu.Text = dt.GetString(1);
            //        txt_XacNhan.Text = dt.GetString(2);
            //        txt_MatKhauMoi.Text = dt.GetString(5);
            //    }
            //    //else
            //    //{
            //    //    MessageBox.Show("Đăng nhập không thành công");
            //    //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //    //conn.Dispose();
            //    //conn = null;
            //}
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauCu.Text != GlobalProperties.curUserPassword)
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng!");
            }
            else if (txt_MatKhauMoi.Text != txt_XacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận chưa đúng!");
            }
            else
            {
                try
                {
                    string querry = "UPDATE TAIKHOAN\n SET PASS = '" + txt_MatKhauMoi.Text + "'\nWHERE EMAIL = '" + GlobalProperties.curUsername + "'";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@hoTen", txt_MatKhauCu.Text);
                    cmd.Parameters.AddWithValue("@sdt", txt_XacNhan.Text);
                    conn.Open();
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Lưu mật khẩu thành công");
                        OpenChildForm(new Form_ThongTinTaiKhoan(), sender);
                    }
                    else
                    {
                        MessageBox.Show("Lưu mật khẩu không thành công");
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

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
