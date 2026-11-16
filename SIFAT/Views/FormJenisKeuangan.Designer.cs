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
            dgvJenisKeuangan.Location = new Point(24, 172);
            dgvJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            dgvJenisKeuangan.Name = "dgvJenisKeuangan";
            dgvJenisKeuangan.ReadOnly = true;
            dgvJenisKeuangan.RowHeadersWidth = 51;
            dgvJenisKeuangan.Size = new Size(1113, 227);
            dgvJenisKeuangan.TabIndex = 6;
            dgvJenisKeuangan.CellClick += dgvJenisKeuangan_CellClick;
            // 
            // colNamaJenis
            // 
            colNamaJenis.DataPropertyName = "NamaJenis";
            colNamaJenis.HeaderText = "Nama Jenis";
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
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
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
            // panelInputJenisKeuangan
            // 
            panelInputJenisKeuangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInputJenisKeuangan.BackColor = Color.Transparent;
            panelInputJenisKeuangan.Controls.Add(cmbKategoriJenis);
            panelInputJenisKeuangan.Controls.Add(btnResetJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnHapusJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnUbahJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(btnTambahJenisKeuangan);
            panelInputJenisKeuangan.Controls.Add(txtNamaJenis);
            panelInputJenisKeuangan.Controls.Add(labelNamaJenis);
            panelInputJenisKeuangan.Controls.Add(labelKategori);
            panelInputJenisKeuangan.Location = new Point(24, 45);
            panelInputJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            panelInputJenisKeuangan.Name = "panelInputJenisKeuangan";
            panelInputJenisKeuangan.Size = new Size(1113, 112);
            panelInputJenisKeuangan.TabIndex = 5;
            // 
            // cmbKategoriJenis
            // 
            cmbKategoriJenis.Cursor = Cursors.Hand;
            cmbKategoriJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriJenis.FormattingEnabled = true;
            cmbKategoriJenis.Location = new Point(284, 33);
            cmbKategoriJenis.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriJenis.Name = "cmbKategoriJenis";
            cmbKategoriJenis.Size = new Size(176, 23);
            cmbKategoriJenis.TabIndex = 1;
            // 
            // btnResetJenisKeuangan
            // 
            btnResetJenisKeuangan.BackColor = Color.Gray;
            btnResetJenisKeuangan.Cursor = Cursors.Hand;
            btnResetJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnResetJenisKeuangan.ForeColor = Color.White;
            btnResetJenisKeuangan.Location = new Point(404, 73);
            btnResetJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnResetJenisKeuangan.Name = "btnResetJenisKeuangan";
            btnResetJenisKeuangan.Size = new Size(92, 26);
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
            btnHapusJenisKeuangan.Location = new Point(276, 73);
            btnHapusJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnHapusJenisKeuangan.Name = "btnHapusJenisKeuangan";
            btnHapusJenisKeuangan.Size = new Size(92, 26);
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
            btnUbahJenisKeuangan.Location = new Point(150, 73);
            btnUbahJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnUbahJenisKeuangan.Name = "btnUbahJenisKeuangan";
            btnUbahJenisKeuangan.Size = new Size(92, 26);
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
            btnTambahJenisKeuangan.Location = new Point(21, 73);
            btnTambahJenisKeuangan.Margin = new Padding(3, 2, 3, 2);
            btnTambahJenisKeuangan.Name = "btnTambahJenisKeuangan";
            btnTambahJenisKeuangan.Size = new Size(92, 26);
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
            txtNamaJenis.Location = new Point(21, 33);
            txtNamaJenis.Margin = new Padding(3, 2, 3, 2);
            txtNamaJenis.Name = "txtNamaJenis";
            txtNamaJenis.Size = new Size(219, 23);
            txtNamaJenis.TabIndex = 0;
            // 
            // labelNamaJenis
            // 
            labelNamaJenis.AutoSize = true;
            labelNamaJenis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaJenis.Location = new Point(21, 14);
            labelNamaJenis.Name = "labelNamaJenis";
            labelNamaJenis.Size = new Size(85, 19);
            labelNamaJenis.TabIndex = 7;
            labelNamaJenis.Text = "Nama Jenis";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKategori.Location = new Point(284, 13);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(67, 19);
            labelKategori.TabIndex = 5;
            labelKategori.Text = "Kategori";
            // 
            // labelJenisKeuangan
            // 
            labelJenisKeuangan.AutoSize = true;
            labelJenisKeuangan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJenisKeuangan.ForeColor = Color.FromArgb(30, 41, 59);
            labelJenisKeuangan.Location = new Point(18, 15);
            labelJenisKeuangan.Name = "labelJenisKeuangan";
            labelJenisKeuangan.Size = new Size(355, 30);
            labelJenisKeuangan.TabIndex = 6;
            labelJenisKeuangan.Text = "Manajemen Data Jenis Keuangan";
            // 
            // FormJenisKeuangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1161, 490);
            Controls.Add(dgvJenisKeuangan);
            Controls.Add(panelInputJenisKeuangan);
            Controls.Add(labelJenisKeuangan);
            Margin = new Padding(3, 2, 3, 2);
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