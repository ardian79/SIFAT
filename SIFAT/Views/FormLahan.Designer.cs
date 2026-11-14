namespace SIFAT.Views
{
    partial class FormLahan
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
            labelLahan = new Label();
            panelInputLahan = new Panel();
            btnResetLahan = new Button();
            btnHapusLahan = new Button();
            btnUbahLahan = new Button();
            btnTambahLahan = new Button();
            txtCatatanLahan = new TextBox();
            labelCatatan = new Label();
            txtLuasLahan = new TextBox();
            labelLuas = new Label();
            txtNamaLahan = new TextBox();
            labelLokasi = new Label();
            dgvLahan = new DataGridView();
            panelInputLahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            SuspendLayout();
            // 
            // labelLahan
            // 
            labelLahan.AutoSize = true;
            labelLahan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLahan.ForeColor = Color.FromArgb(30, 41, 59);
            labelLahan.Location = new Point(20, 20);
            labelLahan.Name = "labelLahan";
            labelLahan.Size = new Size(328, 38);
            labelLahan.TabIndex = 0;
            labelLahan.Text = "Manajemen Data Lahan";
            // 
            // panelInputLahan
            // 
            panelInputLahan.BackColor = Color.Transparent;
            panelInputLahan.BorderStyle = BorderStyle.FixedSingle;
            panelInputLahan.Controls.Add(btnResetLahan);
            panelInputLahan.Controls.Add(btnHapusLahan);
            panelInputLahan.Controls.Add(btnUbahLahan);
            panelInputLahan.Controls.Add(btnTambahLahan);
            panelInputLahan.Controls.Add(txtCatatanLahan);
            panelInputLahan.Controls.Add(labelCatatan);
            panelInputLahan.Controls.Add(txtLuasLahan);
            panelInputLahan.Controls.Add(labelLuas);
            panelInputLahan.Controls.Add(txtNamaLahan);
            panelInputLahan.Controls.Add(labelLokasi);
            panelInputLahan.Location = new Point(28, 60);
            panelInputLahan.Name = "panelInputLahan";
            panelInputLahan.Size = new Size(850, 150);
            panelInputLahan.TabIndex = 1;
            // 
            // btnResetLahan
            // 
            btnResetLahan.BackColor = Color.Gray;
            btnResetLahan.Cursor = Cursors.Hand;
            btnResetLahan.FlatStyle = FlatStyle.Flat;
            btnResetLahan.ForeColor = Color.White;
            btnResetLahan.Location = new Point(462, 98);
            btnResetLahan.Name = "btnResetLahan";
            btnResetLahan.Size = new Size(105, 34);
            btnResetLahan.TabIndex = 11;
            btnResetLahan.Text = "Reset";
            btnResetLahan.UseVisualStyleBackColor = false;
            btnResetLahan.Click += btnResetLahan_Click;
            // 
            // btnHapusLahan
            // 
            btnHapusLahan.BackColor = Color.Crimson;
            btnHapusLahan.Cursor = Cursors.Hand;
            btnHapusLahan.FlatStyle = FlatStyle.Flat;
            btnHapusLahan.ForeColor = Color.White;
            btnHapusLahan.Location = new Point(316, 98);
            btnHapusLahan.Name = "btnHapusLahan";
            btnHapusLahan.Size = new Size(105, 34);
            btnHapusLahan.TabIndex = 10;
            btnHapusLahan.Text = "Hapus";
            btnHapusLahan.UseVisualStyleBackColor = false;
            btnHapusLahan.Click += btnHapusLahan_Click;
            // 
            // btnUbahLahan
            // 
            btnUbahLahan.BackColor = Color.Orange;
            btnUbahLahan.Cursor = Cursors.Hand;
            btnUbahLahan.FlatStyle = FlatStyle.Flat;
            btnUbahLahan.ForeColor = Color.White;
            btnUbahLahan.Location = new Point(171, 98);
            btnUbahLahan.Name = "btnUbahLahan";
            btnUbahLahan.Size = new Size(105, 34);
            btnUbahLahan.TabIndex = 9;
            btnUbahLahan.Text = "Ubah";
            btnUbahLahan.UseVisualStyleBackColor = false;
            btnUbahLahan.Click += btnUbahLahan_Click;
            // 
            // btnTambahLahan
            // 
            btnTambahLahan.BackColor = Color.MediumSeaGreen;
            btnTambahLahan.Cursor = Cursors.Hand;
            btnTambahLahan.FlatStyle = FlatStyle.Flat;
            btnTambahLahan.ForeColor = Color.White;
            btnTambahLahan.Location = new Point(24, 98);
            btnTambahLahan.Name = "btnTambahLahan";
            btnTambahLahan.Size = new Size(105, 34);
            btnTambahLahan.TabIndex = 5;
            btnTambahLahan.Text = "Tambah";
            btnTambahLahan.UseVisualStyleBackColor = false;
            btnTambahLahan.Click += btnTambahLahan_Click;
            // 
            // txtCatatanLahan
            // 
            txtCatatanLahan.BackColor = Color.White;
            txtCatatanLahan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanLahan.ForeColor = Color.Black;
            txtCatatanLahan.Location = new Point(421, 45);
            txtCatatanLahan.Name = "txtCatatanLahan";
            txtCatatanLahan.Size = new Size(250, 27);
            txtCatatanLahan.TabIndex = 8;
            // 
            // labelCatatan
            // 
            labelCatatan.AutoSize = true;
            labelCatatan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCatatan.Location = new Point(421, 20);
            labelCatatan.Name = "labelCatatan";
            labelCatatan.Size = new Size(72, 23);
            labelCatatan.TabIndex = 7;
            labelCatatan.Text = "Catatan";
            // 
            // txtLuasLahan
            // 
            txtLuasLahan.BackColor = Color.White;
            txtLuasLahan.BorderStyle = BorderStyle.FixedSingle;
            txtLuasLahan.ForeColor = Color.Black;
            txtLuasLahan.Location = new Point(273, 45);
            txtLuasLahan.Name = "txtLuasLahan";
            txtLuasLahan.Size = new Size(100, 27);
            txtLuasLahan.TabIndex = 6;
            // 
            // labelLuas
            // 
            labelLuas.AutoSize = true;
            labelLuas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLuas.Location = new Point(273, 20);
            labelLuas.Name = "labelLuas";
            labelLuas.Size = new Size(84, 23);
            labelLuas.TabIndex = 5;
            labelLuas.Text = "Luas (Ha)";
            // 
            // txtNamaLahan
            // 
            txtNamaLahan.BackColor = Color.White;
            txtNamaLahan.BorderStyle = BorderStyle.FixedSingle;
            txtNamaLahan.ForeColor = Color.Black;
            txtNamaLahan.Location = new Point(24, 45);
            txtNamaLahan.Name = "txtNamaLahan";
            txtNamaLahan.Size = new Size(200, 27);
            txtNamaLahan.TabIndex = 4;
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLokasi.Location = new Point(24, 19);
            labelLokasi.Name = "labelLokasi";
            labelLokasi.Size = new Size(112, 23);
            labelLokasi.TabIndex = 3;
            labelLokasi.Text = "Nama Lokasi";
            // 
            // dgvLahan
            // 
            dgvLahan.AllowUserToAddRows = false;
            dgvLahan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLahan.Location = new Point(28, 230);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.ReadOnly = true;
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(1950, 250);
            dgvLahan.TabIndex = 2;
            dgvLahan.CellClick += dgvLahan_CellClick;
            // 
            // FormLahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2005, 889);
            Controls.Add(dgvLahan);
            Controls.Add(panelInputLahan);
            Controls.Add(labelLahan);
            Name = "FormLahan";
            Text = "FormLahan";
            panelInputLahan.ResumeLayout(false);
            panelInputLahan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLahan;
        private Panel panelInputLahan;
        private Label labelLokasi;
        private TextBox txtNamaLahan;
        private TextBox txtLuasLahan;
        private Label labelLuas;
        private TextBox txtCatatanLahan;
        private Label labelCatatan;
        private Button btnTambahLahan;
        private Button btnResetLahan;
        private Button btnHapusLahan;
        private Button btnUbahLahan;
        private DataGridView dgvLahan;
    }
}