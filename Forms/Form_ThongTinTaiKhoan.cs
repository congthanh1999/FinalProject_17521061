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
    public partial class Form_ThongTinTaiKhoan : Form
    {
        private LinkLabel currLinkLabel;
        private Form activeForm;
        bool flag = false;
        private bool nameChanged = false;
        private bool sdtChanged = false;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

        public Form_ThongTinTaiKhoan()
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
            try
            {
                string querry = "SELECT *\nFROM THONGTINTAIKHOAN AS TT, TAIKHOAN AS TK\nWHERE TK.MATT = TT.MATT AND EMAIL = '" + GlobalProperties.curUsername + "'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    txt_HoTen.Text = dt.GetString(1);
                    txt_SDT.Text = dt.GetString(2);
                    txt_Email.Text = dt.GetString(6);
                    txt_DiaChi.Text = dt.GetString(3);
                }
                //else
                //{
                //    MessageBox.Show("Đăng nhập không thành công");
                //}
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

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                //txt_Email.ReadOnly = false;
                txt_HoTen.ReadOnly = false;
                txt_SDT.ReadOnly = false;
                txt_DiaChi.ReadOnly = false;
                btn_ChinhSua.Text = "Lưu thông tin";
                flag = true;


            }
            else
            {
                if (nameChanged || sdtChanged)
                {
                    try
                    {
                        string querry = "UPDATE THONGTINTAIKHOAN\nSET HOTEN = @hoTen, SDT = @sdt, DIACHI = @diaChi\nFROM THONGTINTAIKHOAN TT, TAIKHOAN TK\nWHERE TT.MATT = TK.MATT AND TK.EMAIL='" + Classes.GlobalProperties.curUsername + "'";
                        SqlCommand cmd = new SqlCommand(querry, conn);
                        cmd.Parameters.AddWithValue("@hoTen", txt_HoTen.Text);
                        cmd.Parameters.AddWithValue("@sdt", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@diaChi", txt_DiaChi.Text);
                        conn.Open();
                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0)
                        {
                            MessageBox.Show("Lưu thông tin thành công");
                        }
                        else
                        {
                            MessageBox.Show("Lưu thông tin không thành công");
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

                //txt_Email.ReadOnly = true;
                txt_HoTen.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;

                btn_ChinhSua.Text = "Sửa thông tin";
                flag = false;
            }
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {
            nameChanged = true;
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            sdtChanged = true;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_DoiMatKhau(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_LichSuGD(), sender);
        }
    }
}
