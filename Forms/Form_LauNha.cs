using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_17521061.Classes;

namespace FinalProject_17521061.Forms
{
    public partial class Form_LauNha : Form
    {
        private Rectangle originalFormSize;
        private Rectangle bigPictureOriginalSize;
        private string filePath = "D:\\A_jerry\\Github\\FinalProject_17521061\\bin\\Debug\\image\\cach-lau-san-sach-se-696x372.jpg";

        public Form_LauNha()
        {
            InitializeComponent();
        }

        private void Form_LauNha_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            bigPictureOriginalSize = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Image.Width, pictureBox1.Image.Height);
        }

        private void Form_LauNha_Resize(object sender, EventArgs e)
        {
            //Bitmap bm = ImageUtils.ScaleImage(pictureBox1.Image, this.Width, this.Height);
            //pictureBox1.Image = bm;

            //ImageUtils.Resize_Picture(filePath, this.Width, this.Height, 100);
        }

        private void btn_SuDungDichVu_Click(object sender, EventArgs e)
        {

        }
    }
}
