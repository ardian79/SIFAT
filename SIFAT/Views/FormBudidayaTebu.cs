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
    public partial class FormBudidayaTebu : Form
    {
        private BudidayaTebuController _controller = new BudidayaTebuController();
        private int _selectedId = 0;

        public FormBudidayaTebu()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            LoadComboLahan();
            LoadComboStatus();
            LoadData();
        }

        private void LoadComboLahan()
        {
            try
            {
                List<Lahan> listLahan = _controller.GetListLahan();
                cmbLahanBudidaya.DataSource = listLahan;
                cmbLahanBudidaya.DisplayMember = "NamaLokasi";
                cmbLahanBudidaya.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data lahan: " + ex.Message);
            }
        }

        private void LoadComboStatus()
        {
            cmbStatusBudidaya.Items.Clear();
            cmbStatusBudidaya.Items.AddRange(new string[] { "Masa Tanam", "Panen" });
            cmbStatusBudidaya.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                List<BudidayaTebu> list = _controller.GetAllBudidaya();
                dgvBudidayaTebu.DataSource = list;

                if (dgvBudidayaTebu.Columns["Id"] != null) dgvBudidayaTebu.Columns["Id"].Visible = false;
                if (dgvBudidayaTebu.Columns["IdLahan"] != null) dgvBudidayaTebu.Columns["IdLahan"].Visible = false;
                if (dgvBudidayaTebu.Columns["IsDelete"] != null) dgvBudidayaTebu.Columns["IsDelete"].Visible = false;

                if (dgvBudidayaTebu.Columns["NamaLokasi"] != null) dgvBudidayaTebu.Columns["NamaLokasi"].HeaderText = "Lokasi Lahan";
                if (dgvBudidayaTebu.Columns["TanggalTanam"] != null) dgvBudidayaTebu.Columns["TanggalTanam"].HeaderText = "Tgl Tanam";
                if (dgvBudidayaTebu.Columns["TanggalPanen"] != null) dgvBudidayaTebu.Columns["TanggalPanen"].HeaderText = "Tgl Panen";
                if (dgvBudidayaTebu.Columns["JumlahTebu"] != null) dgvBudidayaTebu.Columns["JumlahTebu"].HeaderText = "Jumlah Tebu";
                if (dgvBudidayaTebu.Columns["Status"] != null) dgvBudidayaTebu.Columns["Status"].HeaderText = "Status";

                AturTinggiTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void AturTinggiTabel()
        {
            int tinggiHeader = dgvBudidayaTebu.ColumnHeadersHeight;
            int tinggiBaris = dgvBudidayaTebu.RowTemplate.Height;
            int jumlahBaris = dgvBudidayaTebu.Rows.Count;
            dgvBudidayaTebu.Height = tinggiHeader + (tinggiBaris * jumlahBaris) + 5;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpTanggalPanen.Enabled = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                cmbStatusBudidaya.SelectedItem = "Panen";
            }
            else
            {
                cmbStatusBudidaya.SelectedItem = "Masa Tanam";
            }
        }

        private void btnTambahBudidayaTebu_Click(object sender, EventArgs e)
        {
            if (cmbLahanBudidaya.SelectedValue == null)
            {
                MessageBox.Show("Pilih lahan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLahan = Convert.ToInt32(cmbLahanBudidaya.SelectedValue);
            string status = cmbStatusBudidaya.SelectedItem.ToString();
            string pesan = _controller.TambahBudidaya(idLahan, dtpTanggalTanam.Value, checkBox1.Checked, dtpTanggalPanen.Value, txtJumlahtebu.Text, status);

            if (pesan == "OK")
            {
                MessageBox.Show("Data Budidaya berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnResetBudidayaTebu_Click(null, null);
            }
            else
            {
                MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbahBudidayaTebu_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLahan = Convert.ToInt32(cmbLahanBudidaya.SelectedValue);
            string status = cmbStatusBudidaya.SelectedItem.ToString();
            string pesan = _controller.UbahBudidaya(_selectedId, idLahan, dtpTanggalTanam.Value, checkBox1.Checked, dtpTanggalPanen.Value, txtJumlahtebu.Text, status);

            if (pesan == "OK")
            {
                MessageBox.Show("Data Budidaya berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnResetBudidayaTebu_Click(null, null);
            }
            else
            {
                MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapusBudidayaTebu_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data budidaya ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusBudidaya(_selectedId);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnResetBudidayaTebu_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnResetBudidayaTebu_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            if (cmbLahanBudidaya.Items.Count > 0) cmbLahanBudidaya.SelectedIndex = 0;
            dtpTanggalTanam.Value = DateTime.Now;
            checkBox1.Checked = false;
            dtpTanggalPanen.Value = DateTime.Now;
            txtJumlahtebu.Clear();
            cmbStatusBudidaya.SelectedIndex = 0;
            dgvBudidayaTebu.ClearSelection();
        }

        private void dgvBudidayaTebu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBudidayaTebu.Rows[e.RowIndex];
                _selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                cmbLahanBudidaya.SelectedValue = Convert.ToInt32(row.Cells["IdLahan"].Value);
                dtpTanggalTanam.Value = Convert.ToDateTime(row.Cells["TanggalTanam"].Value);

                if (row.Cells["TanggalPanen"].Value != null && row.Cells["TanggalPanen"].Value != DBNull.Value)
                {
                    checkBox1.Checked = true;
                    dtpTanggalPanen.Value = Convert.ToDateTime(row.Cells["TanggalPanen"].Value);
                }
                else
                {
                    checkBox1.Checked = false;
                }

                txtJumlahtebu.Text = row.Cells["JumlahTebu"].Value.ToString();
                cmbStatusBudidaya.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }
    }
}
