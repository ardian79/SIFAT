using SIFAT.Controllers;
using SIFAT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIFAT.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Text = "SIFAT - Login";
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void btnMasukLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AuthenticationController auth = new AuthenticationController();
                string pesan = auth.Login(txtUsernameLogin.Text.Trim(), txtPasswordLogin.Text, out Pengguna userLogin);

                if (pesan == "OK")
                {
                    FormUtama utama = new FormUtama(userLogin);
                    utama.FormClosed += (s, args) =>
                    {
                        if (utama.IsLogout)
                        {
                            txtUsernameLogin.Clear();
                            txtPasswordLogin.Clear();
                            txtUsernameLogin.Focus();
                            this.Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    };

                    utama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(pesan, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
