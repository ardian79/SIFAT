namespace SIFAT.Views
{
    partial class FormUtama
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
            panelSidebar = new Panel();
            panelMenu = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnJenisKeuangan = new Button();
            btnKeuangan = new Button();
            btnBudidaya = new Button();
            btnLahan = new Button();
            btnBuruh = new Button();
            panelLogo = new Panel();
            LogoLogin = new PictureBox();
            labelSIFAT = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            panelKonten = new Panel();
            panelSidebar.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoLogin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(panelMenu);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Controls.Add(panel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 930);
            panelSidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(btnJenisKeuangan);
            panelMenu.Controls.Add(btnKeuangan);
            panelMenu.Controls.Add(btnBudidaya);
            panelMenu.Controls.Add(btnLahan);
            panelMenu.Controls.Add(btnBuruh);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.Location = new Point(0, 100);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 770);
            panelMenu.TabIndex = 10;
            panelMenu.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 5);
            btnDashboard.Margin = new Padding(0, 5, 0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(210, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnJenisKeuangan
            // 
            btnJenisKeuangan.Cursor = Cursors.Hand;
            btnJenisKeuangan.FlatAppearance.BorderSize = 0;
            btnJenisKeuangan.FlatStyle = FlatStyle.Flat;
            btnJenisKeuangan.ForeColor = Color.White;
            btnJenisKeuangan.Location = new Point(0, 55);
            btnJenisKeuangan.Margin = new Padding(0, 5, 0, 0);
            btnJenisKeuangan.Name = "btnJenisKeuangan";
            btnJenisKeuangan.Padding = new Padding(20, 0, 0, 0);
            btnJenisKeuangan.Size = new Size(210, 45);
            btnJenisKeuangan.TabIndex = 1;
            btnJenisKeuangan.Text = "Jenis Keuangan";
            btnJenisKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnJenisKeuangan.UseVisualStyleBackColor = true;
            btnJenisKeuangan.Click += btnJenisKeuangan_Click;
            // 
            // btnKeuangan
            // 
            btnKeuangan.Cursor = Cursors.Hand;
            btnKeuangan.FlatAppearance.BorderSize = 0;
            btnKeuangan.FlatStyle = FlatStyle.Flat;
            btnKeuangan.ForeColor = Color.White;
            btnKeuangan.Location = new Point(0, 105);
            btnKeuangan.Margin = new Padding(0, 5, 0, 0);
            btnKeuangan.Name = "btnKeuangan";
            btnKeuangan.Padding = new Padding(20, 0, 0, 0);
            btnKeuangan.Size = new Size(210, 45);
            btnKeuangan.TabIndex = 2;
            btnKeuangan.Text = "Keuangan";
            btnKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnKeuangan.UseVisualStyleBackColor = true;
            btnKeuangan.Click += btnKeuangan_Click;
            // 
            // btnBudidaya
            // 
            btnBudidaya.Cursor = Cursors.Hand;
            btnBudidaya.FlatAppearance.BorderSize = 0;
            btnBudidaya.FlatStyle = FlatStyle.Flat;
            btnBudidaya.ForeColor = Color.White;
            btnBudidaya.Location = new Point(0, 155);
            btnBudidaya.Margin = new Padding(0, 5, 0, 0);
            btnBudidaya.Name = "btnBudidaya";
            btnBudidaya.Padding = new Padding(20, 0, 0, 0);
            btnBudidaya.Size = new Size(210, 45);
            btnBudidaya.TabIndex = 3;
            btnBudidaya.Text = "Budidaya Tebu";
            btnBudidaya.TextAlign = ContentAlignment.MiddleLeft;
            btnBudidaya.UseVisualStyleBackColor = true;
            btnBudidaya.Click += btnBudidaya_Click;
            // 
            // btnLahan
            // 
            btnLahan.Cursor = Cursors.Hand;
            btnLahan.FlatAppearance.BorderSize = 0;
            btnLahan.FlatStyle = FlatStyle.Flat;
            btnLahan.ForeColor = Color.White;
            btnLahan.Location = new Point(0, 205);
            btnLahan.Margin = new Padding(0, 5, 0, 0);
            btnLahan.Name = "btnLahan";
            btnLahan.Padding = new Padding(20, 0, 0, 0);
            btnLahan.Size = new Size(210, 45);
            btnLahan.TabIndex = 4;
            btnLahan.Text = "Lahan";
            btnLahan.TextAlign = ContentAlignment.MiddleLeft;
            btnLahan.UseVisualStyleBackColor = true;
            btnLahan.Click += btnLahan_Click;
            // 
            // btnBuruh
            // 
            btnBuruh.Cursor = Cursors.Hand;
            btnBuruh.FlatAppearance.BorderSize = 0;
            btnBuruh.FlatStyle = FlatStyle.Flat;
            btnBuruh.ForeColor = Color.White;
            btnBuruh.Location = new Point(0, 255);
            btnBuruh.Margin = new Padding(0, 5, 0, 0);
            btnBuruh.Name = "btnBuruh";
            btnBuruh.Padding = new Padding(20, 0, 0, 0);
            btnBuruh.Size = new Size(210, 45);
            btnBuruh.TabIndex = 5;
            btnBuruh.Text = "Kelola Buruh Tani";
            btnBuruh.TextAlign = ContentAlignment.MiddleLeft;
            btnBuruh.UseVisualStyleBackColor = true;
            btnBuruh.Click += btnBuruh_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(LogoLogin);
            panelLogo.Controls.Add(labelSIFAT);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 9;
            // 
            // LogoLogin
            // 
            LogoLogin.BackgroundImageLayout = ImageLayout.None;
            LogoLogin.Image = Properties.Resources.Logo_Login;
            LogoLogin.Location = new Point(17, 27);
            LogoLogin.Name = "LogoLogin";
            LogoLogin.Size = new Size(50, 46);
            LogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            LogoLogin.TabIndex = 8;
            LogoLogin.TabStop = false;
            // 
            // labelSIFAT
            // 
            labelSIFAT.AutoSize = true;
            labelSIFAT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSIFAT.ForeColor = Color.White;
            labelSIFAT.Location = new Point(66, 31);
            labelSIFAT.Name = "labelSIFAT";
            labelSIFAT.Size = new Size(89, 38);
            labelSIFAT.TabIndex = 7;
            labelSIFAT.Text = "SIFAT";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 870);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 60);
            panel1.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(220, 38, 38);
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(0, 5, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelKonten
            // 
            panelKonten.Dock = DockStyle.Fill;
            panelKonten.ForeColor = Color.Black;
            panelKonten.Location = new Point(220, 0);
            panelKonten.Name = "panelKonten";
            panelKonten.Size = new Size(1788, 930);
            panelKonten.TabIndex = 2;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2008, 930);
            Controls.Add(panelKonten);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUtama";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoLogin).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelKonten;
        private Label labelSIFAT;
        private PictureBox LogoLogin;
        private FlowLayoutPanel panelMenu;
        private Panel panelLogo;
        private Button btnDashboard;
        private Button btnJenisKeuangan;
        private Button btnKeuangan;
        private Button btnBudidaya;
        private Button btnLahan;
        private Panel panel1;
        private Button btnLogout;
        private Button btnBuruh;
    }
}