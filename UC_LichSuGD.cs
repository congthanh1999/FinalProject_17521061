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

namespace FinalProject_17521061
{
    public partial class UC_LichSuGD : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

        public UC_LichSuGD()
        {
            InitializeComponent();
        }

        public string TenDV { get => lbl_TenDV.Text; set => lbl_TenDV.Text = value; }
        public string GoiDV { get => lbl_GoiDichVu.Text; set => lbl_GoiDichVu.Text = value; }
        public string DiaChi { get => lbl_DiaChi.Text; set => lbl_DiaChi.Text = value; }
        public int ThanhTien { get => Int32.Parse(lbl_ThanhTien.Text); set => lbl_ThanhTien.Text = value.ToString(); }
        public string Ngay { get => lbl_Ngay.Text; set => lbl_Ngay.Text = value; }
        public string Gio { get => lbl_ThoiGian.Text; set => lbl_GoiDichVu.Text = value; }
        public int DanhGia { get => rate_DanhGia.Value; set => rate_DanhGia.Value = value; }

        private void rate_DanhGia_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Value.ToString());
            try
            {
                string querry = "UPDATE GIAODICH\nSET DANHGIA = '" + rate_DanhGia.Value + "'\nWHERE MAGD = ";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
