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
    public partial class FormJenisKeuangan : Form
    {
        private JenisKeuanganController _controller = new JenisKeuanganController();
        private int _selectedId = 0;

        public FormJenisKeuangan()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            cmbKategoriJenis.Items.Clear();
            cmbKategoriJenis.Items.AddRange(new string[] { "Pemasukan", "Pengeluaran" });
            cmbKategoriJenis.SelectedIndex = 1;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<JenisKeuangan> list = _controller.GetAllJenis();
                dgvJenisKeuangan.AutoGenerateColumns = false;
                dgvJenisKeuangan.DataSource = list;

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int totalHeight = dgvJenisKeuangan.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvJenisKeuangan.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }
            totalHeight += 2;

            bool hasHScroll = false;
            foreach (Control c in dgvJenisKeuangan.Controls)
            {
                if (c is HScrollBar && c.Visible) { hasHScroll = true; break; }
            }
            if (hasHScroll) totalHeight += SystemInformation.HorizontalScrollBarHeight;

            int maxHeight = this.ClientSize.Height - dgvJenisKeuangan.Top - 20;
            dgvJenisKeuangan.Height = Math.Min(totalHeight, maxHeight);
            dgvJenisKeuangan.BackgroundColor = Color.White;
        }

        private void btnTambahJenisKeuangan_Click(object sender, EventArgs e)
        {
            string kategori = cmbKategoriJenis.SelectedItem.ToString();
            string pesan = _controller.TambahJenis(txtNamaJenis.Text, kategori);
            if (pesan == "OK")
            {
                MessageBox.Show("Data Jenis Keuangan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnResetJenisKeuangan_Click(null, null);
            }
            else
            {
                MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbahJenisKeuangan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string kategori = cmbKategoriJenis.SelectedItem.ToString();
            string pesan = _controller.UbahJenis(_selectedId, txtNamaJenis.Text, kategori);
            if (pesan == "OK")
            {
                MessageBox.Show("Data Jenis Keuangan berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnResetJenisKeuangan_Click(null, null);
            }
            else
            {
                MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapusJenisKeuangan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Yakin ingin menghapus jenis keuangan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusJenis(_selectedId);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetJenisKeuangan_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnResetJenisKeuangan_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            txtNamaJenis.Clear();
            cmbKategoriJenis.SelectedIndex = 1;
            dgvJenisKeuangan.ClearSelection();
        }

        private void dgvJenisKeuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvJenisKeuangan.Rows[e.RowIndex];
                if (row.Cells["Id"].Value == null || row.Cells["Id"].Value == DBNull.Value) return;

                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNamaJenis.Text = row.Cells["NamaJenis"].Value.ToString();
                cmbKategoriJenis.SelectedItem = row.Cells["Kategori"].Value.ToString();
            }
        }
    }
}
