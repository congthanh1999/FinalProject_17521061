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
        private bool isCollapsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_VeChungToi_MouseHover(object sender, EventArgs e)
        {
            timer_VeChungToi.Start();
        }

        private void btn_VeChungToi_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_VeChungToi.Size = this.pnl_VeChungToi.MinimumSize;
        }

        private void btn_DichVu_MouseHover(object sender, EventArgs e)
        {
            timer_DichVu.Start();
        }

        private void btn_DichVu_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_DichVu.Size = this.pnl_DichVu.MinimumSize;
        }

        private void timer_Dropdown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.pnl_VeChungToi.Height += 20;
                if (this.pnl_VeChungToi.Size == this.pnl_VeChungToi.MaximumSize)
                {
                    timer_VeChungToi.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.pnl_VeChungToi.Height -= 20;
                if (this.pnl_VeChungToi.Size == this.pnl_VeChungToi.MinimumSize)
                {
                    timer_VeChungToi.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void time_DichVu_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.pnl_DichVu.Height += 20;
                if (this.pnl_DichVu.Size == this.pnl_DichVu.MaximumSize)
                {
                    timer_DichVu.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.pnl_DichVu.Height -= 20;
                if (this.pnl_DichVu.Size == this.pnl_DichVu.MinimumSize)
                {
                    timer_DichVu.Stop();
                    isCollapsed = true;
                }
            }
        }


    }
}
