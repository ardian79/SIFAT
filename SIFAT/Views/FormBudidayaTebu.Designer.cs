namespace SIFAT.Views
{
    partial class FormBudidayaTebu
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
            dgvBudidayaTebu = new DataGridView();
            colLokasi = new DataGridViewTextBoxColumn();
            colTglTanam = new DataGridViewTextBoxColumn();
            colTglPanen = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNamaPengguna = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIdLahan = new DataGridViewTextBoxColumn();
            colIdPengguna = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            panelInputBudidayaTebu = new Panel();
            dtpTanggalPanen = new DateTimePicker();
            labelTanggalPanen = new Label();
            checkBox1 = new CheckBox();
            cmbStatusBudidaya = new ComboBox();
            label2 = new Label();
            cmbLahanBudidaya = new ComboBox();
            dtpTanggalTanam = new DateTimePicker();
            labelTanggalTanam = new Label();
            btnResetBudidayaTebu = new Button();
            btnHapusBudidayaTebu = new Button();
            btnUbahBudidayaTebu = new Button();
            btnTambahBudidayaTebu = new Button();
            txtJumlahtebu = new TextBox();
            labelJumlahTebu = new Label();
            labelPilihLahan = new Label();
            labelBudidayaTebu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBudidayaTebu).BeginInit();
            panelInputBudidayaTebu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBudidayaTebu
            // 
            dgvBudidayaTebu.AllowUserToAddRows = false;
            dgvBudidayaTebu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBudidayaTebu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudidayaTebu.BackgroundColor = Color.White;
            dgvBudidayaTebu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudidayaTebu.Columns.AddRange(new DataGridViewColumn[] { colLokasi, colTglTanam, colTglPanen, colJumlah, colStatus, colNamaPengguna, colId, colIdLahan, colIdPengguna, colIsDelete });
            dgvBudidayaTebu.Location = new Point(24, 248);
            dgvBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            dgvBudidayaTebu.Name = "dgvBudidayaTebu";
            dgvBudidayaTebu.ReadOnly = true;
            dgvBudidayaTebu.RowHeadersWidth = 51;
            dgvBudidayaTebu.Size = new Size(1114, 135);
            dgvBudidayaTebu.TabIndex = 10;
            dgvBudidayaTebu.CellClick += dgvBudidayaTebu_CellClick;
            // 
            // colLokasi
            // 
            colLokasi.DataPropertyName = "NamaLokasi";
            colLokasi.HeaderText = "Lokasi Lahan";
            colLokasi.MinimumWidth = 6;
            colLokasi.Name = "colLokasi";
            colLokasi.ReadOnly = true;
            // 
            // colTglTanam
            // 
            colTglTanam.DataPropertyName = "TanggalTanam";
            colTglTanam.HeaderText = "Tanggal Tanam";
            colTglTanam.MinimumWidth = 6;
            colTglTanam.Name = "colTglTanam";
            colTglTanam.ReadOnly = true;
            // 
            // colTglPanen
            // 
            colTglPanen.DataPropertyName = "TanggalPanen";
            colTglPanen.HeaderText = "Tanggal Panen";
            colTglPanen.MinimumWidth = 6;
            colTglPanen.Name = "colTglPanen";
            colTglPanen.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.DataPropertyName = "JumlahTebu";
            colJumlah.HeaderText = "Jumlah Tebu";
            colJumlah.MinimumWidth = 6;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
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
            // colIdLahan
            // 
            colIdLahan.DataPropertyName = "IdLahan";
            colIdLahan.HeaderText = "IdLahan";
            colIdLahan.MinimumWidth = 6;
            colIdLahan.Name = "colIdLahan";
            colIdLahan.ReadOnly = true;
            colIdLahan.Visible = false;
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
            // colIsDelete
            // 
            colIsDelete.DataPropertyName = "IsDelete";
            colIsDelete.HeaderText = "IsDelete";
            colIsDelete.MinimumWidth = 6;
            colIsDelete.Name = "colIsDelete";
            colIsDelete.ReadOnly = true;
            colIsDelete.Visible = false;
            // 
            // panelInputBudidayaTebu
            // 
            panelInputBudidayaTebu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInputBudidayaTebu.BackColor = Color.Transparent;
            panelInputBudidayaTebu.Controls.Add(dtpTanggalPanen);
            panelInputBudidayaTebu.Controls.Add(labelTanggalPanen);
            panelInputBudidayaTebu.Controls.Add(checkBox1);
            panelInputBudidayaTebu.Controls.Add(cmbStatusBudidaya);
            panelInputBudidayaTebu.Controls.Add(label2);
            panelInputBudidayaTebu.Controls.Add(cmbLahanBudidaya);
            panelInputBudidayaTebu.Controls.Add(dtpTanggalTanam);
            panelInputBudidayaTebu.Controls.Add(labelTanggalTanam);
            panelInputBudidayaTebu.Controls.Add(btnResetBudidayaTebu);
            panelInputBudidayaTebu.Controls.Add(btnHapusBudidayaTebu);
            panelInputBudidayaTebu.Controls.Add(btnUbahBudidayaTebu);
            panelInputBudidayaTebu.Controls.Add(btnTambahBudidayaTebu);
            panelInputBudidayaTebu.Controls.Add(txtJumlahtebu);
            panelInputBudidayaTebu.Controls.Add(labelJumlahTebu);
            panelInputBudidayaTebu.Controls.Add(labelPilihLahan);
            panelInputBudidayaTebu.Location = new Point(24, 45);
            panelInputBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            panelInputBudidayaTebu.Name = "panelInputBudidayaTebu";
            panelInputBudidayaTebu.Size = new Size(1114, 188);
            panelInputBudidayaTebu.TabIndex = 9;
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Enabled = false;
            dtpTanggalPanen.Format = DateTimePickerFormat.Short;
            dtpTanggalPanen.Location = new Point(408, 95);
            dtpTanggalPanen.Margin = new Padding(3, 2, 3, 2);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(219, 23);
            dtpTanggalPanen.TabIndex = 5;
            // 
            // labelTanggalPanen
            // 
            labelTanggalPanen.AutoSize = true;
            labelTanggalPanen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggalPanen.Location = new Point(408, 76);
            labelTanggalPanen.Name = "labelTanggalPanen";
            labelTanggalPanen.Size = new Size(107, 19);
            labelTanggalPanen.TabIndex = 19;
            labelTanggalPanen.Text = "Tanggal Panen";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(272, 95);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Sudah Panen?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cmbStatusBudidaya
            // 
            cmbStatusBudidaya.Cursor = Cursors.Hand;
            cmbStatusBudidaya.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusBudidaya.FormattingEnabled = true;
            cmbStatusBudidaya.Location = new Point(408, 34);
            cmbStatusBudidaya.Margin = new Padding(3, 2, 3, 2);
            cmbStatusBudidaya.Name = "cmbStatusBudidaya";
            cmbStatusBudidaya.Size = new Size(176, 23);
            cmbStatusBudidaya.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 16);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 16;
            label2.Text = "Status";
            // 
            // cmbLahanBudidaya
            // 
            cmbLahanBudidaya.Cursor = Cursors.Hand;
            cmbLahanBudidaya.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLahanBudidaya.FormattingEnabled = true;
            cmbLahanBudidaya.Location = new Point(21, 34);
            cmbLahanBudidaya.Margin = new Padding(3, 2, 3, 2);
            cmbLahanBudidaya.Name = "cmbLahanBudidaya";
            cmbLahanBudidaya.Size = new Size(176, 23);
            cmbLahanBudidaya.TabIndex = 0;
            // 
            // dtpTanggalTanam
            // 
            dtpTanggalTanam.Format = DateTimePickerFormat.Short;
            dtpTanggalTanam.Location = new Point(21, 95);
            dtpTanggalTanam.Margin = new Padding(3, 2, 3, 2);
            dtpTanggalTanam.Name = "dtpTanggalTanam";
            dtpTanggalTanam.Size = new Size(219, 23);
            dtpTanggalTanam.TabIndex = 3;
            // 
            // labelTanggalTanam
            // 
            labelTanggalTanam.AutoSize = true;
            labelTanggalTanam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggalTanam.Location = new Point(21, 76);
            labelTanggalTanam.Name = "labelTanggalTanam";
            labelTanggalTanam.Size = new Size(110, 19);
            labelTanggalTanam.TabIndex = 3;
            labelTanggalTanam.Text = "Tanggal Tanam";
            // 
            // btnResetBudidayaTebu
            // 
            btnResetBudidayaTebu.BackColor = Color.Gray;
            btnResetBudidayaTebu.Cursor = Cursors.Hand;
            btnResetBudidayaTebu.FlatStyle = FlatStyle.Flat;
            btnResetBudidayaTebu.ForeColor = Color.White;
            btnResetBudidayaTebu.Location = new Point(404, 148);
            btnResetBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            btnResetBudidayaTebu.Name = "btnResetBudidayaTebu";
            btnResetBudidayaTebu.Size = new Size(92, 26);
            btnResetBudidayaTebu.TabIndex = 9;
            btnResetBudidayaTebu.Text = "Reset";
            btnResetBudidayaTebu.UseVisualStyleBackColor = false;
            btnResetBudidayaTebu.Click += btnResetBudidayaTebu_Click;
            // 
            // btnHapusBudidayaTebu
            // 
            btnHapusBudidayaTebu.BackColor = Color.Crimson;
            btnHapusBudidayaTebu.Cursor = Cursors.Hand;
            btnHapusBudidayaTebu.FlatStyle = FlatStyle.Flat;
            btnHapusBudidayaTebu.ForeColor = Color.White;
            btnHapusBudidayaTebu.Location = new Point(276, 148);
            btnHapusBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            btnHapusBudidayaTebu.Name = "btnHapusBudidayaTebu";
            btnHapusBudidayaTebu.Size = new Size(92, 26);
            btnHapusBudidayaTebu.TabIndex = 8;
            btnHapusBudidayaTebu.Text = "Hapus";
            btnHapusBudidayaTebu.UseVisualStyleBackColor = false;
            btnHapusBudidayaTebu.Click += btnHapusBudidayaTebu_Click;
            // 
            // btnUbahBudidayaTebu
            // 
            btnUbahBudidayaTebu.BackColor = Color.Orange;
            btnUbahBudidayaTebu.Cursor = Cursors.Hand;
            btnUbahBudidayaTebu.FlatStyle = FlatStyle.Flat;
            btnUbahBudidayaTebu.ForeColor = Color.White;
            btnUbahBudidayaTebu.Location = new Point(150, 148);
            btnUbahBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            btnUbahBudidayaTebu.Name = "btnUbahBudidayaTebu";
            btnUbahBudidayaTebu.Size = new Size(92, 26);
            btnUbahBudidayaTebu.TabIndex = 7;
            btnUbahBudidayaTebu.Text = "Ubah";
            btnUbahBudidayaTebu.UseVisualStyleBackColor = false;
            btnUbahBudidayaTebu.Click += btnUbahBudidayaTebu_Click;
            // 
            // btnTambahBudidayaTebu
            // 
            btnTambahBudidayaTebu.BackColor = Color.MediumSeaGreen;
            btnTambahBudidayaTebu.Cursor = Cursors.Hand;
            btnTambahBudidayaTebu.FlatStyle = FlatStyle.Flat;
            btnTambahBudidayaTebu.ForeColor = Color.White;
            btnTambahBudidayaTebu.Location = new Point(21, 148);
            btnTambahBudidayaTebu.Margin = new Padding(3, 2, 3, 2);
            btnTambahBudidayaTebu.Name = "btnTambahBudidayaTebu";
            btnTambahBudidayaTebu.Size = new Size(92, 26);
            btnTambahBudidayaTebu.TabIndex = 6;
            btnTambahBudidayaTebu.Text = "Tambah";
            btnTambahBudidayaTebu.UseVisualStyleBackColor = false;
            btnTambahBudidayaTebu.Click += btnTambahBudidayaTebu_Click;
            // 
            // txtJumlahtebu
            // 
            txtJumlahtebu.BackColor = Color.White;
            txtJumlahtebu.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahtebu.ForeColor = Color.Black;
            txtJumlahtebu.Location = new Point(237, 34);
            txtJumlahtebu.Margin = new Padding(3, 2, 3, 2);
            txtJumlahtebu.Name = "txtJumlahtebu";
            txtJumlahtebu.Size = new Size(132, 23);
            txtJumlahtebu.TabIndex = 1;
            // 
            // labelJumlahTebu
            // 
            labelJumlahTebu.AutoSize = true;
            labelJumlahTebu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJumlahTebu.Location = new Point(234, 16);
            labelJumlahTebu.Name = "labelJumlahTebu";
            labelJumlahTebu.Size = new Size(92, 19);
            labelJumlahTebu.TabIndex = 7;
            labelJumlahTebu.Text = "Jumlah Tebu";
            // 
            // labelPilihLahan
            // 
            labelPilihLahan.AutoSize = true;
            labelPilihLahan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPilihLahan.Location = new Point(21, 15);
            labelPilihLahan.Name = "labelPilihLahan";
            labelPilihLahan.Size = new Size(81, 19);
            labelPilihLahan.TabIndex = 5;
            labelPilihLahan.Text = "Pilih Lahan";
            // 
            // labelBudidayaTebu
            // 
            labelBudidayaTebu.AutoSize = true;
            labelBudidayaTebu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBudidayaTebu.ForeColor = Color.FromArgb(30, 41, 59);
            labelBudidayaTebu.Location = new Point(18, 10);
            labelBudidayaTebu.Name = "labelBudidayaTebu";
            labelBudidayaTebu.Size = new Size(348, 30);
            labelBudidayaTebu.TabIndex = 6;
            labelBudidayaTebu.Text = "Manajemen Data Budidaya Tebu";
            // 
            // FormBudidayaTebu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1162, 485);
            Controls.Add(dgvBudidayaTebu);
            Controls.Add(panelInputBudidayaTebu);
            Controls.Add(labelBudidayaTebu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBudidayaTebu";
            Text = "FormBudidayaTebu";
            ((System.ComponentModel.ISupportInitialize)dgvBudidayaTebu).EndInit();
            panelInputBudidayaTebu.ResumeLayout(false);
            panelInputBudidayaTebu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBudidayaTebu;
        private Panel panelInputBudidayaTebu;
        private ComboBox cmbLahanBudidaya;
        private DateTimePicker dtpTanggalTanam;
        private Button btnResetBudidayaTebu;
        private Button btnHapusBudidayaTebu;
        private Button btnUbahBudidayaTebu;
        private Button btnTambahBudidayaTebu;
        private TextBox txtJumlahtebu;
        private Label labelJumlahTebu;
        private Label labelPilihLahan;
        private Label labelTanggalTanam;
        private Label labelBudidayaTebu;
        private ComboBox cmbStatusBudidaya;
        private Label label2;
        private CheckBox checkBox1;
        private DateTimePicker dtpTanggalPanen;
        private Label labelTanggalPanen;
        private DataGridViewTextBoxColumn colLokasi;
        private DataGridViewTextBoxColumn colTglTanam;
        private DataGridViewTextBoxColumn colTglPanen;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colNamaPengguna;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIdLahan;
        private DataGridViewTextBoxColumn colIdPengguna;
        private DataGridViewTextBoxColumn colIsDelete;
    }
}