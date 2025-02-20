using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class FormLogin : Form
    {
        public static string username;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            tbUsername.Text = "john_doe";
            tbPassword.Text = "john_doe";
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private string convertToSHA512(string text)
        {
            using (var sha = new SHA512CryptoServiceProvider())
            {
                byte[] data = sha.ComputeHash(Encoding.ASCII.GetBytes(text));
                var sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty || tbPassword.Text == string.Empty)
            {
                Support.msw("field must be filled");
            }

            else
            {

                var db = new DataBaseDataContext();
                var query = db.users.FirstOrDefault(x => x.username == tbUsername.Text && x.password == convertToSHA512(tbPassword.Text));

                if (query != null)
                {
                    username = query.username;
                    new FormMain().Show();
                    Hide();
                }
                else
                {
                    Support.msw("username/password is wrong");
                }
            }

        }
    }
}
