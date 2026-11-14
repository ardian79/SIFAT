namespace SIFAT.Views
{
    partial class FormLogin
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
            tableLayoutLogin = new TableLayoutPanel();
            panelLogin = new Panel();
            LogoLogin = new PictureBox();
            labelSIFAT = new Label();
            buttonLogin = new Button();
            labelPassword = new Label();
            labelUsernameLogin = new Label();
            txtPasswordLogin = new TextBox();
            txtUsernameLogin = new TextBox();
            tableLayoutLogin.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoLogin).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutLogin
            // 
            tableLayoutLogin.BackColor = Color.Transparent;
            tableLayoutLogin.ColumnCount = 3;
            tableLayoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogin.Controls.Add(panelLogin, 1, 1);
            tableLayoutLogin.Dock = DockStyle.Fill;
            tableLayoutLogin.Location = new Point(0, 0);
            tableLayoutLogin.Name = "tableLayoutLogin";
            tableLayoutLogin.RowCount = 3;
            tableLayoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogin.Size = new Size(2005, 892);
            tableLayoutLogin.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(30, 41, 59);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(LogoLogin);
            panelLogin.Controls.Add(labelSIFAT);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(labelUsernameLogin);
            panelLogin.Controls.Add(txtPasswordLogin);
            panelLogin.Controls.Add(txtUsernameLogin);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.ForeColor = Color.White;
            panelLogin.Location = new Point(805, 274);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(394, 344);
            panelLogin.TabIndex = 0;
            // 
            // LogoLogin
            // 
            LogoLogin.BackgroundImageLayout = ImageLayout.None;
            LogoLogin.Image = Properties.Resources.Logo_Login;
            LogoLogin.Location = new Point(161, 11);
            LogoLogin.Name = "LogoLogin";
            LogoLogin.Size = new Size(70, 70);
            LogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            LogoLogin.TabIndex = 5;
            LogoLogin.TabStop = false;
            // 
            // labelSIFAT
            // 
            labelSIFAT.AutoSize = true;
            labelSIFAT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSIFAT.Location = new Point(165, 78);
            labelSIFAT.Name = "labelSIFAT";
            labelSIFAT.Size = new Size(63, 28);
            labelSIFAT.TabIndex = 6;
            labelSIFAT.Text = "SIFAT";
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(144, 294);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(105, 34);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += btnMasukLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(37, 204);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(85, 23);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password\r\n";
            // 
            // labelUsernameLogin
            // 
            labelUsernameLogin.AutoSize = true;
            labelUsernameLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsernameLogin.Location = new Point(37, 113);
            labelUsernameLogin.Name = "labelUsernameLogin";
            labelUsernameLogin.Size = new Size(89, 23);
            labelUsernameLogin.TabIndex = 2;
            labelUsernameLogin.Text = "Username\r\n";
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.BackColor = Color.White;
            txtPasswordLogin.ForeColor = Color.Black;
            txtPasswordLogin.Location = new Point(36, 230);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.Size = new Size(320, 30);
            txtPasswordLogin.TabIndex = 1;
            // 
            // txtUsernameLogin
            // 
            txtUsernameLogin.BackColor = Color.White;
            txtUsernameLogin.ForeColor = Color.Black;
            txtUsernameLogin.Location = new Point(36, 139);
            txtUsernameLogin.Name = "txtUsernameLogin";
            txtUsernameLogin.Size = new Size(320, 30);
            txtUsernameLogin.TabIndex = 0;
            // 
            // FormLogin
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.Background_Login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2005, 892);
            Controls.Add(tableLayoutLogin);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            tableLayoutLogin.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutLogin;
        private Panel panelLogin;
        private TextBox txtUsernameLogin;
        private TextBox txtPasswordLogin;
        private Label labelUsernameLogin;
        private Label labelPassword;
        private Button buttonLogin;
        private PictureBox LogoLogin;
        private Label labelSIFAT;
    }
}