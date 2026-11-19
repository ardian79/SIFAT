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
            lblSelamatDatang.Text = $"Selamat Datang, {_userLogin.NamaLengkap} ({_userLogin.GetHakAkses()})";

            dgvTransaksiTerbaru.ScrollBars = ScrollBars.None;
            dgvTransaksiTerbaru.AllowUserToResizeRows = false;
            dgvTransaksiTerbaru.RowHeadersVisible = false;
            colJumlah.DefaultCellStyle.Format = "N0";
            colTanggal.DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgvTransaksiTerbaru.DataBindingComplete += (s, e) =>
            {
                AturTinggiTabel();
                dgvTransaksiTerbaru.ClearSelection();
            };

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

                List<Keuangan> recentList = _controller.GetRecentKeuangan(5);
                dgvTransaksiTerbaru.AutoGenerateColumns = false;
                dgvTransaksiTerbaru.DataSource = recentList;

                if (dgvTransaksiTerbaru.Columns["colNamaPengguna"] != null)
                {
                    dgvTransaksiTerbaru.Columns["colNamaPengguna"].Visible = _userLogin.BisaLihatPenginput();
                }

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int rowsHeight = dgvTransaksiTerbaru.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int totalHeight = dgvTransaksiTerbaru.ColumnHeadersHeight + rowsHeight + 2;

            dgvTransaksiTerbaru.Height = totalHeight;
        }
    }
}
