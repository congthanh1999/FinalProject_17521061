using FinalProject_17521061.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061.Forms
{
    public partial class Form_ThongTinSuDung : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");
        string[] columns;


        public Form_ThongTinSuDung()
        {
            InitializeComponent();
            dtp_ThoiGian.Format = DateTimePickerFormat.Custom;
            dtp_ThoiGian.CustomFormat = "HH:mm";
            dtp_ThoiGian.ShowUpDown = true;
        }

        private void btn_DatDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                string dateFormat = "SET DATEFORMAT dmy\n";
                string querry = "INSERT INTO GIAODICH(MATK,TENDV,DVVESINH,DVNAUAN,DVGIATUI,DIACHI,NGAYDAT,THOIGIAN,THANHTIEN,DANHGIA) VALUES (@maTK,@tenDV,@DVVeSinh,@DVNauAn,@DVGiatUi,@diaChi,@ngayDat,@thoiGian,@thanhTien,@danhGia)";
                SqlCommand cmd = new SqlCommand(dateFormat + querry, conn);
                cmd.Parameters.AddWithValue("@maTK", GlobalProperties.maTK);
                cmd.Parameters.AddWithValue("@tenDV", cbb_DichVu.Text);
                if (cbb_DichVu.SelectedIndex == 0)
                {
                    cmd.Parameters.AddWithValue("@DVVeSinh", cbb_TongVeSinh.Text);
                    cmd.Parameters.AddWithValue("@DVNauAn", "");
                    cmd.Parameters.AddWithValue("@DVGiatUi", "");

                }
                else if (cbb_DichVu.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@DVVeSinh", "");
                    cmd.Parameters.AddWithValue("@DVNauAn", cbb_NauAn.Text);
                    cmd.Parameters.AddWithValue("@DVGiatUi", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DVVeSinh", "");
                    cmd.Parameters.AddWithValue("@DVNauAn", "");
                    cmd.Parameters.AddWithValue("@DVGiatUi", txt_GiatUi.Text + " kg");
                }
                cmd.Parameters.AddWithValue("@diaChi", txt_DiaChi.Text);
                cmd.Parameters.AddWithValue("@ngayDat", dtp_Ngay.Value.ToString("d"));
                cmd.Parameters.AddWithValue("@thoiGian", dtp_ThoiGian.Value.ToString("t"));
                columns = lbl_ThanhTien.Text.Split('đ', ',');
                //cmd.Parameters.AddWithValue("@thanhTien", Int32.Parse(columns[0] + columns[1] + columns[2]));
                string money = "";
                for (int i = 0; i < columns.Length; i++)
                {
                    money += columns[i];
                }
                cmd.Parameters.AddWithValue("@thanhTien", Int32.Parse(money));
                cmd.Parameters.AddWithValue("@danhGia", 0);
                conn.Open();
                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount > 0)
                {

                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            finally
            {
                conn.Close();
            }
        }

        private void cbb_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_DichVu.SelectedIndex == 0)
            {
                cbb_TongVeSinh.Visible = true;
            }
            switch (cbb_DichVu.SelectedIndex)
            {
                case 0:
                    cbb_TongVeSinh.Visible = true;
                    cbb_NauAn.Visible = false;
                    txt_GiatUi.Visible = false;
                    break;
                case 1:
                    cbb_TongVeSinh.Visible = false;
                    cbb_NauAn.Visible = true;
                    txt_GiatUi.Visible = false;
                    break;
                case 2:
                    cbb_TongVeSinh.Visible = false;
                    cbb_NauAn.Visible = false;
                    txt_GiatUi.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void cbb_TongVeSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_TongVeSinh.SelectedIndex)
            {
                case 0:
                    lbl_ThanhTien.Text = "450,000đ";
                    break;
                case 1:
                    lbl_ThanhTien.Text = "600,000đ";
                    break;
                case 2:
                    lbl_ThanhTien.Text = "675,000đ";
                    break;
                case 3:
                    lbl_ThanhTien.Text = "900,000đ";
                    break;
                case 4:
                    lbl_ThanhTien.Text = "1,200,000đ";
                    break;
                case 5:
                    lbl_ThanhTien.Text = "2,640,000đ";
                    break;
                default:
                    break;
            }
        }

        private void cbb_NauAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_NauAn.SelectedIndex)
            {
                case 0:
                    lbl_ThanhTien.Text = "140,000đ";
                    break;
                case 1:
                    lbl_ThanhTien.Text = "175,000đ";
                    break;
                case 2:
                    lbl_ThanhTien.Text = "210,000đ";
                    break;
                case 3:
                    lbl_ThanhTien.Text = "245,000đ";
                    break;
                default:
                    break;
            }
        }

        private void btn_DiaChiMoi_Click(object sender, EventArgs e)
        {
            txt_DiaChi.ReadOnly = false;
        }

        private void Form_ThongTinSuDung_Load(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT TK.MATK, TT.DIACHI FROM THONGTINTAIKHOAN AS TT, TAIKHOAN AS TK WHERE TT.MATT = TK.MATT AND TK.MATK = '" + GlobalProperties.maTK + "'";
                SqlCommand cmd = new SqlCommand(querry, Classes.DBConnection.GetConnection());
                //conn.Open();
                SqlDataReader dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    txt_DiaChi.Text = dt[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_GiatUi_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_GiatUi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_ThanhTien.Text = ((int)(20000 * float.Parse(txt_GiatUi.Text) + 30000)).ToString() + "đ";
            }
        }
    }
}
