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
        private Pengguna _userLogin;
        private int _selectedId = 0;

        public FormBudidayaTebu(Pengguna user)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;

            colTglTanam.DefaultCellStyle.Format = "dd/MMM/yyyy";
            colTglPanen.DefaultCellStyle.Format = "dd/MMM/yyyy";
            colJumlah.DefaultCellStyle.Format = "N0";

            _userLogin = user;

            LoadComboLahan();
            LoadComboStatus();
            cmbStatusBudidaya.SelectedIndexChanged += cmbStatusBudidaya_SelectedIndexChanged;
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
                MessageBox.Show("Gagal memuat data lahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvBudidayaTebu.AutoGenerateColumns = false;
                dgvBudidayaTebu.DataSource = list;

                if (dgvBudidayaTebu.Columns["colNamaPengguna"] != null)
                {
                    dgvBudidayaTebu.Columns["colNamaPengguna"].Visible = _userLogin.BisaLihatPenginput();
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
            int totalHeight = dgvBudidayaTebu.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvBudidayaTebu.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }
            totalHeight += 2;

            bool hasHScroll = false;
            foreach (Control c in dgvBudidayaTebu.Controls)
            {
                if (c is HScrollBar && c.Visible) { hasHScroll = true; break; }
            }
            if (hasHScroll) totalHeight += SystemInformation.HorizontalScrollBarHeight;

            dgvBudidayaTebu.Height = totalHeight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpTanggalPanen.Enabled = checkBox1.Checked;
            string targetStatus = checkBox1.Checked ? "Panen" : "Masa Tanam";
            if (cmbStatusBudidaya.SelectedItem?.ToString() != targetStatus)
            {
                cmbStatusBudidaya.SelectedItem = targetStatus;
            }
        }

        private void cmbStatusBudidaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusBudidaya.SelectedItem == null) return;

            bool isPanen = cmbStatusBudidaya.SelectedItem.ToString() == "Panen";
            if (checkBox1.Checked != isPanen)
            {
                checkBox1.Checked = isPanen;
            }
        }

        private void btnTambahBudidayaTebu_Click(object sender, EventArgs e)
        {
            if (cmbLahanBudidaya.SelectedValue == null)
            {
                MessageBox.Show("Pilih lahan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idLahan = Convert.ToInt32(cmbLahanBudidaya.SelectedValue);
                string status = cmbStatusBudidaya.SelectedItem?.ToString() ?? "Masa Tanam";
                string pesan = _controller.TambahBudidaya(idLahan, _userLogin.Id, dtpTanggalTanam.Value, checkBox1.Checked, dtpTanggalPanen.Value, txtJumlahtebu.Text, status);

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
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data budidaya: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahBudidayaTebu_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLahanBudidaya.SelectedValue == null)
            {
                MessageBox.Show("Lahan sebelumnya sudah tidak aktif. Pilih lahan yang aktif terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idLahan = Convert.ToInt32(cmbLahanBudidaya.SelectedValue);
                string status = cmbStatusBudidaya.SelectedItem?.ToString() ?? "Masa Tanam";
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
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data budidaya: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (row.Cells["colId"].Value == null || row.Cells["colId"].Value == DBNull.Value) return;

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                int idLahan = Convert.ToInt32(row.Cells["colIdLahan"].Value);
                cmbLahanBudidaya.SelectedValue = idLahan;
                if (cmbLahanBudidaya.SelectedValue == null || Convert.ToInt32(cmbLahanBudidaya.SelectedValue) != idLahan)
                {
                    cmbLahanBudidaya.SelectedIndex = -1;
                }

                dtpTanggalTanam.Value = Convert.ToDateTime(row.Cells["colTglTanam"].Value);

                if (row.Cells["colTglPanen"].Value != null && row.Cells["colTglPanen"].Value != DBNull.Value)
                {
                    checkBox1.Checked = true;
                    dtpTanggalPanen.Value = Convert.ToDateTime(row.Cells["colTglPanen"].Value);
                }
                else
                {
                    checkBox1.Checked = false;
                }

                txtJumlahtebu.Text = row.Cells["colJumlah"].Value?.ToString() ?? string.Empty;
                cmbStatusBudidaya.SelectedItem = row.Cells["colStatus"].Value?.ToString();
            }
        }
    }
}
