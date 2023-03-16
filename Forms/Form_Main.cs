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
    public partial class Form_Main : Form
    {
        private Rectangle originalFormSize;
        private Rectangle bigPictureOriginalSize;
        private Button currentButton;
        private Form activeForm;
        private Label currentLabel;
        private PictureBox currentPicture;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            //int newX = (int)(r.Location.X * xRatio);
            //int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(0, 0);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            bigPictureOriginalSize = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Image.Width, pictureBox2.Image.Height);
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            //ResizeControl(bigPictureOriginalSize, pictureBox2);
        }

        private void ActivateButton(object objSender)
        {
            if (objSender is Button)
            {
                if (currentButton != (Button)objSender)
                {
                    currentButton = (Button)objSender;
                }
            }
            else if (objSender is PictureBox)
            {
                if (currentPicture != (PictureBox)objSender)
                {
                    currentPicture = (PictureBox)objSender;
                }
            }
            else if (objSender is Label)
            {
                if (currentLabel != (Label)objSender)
                {
                    currentLabel = (Label)objSender;
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
            this.Controls.Clear();
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void btn_SuDungDV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ThongTinSuDung(), sender);
        }
    }
}
