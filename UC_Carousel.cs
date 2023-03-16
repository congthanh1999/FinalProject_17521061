using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061
{
    public partial class UC_Carousel : UserControl
    {
        public event EventHandler UC_Carousel_Button_Click;
        public event EventHandler UC_Carousel_MouseEnter;
        public event EventHandler UC_Carousel_MouseLeave;

        public UC_Carousel()
        {
            InitializeComponent();
        }

        private int imageNum = 1;

        private void LoadNextImage()
        {
            timer1.Start();
            imageNum++;
            if (imageNum > 5)
            {
                imageNum = 1;
            }
            pic_Slider.ImageLocation = String.Format(@"D:\A_jerry\Github\FinalProject_17521061\img\" + imageNum + ".png");
        }

        private void LoadPrevImage()
        {
            timer1.Start();
            imageNum--;
            if (imageNum < 1)
            {
                imageNum = 5;
            }
            pic_Slider.ImageLocation = String.Format(@"D:\A_jerry\Github\FinalProject_17521061\img\" + imageNum + ".png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            UC_Carousel_Button_Click?.Invoke(this, e);

            timer1.Stop();
            LoadPrevImage();
        }

        private void UC_Carousel_Load(object sender, EventArgs e)
        {
            pic_Slider.ImageLocation = String.Format(@"D:\A_jerry\Github\FinalProject_17521061\img\" + imageNum + ".png");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            UC_Carousel_Button_Click?.Invoke(this, e);

            timer1.Stop();
            LoadNextImage();
        }

        private void pic_Slider_MouseEnter(object sender, EventArgs e)
        {
            UC_Carousel_MouseEnter?.Invoke(this, e);

            lbl_TomTat.Visible = true;
            timer1.Stop();

            switch (imageNum)
            {
                case 1:
                    lbl_TomTat.Text = "Xử lý chuyên xâu mọi vết bẩn trong căn nhà của bạn với từ 2 cộng tác viên giúp việc nhà trở lên.";
                    break;
                case 2:
                    lbl_TomTat.Text = "Việc mua sắm thực phẩm và đồ dùng gia đình trở nên tiện lợi hơn bao giờ hết. Giao hàng tận nơi chỉ sau 1h.";
                    break;
                case 3:
                    lbl_TomTat.Text = "Mang đến bữa ăn gia đình ấm áp, tròn vị mỗi khi cuộc sống quá bận rộn.";
                    break;
                case 4:
                    lbl_TomTat.Text = "Là dịch vụ đầu tiên bTaskee triển khai. Giờ đây công việc dọn dẹp không còn là nỗi bận tâm, bạn sẽ có nhiều thời gian nghỉ ngơi và tận hưởng cuộc sống.";
                    break;
                case 5:
                    lbl_TomTat.Text = "Giúp bạn làm sạch quần áo nhanh chóng, cùng tiện ích giao nhận tận nơi.";
                    break;
                default:
                    break;
            }
        }

        private void pic_Slider_MouseLeave(object sender, EventArgs e)
        {
            UC_Carousel_MouseLeave?.Invoke(this, e);

            lbl_TomTat.Visible = false;
            timer1.Start();
        }
    }
}
