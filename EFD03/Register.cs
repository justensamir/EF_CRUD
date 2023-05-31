using EFD03.Models;
using EFD03.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFD03
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void log_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            BlogContext context = new BlogContext();
            if (txt_password.Text == txt_confpass.Text)
            {
                User user = new User()
                {
                    Name = txt_name.Text,
                    Password = txt_password.Text,
                    ConfirmPassword = txt_confpass.Text,
                    Username = txt_username.Text.ToLower(),
                    Age = int.Parse(txt_age.Text),
                    Address = txt_address.Text
                };
                context.Add(user);
                context.SaveChanges();
                MessageBox.Show("You are Register Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_address.Text = txt_age.Text = txt_confpass.Text = txt_name.Text = txt_password.Text = txt_username.Text = "";
                this.SendToBack();
            }

        }
    }
}
