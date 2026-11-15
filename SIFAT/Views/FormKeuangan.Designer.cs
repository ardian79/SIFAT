namespace SIFAT.Views
{
    partial class FormKeuangan
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
            dgvKeuangan = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colNamaJenis = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIdPengguna = new DataGridViewTextBoxColumn();
            colIdJenisKeuangan = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            panelInputKeuangan = new Panel();
            txtKeteranganKeuangan = new TextBox();
            label1 = new Label();
            cmbJenisKeuangan = new ComboBox();
            dtpTanggalKeuangan = new DateTimePicker();
            btnResetKeuangan = new Button();
            btnHapusKeuangan = new Button();
            btnUbahKeuangan = new Button();
            btnTambahKeuangan = new Button();
            txtJumlahKeuangan = new TextBox();
            labelJumlah = new Label();
            labelJenisTransaksi = new Label();
            labelTanggal = new Label();
            labelKeuangan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKeuangan).BeginInit();
            panelInputKeuangan.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKeuangan
            // 
            dgvKeuangan.AllowUserToAddRows = false;
            dgvKeuangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvKeuangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeuangan.BackgroundColor = Color.White;
            dgvKeuangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeuangan.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colNamaJenis, colKategori, colJumlah, colKeterangan, colId, colIdPengguna, colIdJenisKeuangan, colIsDelete });
            dgvKeuangan.Location = new Point(28, 230);
            dgvKeuangan.Name = "dgvKeuangan";
            dgvKeuangan.ReadOnly = true;
            dgvKeuangan.RowHeadersWidth = 51;
            dgvKeuangan.Size = new Size(1950, 250);
            dgvKeuangan.TabIndex = 5;
            dgvKeuangan.CellClick += dgvKeuangan_CellClick;
            // 
            // colTanggal
            // 
            colTanggal.DataPropertyName = "Tanggal";
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "Tanggal";
            colTanggal.ReadOnly = true;
            // 
            // colNamaJenis
            // 
            colNamaJenis.DataPropertyName = "NamaJenis";
            colNamaJenis.HeaderText = "Jenis";
            colNamaJenis.MinimumWidth = 6;
            colNamaJenis.Name = "NamaJenis";
            colNamaJenis.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.DataPropertyName = "Kategori";
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "Kategori";
            colKategori.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.DataPropertyName = "Jumlah";
            colJumlah.HeaderText = "Jumlah (Rp)";
            colJumlah.MinimumWidth = 6;
            colJumlah.Name = "Jumlah";
            colJumlah.ReadOnly = true;
            // 
            // colKeterangan
            // 
            colKeterangan.DataPropertyName = "Keterangan";
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 6;
            colKeterangan.Name = "Keterangan";
            colKeterangan.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "Id";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colIdPengguna
            // 
            colIdPengguna.DataPropertyName = "IdPengguna";
            colIdPengguna.HeaderText = "IdPengguna";
            colIdPengguna.MinimumWidth = 6;
            colIdPengguna.Name = "IdPengguna";
            colIdPengguna.ReadOnly = true;
            colIdPengguna.Visible = false;
            // 
            // colIdJenisKeuangan
            // 
            colIdJenisKeuangan.DataPropertyName = "IdJenisKeuangan";
            colIdJenisKeuangan.HeaderText = "IdJenisKeuangan";
            colIdJenisKeuangan.MinimumWidth = 6;
            colIdJenisKeuangan.Name = "IdJenisKeuangan";
            colIdJenisKeuangan.ReadOnly = true;
            colIdJenisKeuangan.Visible = false;
            // 
            // colIsDelete
            // 
            colIsDelete.DataPropertyName = "IsDelete";
            colIsDelete.HeaderText = "IsDelete";
            colIsDelete.MinimumWidth = 6;
            colIsDelete.Name = "IsDelete";
            colIsDelete.ReadOnly = true;
            colIsDelete.Visible = false;
            // 
            // panelInputKeuangan
            // 
            panelInputKeuangan.BackColor = Color.Transparent;
            panelInputKeuangan.Controls.Add(txtKeteranganKeuangan);
            panelInputKeuangan.Controls.Add(label1);
            panelInputKeuangan.Controls.Add(cmbJenisKeuangan);
            panelInputKeuangan.Controls.Add(dtpTanggalKeuangan);
            panelInputKeuangan.Controls.Add(btnResetKeuangan);
            panelInputKeuangan.Controls.Add(btnHapusKeuangan);
            panelInputKeuangan.Controls.Add(btnUbahKeuangan);
            panelInputKeuangan.Controls.Add(btnTambahKeuangan);
            panelInputKeuangan.Controls.Add(txtJumlahKeuangan);
            panelInputKeuangan.Controls.Add(labelJumlah);
            panelInputKeuangan.Controls.Add(labelJenisTransaksi);
            panelInputKeuangan.Controls.Add(labelTanggal);
            panelInputKeuangan.Location = new Point(28, 60);
            panelInputKeuangan.Name = "panelInputKeuangan";
            panelInputKeuangan.Size = new Size(1100, 150);
            panelInputKeuangan.TabIndex = 4;
            // 
            // txtKeteranganKeuangan
            // 
            txtKeteranganKeuangan.BackColor = Color.White;
            txtKeteranganKeuangan.BorderStyle = BorderStyle.FixedSingle;
            txtKeteranganKeuangan.ForeColor = Color.Black;
            txtKeteranganKeuangan.Location = new Point(774, 46);
            txtKeteranganKeuangan.Name = "txtKeteranganKeuangan";
            txtKeteranganKeuangan.Size = new Size(250, 27);
            txtKeteranganKeuangan.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(774, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 14;
            label1.Text = "Keterangan";
            // 
            // cmbJenisKeuangan
            // 
            cmbJenisKeuangan.Cursor = Cursors.Hand;
            cmbJenisKeuangan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisKeuangan.FormattingEnabled = true;
            cmbJenisKeuangan.Location = new Point(325, 45);
            cmbJenisKeuangan.Name = "cmbJenisKeuangan";
            cmbJenisKeuangan.Size = new Size(200, 28);
            cmbJenisKeuangan.TabIndex = 13;
            // 
            // dtpTanggalKeuangan
            // 
            dtpTanggalKeuangan.Format = DateTimePickerFormat.Short;
            dtpTanggalKeuangan.Location = new Point(24, 45);
            dtpTanggalKeuangan.Name = "dtpTanggalKeuangan";
            dtpTanggalKeuangan.Size = new Size(250, 27);
            dtpTanggalKeuangan.TabIndex = 12;
            // 
            // btnResetKeuangan
            // 
            btnResetKeuangan.BackColor = Color.Gray;
            btnResetKeuangan.Cursor = Cursors.Hand;
            btnResetKeuangan.FlatStyle = FlatStyle.Flat;
            btnResetKeuangan.ForeColor = Color.White;
            btnResetKeuangan.Location = new Point(462, 98);
            btnResetKeuangan.Name = "btnResetKeuangan";
            btnResetKeuangan.Size = new Size(105, 34);
            btnResetKeuangan.TabIndex = 11;
            btnResetKeuangan.Text = "Reset";
            btnResetKeuangan.UseVisualStyleBackColor = false;
            btnResetKeuangan.Click += btnResetKeuangan_Click;
            // 
            // btnHapusKeuangan
            // 
            btnHapusKeuangan.BackColor = Color.Crimson;
            btnHapusKeuangan.Cursor = Cursors.Hand;
            btnHapusKeuangan.FlatStyle = FlatStyle.Flat;
            btnHapusKeuangan.ForeColor = Color.White;
            btnHapusKeuangan.Location = new Point(316, 98);
            btnHapusKeuangan.Name = "btnHapusKeuangan";
            btnHapusKeuangan.Size = new Size(105, 34);
            btnHapusKeuangan.TabIndex = 10;
            btnHapusKeuangan.Text = "Hapus";
            btnHapusKeuangan.UseVisualStyleBackColor = false;
            btnHapusKeuangan.Click += btnHapusKeuangan_Click;
            // 
            // btnUbahKeuangan
            // 
            btnUbahKeuangan.BackColor = Color.Orange;
            btnUbahKeuangan.Cursor = Cursors.Hand;
            btnUbahKeuangan.FlatStyle = FlatStyle.Flat;
            btnUbahKeuangan.ForeColor = Color.White;
            btnUbahKeuangan.Location = new Point(171, 98);
            btnUbahKeuangan.Name = "btnUbahKeuangan";
            btnUbahKeuangan.Size = new Size(105, 34);
            btnUbahKeuangan.TabIndex = 9;
            btnUbahKeuangan.Text = "Ubah";
            btnUbahKeuangan.UseVisualStyleBackColor = false;
            btnUbahKeuangan.Click += btnUbahKeuangan_Click;
            // 
            // btnTambahKeuangan
            // 
            btnTambahKeuangan.BackColor = Color.MediumSeaGreen;
            btnTambahKeuangan.Cursor = Cursors.Hand;
            btnTambahKeuangan.FlatStyle = FlatStyle.Flat;
            btnTambahKeuangan.ForeColor = Color.White;
            btnTambahKeuangan.Location = new Point(24, 98);
            btnTambahKeuangan.Name = "btnTambahKeuangan";
            btnTambahKeuangan.Size = new Size(105, 34);
            btnTambahKeuangan.TabIndex = 5;
            btnTambahKeuangan.Text = "Tambah";
            btnTambahKeuangan.UseVisualStyleBackColor = false;
            btnTambahKeuangan.Click += btnTambahKeuangan_Click;
            // 
            // txtJumlahKeuangan
            // 
            txtJumlahKeuangan.BackColor = Color.White;
            txtJumlahKeuangan.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahKeuangan.ForeColor = Color.Black;
            txtJumlahKeuangan.Location = new Point(574, 46);
            txtJumlahKeuangan.Name = "txtJumlahKeuangan";
            txtJumlahKeuangan.Size = new Size(150, 27);
            txtJumlahKeuangan.TabIndex = 8;
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJumlah.Location = new Point(574, 21);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(107, 23);
            labelJumlah.TabIndex = 7;
            labelJumlah.Text = "Jumlah (Rp)";
            // 
            // labelJenisTransaksi
            // 
            labelJenisTransaksi.AutoSize = true;
            labelJenisTransaksi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJenisTransaksi.Location = new Point(325, 20);
            labelJenisTransaksi.Name = "labelJenisTransaksi";
            labelJenisTransaksi.Size = new Size(127, 23);
            labelJenisTransaksi.TabIndex = 5;
            labelJenisTransaksi.Text = "Jenis Transaksi";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggal.Location = new Point(24, 19);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(74, 23);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKeuangan
            // 
            labelKeuangan.AutoSize = true;
            labelKeuangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKeuangan.ForeColor = Color.FromArgb(30, 41, 59);
            labelKeuangan.Location = new Point(20, 20);
            labelKeuangan.Name = "labelKeuangan";
            labelKeuangan.Size = new Size(381, 38);
            labelKeuangan.TabIndex = 3;
            labelKeuangan.Text = "Manajemen Data Keuangan";
            // 
            // FormKeuangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2007, 890);
            Controls.Add(dgvKeuangan);
            Controls.Add(panelInputKeuangan);
            Controls.Add(labelKeuangan);
            Name = "FormKeuangan";
            Text = "FormKeuangan";
            ((System.ComponentModel.ISupportInitialize)dgvKeuangan).EndInit();
            panelInputKeuangan.ResumeLayout(false);
            panelInputKeuangan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKeuangan;
        private Panel panelInputKeuangan;
        private Button btnResetKeuangan;
        private Button btnHapusKeuangan;
        private Button btnUbahKeuangan;
        private Button btnTambahKeuangan;
        private TextBox txtJumlahKeuangan;
        private Label labelJumlah;
        private Label labelJenisTransaksi;
        private Label labelTanggal;
        private Label labelKeuangan;
        private DateTimePicker dtpTanggalKeuangan;
        private ComboBox cmbJenisKeuangan;
        private TextBox txtKeteranganKeuangan;
        private Label label1;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colNamaJenis;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colKeterangan;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIdPengguna;
        private DataGridViewTextBoxColumn colIdJenisKeuangan;
        private DataGridViewTextBoxColumn colIsDelete;
    }
}