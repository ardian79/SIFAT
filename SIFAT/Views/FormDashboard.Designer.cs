namespace SIFAT.Views
{
    partial class FormDashboard
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
            lblSelamatDatang = new Label();
            panelPemasukan = new Panel();
            lblTotalPemasukan = new Label();
            labelTitlePemasukan = new Label();
            panelPengeluaran = new Panel();
            lblTotalPengeluaran = new Label();
            labelTitlePengeluaran = new Label();
            panelSaldo = new Panel();
            lblSaldo = new Label();
            labelTitleSaldo = new Label();
            tableLayoutDashboard = new TableLayoutPanel();
            panelTengah = new Panel();
            panelPemasukan.SuspendLayout();
            panelPengeluaran.SuspendLayout();
            panelSaldo.SuspendLayout();
            tableLayoutDashboard.SuspendLayout();
            panelTengah.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatang.Location = new Point(30, 30);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(281, 46);
            lblSelamatDatang.TabIndex = 0;
            lblSelamatDatang.Text = "Selamat Datang,";
            // 
            // panelPemasukan
            // 
            panelPemasukan.BackColor = Color.MediumSeaGreen;
            panelPemasukan.Controls.Add(lblTotalPemasukan);
            panelPemasukan.Controls.Add(labelTitlePemasukan);
            panelPemasukan.Location = new Point(3, 2);
            panelPemasukan.Name = "panelPemasukan";
            panelPemasukan.Size = new Size(250, 140);
            panelPemasukan.TabIndex = 1;
            // 
            // lblTotalPemasukan
            // 
            lblTotalPemasukan.AutoSize = true;
            lblTotalPemasukan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPemasukan.ForeColor = Color.White;
            lblTotalPemasukan.Location = new Point(20, 60);
            lblTotalPemasukan.Name = "lblTotalPemasukan";
            lblTotalPemasukan.Size = new Size(82, 41);
            lblTotalPemasukan.TabIndex = 1;
            lblTotalPemasukan.Text = "Rp 0";
            // 
            // labelTitlePemasukan
            // 
            labelTitlePemasukan.AutoSize = true;
            labelTitlePemasukan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitlePemasukan.ForeColor = Color.White;
            labelTitlePemasukan.Location = new Point(20, 20);
            labelTitlePemasukan.Name = "labelTitlePemasukan";
            labelTitlePemasukan.Size = new Size(171, 23);
            labelTitlePemasukan.TabIndex = 0;
            labelTitlePemasukan.Text = "TOTAL PEMASUKAN";
            // 
            // panelPengeluaran
            // 
            panelPengeluaran.BackColor = Color.Crimson;
            panelPengeluaran.Controls.Add(lblTotalPengeluaran);
            panelPengeluaran.Controls.Add(labelTitlePengeluaran);
            panelPengeluaran.Location = new Point(298, 2);
            panelPengeluaran.Name = "panelPengeluaran";
            panelPengeluaran.Size = new Size(250, 140);
            panelPengeluaran.TabIndex = 2;
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPengeluaran.ForeColor = Color.White;
            lblTotalPengeluaran.Location = new Point(20, 60);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(82, 41);
            lblTotalPengeluaran.TabIndex = 1;
            lblTotalPengeluaran.Text = "Rp 0";
            // 
            // labelTitlePengeluaran
            // 
            labelTitlePengeluaran.AutoSize = true;
            labelTitlePengeluaran.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitlePengeluaran.ForeColor = Color.White;
            labelTitlePengeluaran.Location = new Point(20, 20);
            labelTitlePengeluaran.Name = "labelTitlePengeluaran";
            labelTitlePengeluaran.Size = new Size(188, 23);
            labelTitlePengeluaran.TabIndex = 0;
            labelTitlePengeluaran.Text = "TOTAL PENGELUARAN";
            // 
            // panelSaldo
            // 
            panelSaldo.BackColor = Color.RoyalBlue;
            panelSaldo.Controls.Add(lblSaldo);
            panelSaldo.Controls.Add(labelTitleSaldo);
            panelSaldo.Location = new Point(594, 2);
            panelSaldo.Name = "panelSaldo";
            panelSaldo.Size = new Size(250, 140);
            panelSaldo.TabIndex = 4;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(20, 60);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(82, 41);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Rp 0";
            // 
            // labelTitleSaldo
            // 
            labelTitleSaldo.AutoSize = true;
            labelTitleSaldo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleSaldo.ForeColor = Color.White;
            labelTitleSaldo.Location = new Point(20, 20);
            labelTitleSaldo.Name = "labelTitleSaldo";
            labelTitleSaldo.Size = new Size(105, 23);
            labelTitleSaldo.TabIndex = 0;
            labelTitleSaldo.Text = "SALDO KAS";
            // 
            // tableLayoutDashboard
            // 
            tableLayoutDashboard.BackColor = Color.Transparent;
            tableLayoutDashboard.ColumnCount = 3;
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 850F));
            tableLayoutDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.Controls.Add(panelTengah, 1, 1);
            tableLayoutDashboard.Dock = DockStyle.Fill;
            tableLayoutDashboard.Location = new Point(0, 0);
            tableLayoutDashboard.Name = "tableLayoutDashboard";
            tableLayoutDashboard.RowCount = 3;
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutDashboard.Size = new Size(2003, 889);
            tableLayoutDashboard.TabIndex = 5;
            // 
            // panelTengah
            // 
            panelTengah.Controls.Add(panelSaldo);
            panelTengah.Controls.Add(panelPemasukan);
            panelTengah.Controls.Add(panelPengeluaran);
            panelTengah.Dock = DockStyle.Fill;
            panelTengah.Location = new Point(579, 372);
            panelTengah.Name = "panelTengah";
            panelTengah.Size = new Size(844, 144);
            panelTengah.TabIndex = 0;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2003, 889);
            Controls.Add(lblSelamatDatang);
            Controls.Add(tableLayoutDashboard);
            Name = "FormDashboard";
            Text = "FormDashboard";
            panelPemasukan.ResumeLayout(false);
            panelPemasukan.PerformLayout();
            panelPengeluaran.ResumeLayout(false);
            panelPengeluaran.PerformLayout();
            panelSaldo.ResumeLayout(false);
            panelSaldo.PerformLayout();
            tableLayoutDashboard.ResumeLayout(false);
            panelTengah.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelamatDatang;
        private Panel panelPemasukan;
        private Panel panelPengeluaran;
        private Panel panelSaldo;
        private TableLayoutPanel tableLayoutDashboard;
        private Panel panelTengah;
        private Label lblTotalPemasukan;
        private Label labelTitlePemasukan;
        private Label lblTotalPengeluaran;
        private Label labelTitlePengeluaran;
        private Label lblSaldo;
        private Label labelTitleSaldo;
    }
}