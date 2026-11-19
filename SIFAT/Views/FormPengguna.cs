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
    public partial class FormPengguna : Form
    {
        private PenggunaController _controller = new PenggunaController();
        private int _selectedId = 0;

        public FormPengguna()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            txtPasswordPengguna.PlaceholderText = "Masukkan password";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Pengguna> list = _controller.GetAllBuruh();
                dgvPengguna.AutoGenerateColumns = false;
                dgvPengguna.DataSource = list;

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturTinggiTabel()
        {
            int totalHeight = dgvPengguna.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvPengguna.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }
            totalHeight += 2;

            bool hasHScroll = false;
            foreach (Control c in dgvPengguna.Controls)
            {
                if (c is HScrollBar && c.Visible) { hasHScroll = true; break; }
            }
            if (hasHScroll) totalHeight += SystemInformation.HorizontalScrollBarHeight;

            dgvPengguna.Height = totalHeight;
        }

        private void btnTambahPengguna_Click(object sender, EventArgs e)
        {
            try
            {
                string pesan = _controller.TambahBuruh(txtNamaLengkapPengguna.Text, txtUsernamePengguna.Text, txtPasswordPengguna.Text);
                if (pesan == "OK")
                {
                    MessageBox.Show("Akun buruh tani berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetPengguna_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat akun buruh tani: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahPengguna_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string pesan = _controller.UbahBuruh(_selectedId, txtNamaLengkapPengguna.Text, txtUsernamePengguna.Text, txtPasswordPengguna.Text);
                if (pesan == "OK")
                {
                    MessageBox.Show("Data akun buruh tani berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetPengguna_Click(null, null);
                }
                else
                {
                    MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah akun buruh tani: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusPengguna_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menonaktifkan buruh tani ini? Buruh tani tidak akan bisa login lagi.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _controller.NonaktifkanBuruh(_selectedId);
                    MessageBox.Show("Akun buruh tani berhasil dinonaktifkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetPengguna_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetPengguna_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            txtNamaLengkapPengguna.Clear();
            txtUsernamePengguna.Clear();
            txtPasswordPengguna.Clear();
            txtPasswordPengguna.PlaceholderText = "Masukkan password";
            dgvPengguna.ClearSelection();
        }

        private void dgvPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengguna.Rows[e.RowIndex];
                if (row.Cells["colId"].Value == null || row.Cells["colId"].Value == DBNull.Value) return;

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
                txtNamaLengkapPengguna.Text = row.Cells["colNamaLengkap"].Value?.ToString() ?? string.Empty;
                txtUsernamePengguna.Text = row.Cells["colUsername"].Value?.ToString() ?? string.Empty;
                txtPasswordPengguna.Clear();
                txtPasswordPengguna.PlaceholderText = "Kosongkan jika tidak diubah";
            }
        }
    }
}
