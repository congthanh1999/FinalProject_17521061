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
    public partial class Form_DangKy : Form
    {
        private LinkLabel currLinkLabel;
        private Form activeForm;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");
        int rowNum;

        public Form_DangKy()
        {
            InitializeComponent();
            string querry1 = "SELECT * FROM THONGTINTAIKHOAN";

            SqlDataAdapter sda = new SqlDataAdapter(querry1, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rowNum = dt.Rows.Count + 1;
            conn.Close();
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

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            try
            {
                string querry1 = "INSERT INTO THONGTINTAIKHOAN(HOTEN, SDT, DIACHI) VALUES (@hoTen, @sdt, @diaChi)\n"
                + "INSERT INTO TAIKHOAN(MATT, EMAIL, PASS) VALUES (@matt, @email, @pass)";

                SqlCommand cmd = new SqlCommand(querry1, conn);

                cmd.Parameters.AddWithValue("@hoTen", txt_HoTen.Text);
                cmd.Parameters.AddWithValue("@sdt", txt_SDT.Text);
                cmd.Parameters.AddWithValue("@diaChi", txt_DiaChi.Text);
                cmd.Parameters.AddWithValue("@matt", rowNum);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@pass", txt_MatKhau.Text);
                conn.Open();

                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công");
                }

                OpenChildForm(new Form_Main(), sender);
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
