using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Bunifu.UI.WinForms.BunifuButton;
using System.Data.SqlClient;
using System.Security.Cryptography;
using FinalProject_17521061.Classes;

namespace FinalProject_17521061.Forms
{
    public partial class Form_QuenMatKhau : Form
    {
        string randomCode;
        public static string to;
        private BunifuButton currentButton;
        private Form activeForm;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");

        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();

            to = (txt_Email.Text).ToString();
            from = "congthanh10021999@gmail.com";
            pass = "djrmtzbgskvuntoa";
            messageBody = "your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);

                string querry = "UPDATE TAIKHOAN\nSET PASS = @pass\nWHERE EMAIL = @email";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@pass", randomCode);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                conn.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("code send successfully: " + randomCode);
                }
                else
                {
                    MessageBox.Show("code send unsuccessfully: " + randomCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            OpenChildForm(new Form_DangNhap(), sender);
        }

        private void ActivateButton(object objSender)
        {
            if (objSender is BunifuButton)
            {
                if (currentButton != (BunifuButton)objSender)
                {
                    currentButton = (BunifuButton)objSender;
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
