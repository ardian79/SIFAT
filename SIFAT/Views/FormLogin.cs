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
            AuthenticationController auth = new AuthenticationController();
            string pesan = auth.Login(txtUsernameLogin.Text, txtPasswordLogin.Text, out Pengguna userLogin);

            if (pesan == "OK")
            {
                FormUtama utama = new FormUtama(userLogin);
                utama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(pesan, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
