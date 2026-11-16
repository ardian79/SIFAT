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
            colNamaPengguna = new DataGridViewTextBoxColumn();
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
            dgvKeuangan.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colNamaJenis, colKategori, colJumlah, colKeterangan, colNamaPengguna, colId, colIdPengguna, colIdJenisKeuangan, colIsDelete });
            dgvKeuangan.Location = new Point(24, 172);
            dgvKeuangan.Margin = new Padding(3, 2, 3, 2);
            dgvKeuangan.Name = "dgvKeuangan";
            dgvKeuangan.ReadOnly = true;
            dgvKeuangan.RowHeadersWidth = 51;
            dgvKeuangan.Size = new Size(1113, 135);
            dgvKeuangan.TabIndex = 8;
            dgvKeuangan.CellClick += dgvKeuangan_CellClick;
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
            // panelInputKeuangan
            // 
            panelInputKeuangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            panelInputKeuangan.Location = new Point(24, 45);
            panelInputKeuangan.Margin = new Padding(3, 2, 3, 2);
            panelInputKeuangan.Name = "panelInputKeuangan";
            panelInputKeuangan.Size = new Size(1113, 112);
            panelInputKeuangan.TabIndex = 4;
            // 
            // txtKeteranganKeuangan
            // 
            txtKeteranganKeuangan.BackColor = Color.White;
            txtKeteranganKeuangan.BorderStyle = BorderStyle.FixedSingle;
            txtKeteranganKeuangan.ForeColor = Color.Black;
            txtKeteranganKeuangan.Location = new Point(677, 33);
            txtKeteranganKeuangan.Margin = new Padding(3, 2, 3, 2);
            txtKeteranganKeuangan.Name = "txtKeteranganKeuangan";
            txtKeteranganKeuangan.Size = new Size(219, 23);
            txtKeteranganKeuangan.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(677, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 14;
            label1.Text = "Keterangan";
            // 
            // cmbJenisKeuangan
            // 
            cmbJenisKeuangan.Cursor = Cursors.Hand;
            cmbJenisKeuangan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisKeuangan.FormattingEnabled = true;
            cmbJenisKeuangan.Location = new Point(284, 33);
            cmbJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            cmbJenisKeuangan.Name = "cmbJenisKeuangan";
            cmbJenisKeuangan.Size = new Size(176, 23);
            cmbJenisKeuangan.TabIndex = 1;
            // 
            // dtpTanggalKeuangan
            // 
            dtpTanggalKeuangan.Format = DateTimePickerFormat.Short;
            dtpTanggalKeuangan.Location = new Point(21, 33);
            dtpTanggalKeuangan.Margin = new Padding(3, 2, 3, 2);
            dtpTanggalKeuangan.Name = "dtpTanggalKeuangan";
            dtpTanggalKeuangan.Size = new Size(219, 23);
            dtpTanggalKeuangan.TabIndex = 0;
            // 
            // btnResetKeuangan
            // 
            btnResetKeuangan.BackColor = Color.Gray;
            btnResetKeuangan.Cursor = Cursors.Hand;
            btnResetKeuangan.FlatStyle = FlatStyle.Flat;
            btnResetKeuangan.ForeColor = Color.White;
            btnResetKeuangan.Location = new Point(404, 73);
            btnResetKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnResetKeuangan.Name = "btnResetKeuangan";
            btnResetKeuangan.Size = new Size(92, 26);
            btnResetKeuangan.TabIndex = 7;
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
            btnHapusKeuangan.Location = new Point(276, 73);
            btnHapusKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnHapusKeuangan.Name = "btnHapusKeuangan";
            btnHapusKeuangan.Size = new Size(92, 26);
            btnHapusKeuangan.TabIndex = 6;
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
            btnUbahKeuangan.Location = new Point(150, 73);
            btnUbahKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnUbahKeuangan.Name = "btnUbahKeuangan";
            btnUbahKeuangan.Size = new Size(92, 26);
            btnUbahKeuangan.TabIndex = 5;
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
            btnTambahKeuangan.Location = new Point(21, 73);
            btnTambahKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnTambahKeuangan.Name = "btnTambahKeuangan";
            btnTambahKeuangan.Size = new Size(92, 26);
            btnTambahKeuangan.TabIndex = 4;
            btnTambahKeuangan.Text = "Tambah";
            btnTambahKeuangan.UseVisualStyleBackColor = false;
            btnTambahKeuangan.Click += btnTambahKeuangan_Click;
            // 
            // txtJumlahKeuangan
            // 
            txtJumlahKeuangan.BackColor = Color.White;
            txtJumlahKeuangan.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahKeuangan.ForeColor = Color.Black;
            txtJumlahKeuangan.Location = new Point(502, 33);
            txtJumlahKeuangan.Margin = new Padding(3, 2, 3, 2);
            txtJumlahKeuangan.Name = "txtJumlahKeuangan";
            txtJumlahKeuangan.Size = new Size(132, 23);
            txtJumlahKeuangan.TabIndex = 2;
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJumlah.Location = new Point(502, 15);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(88, 19);
            labelJumlah.TabIndex = 7;
            labelJumlah.Text = "Jumlah (Rp)";
            // 
            // labelJenisTransaksi
            // 
            labelJenisTransaksi.AutoSize = true;
            labelJenisTransaksi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJenisTransaksi.Location = new Point(284, 14);
            labelJenisTransaksi.Name = "labelJenisTransaksi";
            labelJenisTransaksi.Size = new Size(106, 19);
            labelJenisTransaksi.TabIndex = 5;
            labelJenisTransaksi.Text = "Jenis Transaksi";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggal.Location = new Point(21, 13);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(62, 19);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKeuangan
            // 
            labelKeuangan.AutoSize = true;
            labelKeuangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKeuangan.ForeColor = Color.FromArgb(30, 41, 59);
            labelKeuangan.Location = new Point(18, 15);
            labelKeuangan.Name = "labelKeuangan";
            labelKeuangan.Size = new Size(298, 30);
            labelKeuangan.TabIndex = 3;
            labelKeuangan.Text = "Manajemen Data Keuangan";
            // 
            // FormKeuangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1161, 485);
            Controls.Add(dgvKeuangan);
            Controls.Add(panelInputKeuangan);
            Controls.Add(labelKeuangan);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn colNamaPengguna;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIdPengguna;
        private DataGridViewTextBoxColumn colIdJenisKeuangan;
        private DataGridViewTextBoxColumn colIsDelete;
    }
}