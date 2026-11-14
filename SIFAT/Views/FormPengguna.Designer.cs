namespace SIFAT.Views
{
    partial class FormPengguna
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
            labelPassword = new Label();
            panelInputPengguna = new Panel();
            btnResetPengguna = new Button();
            btnHapusPengguna = new Button();
            btnUbahPengguna = new Button();
            btnTambahPengguna = new Button();
            txtPasswordPengguna = new TextBox();
            txtUsernamePengguna = new TextBox();
            labelUsername = new Label();
            txtNamaLengkapPengguna = new TextBox();
            labelNamaLengkap = new Label();
            labelBuruhTani = new Label();
            dgvPengguna = new DataGridView();
            panelInputPengguna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(520, 20);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(85, 23);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // panelInputPengguna
            // 
            panelInputPengguna.BackColor = Color.Transparent;
            panelInputPengguna.BorderStyle = BorderStyle.FixedSingle;
            panelInputPengguna.Controls.Add(btnResetPengguna);
            panelInputPengguna.Controls.Add(btnHapusPengguna);
            panelInputPengguna.Controls.Add(btnUbahPengguna);
            panelInputPengguna.Controls.Add(btnTambahPengguna);
            panelInputPengguna.Controls.Add(txtPasswordPengguna);
            panelInputPengguna.Controls.Add(labelPassword);
            panelInputPengguna.Controls.Add(txtUsernamePengguna);
            panelInputPengguna.Controls.Add(labelUsername);
            panelInputPengguna.Controls.Add(txtNamaLengkapPengguna);
            panelInputPengguna.Controls.Add(labelNamaLengkap);
            panelInputPengguna.Location = new Point(28, 60);
            panelInputPengguna.Name = "panelInputPengguna";
            panelInputPengguna.Size = new Size(850, 150);
            panelInputPengguna.TabIndex = 4;
            // 
            // btnResetPengguna
            // 
            btnResetPengguna.BackColor = Color.Gray;
            btnResetPengguna.Cursor = Cursors.Hand;
            btnResetPengguna.FlatStyle = FlatStyle.Flat;
            btnResetPengguna.ForeColor = Color.White;
            btnResetPengguna.Location = new Point(462, 98);
            btnResetPengguna.Name = "btnResetPengguna";
            btnResetPengguna.Size = new Size(105, 34);
            btnResetPengguna.TabIndex = 11;
            btnResetPengguna.Text = "Reset";
            btnResetPengguna.UseVisualStyleBackColor = false;
            btnResetPengguna.Click += btnResetPengguna_Click;
            // 
            // btnHapusPengguna
            // 
            btnHapusPengguna.BackColor = Color.Crimson;
            btnHapusPengguna.Cursor = Cursors.Hand;
            btnHapusPengguna.FlatStyle = FlatStyle.Flat;
            btnHapusPengguna.ForeColor = Color.White;
            btnHapusPengguna.Location = new Point(316, 98);
            btnHapusPengguna.Name = "btnHapusPengguna";
            btnHapusPengguna.Size = new Size(105, 34);
            btnHapusPengguna.TabIndex = 10;
            btnHapusPengguna.Text = "Hapus";
            btnHapusPengguna.UseVisualStyleBackColor = false;
            btnHapusPengguna.Click += btnHapusPengguna_Click;
            // 
            // btnUbahPengguna
            // 
            btnUbahPengguna.BackColor = Color.Orange;
            btnUbahPengguna.Cursor = Cursors.Hand;
            btnUbahPengguna.FlatStyle = FlatStyle.Flat;
            btnUbahPengguna.ForeColor = Color.White;
            btnUbahPengguna.Location = new Point(171, 98);
            btnUbahPengguna.Name = "btnUbahPengguna";
            btnUbahPengguna.Size = new Size(105, 34);
            btnUbahPengguna.TabIndex = 9;
            btnUbahPengguna.Text = "Ubah";
            btnUbahPengguna.UseVisualStyleBackColor = false;
            btnUbahPengguna.Click += btnUbahPengguna_Click;
            // 
            // btnTambahPengguna
            // 
            btnTambahPengguna.BackColor = Color.MediumSeaGreen;
            btnTambahPengguna.Cursor = Cursors.Hand;
            btnTambahPengguna.FlatStyle = FlatStyle.Flat;
            btnTambahPengguna.ForeColor = Color.White;
            btnTambahPengguna.Location = new Point(24, 98);
            btnTambahPengguna.Name = "btnTambahPengguna";
            btnTambahPengguna.Size = new Size(105, 34);
            btnTambahPengguna.TabIndex = 5;
            btnTambahPengguna.Text = "Tambah";
            btnTambahPengguna.UseVisualStyleBackColor = false;
            btnTambahPengguna.Click += btnTambahPengguna_Click;
            // 
            // txtPasswordPengguna
            // 
            txtPasswordPengguna.BackColor = Color.White;
            txtPasswordPengguna.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordPengguna.ForeColor = Color.Black;
            txtPasswordPengguna.Location = new Point(520, 45);
            txtPasswordPengguna.Name = "txtPasswordPengguna";
            txtPasswordPengguna.PasswordChar = '*';
            txtPasswordPengguna.Size = new Size(200, 27);
            txtPasswordPengguna.TabIndex = 8;
            // 
            // txtUsernamePengguna
            // 
            txtUsernamePengguna.BackColor = Color.White;
            txtUsernamePengguna.BorderStyle = BorderStyle.FixedSingle;
            txtUsernamePengguna.ForeColor = Color.Black;
            txtUsernamePengguna.Location = new Point(273, 45);
            txtUsernamePengguna.Name = "txtUsernamePengguna";
            txtUsernamePengguna.Size = new Size(200, 27);
            txtUsernamePengguna.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(273, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // txtNamaLengkapPengguna
            // 
            txtNamaLengkapPengguna.BackColor = Color.White;
            txtNamaLengkapPengguna.BorderStyle = BorderStyle.FixedSingle;
            txtNamaLengkapPengguna.ForeColor = Color.Black;
            txtNamaLengkapPengguna.Location = new Point(24, 45);
            txtNamaLengkapPengguna.Name = "txtNamaLengkapPengguna";
            txtNamaLengkapPengguna.Size = new Size(200, 27);
            txtNamaLengkapPengguna.TabIndex = 4;
            // 
            // labelNamaLengkap
            // 
            labelNamaLengkap.AutoSize = true;
            labelNamaLengkap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaLengkap.Location = new Point(24, 19);
            labelNamaLengkap.Name = "labelNamaLengkap";
            labelNamaLengkap.Size = new Size(131, 23);
            labelNamaLengkap.TabIndex = 3;
            labelNamaLengkap.Text = "Nama Lengkap";
            // 
            // labelBuruhTani
            // 
            labelBuruhTani.AutoSize = true;
            labelBuruhTani.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuruhTani.ForeColor = Color.FromArgb(30, 41, 59);
            labelBuruhTani.Location = new Point(20, 20);
            labelBuruhTani.Name = "labelBuruhTani";
            labelBuruhTani.Size = new Size(392, 38);
            labelBuruhTani.TabIndex = 3;
            labelBuruhTani.Text = "Manajemen Data Buruh Tani";
            // 
            // dgvPengguna
            // 
            dgvPengguna.AllowUserToAddRows = false;
            dgvPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengguna.Location = new Point(28, 230);
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.ReadOnly = true;
            dgvPengguna.RowHeadersWidth = 51;
            dgvPengguna.Size = new Size(1950, 250);
            dgvPengguna.TabIndex = 5;
            dgvPengguna.CellClick += dgvPengguna_CellClick;
            // 
            // FormPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2007, 891);
            Controls.Add(panelInputPengguna);
            Controls.Add(labelBuruhTani);
            Controls.Add(dgvPengguna);
            Name = "FormPengguna";
            Text = "FormPengguna";
            panelInputPengguna.ResumeLayout(false);
            panelInputPengguna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Panel panelInputPengguna;
        private Button btnResetPengguna;
        private Button btnHapusPengguna;
        private Button btnUbahPengguna;
        private Button btnTambahPengguna;
        private TextBox txtPasswordPengguna;
        private TextBox txtUsernamePengguna;
        private Label labelUsername;
        private TextBox txtNamaLengkapPengguna;
        private Label labelNamaLengkap;
        private Label labelBuruhTani;
        private DataGridView dgvPengguna;
    }
}