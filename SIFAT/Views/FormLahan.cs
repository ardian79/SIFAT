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
    public partial class FormLahan : Form
    {
        private LahanController _controller = new LahanController();
        private int _selectedId = 0;

        public FormLahan()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            colLuas.DefaultCellStyle.Format = "0.##";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Lahan> list = _controller.GetAllLahan();
                dgvLahan.AutoGenerateColumns = false;
                dgvLahan.DataSource = list;

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturTinggiTabel()
        {
            int totalHeight = dgvLahan.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvLahan.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }
            totalHeight += 2;

            bool hasHScroll = false;
            foreach (Control c in dgvLahan.Controls)
            {
                if (c is HScrollBar && c.Visible) { hasHScroll = true; break; }
            }
            if (hasHScroll) totalHeight += SystemInformation.HorizontalScrollBarHeight;

            dgvLahan.Height = totalHeight;
            dgvLahan.BackgroundColor = Color.White;
        }

        private void btnTambahLahan_Click(object sender, EventArgs e)
        {
            try
            {
                string pesan = _controller.TambahLahan(txtNamaLahan.Text, txtLuasLahan.Text, txtCatatanLahan.Text);
                if (pesan == "OK")
                {
                    MessageBox.Show("Data Lahan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetLahan_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data lahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahLahan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string pesan = _controller.UbahLahan(_selectedId, txtNamaLahan.Text, txtLuasLahan.Text, txtCatatanLahan.Text);
                if (pesan == "OK")
                {
                    MessageBox.Show("Data Lahan berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetLahan_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data lahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusLahan_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus lahan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusLahan(_selectedId);
                    MessageBox.Show("Data Lahan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetLahan_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetLahan_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            txtNamaLahan.Clear();
            txtLuasLahan.Clear();
            txtCatatanLahan.Clear();
            dgvLahan.ClearSelection();
        }

        private void dgvLahan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLahan.Rows[e.RowIndex];
                if (row.Cells["colId"].Value == null || row.Cells["colId"].Value == DBNull.Value) return;

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
                txtNamaLahan.Text = row.Cells["colNamaLokasi"].Value?.ToString() ?? string.Empty;
                txtLuasLahan.Text = row.Cells["colLuas"].Value?.ToString() ?? string.Empty;
                txtCatatanLahan.Text = row.Cells["colCatatan"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
