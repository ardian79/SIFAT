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

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Pengguna> list = _controller.GetAllBuruh();
                dgvPengguna.DataSource = list;

                if (dgvPengguna.Columns["Id"] != null) dgvPengguna.Columns["Id"].Visible = false;
                if (dgvPengguna.Columns["NamaLengkap"] != null) dgvPengguna.Columns["NamaLengkap"].HeaderText = "Nama Lengkap";
                if (dgvPengguna.Columns["Username"] != null) dgvPengguna.Columns["Username"].HeaderText = "Username";
                if (dgvPengguna.Columns["Role"] != null) dgvPengguna.Columns["Role"].Visible = false;
                if (dgvPengguna.Columns["IsDelete"] != null) dgvPengguna.Columns["IsDelete"].Visible = false;
                if (dgvPengguna.Columns["Password"] != null) dgvPengguna.Columns["Password"].Visible = false;

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int tinggiHeader = dgvPengguna.ColumnHeadersHeight;
            int tinggiBaris = dgvPengguna.RowTemplate.Height;
            int jumlahBaris = dgvPengguna.Rows.Count;
            dgvPengguna.Height = tinggiHeader + (tinggiBaris * jumlahBaris) + 5;
        }

        private void btnTambahPengguna_Click(object sender, EventArgs e)
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

        private void btnUbahPengguna_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnResetPengguna_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            txtNamaLengkapPengguna.Clear();
            txtUsernamePengguna.Clear();
            txtPasswordPengguna.Clear();
            dgvPengguna.ClearSelection();
        }

        private void dgvPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengguna.Rows[e.RowIndex];
                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNamaLengkapPengguna.Text = row.Cells["NamaLengkap"].Value.ToString();
                txtUsernamePengguna.Text = row.Cells["Username"].Value.ToString();
                txtPasswordPengguna.Clear();
            }
        }
    }
}

