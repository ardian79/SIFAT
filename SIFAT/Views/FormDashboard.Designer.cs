namespace SIFAT.Views
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSelamatDatang = new Label();
            tableLayoutDashboard = new TableLayoutPanel();
            panelTengah = new Panel();
            panelSaldo = new Panel();
            lblSaldo = new Label();
            labelTitleSaldo = new Label();
            panelPemasukan = new Panel();
            lblTotalPemasukan = new Label();
            labelTitlePemasukan = new Label();
            panelPengeluaran = new Panel();
            lblTotalPengeluaran = new Label();
            labelTitlePengeluaran = new Label();
            lblRiwayat = new Label();
            dgvTransaksiTerbaru = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colNamaJenis = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            colNamaPengguna = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIdPengguna = new DataGridViewTextBoxColumn();
            colIdJenisKeuangan = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            tableLayoutDashboard.SuspendLayout();
            panelTengah.SuspendLayout();
            panelSaldo.SuspendLayout();
            panelPemasukan.SuspendLayout();
            panelPengeluaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).BeginInit();
            SuspendLayout();
            // 
            // lblSelamatDatang
            // 
            tableLayoutDashboard.SetColumnSpan(lblSelamatDatang, 3);
            lblSelamatDatang.Dock = DockStyle.Fill;
            lblSelamatDatang.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatang.Location = new Point(20, 0);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Padding = new Padding(20, 0, 0, 0);
            lblSelamatDatang.Size = new Size(1713, 80);
            lblSelamatDatang.TabIndex = 0;
            lblSelamatDatang.Text = "Selamat Datang,";
            lblSelamatDatang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutDashboard
            // 
            tableLayoutDashboard.ColumnCount = 3;
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 850F));
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.Controls.Add(lblSelamatDatang, 0, 0);
            tableLayoutDashboard.Controls.Add(panelTengah, 1, 1);
            tableLayoutDashboard.Controls.Add(lblRiwayat, 0, 2);
            tableLayoutDashboard.Controls.Add(dgvTransaksiTerbaru, 0, 3);
            tableLayoutDashboard.Dock = DockStyle.Fill;
            tableLayoutDashboard.Location = new Point(0, 0);
            tableLayoutDashboard.Name = "tableLayoutDashboard";
            tableLayoutDashboard.RowCount = 4;
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutDashboard.Size = new Size(1753, 667);
            tableLayoutDashboard.TabIndex = 5;
            // 
            // panelTengah
            // 
            panelTengah.Controls.Add(panelSaldo);
            panelTengah.Controls.Add(panelPemasukan);
            panelTengah.Controls.Add(panelPengeluaran);
            panelTengah.Dock = DockStyle.Fill;
            panelTengah.Location = new Point(454, 83);
            panelTengah.Name = "panelTengah";
            panelTengah.Size = new Size(844, 154);
            panelTengah.TabIndex = 0;
            // 
            // panelSaldo
            // 
            panelSaldo.BackColor = Color.RoyalBlue;
            panelSaldo.Controls.Add(lblSaldo);
            panelSaldo.Controls.Add(labelTitleSaldo);
            panelSaldo.Location = new Point(560, 20);
            panelSaldo.Name = "panelSaldo";
            panelSaldo.Size = new Size(260, 120);
            panelSaldo.TabIndex = 4;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(15, 55);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(89, 37);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Rp 0";
            // 
            // labelTitleSaldo
            // 
            labelTitleSaldo.AutoSize = true;
            labelTitleSaldo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleSaldo.ForeColor = Color.White;
            labelTitleSaldo.Location = new Point(15, 15);
            labelTitleSaldo.Name = "labelTitleSaldo";
            labelTitleSaldo.Size = new Size(104, 23);
            labelTitleSaldo.TabIndex = 0;
            labelTitleSaldo.Text = "SALDO KAS";
            // 
            // panelPemasukan
            // 
            panelPemasukan.BackColor = Color.MediumSeaGreen;
            panelPemasukan.Controls.Add(lblTotalPemasukan);
            panelPemasukan.Controls.Add(labelTitlePemasukan);
            panelPemasukan.Location = new Point(0, 20);
            panelPemasukan.Name = "panelPemasukan";
            panelPemasukan.Size = new Size(260, 120);
            panelPemasukan.TabIndex = 1;
            // 
            // lblTotalPemasukan
            // 
            lblTotalPemasukan.AutoSize = true;
            lblTotalPemasukan.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPemasukan.ForeColor = Color.White;
            lblTotalPemasukan.Location = new Point(15, 55);
            lblTotalPemasukan.Name = "lblTotalPemasukan";
            lblTotalPemasukan.Size = new Size(89, 37);
            lblTotalPemasukan.TabIndex = 1;
            lblTotalPemasukan.Text = "Rp 0";
            // 
            // labelTitlePemasukan
            // 
            labelTitlePemasukan.AutoSize = true;
            labelTitlePemasukan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitlePemasukan.ForeColor = Color.White;
            labelTitlePemasukan.Location = new Point(15, 15);
            labelTitlePemasukan.Name = "labelTitlePemasukan";
            labelTitlePemasukan.Size = new Size(164, 23);
            labelTitlePemasukan.TabIndex = 0;
            labelTitlePemasukan.Text = "TOTAL PEMASUKAN";
            // 
            // panelPengeluaran
            // 
            panelPengeluaran.BackColor = Color.Crimson;
            panelPengeluaran.Controls.Add(lblTotalPengeluaran);
            panelPengeluaran.Controls.Add(labelTitlePengeluaran);
            panelPengeluaran.Location = new Point(280, 20);
            panelPengeluaran.Name = "panelPengeluaran";
            panelPengeluaran.Size = new Size(260, 120);
            panelPengeluaran.TabIndex = 2;
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPengeluaran.ForeColor = Color.White;
            lblTotalPengeluaran.Location = new Point(15, 55);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(89, 37);
            lblTotalPengeluaran.TabIndex = 1;
            lblTotalPengeluaran.Text = "Rp 0";
            // 
            // labelTitlePengeluaran
            // 
            labelTitlePengeluaran.AutoSize = true;
            labelTitlePengeluaran.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitlePengeluaran.ForeColor = Color.White;
            labelTitlePengeluaran.Location = new Point(15, 15);
            labelTitlePengeluaran.Name = "labelTitlePengeluaran";
            labelTitlePengeluaran.Size = new Size(183, 23);
            labelTitlePengeluaran.TabIndex = 0;
            labelTitlePengeluaran.Text = "TOTAL PENGELUARAN";
            // 
            // lblRiwayat
            // 
            tableLayoutDashboard.SetColumnSpan(lblRiwayat, 3);
            lblRiwayat.Dock = DockStyle.Fill;
            lblRiwayat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiwayat.Location = new Point(3, 240);
            lblRiwayat.Name = "lblRiwayat";
            lblRiwayat.Padding = new Padding(20, 0, 0, 0);
            lblRiwayat.Size = new Size(1747, 40);
            lblRiwayat.TabIndex = 1;
            lblRiwayat.Text = "5 Transaksi Terbaru";
            lblRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvTransaksiTerbaru
            // 
            dgvTransaksiTerbaru.AllowUserToAddRows = false;
            dgvTransaksiTerbaru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransaksiTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksiTerbaru.BackgroundColor = Color.White;
            dgvTransaksiTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiTerbaru.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colNamaJenis, colKategori, colJumlah, colKeterangan, colNamaPengguna, colId, colIdPengguna, colIdJenisKeuangan, colIsDelete });
            tableLayoutDashboard.SetColumnSpan(dgvTransaksiTerbaru, 3);
            dgvTransaksiTerbaru.Dock = DockStyle.None;
            dgvTransaksiTerbaru.Location = new Point(20, 300);
            dgvTransaksiTerbaru.Margin = new Padding(20);
            dgvTransaksiTerbaru.Name = "dgvTransaksiTerbaru";
            dgvTransaksiTerbaru.ReadOnly = true;
            dgvTransaksiTerbaru.RowHeadersWidth = 51;
            dgvTransaksiTerbaru.ScrollBars = ScrollBars.Horizontal;
            dgvTransaksiTerbaru.Size = new Size(1713, 200);
            dgvTransaksiTerbaru.TabIndex = 10;
            // 
            // colTanggal
            // 
            colTanggal.DataPropertyName = "Tanggal";
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colNamaJenis
            // 
            colNamaJenis.DataPropertyName = "NamaJenis";
            colNamaJenis.HeaderText = "Jenis";
            colNamaJenis.MinimumWidth = 6;
            colNamaJenis.Name = "colNamaJenis";
            colNamaJenis.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.DataPropertyName = "Kategori";
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.DataPropertyName = "Jumlah";
            colJumlah.HeaderText = "Jumlah (Rp)";
            colJumlah.MinimumWidth = 6;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colKeterangan
            // 
            colKeterangan.DataPropertyName = "Keterangan";
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 6;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.ReadOnly = true;
            // 
            // colNamaPengguna
            // 
            colNamaPengguna.DataPropertyName = "NamaPengguna";
            colNamaPengguna.HeaderText = "Diinput Oleh";
            colNamaPengguna.MinimumWidth = 6;
            colNamaPengguna.Name = "colNamaPengguna";
            colNamaPengguna.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colIdPengguna
            // 
            colIdPengguna.DataPropertyName = "IdPengguna";
            colIdPengguna.HeaderText = "IdPengguna";
            colIdPengguna.MinimumWidth = 6;
            colIdPengguna.Name = "colIdPengguna";
            colIdPengguna.ReadOnly = true;
            colIdPengguna.Visible = false;
            // 
            // colIdJenisKeuangan
            // 
            colIdJenisKeuangan.DataPropertyName = "IdJenisKeuangan";
            colIdJenisKeuangan.HeaderText = "IdJenisKeuangan";
            colIdJenisKeuangan.MinimumWidth = 6;
            colIdJenisKeuangan.Name = "colIdJenisKeuangan";
            colIdJenisKeuangan.ReadOnly = true;
            colIdJenisKeuangan.Visible = false;
            // 
            // colIsDelete
            // 
            colIsDelete.DataPropertyName = "IsDelete";
            colIsDelete.HeaderText = "IsDelete";
            colIsDelete.MinimumWidth = 6;
            colIsDelete.Name = "colIsDelete";
            colIsDelete.ReadOnly = true;
            colIsDelete.Visible = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1753, 667);
            Controls.Add(tableLayoutDashboard);
            Name = "FormDashboard";
            Text = "FormDashboard";
            tableLayoutDashboard.ResumeLayout(false);
            panelTengah.ResumeLayout(false);
            panelSaldo.ResumeLayout(false);
            panelSaldo.PerformLayout();
            panelPemasukan.ResumeLayout(false);
            panelPemasukan.PerformLayout();
            panelPengeluaran.ResumeLayout(false);
            panelPengeluaran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSelamatDatang;
        private Panel panelPemasukan;
        private Panel panelPengeluaran;
        private Panel panelSaldo;
        private TableLayoutPanel tableLayoutDashboard;
        private Panel panelTengah;
        private Label lblTotalPemasukan;
        private Label labelTitlePemasukan;
        private Label lblTotalPengeluaran;
        private Label labelTitlePengeluaran;
        private Label lblSaldo;
        private Label labelTitleSaldo;
        private DataGridView dgvTransaksiTerbaru;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colNamaJenis;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colKeterangan;
        private DataGridViewTextBoxColumn colNamaPengguna;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIdPengguna;
        private DataGridViewTextBoxColumn colIdJenisKeuangan;
        private DataGridViewTextBoxColumn colIsDelete;
        private Label lblRiwayat;
    }
}