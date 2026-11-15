namespace SIFAT.Views
{
    partial class FormJenisKeuangan
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
            dgvJenisKeuangan = new DataGridView();
            colNamaJenis = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            panelInputJenisKeuangan = new Panel();
            cmbKategoriJenis = new ComboBox();
            btnResetJenisKeuangan = new Button();
            btnHapusJenisKeuangan = new Button();
            btnUbahJenisKeuangan = new Button();
            btnTambahJenisKeuangan = new Button();
            txtNamaJenis = new TextBox();
            labelNamaJenis = new Label();
            labelKategori = new Label();
            labelJenisKeuangan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJenisKeuangan).BeginInit();
            panelInputJenisKeuangan.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJenisKeuangan
            // 
            dgvJenisKeuangan.AllowUserToAddRows = false;
            dgvJenisKeuangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvJenisKeuangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJenisKeuangan.BackgroundColor = Color.White;
            dgvJenisKeuangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJenisKeuangan.Columns.AddRange(new DataGridViewColumn[] { colNamaJenis, colKategori, colId, colIsDelete });
            dgvJenisKeuangan.Location = new Point(28, 230);
            dgvJenisKeuangan.Name = "dgvJenisKeuangan";
            dgvJenisKeuangan.ReadOnly = true;
            dgvJenisKeuangan.RowHeadersWidth = 51;
            dgvJenisKeuangan.Size = new Size(1950, 250);
            dgvJenisKeuangan.TabIndex = 6;
            dgvJenisKeuangan.CellClick += dgvJenisKeuangan_CellClick;
            // 
            // colNamaJenis
            // 
            colNamaJenis.DataPropertyName = "NamaJenis";
            colNamaJenis.HeaderText = "Nama Jenis";
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
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "Id";
            colId.ReadOnly = true;
            colId.Visible = false;
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
            // panelInputJenisKeuangan
            // 
            panelInputJenisKeuangan.BackColor = Color.Transparent;
            panelInputJenisKeuangan.Controls.Add(cmbKategoriJenis);
            panelInputJenisKeuangan.Controls.Add(btnResetJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnHapusJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnUbahJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnTambahJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(txtNamaJenis);
            panelInputJenisKeuangan.Controls.Add(labelNamaJenis);
            panelInputJenisKeuangan.Controls.Add(labelKategori);
            panelInputJenisKeuangan.Location = new Point(28, 60);
            panelInputJenisKeuangan.Name = "panelInputJenisKeuangan";
            panelInputJenisKeuangan.Size = new Size(850, 150);
            panelInputJenisKeuangan.TabIndex = 5;
            // 
            // cmbKategoriJenis
            // 
            cmbKategoriJenis.Cursor = Cursors.Hand;
            cmbKategoriJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriJenis.FormattingEnabled = true;
            cmbKategoriJenis.Location = new Point(325, 45);
            cmbKategoriJenis.Name = "cmbKategoriJenis";
            cmbKategoriJenis.Size = new Size(200, 28);
            cmbKategoriJenis.TabIndex = 1;
            // 
            // btnResetJenisKeuangan
            // 
            btnResetJenisKeuangan.BackColor = Color.Gray;
            btnResetJenisKeuangan.Cursor = Cursors.Hand;
            btnResetJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnResetJenisKeuangan.ForeColor = Color.White;
            btnResetJenisKeuangan.Location = new Point(462, 98);
            btnResetJenisKeuangan.Name = "btnResetJenisKeuangan";
            btnResetJenisKeuangan.Size = new Size(105, 34);
            btnResetJenisKeuangan.TabIndex = 5;
            btnResetJenisKeuangan.Text = "Reset";
            btnResetJenisKeuangan.UseVisualStyleBackColor = false;
            btnResetJenisKeuangan.Click += btnResetJenisKeuangan_Click;
            // 
            // btnHapusJenisKeuangan
            // 
            btnHapusJenisKeuangan.BackColor = Color.Crimson;
            btnHapusJenisKeuangan.Cursor = Cursors.Hand;
            btnHapusJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnHapusJenisKeuangan.ForeColor = Color.White;
            btnHapusJenisKeuangan.Location = new Point(316, 98);
            btnHapusJenisKeuangan.Name = "btnHapusJenisKeuangan";
            btnHapusJenisKeuangan.Size = new Size(105, 34);
            btnHapusJenisKeuangan.TabIndex = 4;
            btnHapusJenisKeuangan.Text = "Hapus";
            btnHapusJenisKeuangan.UseVisualStyleBackColor = false;
            btnHapusJenisKeuangan.Click += btnHapusJenisKeuangan_Click;
            // 
            // btnUbahJenisKeuangan
            // 
            btnUbahJenisKeuangan.BackColor = Color.Orange;
            btnUbahJenisKeuangan.Cursor = Cursors.Hand;
            btnUbahJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnUbahJenisKeuangan.ForeColor = Color.White;
            btnUbahJenisKeuangan.Location = new Point(171, 98);
            btnUbahJenisKeuangan.Name = "btnUbahJenisKeuangan";
            btnUbahJenisKeuangan.Size = new Size(105, 34);
            btnUbahJenisKeuangan.TabIndex = 3;
            btnUbahJenisKeuangan.Text = "Ubah";
            btnUbahJenisKeuangan.UseVisualStyleBackColor = false;
            btnUbahJenisKeuangan.Click += btnUbahJenisKeuangan_Click;
            // 
            // btnTambahJenisKeuangan
            // 
            btnTambahJenisKeuangan.BackColor = Color.MediumSeaGreen;
            btnTambahJenisKeuangan.Cursor = Cursors.Hand;
            btnTambahJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnTambahJenisKeuangan.ForeColor = Color.White;
            btnTambahJenisKeuangan.Location = new Point(24, 98);
            btnTambahJenisKeuangan.Name = "btnTambahJenisKeuangan";
            btnTambahJenisKeuangan.Size = new Size(105, 34);
            btnTambahJenisKeuangan.TabIndex = 2;
            btnTambahJenisKeuangan.Text = "Tambah";
            btnTambahJenisKeuangan.UseVisualStyleBackColor = false;
            btnTambahJenisKeuangan.Click += btnTambahJenisKeuangan_Click;
            // 
            // txtNamaJenis
            // 
            txtNamaJenis.BackColor = Color.White;
            txtNamaJenis.BorderStyle = BorderStyle.FixedSingle;
            txtNamaJenis.ForeColor = Color.Black;
            txtNamaJenis.Location = new Point(24, 45);
            txtNamaJenis.Name = "txtNamaJenis";
            txtNamaJenis.Size = new Size(250, 27);
            txtNamaJenis.TabIndex = 0;
            // 
            // labelNamaJenis
            // 
            labelNamaJenis.AutoSize = true;
            labelNamaJenis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaJenis.Location = new Point(24, 20);
            labelNamaJenis.Name = "labelNamaJenis";
            labelNamaJenis.Size = new Size(101, 23);
            labelNamaJenis.TabIndex = 7;
            labelNamaJenis.Text = "Nama Jenis";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKategori.Location = new Point(325, 19);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(79, 23);
            labelKategori.TabIndex = 5;
            labelKategori.Text = "Kategori";
            // 
            // labelJenisKeuangan
            // 
            labelJenisKeuangan.AutoSize = true;
            labelJenisKeuangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJenisKeuangan.ForeColor = Color.FromArgb(30, 41, 59);
            labelJenisKeuangan.Location = new Point(20, 20);
            labelJenisKeuangan.Name = "labelJenisKeuangan";
            labelJenisKeuangan.Size = new Size(453, 38);
            labelJenisKeuangan.TabIndex = 6;
            labelJenisKeuangan.Text = "Manajemen Data Jenis Keuangan";
            // 
            // FormJenisKeuangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2007, 891);
            Controls.Add(dgvJenisKeuangan);
            Controls.Add(panelInputJenisKeuangan);
            Controls.Add(labelJenisKeuangan);
            Name = "FormJenisKeuangan";
            Text = "FormJenisKeuangan";
            ((System.ComponentModel.ISupportInitialize)dgvJenisKeuangan).EndInit();
            panelInputJenisKeuangan.ResumeLayout(false);
            panelInputJenisKeuangan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvJenisKeuangan;
        private DataGridViewTextBoxColumn colNamaJenis;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIsDelete;
        private Panel panelInputJenisKeuangan;
        private ComboBox cmbKategoriJenis;
        private Button btnResetJenisKeuangan;
        private Button btnHapusJenisKeuangan;
        private Button btnUbahJenisKeuangan;
        private Button btnTambahJenisKeuangan;
        private TextBox txtNamaJenis;
        private Label labelNamaJenis;
        private Label labelKategori;
        private Label labelJenisKeuangan;
    }
}