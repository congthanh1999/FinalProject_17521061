using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061.Forms
{
    public partial class Form_Chatbot : Form
    {
        int currentTop = 10;

        public Form_Chatbot()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void Send()
        {
            if (txt_Message.Text.Trim().Length == 0) return;

            AddOutgoing(txt_Message.Text);
            txt_Message.Text = string.Empty;

            lbl_Status.Text = "Typing";
            timer1.Start();
        }

        void AddIncomming(string message)
        {
            //var bubble = new ChatItem.UC_Incomming();
            //pnl_Container.Controls.Add(bubble);
            //bubble.Dock = DockStyle.Top;
            //bubble.BringToFront();
            //bubble.Message = message;

            //currentTop += bubble.Height;
            
            var bubble = new ChatItem.UC_Incomming();
            pnl_Container.Controls.Add(bubble);
            bubble.Top = currentTop;
            bubble.Width = pnl_Container.Width - 10;
            bubble.Message = message;

            currentTop += bubble.Height;
        }

        void AddOutgoing(string message)
        {
            //var bubble = new ChatItem.UC_Outgoing();
            //pnl_Container.Controls.Add(bubble);
            //bubble.Dock = DockStyle.Top;
            //bubble.BringToFront();
            //bubble.Message = message;

            //currentTop += bubble.Height;

            var bubble = new ChatItem.UC_Outgoing();
            pnl_Container.Controls.Add(bubble);
            bubble.Top = currentTop;
            bubble.Width = pnl_Container.Width - 20;
            bubble.Message = message;

            currentTop += bubble.Height;
        }

        private void txt_Message_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_Status.Text = "Online";

            AddIncomming("Random answer");
        }

        private void Form_Chatbot_Shown(object sender, EventArgs e)
        {
            AddIncomming("Xin chào! Tôi có thể giúp được gì cho bạn?");
        }
    }
}
