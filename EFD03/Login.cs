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
    public partial class Login : UserControl
    {

        public Login()
        {
            InitializeComponent();

        }

        private void reg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendToBack();
        }
        public static int userId = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            BlogContext context = new BlogContext();
            var user = context.Users
                .Where(user => user.Username == txt_lusername.Text.ToLower()).SingleOrDefault();
            if (user == null)
            {
                MessageBox.Show("Invalid Username", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.Password == txt_lpassword.Text)
                {
                    userId = user.Id;
                    MessageBox.Show("You are Loging Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_lpassword.Text = txt_lusername.Text = "";
                    HomePage home = new HomePage();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
