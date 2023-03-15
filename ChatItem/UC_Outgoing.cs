using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061.ChatItem
{
    public partial class UC_Outgoing : UserControl
    {
        public UC_Outgoing()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return lbl_Message.Text; }

            set
            {
                lbl_Message.Text = value;

                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            lbl_Message.Height = Classes.Utils.GetTextHeight(lbl_Message) + 10;

            bunifuUserControl1.Height = lbl_Message.Top + bunifuUserControl1.Top + lbl_Message.Height;

            this.Height = bunifuUserControl1.Bottom + 10;
        }

        //public Image Avatar { get => bunifuPictureBox1.Image; set => bunifuPictureBox1.Image = value; }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void UC_Outgoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
