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

namespace FinalProject_17521061.Forms
{
    public partial class Form_LienHe : Form
    {
        Form form = new Form_Chatbot();

        public Form_LienHe()
        {
            InitializeComponent();

            form.TopLevel = false;
            form.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.Controls.Add(form);
            //form.BringToFront();
            //form.Location = new Point((this.Width - form.Width), (this.Height - form.Height));
        }

        private void btn_TroLyAo_Click(object sender, EventArgs e)
        {
            //Form form = new Forms.Form_Chatbot();
            //form.TopLevel = false;
            btn_TroLyAo.Visible = false;
            //form.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            //this.Controls.Add(form);
            form.BringToFront();
            form.Location = new Point((this.Width - form.Width), (this.Height - form.Height));
            form.Show();
        }
    }
}
