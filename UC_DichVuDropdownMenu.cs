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
    public partial class UC_DichVuDropdownMenu : UserControl
    {
        public event EventHandler UC_DichVuDropdownMenu_MouseEnter;
        public event EventHandler UC_DichVuDropdownMenu_MouseLeave;
        public UC_DichVuDropdownMenu()
        {
            InitializeComponent();
        }

        private void UC_MouseEnter(object sender, EventArgs e)
        {
            UC_DichVuDropdownMenu_MouseEnter?.Invoke(this, e);

            if (this.Height == 40)
            {
                this.Height = 240;
            }
        }

        private void UC_MouseLeave(object sender, EventArgs e)
        {
            UC_DichVuDropdownMenu_MouseLeave?.Invoke(this, e);

            if (this.Height == 240)
            {
                this.Height = 40;
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (this.Height == 40)
            {
                this.Height = 240;
            }
        }
    }
}
