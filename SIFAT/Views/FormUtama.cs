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
    public partial class FormUtama : Form
    {
        private Pengguna _userLogin;

        public FormUtama(Pengguna user)
        {
            InitializeComponent();
            _userLogin = user;

            if (_userLogin.Role == "Buruh Tani")
            {
                btnDashboard.Visible = false;
                btnLahan.Visible = false;
                btnBuruh.Visible = false;
                btnJenisKeuangan.Visible = false;

                BukaForm(new FormKeuangan(_userLogin));
            }
            else
            {
                BukaFormDashboard();
            }
        }

        private void BukaFormDashboard()
        {
            panelKonten.Controls.Clear();
            FormDashboard formDash = new FormDashboard(_userLogin);
            formDash.TopLevel = false;
            formDash.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(formDash);
            formDash.Show();
        }

        private void BukaForm(Form formAnak)
        {
            panelKonten.Controls.Clear();
            formAnak.TopLevel = false;
            formAnak.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(formAnak);
            formAnak.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BukaFormDashboard();
        }

        private void btnLahan_Click(object sender, EventArgs e)
        {
            BukaForm(new FormLahan());
        }

        private void btnJenisKeuangan_Click(object sender, EventArgs e)
        {
            BukaForm(new FormJenisKeuangan());
        }

        private void btnKeuangan_Click(object sender, EventArgs e)
        {
            BukaForm(new FormKeuangan(_userLogin));
        }

        private void btnBudidaya_Click(object sender, EventArgs e)
        {
            BukaForm(new FormBudidayaTebu());
        }

        private void btnBuruh_Click(object sender, EventArgs e)
        {
            BukaForm(new FormPengguna());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
        }
    }
}