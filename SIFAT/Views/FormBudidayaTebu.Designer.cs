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
            dgvBudidayaTebu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudidayaTebu.Location = new Point(28, 330);
            dgvBudidayaTebu.Name = "dgvBudidayaTebu";
            dgvBudidayaTebu.ReadOnly = true;
            dgvBudidayaTebu.RowHeadersWidth = 51;
            dgvBudidayaTebu.Size = new Size(1950, 250);
            dgvBudidayaTebu.TabIndex = 8;
            dgvBudidayaTebu.CellClick += dgvBudidayaTebu_CellClick;
            // 
            // panelInputBudidayaTebu
            // 
            panelInputBudidayaTebu.BackColor = Color.Transparent;
            panelInputBudidayaTebu.BorderStyle = BorderStyle.FixedSingle;
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
            panelInputBudidayaTebu.Location = new Point(28, 60);
            panelInputBudidayaTebu.Name = "panelInputBudidayaTebu";
            panelInputBudidayaTebu.Size = new Size(850, 250);
            panelInputBudidayaTebu.TabIndex = 7;
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Enabled = false;
            dtpTanggalPanen.Format = DateTimePickerFormat.Short;
            dtpTanggalPanen.Location = new Point(466, 127);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(250, 27);
            dtpTanggalPanen.TabIndex = 20;
            // 
            // labelTanggalPanen
            // 
            labelTanggalPanen.AutoSize = true;
            labelTanggalPanen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggalPanen.Location = new Point(466, 101);
            labelTanggalPanen.Name = "labelTanggalPanen";
            labelTanggalPanen.Size = new Size(127, 23);
            labelTanggalPanen.TabIndex = 19;
            labelTanggalPanen.Text = "Tanggal Panen";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(311, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Sudah Panen?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cmbStatusBudidaya
            // 
            cmbStatusBudidaya.Cursor = Cursors.Hand;
            cmbStatusBudidaya.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusBudidaya.FormattingEnabled = true;
            cmbStatusBudidaya.Location = new Point(466, 46);
            cmbStatusBudidaya.Name = "cmbStatusBudidaya";
            cmbStatusBudidaya.Size = new Size(200, 28);
            cmbStatusBudidaya.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 21);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 16;
            label2.Text = "Status";
            // 
            // cmbLahanBudidaya
            // 
            cmbLahanBudidaya.Cursor = Cursors.Hand;
            cmbLahanBudidaya.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLahanBudidaya.FormattingEnabled = true;
            cmbLahanBudidaya.Location = new Point(24, 45);
            cmbLahanBudidaya.Name = "cmbLahanBudidaya";
            cmbLahanBudidaya.Size = new Size(200, 28);
            cmbLahanBudidaya.TabIndex = 13;
            // 
            // dtpTanggalTanam
            // 
            dtpTanggalTanam.Format = DateTimePickerFormat.Short;
            dtpTanggalTanam.Location = new Point(24, 127);
            dtpTanggalTanam.Name = "dtpTanggalTanam";
            dtpTanggalTanam.Size = new Size(250, 27);
            dtpTanggalTanam.TabIndex = 12;
            // 
            // labelTanggalTanam
            // 
            labelTanggalTanam.AutoSize = true;
            labelTanggalTanam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTanggalTanam.Location = new Point(24, 101);
            labelTanggalTanam.Name = "labelTanggalTanam";
            labelTanggalTanam.Size = new Size(132, 23);
            labelTanggalTanam.TabIndex = 3;
            labelTanggalTanam.Text = "Tanggal Tanam";
            // 
            // btnResetBudidayaTebu
            // 
            btnResetBudidayaTebu.BackColor = Color.Gray;
            btnResetBudidayaTebu.Cursor = Cursors.Hand;
            btnResetBudidayaTebu.FlatStyle = FlatStyle.Flat;
            btnResetBudidayaTebu.ForeColor = Color.White;
            btnResetBudidayaTebu.Location = new Point(462, 198);
            btnResetBudidayaTebu.Name = "btnResetBudidayaTebu";
            btnResetBudidayaTebu.Size = new Size(105, 34);
            btnResetBudidayaTebu.TabIndex = 11;
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
            btnHapusBudidayaTebu.Location = new Point(316, 198);
            btnHapusBudidayaTebu.Name = "btnHapusBudidayaTebu";
            btnHapusBudidayaTebu.Size = new Size(105, 34);
            btnHapusBudidayaTebu.TabIndex = 10;
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
            btnUbahBudidayaTebu.Location = new Point(171, 198);
            btnUbahBudidayaTebu.Name = "btnUbahBudidayaTebu";
            btnUbahBudidayaTebu.Size = new Size(105, 34);
            btnUbahBudidayaTebu.TabIndex = 9;
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
            btnTambahBudidayaTebu.Location = new Point(24, 198);
            btnTambahBudidayaTebu.Name = "btnTambahBudidayaTebu";
            btnTambahBudidayaTebu.Size = new Size(105, 34);
            btnTambahBudidayaTebu.TabIndex = 5;
            btnTambahBudidayaTebu.Text = "Tambah";
            btnTambahBudidayaTebu.UseVisualStyleBackColor = false;
            btnTambahBudidayaTebu.Click += btnTambahBudidayaTebu_Click;
            // 
            // txtJumlahtebu
            // 
            txtJumlahtebu.BackColor = Color.White;
            txtJumlahtebu.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahtebu.ForeColor = Color.Black;
            txtJumlahtebu.Location = new Point(271, 46);
            txtJumlahtebu.Name = "txtJumlahtebu";
            txtJumlahtebu.Size = new Size(150, 27);
            txtJumlahtebu.TabIndex = 8;
            // 
            // labelJumlahTebu
            // 
            labelJumlahTebu.AutoSize = true;
            labelJumlahTebu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJumlahTebu.Location = new Point(267, 21);
            labelJumlahTebu.Name = "labelJumlahTebu";
            labelJumlahTebu.Size = new Size(111, 23);
            labelJumlahTebu.TabIndex = 7;
            labelJumlahTebu.Text = "Jumlah Tebu";
            // 
            // labelPilihLahan
            // 
            labelPilihLahan.AutoSize = true;
            labelPilihLahan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPilihLahan.Location = new Point(24, 20);
            labelPilihLahan.Name = "labelPilihLahan";
            labelPilihLahan.Size = new Size(97, 23);
            labelPilihLahan.TabIndex = 5;
            labelPilihLahan.Text = "Pilih Lahan";
            // 
            // labelBudidayaTebu
            // 
            labelBudidayaTebu.AutoSize = true;
            labelBudidayaTebu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBudidayaTebu.ForeColor = Color.FromArgb(30, 41, 59);
            labelBudidayaTebu.Location = new Point(20, 20);
            labelBudidayaTebu.Name = "labelBudidayaTebu";
            labelBudidayaTebu.Size = new Size(442, 38);
            labelBudidayaTebu.TabIndex = 6;
            labelBudidayaTebu.Text = "Manajemen Data Budidaya Tebu";
            // 
            // FormBudidayaTebu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2006, 888);
            Controls.Add(dgvBudidayaTebu);
            Controls.Add(panelInputBudidayaTebu);
            Controls.Add(labelBudidayaTebu);
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
    }
}