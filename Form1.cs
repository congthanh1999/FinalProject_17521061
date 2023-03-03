using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_17521061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_VeChungToi_MouseHover(object sender, EventArgs e)
        {
            this.pnl_VeChungToiMenu.Height = 144;
            timer_VeChungToi.Start();
        }

        private void btn_VeChungToi_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_VeChungToiMenu.Height = 64;
            timer_VeChungToi.Stop();
        }

        private void timer_VeChungToi_Tick(object sender, EventArgs e)
        {
            if(this.pnl_VeChungToiMenu.Height > 144)
            {
                timer_VeChungToi.Stop();
            }
            else
            {
                this.pnl_VeChungToiMenu.Height = 144;
                this.pnl_VeChungToiMenu.Height += 5;
            }
        }
    }
}
