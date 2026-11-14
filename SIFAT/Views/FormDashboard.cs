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
    public partial class FormDashboard : Form
    {
        private DashboardController _controller = new DashboardController();
        private Pengguna _userLogin;

        public FormDashboard(Pengguna user)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            _userLogin = user;
            lblSelamatDatang.Text = "Selamat Datang, " + _userLogin.NamaLengkap;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                decimal pemasukan = _controller.GetTotalPemasukan();
                decimal pengeluaran = _controller.GetTotalPengeluaran();
                decimal saldo = pemasukan - pengeluaran;

                lblTotalPemasukan.Text = "Rp " + pemasukan.ToString("N0");
                lblTotalPengeluaran.Text = "Rp " + pengeluaran.ToString("N0");
                lblSaldo.Text = "Rp " + saldo.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message);
            }
        }
    }
}

