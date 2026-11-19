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
        private Form _formAktif;

        public bool IsLogout { get; private set; } = false;

        public FormUtama(Pengguna user)
        {
            InitializeComponent();
            _userLogin = user;
            this.Text = $"SIFAT - {_userLogin.NamaLengkap} ({_userLogin.GetHakAkses()})";

            if (!_userLogin.BisaAksesMenuAdmin())
            {
                btnDashboard.Visible = false;
                btnLahan.Visible = false;
                btnBuruh.Visible = false;
                btnJenisKeuangan.Visible = false;

                BukaForm(new FormKeuangan(_userLogin));
            }
            else
            {
                BukaForm(new FormDashboard(_userLogin));
            }
        }

        private void BukaForm(Form formAnak)
        {
            if (_formAktif != null)
            {
                _formAktif.Close();
                _formAktif.Dispose();
            }

            _formAktif = formAnak;
            panelKonten.Controls.Clear();
            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(formAnak);
            formAnak.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BukaForm(new FormDashboard(_userLogin));
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
            BukaForm(new FormBudidayaTebu(_userLogin));
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
                IsLogout = true;
                this.Close();
            }
        }
    }
}
