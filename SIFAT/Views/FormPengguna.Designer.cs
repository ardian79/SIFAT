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
            colNamaLengkap = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colIsDelete = new DataGridViewTextBoxColumn();
            panelInputPengguna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(455, 14);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 19);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // panelInputPengguna
            // 
            panelInputPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInputPengguna.BackColor = Color.Transparent;
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
            panelInputPengguna.Location = new Point(24, 45);
            panelInputPengguna.Margin = new Padding(3, 2, 3, 2);
            panelInputPengguna.Name = "panelInputPengguna";
            panelInputPengguna.Size = new Size(1113, 112);
            panelInputPengguna.TabIndex = 4;
            // 
            // btnResetPengguna
            // 
            btnResetPengguna.BackColor = Color.Gray;
            btnResetPengguna.Cursor = Cursors.Hand;
            btnResetPengguna.FlatStyle = FlatStyle.Flat;
            btnResetPengguna.ForeColor = Color.White;
            btnResetPengguna.Location = new Point(404, 73);
            btnResetPengguna.Margin = new Padding(3, 2, 3, 2);
            btnResetPengguna.Name = "btnResetPengguna";
            btnResetPengguna.Size = new Size(92, 26);
            btnResetPengguna.TabIndex = 6;
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
            btnHapusPengguna.Location = new Point(276, 73);
            btnHapusPengguna.Margin = new Padding(3, 2, 3, 2);
            btnHapusPengguna.Name = "btnHapusPengguna";
            btnHapusPengguna.Size = new Size(92, 26);
            btnHapusPengguna.TabIndex = 5;
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
            btnUbahPengguna.Location = new Point(150, 73);
            btnUbahPengguna.Margin = new Padding(3, 2, 3, 2);
            btnUbahPengguna.Name = "btnUbahPengguna";
            btnUbahPengguna.Size = new Size(92, 26);
            btnUbahPengguna.TabIndex = 4;
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
            btnTambahPengguna.Location = new Point(21, 73);
            btnTambahPengguna.Margin = new Padding(3, 2, 3, 2);
            btnTambahPengguna.Name = "btnTambahPengguna";
            btnTambahPengguna.Size = new Size(92, 26);
            btnTambahPengguna.TabIndex = 3;
            btnTambahPengguna.Text = "Tambah";
            btnTambahPengguna.UseVisualStyleBackColor = false;
            btnTambahPengguna.Click += btnTambahPengguna_Click;
            // 
            // txtPasswordPengguna
            // 
            txtPasswordPengguna.BackColor = Color.White;
            txtPasswordPengguna.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordPengguna.ForeColor = Color.Black;
            txtPasswordPengguna.Location = new Point(455, 33);
            txtPasswordPengguna.Margin = new Padding(3, 2, 3, 2);
            txtPasswordPengguna.Name = "txtPasswordPengguna";
            txtPasswordPengguna.PasswordChar = '*';
            txtPasswordPengguna.Size = new Size(200, 23);
            txtPasswordPengguna.TabIndex = 2;
            // 
            // txtUsernamePengguna
            // 
            txtUsernamePengguna.BackColor = Color.White;
            txtUsernamePengguna.BorderStyle = BorderStyle.FixedSingle;
            txtUsernamePengguna.ForeColor = Color.Black;
            txtUsernamePengguna.Location = new Point(239, 33);
            txtUsernamePengguna.Margin = new Padding(3, 2, 3, 2);
            txtUsernamePengguna.Name = "txtUsernamePengguna";
            txtUsernamePengguna.Size = new Size(175, 23);
            txtUsernamePengguna.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(239, 14);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(76, 19);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // txtNamaLengkapPengguna
            // 
            txtNamaLengkapPengguna.BackColor = Color.White;
            txtNamaLengkapPengguna.BorderStyle = BorderStyle.FixedSingle;
            txtNamaLengkapPengguna.ForeColor = Color.Black;
            txtNamaLengkapPengguna.Location = new Point(21, 33);
            txtNamaLengkapPengguna.Margin = new Padding(3, 2, 3, 2);
            txtNamaLengkapPengguna.Name = "txtNamaLengkapPengguna";
            txtNamaLengkapPengguna.Size = new Size(175, 23);
            txtNamaLengkapPengguna.TabIndex = 0;
            // 
            // labelNamaLengkap
            // 
            labelNamaLengkap.AutoSize = true;
            labelNamaLengkap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaLengkap.Location = new Point(21, 13);
            labelNamaLengkap.Name = "labelNamaLengkap";
            labelNamaLengkap.Size = new Size(110, 19);
            labelNamaLengkap.TabIndex = 3;
            labelNamaLengkap.Text = "Nama Lengkap";
            // 
            // labelBuruhTani
            // 
            labelBuruhTani.AutoSize = true;
            labelBuruhTani.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuruhTani.ForeColor = Color.FromArgb(30, 41, 59);
            labelBuruhTani.Location = new Point(18, 15);
            labelBuruhTani.Name = "labelBuruhTani";
            labelBuruhTani.Size = new Size(305, 30);
            labelBuruhTani.TabIndex = 3;
            labelBuruhTani.Text = "Manajemen Data Buruh Tani";
            // 
            // dgvPengguna
            // 
            dgvPengguna.AllowUserToAddRows = false;
            dgvPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengguna.BackgroundColor = Color.White;
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengguna.Columns.AddRange(new DataGridViewColumn[] { colNamaLengkap, colUsername, colId, colPassword, colRole, colIsDelete });
            dgvPengguna.Location = new Point(24, 172);
            dgvPengguna.Margin = new Padding(3, 2, 3, 2);
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.ReadOnly = true;
            dgvPengguna.RowHeadersWidth = 51;
            dgvPengguna.Size = new Size(1113, 223);
            dgvPengguna.TabIndex = 7;
            dgvPengguna.CellClick += dgvPengguna_CellClick;
            // 
            // colNamaLengkap
            // 
            colNamaLengkap.DataPropertyName = "NamaLengkap";
            colNamaLengkap.HeaderText = "Nama Lengkap";
            colNamaLengkap.MinimumWidth = 6;
            colNamaLengkap.Name = "colNamaLengkap";
            colNamaLengkap.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
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
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 6;
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Visible = false;
            // 
            // colRole
            // 
            colRole.DataPropertyName = "Role";
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Visible = false;
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
            // FormPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1161, 486);
            Controls.Add(panelInputPengguna);
            Controls.Add(labelBuruhTani);
            Controls.Add(dgvPengguna);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn colNamaLengkap;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colIsDelete;
    }
}