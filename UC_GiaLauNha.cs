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
    public partial class UC_GiaLauNha : UserControl
    {
        public event EventHandler UC_GiaLauNha_MouseEnter;
        public event EventHandler UC_GiaLauNha_MouseLeave;

        public UC_GiaLauNha()
        {
            InitializeComponent();
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            UC_GiaLauNha_MouseEnter?.Invoke(this, e);

            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.FromArgb(255, 130, 40);
            pnl.ForeColor = Color.White;
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            UC_GiaLauNha_MouseLeave?.Invoke(this, e);

            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.White;
            pnl.ForeColor = Color.Black;
        }
    }
}
