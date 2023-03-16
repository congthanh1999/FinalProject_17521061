using FinalProject_17521061.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061.Forms
{
    public partial class Form_LichSuGD : Form
    {
        List<LichSuGD> list = Classes.LichSuGD.GetData();

        public Form_LichSuGD()
        {
            InitializeComponent();
        }

        public void addItem(string tenDV, string goiDV, string diaChi, int thanhTien, string ngay, string gio, int danhGia)
        {
            this.flowLayoutPanel1.Controls.Add(new UC_LichSuGD()
            {
                TenDV = tenDV,
                GoiDV = goiDV,
                DiaChi = diaChi,
                ThanhTien = thanhTien,
                Ngay = ngay,
                Gio = gio,
                DanhGia = danhGia
            });
        }

        private void Form_LichSuGD_Load(object sender, EventArgs e)
        {
            foreach (LichSuGD ls in list)
            {
                if (ls.TenDV == "Tổng vệ sinh")
                {
                    addItem(ls.TenDV, ls.DVVeSinh1, ls.DiaChi, ls.ThanhTien, ls.NgayDat, ls.ThoiGian, ls.DanhGia);
                }
                else if (ls.TenDV == "Nấu ăn")
                {
                    addItem(ls.TenDV, ls.DVNauAn1, ls.DiaChi, ls.ThanhTien, ls.NgayDat, ls.ThoiGian, ls.DanhGia);
                }
                else
                {
                    addItem(ls.TenDV, ls.DVGiatUi1, ls.DiaChi, ls.ThanhTien, ls.NgayDat, ls.ThoiGian, ls.DanhGia);
                }
            }
        }
    }
}
