using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061.Classes
{
    internal class LichSuGD
    {
        private int maGD;
        private string tenDV;
        private string DVVeSinh;
        private string DVNauAn;
        private string DVGiatUi;
        private string diaChi;
        private string ngayDat;
        private string thoiGian;
        private int thanhTien;
        private int danhGia;

        public LichSuGD() { }

        public LichSuGD(int maGD, string tenDV, string dVVeSinh, string dVNauAn, string dVGiatUi, string diaChi, string ngayDat, string thoiGian, int thanhTien, int danhGia)
        {
            this.maGD = maGD;
            this.tenDV = tenDV;
            DVVeSinh = dVVeSinh;
            DVNauAn = dVNauAn;
            DVGiatUi = dVGiatUi;
            this.diaChi = diaChi;
            this.ngayDat = ngayDat;
            this.thoiGian = thoiGian;
            this.thanhTien = thanhTien;
            this.danhGia = danhGia;
        }

        public int MaGD { get => maGD; set => maGD = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string DVVeSinh1 { get => DVVeSinh; set => DVVeSinh = value; }
        public string DVNauAn1 { get => DVNauAn; set => DVNauAn = value; }
        public string DVGiatUi1 { get => DVGiatUi; set => DVGiatUi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgayDat { get => ngayDat; set => ngayDat = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int DanhGia { get => danhGia; set => danhGia = value; }

        public static List<LichSuGD> GetData()
        {
            List<LichSuGD> list = new List<LichSuGD>();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

            try
            {
                string querry = "SELECT * FROM GIAODICH WHERE MATK = '" + GlobalProperties.maTK + "'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader dt= cmd.ExecuteReader();

                while (dt.Read())
                {
                    LichSuGD ls = new LichSuGD(Int32.Parse(dt[0].ToString()),dt[2].ToString(), dt[3].ToString(), dt[4].ToString(), dt[5].ToString(), dt[6].ToString(), dt[7].ToString(), dt[8].ToString(), Int32.Parse(dt[9].ToString()), Int32.Parse(dt[10].ToString()));
                    list.Add(ls);
                }
            }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            finally
            {
                conn.Close();
            }
            return list;
        }
    }
}
