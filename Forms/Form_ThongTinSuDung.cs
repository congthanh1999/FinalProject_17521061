using FinalProject_17521061.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            dtp_ThoiGian.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtp_ThoiGian.ShowUpDown = true;
            columns = lbl_ThanhTien.Text.Split('đ');
        }

        private void btn_DatDichVu_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO GIAODICH VALUES (@maTK,@tenDV,@DVVeSinh,@DVNauAn,@DVGiatUi,@diaChi,@ngayDat,@thoiGian,@thanhTien,@danhGia)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@maTK", GlobalProperties.maTK);
            cmd.Parameters.AddWithValue("@tenDV", cbb_DichVu.Text);
            if(cbb_DichVu.SelectedIndex == 0)
            {
                cmd.Parameters.AddWithValue("@DVVeSinh", cbb_TongVeSinh.Text);
                cmd.Parameters.AddWithValue("@DVNauAn", "");
                cmd.Parameters.AddWithValue("@DVGiatUi", "");

            }
            else if(cbb_DichVu.SelectedIndex == 1)
            {
                cmd.Parameters.AddWithValue("@DVVeSinh", "");
                cmd.Parameters.AddWithValue("@DVNauAn", cbb_NauAn.Text);
                cmd.Parameters.AddWithValue("@DVGiatUi", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("@DVVeSinh", "");
                cmd.Parameters.AddWithValue("@DVNauAn", "");
                cmd.Parameters.AddWithValue("@DVGiatUi", txt_GiatUi.Text);
            }
            cmd.Parameters.AddWithValue("@diaChi", txt_DiaChi);
            cmd.Parameters.AddWithValue("@ngayDat", dtp_Ngay.Value.ToString("dd-MM-yyy"));
            cmd.Parameters.AddWithValue("@thoiGian", dtp_ThoiGian.Format.ToString("HH:mm"));
            cmd.Parameters.AddWithValue("@thanhTien", Int32.Parse(columns[0]));
            cmd.Parameters.AddWithValue("@danhGia", 0);
            conn.Open();
            int rowCount = cmd.ExecuteNonQuery();

            if (rowCount>0)
            {

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
    }
}
