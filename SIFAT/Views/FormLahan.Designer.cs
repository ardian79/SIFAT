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
            colNamaLokasi = new DataGridViewTextBoxColumn();
            colLuas = new DataGridViewTextBoxColumn();
            colCatatan = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            panelInputLahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLahan).BeginInit();
            SuspendLayout();
            // 
            // labelLahan
            // 
            labelLahan.AutoSize = true;
            labelLahan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLahan.ForeColor = Color.FromArgb(30, 41, 59);
            labelLahan.Location = new Point(18, 15);
            labelLahan.Name = "labelLahan";
            labelLahan.Size = new Size(256, 30);
            labelLahan.TabIndex = 0;
            labelLahan.Text = "Manajemen Data Lahan";
            // 
            // panelInputLahan
            // 
            panelInputLahan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInputLahan.BackColor = Color.Transparent;
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
            panelInputLahan.Location = new Point(24, 45);
            panelInputLahan.Margin = new Padding(3, 2, 3, 2);
            panelInputLahan.Name = "panelInputLahan";
            panelInputLahan.Size = new Size(1112, 112);
            panelInputLahan.TabIndex = 1;
            // 
            // btnResetLahan
            // 
            btnResetLahan.BackColor = Color.Gray;
            btnResetLahan.Cursor = Cursors.Hand;
            btnResetLahan.FlatStyle = FlatStyle.Flat;
            btnResetLahan.ForeColor = Color.White;
            btnResetLahan.Location = new Point(404, 73);
            btnResetLahan.Margin = new Padding(3, 2, 3, 2);
            btnResetLahan.Name = "btnResetLahan";
            btnResetLahan.Size = new Size(92, 26);
            btnResetLahan.TabIndex = 6;
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
            btnHapusLahan.Location = new Point(276, 73);
            btnHapusLahan.Margin = new Padding(3, 2, 3, 2);
            btnHapusLahan.Name = "btnHapusLahan";
            btnHapusLahan.Size = new Size(92, 26);
            btnHapusLahan.TabIndex = 5;
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
            btnUbahLahan.Location = new Point(150, 73);
            btnUbahLahan.Margin = new Padding(3, 2, 3, 2);
            btnUbahLahan.Name = "btnUbahLahan";
            btnUbahLahan.Size = new Size(92, 26);
            btnUbahLahan.TabIndex = 4;
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
            btnTambahLahan.Location = new Point(21, 73);
            btnTambahLahan.Margin = new Padding(3, 2, 3, 2);
            btnTambahLahan.Name = "btnTambahLahan";
            btnTambahLahan.Size = new Size(92, 26);
            btnTambahLahan.TabIndex = 3;
            btnTambahLahan.Text = "Tambah";
            btnTambahLahan.UseVisualStyleBackColor = false;
            btnTambahLahan.Click += btnTambahLahan_Click;
            // 
            // txtCatatanLahan
            // 
            txtCatatanLahan.BackColor = Color.White;
            txtCatatanLahan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanLahan.ForeColor = Color.Black;
            txtCatatanLahan.Location = new Point(368, 33);
            txtCatatanLahan.Margin = new Padding(3, 2, 3, 2);
            txtCatatanLahan.Name = "txtCatatanLahan";
            txtCatatanLahan.Size = new Size(219, 23);
            txtCatatanLahan.TabIndex = 2;
            // 
            // labelCatatan
            // 
            labelCatatan.AutoSize = true;
            labelCatatan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCatatan.Location = new Point(368, 14);
            labelCatatan.Name = "labelCatatan";
            labelCatatan.Size = new Size(60, 19);
            labelCatatan.TabIndex = 7;
            labelCatatan.Text = "Catatan";
            // 
            // txtLuasLahan
            // 
            txtLuasLahan.BackColor = Color.White;
            txtLuasLahan.BorderStyle = BorderStyle.FixedSingle;
            txtLuasLahan.ForeColor = Color.Black;
            txtLuasLahan.Location = new Point(239, 33);
            txtLuasLahan.Margin = new Padding(3, 2, 3, 2);
            txtLuasLahan.Name = "txtLuasLahan";
            txtLuasLahan.Size = new Size(88, 23);
            txtLuasLahan.TabIndex = 1;
            // 
            // labelLuas
            // 
            labelLuas.AutoSize = true;
            labelLuas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLuas.Location = new Point(239, 14);
            labelLuas.Name = "labelLuas";
            labelLuas.Size = new Size(71, 19);
            labelLuas.TabIndex = 5;
            labelLuas.Text = "Luas (Ha)";
            // 
            // txtNamaLahan
            // 
            txtNamaLahan.BackColor = Color.White;
            txtNamaLahan.BorderStyle = BorderStyle.FixedSingle;
            txtNamaLahan.ForeColor = Color.Black;
            txtNamaLahan.Location = new Point(21, 33);
            txtNamaLahan.Margin = new Padding(3, 2, 3, 2);
            txtNamaLahan.Name = "txtNamaLahan";
            txtNamaLahan.Size = new Size(175, 23);
            txtNamaLahan.TabIndex = 0;
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLokasi.Location = new Point(21, 13);
            labelLokasi.Name = "labelLokasi";
            labelLokasi.Size = new Size(95, 19);
            labelLokasi.TabIndex = 3;
            labelLokasi.Text = "Nama Lokasi";
            // 
            // dgvLahan
            // 
            dgvLahan.AllowUserToAddRows = false;
            dgvLahan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLahan.BackgroundColor = Color.White;
            dgvLahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLahan.Columns.AddRange(new DataGridViewColumn[] { colNamaLokasi, colLuas, colCatatan, colId, colIsDelete });
            dgvLahan.Location = new Point(24, 172);
            dgvLahan.Margin = new Padding(3, 2, 3, 2);
            dgvLahan.Name = "dgvLahan";
            dgvLahan.ReadOnly = true;
            dgvLahan.RowHeadersWidth = 51;
            dgvLahan.Size = new Size(1112, 225);
            dgvLahan.TabIndex = 2;
            dgvLahan.CellClick += dgvLahan_CellClick;
            // 
            // colNamaLokasi
            // 
            colNamaLokasi.DataPropertyName = "NamaLokasi";
            colNamaLokasi.HeaderText = "Nama Lokasi";
            colNamaLokasi.MinimumWidth = 6;
            colNamaLokasi.Name = "colNamaLokasi";
            colNamaLokasi.ReadOnly = true;
            // 
            // colLuas
            // 
            colLuas.DataPropertyName = "LuasLahan";
            colLuas.HeaderText = "Luas (Ha)";
            colLuas.MinimumWidth = 6;
            colLuas.Name = "colLuas";
            colLuas.ReadOnly = true;
            // 
            // colCatatan
            // 
            colCatatan.DataPropertyName = "Catatan";
            colCatatan.HeaderText = "Catatan";
            colCatatan.MinimumWidth = 6;
            colCatatan.Name = "colCatatan";
            colCatatan.ReadOnly = true;
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
            // FormLahan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1160, 488);
            Controls.Add(dgvLahan);
            Controls.Add(panelInputLahan);
            Controls.Add(labelLahan);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn colNamaLokasi;
        private DataGridViewTextBoxColumn colLuas;
        private DataGridViewTextBoxColumn colCatatan;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIsDelete;
    }
}