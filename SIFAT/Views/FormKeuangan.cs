using SIFAT.Controllers;
using SIFAT.Models;
using SIFAT.Models;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
                MessageBox.Show("Gagal memuat jenis keuangan: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                List<Keuangan> list = _controller.GetAllKeuangan();
                dgvKeuangan.DataSource = list;

                if (dgvKeuangan.Columns["Id"] != null) dgvKeuangan.Columns["Id"].Visible = false;
                if (dgvKeuangan.Columns["IdPengguna"] != null) dgvKeuangan.Columns["IdPengguna"].Visible = false;
                if (dgvKeuangan.Columns["IdJenisKeuangan"] != null) dgvKeuangan.Columns["IdJenisKeuangan"].Visible = false;
                if (dgvKeuangan.Columns["IsDelete"] != null) dgvKeuangan.Columns["IsDelete"].Visible = false;

                if (dgvKeuangan.Columns["NamaJenis"] != null) dgvKeuangan.Columns["NamaJenis"].HeaderText = "Jenis";
                if (dgvKeuangan.Columns["Kategori"] != null) dgvKeuangan.Columns["Kategori"].HeaderText = "Kategori";
                if (dgvKeuangan.Columns["Tanggal"] != null) dgvKeuangan.Columns["Tanggal"].HeaderText = "Tanggal";
                if (dgvKeuangan.Columns["Jumlah"] != null) dgvKeuangan.Columns["Jumlah"].HeaderText = "Jumlah (Rp)";
                if (dgvKeuangan.Columns["Keterangan"] != null) dgvKeuangan.Columns["Keterangan"].HeaderText = "Keterangan";

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int tinggiHeader = dgvKeuangan.ColumnHeadersHeight;
            int tinggiBaris = dgvKeuangan.RowTemplate.Height;
            int jumlahBaris = dgvKeuangan.Rows.Count;
            dgvKeuangan.Height = tinggiHeader + (tinggiBaris * jumlahBaris) + 5;
        }

        private void btnTambahKeuangan_Click(object sender, EventArgs e)
        {
            if (cmbJenisKeuangan.SelectedValue == null)
            {
                MessageBox.Show("Pilih jenis keuangan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnUbahKeuangan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbJenisKeuangan.SelectedValue == null)
            {
                MessageBox.Show("Pilih jenis keuangan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    MessageBox.Show("Error: " + ex.Message);
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
                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                dtpTanggalKeuangan.Value = Convert.ToDateTime(row.Cells["Tanggal"].Value);
                cmbJenisKeuangan.SelectedValue = Convert.ToInt32(row.Cells["IdJenisKeuangan"].Value);
                txtJumlahKeuangan.Text = row.Cells["Jumlah"].Value.ToString();
                txtKeteranganKeuangan.Text = row.Cells["Keterangan"].Value.ToString();
            }
        }
    }
}
