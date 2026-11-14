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
                dgvJenisKeuangan.DataSource = list;

                if (dgvJenisKeuangan.Columns["Id"] != null) dgvJenisKeuangan.Columns["Id"].Visible = false;
                if (dgvJenisKeuangan.Columns["NamaJenis"] != null) dgvJenisKeuangan.Columns["NamaJenis"].HeaderText = "Nama Jenis";
                if (dgvJenisKeuangan.Columns["Kategori"] != null) dgvJenisKeuangan.Columns["Kategori"].HeaderText = "Kategori";
                if (dgvJenisKeuangan.Columns["IsDelete"] != null) dgvJenisKeuangan.Columns["IsDelete"].Visible = false;

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int tinggiHeader = dgvJenisKeuangan.ColumnHeadersHeight;
            int tinggiBaris = dgvJenisKeuangan.RowTemplate.Height;
            int jumlahBaris = dgvJenisKeuangan.Rows.Count;
            dgvJenisKeuangan.Height = tinggiHeader + (tinggiBaris * jumlahBaris) + 5;
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
                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNamaJenis.Text = row.Cells["NamaJenis"].Value.ToString();
                cmbKategoriJenis.SelectedItem = row.Cells["Kategori"].Value.ToString();
            }
        }
    }
}
