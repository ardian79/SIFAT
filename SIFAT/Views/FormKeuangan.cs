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
    public partial class FormKeuangan : Form
    {
        private KeuanganController _controller = new KeuanganController();
        private Pengguna _userLogin;
        private int _selectedId = 0;

        public FormKeuangan(Pengguna user)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            colJumlah.DefaultCellStyle.Format = "N0";
            colTanggal.DefaultCellStyle.Format = "dd/MMM/yyyy";

            _userLogin = user;

            LoadComboJenis();
            LoadData();
        }

        private void LoadComboJenis()
        {
            try
            {
                List<JenisKeuangan> listJenis = _controller.GetListJenisKeuangan();
                cmbJenisKeuangan.DataSource = listJenis;
                cmbJenisKeuangan.DisplayMember = "NamaJenis";
                cmbJenisKeuangan.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jenis keuangan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                List<Keuangan> list = _controller.GetAllKeuangan();
                dgvKeuangan.AutoGenerateColumns = false;
                dgvKeuangan.DataSource = list;

                if (dgvKeuangan.Columns["colNamaPengguna"] != null)
                {
                    dgvKeuangan.Columns["colNamaPengguna"].Visible = _userLogin.BisaLihatPenginput();
                }

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturTinggiTabel()
        {
            int totalHeight = dgvKeuangan.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvKeuangan.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }
            totalHeight += 2;

            bool hasHScroll = false;
            foreach (Control c in dgvKeuangan.Controls)
            {
                if (c is HScrollBar && c.Visible) { hasHScroll = true; break; }
            }
            if (hasHScroll) totalHeight += SystemInformation.HorizontalScrollBarHeight;

            dgvKeuangan.Height = totalHeight;
        }

        private void btnTambahKeuangan_Click(object sender, EventArgs e)
        {
            if (cmbJenisKeuangan.SelectedValue == null)
            {
                MessageBox.Show("Pilih jenis keuangan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idJenis = Convert.ToInt32(cmbJenisKeuangan.SelectedValue);
                string pesan = _controller.TambahKeuangan(_userLogin.Id, idJenis, dtpTanggalKeuangan.Value, txtJumlahKeuangan.Text, txtKeteranganKeuangan.Text);

                if (pesan == "OK")
                {
                    MessageBox.Show("Transaksi berhasil dicatat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetKeuangan_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencatat transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahKeuangan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbJenisKeuangan.SelectedValue == null)
            {
                MessageBox.Show("Jenis keuangan sebelumnya sudah tidak aktif. Pilih jenis keuangan yang aktif terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idJenis = Convert.ToInt32(cmbJenisKeuangan.SelectedValue);
                string pesan = _controller.UbahKeuangan(_selectedId, idJenis, dtpTanggalKeuangan.Value, txtJumlahKeuangan.Text, txtKeteranganKeuangan.Text);

                if (pesan == "OK")
                {
                    MessageBox.Show("Transaksi berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetKeuangan_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusKeuangan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusKeuangan(_selectedId);
                    MessageBox.Show("Transaksi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetKeuangan_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetKeuangan_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            dtpTanggalKeuangan.Value = DateTime.Now;
            if (cmbJenisKeuangan.Items.Count > 0) cmbJenisKeuangan.SelectedIndex = 0;
            txtJumlahKeuangan.Clear();
            txtKeteranganKeuangan.Clear();
            dgvKeuangan.ClearSelection();
        }

        private void dgvKeuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKeuangan.Rows[e.RowIndex];
                if (row.Cells["colId"].Value == null || row.Cells["colId"].Value == DBNull.Value) return;

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
                dtpTanggalKeuangan.Value = Convert.ToDateTime(row.Cells["colTanggal"].Value);

                int idJenis = Convert.ToInt32(row.Cells["colIdJenisKeuangan"].Value);
                cmbJenisKeuangan.SelectedValue = idJenis;
                if (cmbJenisKeuangan.SelectedValue == null || Convert.ToInt32(cmbJenisKeuangan.SelectedValue) != idJenis)
                {
                    cmbJenisKeuangan.SelectedIndex = -1;
                }

                txtJumlahKeuangan.Text = row.Cells["colJumlah"].Value?.ToString() ?? string.Empty;
                txtKeteranganKeuangan.Text = row.Cells["colKeterangan"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
