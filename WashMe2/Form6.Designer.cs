using System.Drawing;
using System.Windows.Forms;

namespace WashMe2
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelBadgeAdmin = new System.Windows.Forms.Label();
            this.labelMenuDasbor = new System.Windows.Forms.Label();
            this.labelMenuPesanan = new System.Windows.Forms.Label();
            this.labelMenuPaket = new System.Windows.Forms.Label();
            this.labelAdminOutlet = new System.Windows.Forms.Label();
            this.linkLabelKeluar = new System.Windows.Forms.LinkLabel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.buttonLihatSemuaPesanan = new System.Windows.Forms.Button();
            this.labelPapanStatus = new System.Windows.Forms.Label();
            this.panelStatDiterima = new System.Windows.Forms.Panel();
            this.labelBadgeDiterima = new System.Windows.Forms.Label();
            this.labelAngkaDiterima = new System.Windows.Forms.Label();
            this.labelKetDiterima = new System.Windows.Forms.Label();
            this.panelStatDicuci = new System.Windows.Forms.Panel();
            this.labelBadgeDicuci = new System.Windows.Forms.Label();
            this.labelAngkaDicuci = new System.Windows.Forms.Label();
            this.labelKetDicuci = new System.Windows.Forms.Label();
            this.panelStatDisetrika = new System.Windows.Forms.Panel();
            this.labelBadgeDisetrika = new System.Windows.Forms.Label();
            this.labelAngkaDisetrika = new System.Windows.Forms.Label();
            this.labelKetDisetrika = new System.Windows.Forms.Label();
            this.panelStatSiap = new System.Windows.Forms.Panel();
            this.labelBadgeSiap = new System.Windows.Forms.Label();
            this.labelAngkaSiap = new System.Windows.Forms.Label();
            this.labelKetSiap = new System.Windows.Forms.Label();
            this.panelStatSelesai = new System.Windows.Forms.Panel();
            this.labelBadgeSelesai = new System.Windows.Forms.Label();
            this.labelAngkaSelesai = new System.Windows.Forms.Label();
            this.labelKetSelesai = new System.Windows.Forms.Label();
            this.panelKolomDiterima = new System.Windows.Forms.Panel();
            this.labelJudulKolomDiterima = new System.Windows.Forms.Label();
            this.labelJumlahKolomDiterima = new System.Windows.Forms.Label();
            this.panelKartuLD0152 = new System.Windows.Forms.Panel();
            this.labelNoLD0152 = new System.Windows.Forms.Label();
            this.labelEstLD0152 = new System.Windows.Forms.Label();
            this.labelNamaLD0152 = new System.Windows.Forms.Label();
            this.labelPaketLD0152 = new System.Windows.Forms.Label();
            this.buttonAksiLD0152 = new System.Windows.Forms.Button();
            this.panelKartuLD0153 = new System.Windows.Forms.Panel();
            this.labelNoLD0153 = new System.Windows.Forms.Label();
            this.labelEstLD0153 = new System.Windows.Forms.Label();
            this.labelNamaLD0153 = new System.Windows.Forms.Label();
            this.labelPaketLD0153 = new System.Windows.Forms.Label();
            this.buttonAksiLD0153 = new System.Windows.Forms.Button();
            this.panelKolomDicuci = new System.Windows.Forms.Panel();
            this.labelJudulKolomDicuci = new System.Windows.Forms.Label();
            this.labelJumlahKolomDicuci = new System.Windows.Forms.Label();
            this.panelKartuLD0151 = new System.Windows.Forms.Panel();
            this.labelNoLD0151 = new System.Windows.Forms.Label();
            this.labelEstLD0151 = new System.Windows.Forms.Label();
            this.labelNamaLD0151 = new System.Windows.Forms.Label();
            this.labelPaketLD0151 = new System.Windows.Forms.Label();
            this.buttonAksiLD0151 = new System.Windows.Forms.Button();
            this.panelKartuLD0149 = new System.Windows.Forms.Panel();
            this.labelNoLD0149 = new System.Windows.Forms.Label();
            this.labelEstLD0149 = new System.Windows.Forms.Label();
            this.labelNamaLD0149 = new System.Windows.Forms.Label();
            this.labelPaketLD0149 = new System.Windows.Forms.Label();
            this.buttonAksiLD0149 = new System.Windows.Forms.Button();
            this.panelKolomDisetrika = new System.Windows.Forms.Panel();
            this.labelJudulKolomDisetrika = new System.Windows.Forms.Label();
            this.labelJumlahKolomDisetrika = new System.Windows.Forms.Label();
            this.panelKartuLD0142 = new System.Windows.Forms.Panel();
            this.labelNoLD0142 = new System.Windows.Forms.Label();
            this.labelEstLD0142 = new System.Windows.Forms.Label();
            this.labelNamaLD0142 = new System.Windows.Forms.Label();
            this.labelPaketLD0142 = new System.Windows.Forms.Label();
            this.buttonAksiLD0142 = new System.Windows.Forms.Button();
            this.panelKartuLD0148 = new System.Windows.Forms.Panel();
            this.labelNoLD0148 = new System.Windows.Forms.Label();
            this.labelEstLD0148 = new System.Windows.Forms.Label();
            this.labelNamaLD0148 = new System.Windows.Forms.Label();
            this.labelPaketLD0148 = new System.Windows.Forms.Label();
            this.buttonAksiLD0148 = new System.Windows.Forms.Button();
            this.panelKolomSiap = new System.Windows.Forms.Panel();
            this.labelJudulKolomSiap = new System.Windows.Forms.Label();
            this.labelJumlahKolomSiap = new System.Windows.Forms.Label();
            this.panelKartuLD0146 = new System.Windows.Forms.Panel();
            this.labelNoLD0146 = new System.Windows.Forms.Label();
            this.labelEstLD0146 = new System.Windows.Forms.Label();
            this.labelNamaLD0146 = new System.Windows.Forms.Label();
            this.labelPaketLD0146 = new System.Windows.Forms.Label();
            this.buttonAksiLD0146 = new System.Windows.Forms.Button();
            this.panelKartuLD0144 = new System.Windows.Forms.Panel();
            this.labelNoLD0144 = new System.Windows.Forms.Label();
            this.labelEstLD0144 = new System.Windows.Forms.Label();
            this.labelNamaLD0144 = new System.Windows.Forms.Label();
            this.labelPaketLD0144 = new System.Windows.Forms.Label();
            this.buttonAksiLD0144 = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelStatDiterima.SuspendLayout();
            this.panelStatDicuci.SuspendLayout();
            this.panelStatDisetrika.SuspendLayout();
            this.panelStatSiap.SuspendLayout();
            this.panelStatSelesai.SuspendLayout();
            this.panelKolomDiterima.SuspendLayout();
            this.panelKartuLD0152.SuspendLayout();
            this.panelKartuLD0153.SuspendLayout();
            this.panelKolomDicuci.SuspendLayout();
            this.panelKartuLD0151.SuspendLayout();
            this.panelKartuLD0149.SuspendLayout();
            this.panelKolomDisetrika.SuspendLayout();
            this.panelKartuLD0142.SuspendLayout();
            this.panelKartuLD0148.SuspendLayout();
            this.panelKolomSiap.SuspendLayout();
            this.panelKartuLD0146.SuspendLayout();
            this.panelKartuLD0144.SuspendLayout();
            this.SuspendLayout();
             
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panelSidebar.Controls.Add(this.labelLogo);
            this.panelSidebar.Controls.Add(this.labelBadgeAdmin);
            this.panelSidebar.Controls.Add(this.labelMenuDasbor);
            this.panelSidebar.Controls.Add(this.labelMenuPesanan);
            this.panelSidebar.Controls.Add(this.labelMenuPaket);
            this.panelSidebar.Controls.Add(this.labelAdminOutlet);
            this.panelSidebar.Controls.Add(this.linkLabelKeluar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 680);
            this.panelSidebar.TabIndex = 13;
             
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(20, 22);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 23);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "WashMe";
             
            this.labelBadgeAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(88)))));
            this.labelBadgeAdmin.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.labelBadgeAdmin.ForeColor = System.Drawing.Color.White;
            this.labelBadgeAdmin.Location = new System.Drawing.Point(118, 26);
            this.labelBadgeAdmin.Name = "labelBadgeAdmin";
            this.labelBadgeAdmin.Size = new System.Drawing.Size(71, 19);
            this.labelBadgeAdmin.TabIndex = 1;
            this.labelBadgeAdmin.Text = "ADMIN";
            this.labelBadgeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            this.labelMenuDasbor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(88)))));
            this.labelMenuDasbor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelMenuDasbor.ForeColor = System.Drawing.Color.White;
            this.labelMenuDasbor.Location = new System.Drawing.Point(14, 80);
            this.labelMenuDasbor.Name = "labelMenuDasbor";
            this.labelMenuDasbor.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.labelMenuDasbor.Size = new System.Drawing.Size(192, 38);
            this.labelMenuDasbor.TabIndex = 2;
            this.labelMenuDasbor.Text = "Dasbor";
            this.labelMenuDasbor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            this.labelMenuPesanan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMenuPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.labelMenuPesanan.Location = new System.Drawing.Point(14, 124);
            this.labelMenuPesanan.Name = "labelMenuPesanan";
            this.labelMenuPesanan.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.labelMenuPesanan.Size = new System.Drawing.Size(192, 38);
            this.labelMenuPesanan.TabIndex = 3;
            this.labelMenuPesanan.Text = "Pesanan";
            this.labelMenuPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
             
            this.labelMenuPaket.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelMenuPaket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.labelMenuPaket.Location = new System.Drawing.Point(14, 168);
            this.labelMenuPaket.Name = "labelMenuPaket";
            this.labelMenuPaket.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.labelMenuPaket.Size = new System.Drawing.Size(192, 38);
            this.labelMenuPaket.TabIndex = 4;
            this.labelMenuPaket.Text = "Paket dan Harga";
            this.labelMenuPaket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            this.labelAdminOutlet.AutoSize = true;
            this.labelAdminOutlet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAdminOutlet.ForeColor = System.Drawing.Color.White;
            this.labelAdminOutlet.Location = new System.Drawing.Point(20, 618);
            this.labelAdminOutlet.Name = "labelAdminOutlet";
            this.labelAdminOutlet.Size = new System.Drawing.Size(102, 20);
            this.labelAdminOutlet.TabIndex = 5;
            this.labelAdminOutlet.Text = "Admin outlet";
            
            this.linkLabelKeluar.AutoSize = true;
            this.linkLabelKeluar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.linkLabelKeluar.Location = new System.Drawing.Point(20, 644);
            this.linkLabelKeluar.Name = "linkLabelKeluar";
            this.linkLabelKeluar.Size = new System.Drawing.Size(45, 16);
            this.linkLabelKeluar.TabIndex = 6;
            this.linkLabelKeluar.TabStop = true;
            this.linkLabelKeluar.Text = "Keluar";
            
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold);
            this.labelJudul.Location = new System.Drawing.Point(248, 22);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(329, 42);
            this.labelJudul.TabIndex = 12;
            this.labelJudul.Text = "Dasbor monitoring";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelTanggal.Location = new System.Drawing.Point(252, 66);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(252, 16);
            this.labelTanggal.TabIndex = 11;
            this.labelTanggal.Text = "Sabtu, 7 November 2026 · 8 pesanan aktif";
             
            this.buttonLihatSemuaPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.buttonLihatSemuaPesanan.FlatAppearance.BorderSize = 0;
            this.buttonLihatSemuaPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatSemuaPesanan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLihatSemuaPesanan.ForeColor = System.Drawing.Color.White;
            this.buttonLihatSemuaPesanan.Location = new System.Drawing.Point(958, 26);
            this.buttonLihatSemuaPesanan.Name = "buttonLihatSemuaPesanan";
            this.buttonLihatSemuaPesanan.Size = new System.Drawing.Size(190, 40);
            this.buttonLihatSemuaPesanan.TabIndex = 10;
            this.buttonLihatSemuaPesanan.Text = "Lihat semua pesanan";
            this.buttonLihatSemuaPesanan.UseVisualStyleBackColor = false;
             
            this.labelPapanStatus.AutoSize = true;
            this.labelPapanStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPapanStatus.Location = new System.Drawing.Point(248, 250);
            this.labelPapanStatus.Name = "labelPapanStatus";
            this.labelPapanStatus.Size = new System.Drawing.Size(204, 25);
            this.labelPapanStatus.TabIndex = 4;
            this.labelPapanStatus.Text = "Papan status pesanan";
            
            this.panelStatDiterima.BackColor = System.Drawing.Color.White;
            this.panelStatDiterima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatDiterima.Controls.Add(this.labelBadgeDiterima);
            this.panelStatDiterima.Controls.Add(this.labelAngkaDiterima);
            this.panelStatDiterima.Controls.Add(this.labelKetDiterima);
            this.panelStatDiterima.Location = new System.Drawing.Point(252, 104);
            this.panelStatDiterima.Name = "panelStatDiterima";
            this.panelStatDiterima.Size = new System.Drawing.Size(168, 124);
            this.panelStatDiterima.TabIndex = 9;
            
            this.labelBadgeDiterima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.labelBadgeDiterima.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelBadgeDiterima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.labelBadgeDiterima.Location = new System.Drawing.Point(12, 12);
            this.labelBadgeDiterima.Name = "labelBadgeDiterima";
            this.labelBadgeDiterima.Size = new System.Drawing.Size(64, 18);
            this.labelBadgeDiterima.TabIndex = 0;
            this.labelBadgeDiterima.Text = "Diterima";
            this.labelBadgeDiterima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            this.labelAngkaDiterima.AutoSize = true;
            this.labelAngkaDiterima.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelAngkaDiterima.Location = new System.Drawing.Point(8, 38);
            this.labelAngkaDiterima.Name = "labelAngkaDiterima";
            this.labelAngkaDiterima.Size = new System.Drawing.Size(43, 50);
            this.labelAngkaDiterima.TabIndex = 1;
            this.labelAngkaDiterima.Text = "2";
             
            this.labelKetDiterima.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKetDiterima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKetDiterima.Location = new System.Drawing.Point(12, 88);
            this.labelKetDiterima.Name = "labelKetDiterima";
            this.labelKetDiterima.Size = new System.Drawing.Size(146, 30);
            this.labelKetDiterima.TabIndex = 2;
            this.labelKetDiterima.Text = "Menunggu diproses";
             
            this.panelStatDicuci.BackColor = System.Drawing.Color.White;
            this.panelStatDicuci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatDicuci.Controls.Add(this.labelBadgeDicuci);
            this.panelStatDicuci.Controls.Add(this.labelAngkaDicuci);
            this.panelStatDicuci.Controls.Add(this.labelKetDicuci);
            this.panelStatDicuci.Location = new System.Drawing.Point(434, 104);
            this.panelStatDicuci.Name = "panelStatDicuci";
            this.panelStatDicuci.Size = new System.Drawing.Size(168, 124);
            this.panelStatDicuci.TabIndex = 8;
            // 
            // labelBadgeDicuci
            // 
            this.labelBadgeDicuci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.labelBadgeDicuci.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelBadgeDicuci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.labelBadgeDicuci.Location = new System.Drawing.Point(12, 12);
            this.labelBadgeDicuci.Name = "labelBadgeDicuci";
            this.labelBadgeDicuci.Size = new System.Drawing.Size(54, 18);
            this.labelBadgeDicuci.TabIndex = 0;
            this.labelBadgeDicuci.Text = "Dicuci";
            this.labelBadgeDicuci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAngkaDicuci
            // 
            this.labelAngkaDicuci.AutoSize = true;
            this.labelAngkaDicuci.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelAngkaDicuci.Location = new System.Drawing.Point(8, 38);
            this.labelAngkaDicuci.Name = "labelAngkaDicuci";
            this.labelAngkaDicuci.Size = new System.Drawing.Size(43, 50);
            this.labelAngkaDicuci.TabIndex = 1;
            this.labelAngkaDicuci.Text = "2";
            // 
            // labelKetDicuci
            // 
            this.labelKetDicuci.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKetDicuci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKetDicuci.Location = new System.Drawing.Point(12, 88);
            this.labelKetDicuci.Name = "labelKetDicuci";
            this.labelKetDicuci.Size = new System.Drawing.Size(146, 30);
            this.labelKetDicuci.TabIndex = 2;
            this.labelKetDicuci.Text = "Sedang di mesin cuci";
            // 
            // panelStatDisetrika
            // 
            this.panelStatDisetrika.BackColor = System.Drawing.Color.White;
            this.panelStatDisetrika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatDisetrika.Controls.Add(this.labelBadgeDisetrika);
            this.panelStatDisetrika.Controls.Add(this.labelAngkaDisetrika);
            this.panelStatDisetrika.Controls.Add(this.labelKetDisetrika);
            this.panelStatDisetrika.Location = new System.Drawing.Point(616, 104);
            this.panelStatDisetrika.Name = "panelStatDisetrika";
            this.panelStatDisetrika.Size = new System.Drawing.Size(168, 124);
            this.panelStatDisetrika.TabIndex = 7;
            // 
            // labelBadgeDisetrika
            // 
            this.labelBadgeDisetrika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.labelBadgeDisetrika.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelBadgeDisetrika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.labelBadgeDisetrika.Location = new System.Drawing.Point(12, 12);
            this.labelBadgeDisetrika.Name = "labelBadgeDisetrika";
            this.labelBadgeDisetrika.Size = new System.Drawing.Size(64, 18);
            this.labelBadgeDisetrika.TabIndex = 0;
            this.labelBadgeDisetrika.Text = "Disetrika";
            this.labelBadgeDisetrika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAngkaDisetrika
            // 
            this.labelAngkaDisetrika.AutoSize = true;
            this.labelAngkaDisetrika.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelAngkaDisetrika.Location = new System.Drawing.Point(8, 38);
            this.labelAngkaDisetrika.Name = "labelAngkaDisetrika";
            this.labelAngkaDisetrika.Size = new System.Drawing.Size(43, 50);
            this.labelAngkaDisetrika.TabIndex = 1;
            this.labelAngkaDisetrika.Text = "2";
            // 
            // labelKetDisetrika
            // 
            this.labelKetDisetrika.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKetDisetrika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKetDisetrika.Location = new System.Drawing.Point(12, 88);
            this.labelKetDisetrika.Name = "labelKetDisetrika";
            this.labelKetDisetrika.Size = new System.Drawing.Size(146, 30);
            this.labelKetDisetrika.TabIndex = 2;
            this.labelKetDisetrika.Text = "Sedang disetrika";
            // 
            // panelStatSiap
            // 
            this.panelStatSiap.BackColor = System.Drawing.Color.White;
            this.panelStatSiap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatSiap.Controls.Add(this.labelBadgeSiap);
            this.panelStatSiap.Controls.Add(this.labelAngkaSiap);
            this.panelStatSiap.Controls.Add(this.labelKetSiap);
            this.panelStatSiap.Location = new System.Drawing.Point(798, 104);
            this.panelStatSiap.Name = "panelStatSiap";
            this.panelStatSiap.Size = new System.Drawing.Size(168, 124);
            this.panelStatSiap.TabIndex = 6;
            // 
            // labelBadgeSiap
            // 
            this.labelBadgeSiap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.labelBadgeSiap.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelBadgeSiap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.labelBadgeSiap.Location = new System.Drawing.Point(12, 12);
            this.labelBadgeSiap.Name = "labelBadgeSiap";
            this.labelBadgeSiap.Size = new System.Drawing.Size(134, 18);
            this.labelBadgeSiap.TabIndex = 0;
            this.labelBadgeSiap.Text = "Siap diantar / diambil";
            this.labelBadgeSiap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAngkaSiap
            // 
            this.labelAngkaSiap.AutoSize = true;
            this.labelAngkaSiap.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelAngkaSiap.Location = new System.Drawing.Point(8, 38);
            this.labelAngkaSiap.Name = "labelAngkaSiap";
            this.labelAngkaSiap.Size = new System.Drawing.Size(43, 50);
            this.labelAngkaSiap.TabIndex = 1;
            this.labelAngkaSiap.Text = "2";
            // 
            // labelKetSiap
            // 
            this.labelKetSiap.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKetSiap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKetSiap.Location = new System.Drawing.Point(12, 88);
            this.labelKetSiap.Name = "labelKetSiap";
            this.labelKetSiap.Size = new System.Drawing.Size(146, 30);
            this.labelKetSiap.TabIndex = 2;
            this.labelKetSiap.Text = "Menunggu pelanggan";
            // 
            // panelStatSelesai
            // 
            this.panelStatSelesai.BackColor = System.Drawing.Color.White;
            this.panelStatSelesai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatSelesai.Controls.Add(this.labelBadgeSelesai);
            this.panelStatSelesai.Controls.Add(this.labelAngkaSelesai);
            this.panelStatSelesai.Controls.Add(this.labelKetSelesai);
            this.panelStatSelesai.Location = new System.Drawing.Point(980, 104);
            this.panelStatSelesai.Name = "panelStatSelesai";
            this.panelStatSelesai.Size = new System.Drawing.Size(168, 124);
            this.panelStatSelesai.TabIndex = 5;
            // 
            // labelBadgeSelesai
            // 
            this.labelBadgeSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.labelBadgeSelesai.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelBadgeSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelBadgeSelesai.Location = new System.Drawing.Point(12, 12);
            this.labelBadgeSelesai.Name = "labelBadgeSelesai";
            this.labelBadgeSelesai.Size = new System.Drawing.Size(58, 18);
            this.labelBadgeSelesai.TabIndex = 0;
            this.labelBadgeSelesai.Text = "Selesai";
            this.labelBadgeSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAngkaSelesai
            // 
            this.labelAngkaSelesai.AutoSize = true;
            this.labelAngkaSelesai.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelAngkaSelesai.Location = new System.Drawing.Point(8, 38);
            this.labelAngkaSelesai.Name = "labelAngkaSelesai";
            this.labelAngkaSelesai.Size = new System.Drawing.Size(43, 50);
            this.labelAngkaSelesai.TabIndex = 1;
            this.labelAngkaSelesai.Text = "1";
            // 
            // labelKetSelesai
            // 
            this.labelKetSelesai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKetSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKetSelesai.Location = new System.Drawing.Point(12, 88);
            this.labelKetSelesai.Name = "labelKetSelesai";
            this.labelKetSelesai.Size = new System.Drawing.Size(146, 30);
            this.labelKetSelesai.TabIndex = 2;
            this.labelKetSelesai.Text = "Sudah diterima pelanggan";
            // 
            // panelKolomDiterima
            // 
            this.panelKolomDiterima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelKolomDiterima.Controls.Add(this.labelJudulKolomDiterima);
            this.panelKolomDiterima.Controls.Add(this.labelJumlahKolomDiterima);
            this.panelKolomDiterima.Controls.Add(this.panelKartuLD0152);
            this.panelKolomDiterima.Controls.Add(this.panelKartuLD0153);
            this.panelKolomDiterima.Location = new System.Drawing.Point(252, 288);
            this.panelKolomDiterima.Name = "panelKolomDiterima";
            this.panelKolomDiterima.Size = new System.Drawing.Size(212, 300);
            this.panelKolomDiterima.TabIndex = 3;
            // 
            // labelJudulKolomDiterima
            // 
            this.labelJudulKolomDiterima.AutoSize = true;
            this.labelJudulKolomDiterima.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelJudulKolomDiterima.Location = new System.Drawing.Point(12, 12);
            this.labelJudulKolomDiterima.Name = "labelJudulKolomDiterima";
            this.labelJudulKolomDiterima.Size = new System.Drawing.Size(77, 21);
            this.labelJudulKolomDiterima.TabIndex = 0;
            this.labelJudulKolomDiterima.Text = "Diterima";
            // 
            // labelJumlahKolomDiterima
            // 
            this.labelJumlahKolomDiterima.BackColor = System.Drawing.Color.White;
            this.labelJumlahKolomDiterima.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelJumlahKolomDiterima.Location = new System.Drawing.Point(176, 11);
            this.labelJumlahKolomDiterima.Name = "labelJumlahKolomDiterima";
            this.labelJumlahKolomDiterima.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahKolomDiterima.TabIndex = 1;
            this.labelJumlahKolomDiterima.Text = "2";
            this.labelJumlahKolomDiterima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKartuLD0152
            // 
            this.panelKartuLD0152.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0152.Controls.Add(this.labelNoLD0152);
            this.panelKartuLD0152.Controls.Add(this.labelEstLD0152);
            this.panelKartuLD0152.Controls.Add(this.labelNamaLD0152);
            this.panelKartuLD0152.Controls.Add(this.labelPaketLD0152);
            this.panelKartuLD0152.Controls.Add(this.buttonAksiLD0152);
            this.panelKartuLD0152.Location = new System.Drawing.Point(10, 44);
            this.panelKartuLD0152.Name = "panelKartuLD0152";
            this.panelKartuLD0152.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0152.TabIndex = 2;
            // 
            // labelNoLD0152
            // 
            this.labelNoLD0152.AutoSize = true;
            this.labelNoLD0152.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0152.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0152.Name = "labelNoLD0152";
            this.labelNoLD0152.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0152.TabIndex = 0;
            this.labelNoLD0152.Text = "LD-0152";
            // 
            // labelEstLD0152
            // 
            this.labelEstLD0152.AutoSize = true;
            this.labelEstLD0152.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0152.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0152.Location = new System.Drawing.Point(84, 10);
            this.labelEstLD0152.Name = "labelEstLD0152";
            this.labelEstLD0152.Size = new System.Drawing.Size(107, 19);
            this.labelEstLD0152.TabIndex = 1;
            this.labelEstLD0152.Text = "Estimasi 10 Nov";
            // 
            // labelNamaLD0152
            // 
            this.labelNamaLD0152.AutoSize = true;
            this.labelNamaLD0152.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0152.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0152.Name = "labelNamaLD0152";
            this.labelNamaLD0152.Size = new System.Drawing.Size(101, 20);
            this.labelNamaLD0152.TabIndex = 2;
            this.labelNamaLD0152.Text = "Budi Santoso";
            // 
            // labelPaketLD0152
            // 
            this.labelPaketLD0152.AutoSize = true;
            this.labelPaketLD0152.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0152.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0152.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0152.Name = "labelPaketLD0152";
            this.labelPaketLD0152.Size = new System.Drawing.Size(114, 19);
            this.labelPaketLD0152.TabIndex = 3;
            this.labelPaketLD0152.Text = "Cuci Kiloan · 6 kg";
            // 
            // buttonAksiLD0152
            // 
            this.buttonAksiLD0152.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0152.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0152.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0152.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0152.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0152.Name = "buttonAksiLD0152";
            this.buttonAksiLD0152.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0152.TabIndex = 4;
            this.buttonAksiLD0152.Text = "Mulai cuci";
            this.buttonAksiLD0152.UseVisualStyleBackColor = false;
            // 
            // panelKartuLD0153
            // 
            this.panelKartuLD0153.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0153.Controls.Add(this.labelNoLD0153);
            this.panelKartuLD0153.Controls.Add(this.labelEstLD0153);
            this.panelKartuLD0153.Controls.Add(this.labelNamaLD0153);
            this.panelKartuLD0153.Controls.Add(this.labelPaketLD0153);
            this.panelKartuLD0153.Controls.Add(this.buttonAksiLD0153);
            this.panelKartuLD0153.Location = new System.Drawing.Point(10, 166);
            this.panelKartuLD0153.Name = "panelKartuLD0153";
            this.panelKartuLD0153.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0153.TabIndex = 3;
            // 
            // labelNoLD0153
            // 
            this.labelNoLD0153.AutoSize = true;
            this.labelNoLD0153.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0153.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0153.Name = "labelNoLD0153";
            this.labelNoLD0153.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0153.TabIndex = 0;
            this.labelNoLD0153.Text = "LD-0153";
            // 
            // labelEstLD0153
            // 
            this.labelEstLD0153.AutoSize = true;
            this.labelEstLD0153.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0153.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0153.Location = new System.Drawing.Point(84, 10);
            this.labelEstLD0153.Name = "labelEstLD0153";
            this.labelEstLD0153.Size = new System.Drawing.Size(107, 19);
            this.labelEstLD0153.TabIndex = 1;
            this.labelEstLD0153.Text = "Estimasi 11 Nov";
            // 
            // labelNamaLD0153
            // 
            this.labelNamaLD0153.AutoSize = true;
            this.labelNamaLD0153.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0153.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0153.Name = "labelNamaLD0153";
            this.labelNamaLD0153.Size = new System.Drawing.Size(95, 20);
            this.labelNamaLD0153.TabIndex = 2;
            this.labelNamaLD0153.Text = "Dewi Lestari";
            // 
            // labelPaketLD0153
            // 
            this.labelPaketLD0153.AutoSize = true;
            this.labelPaketLD0153.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0153.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0153.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0153.Name = "labelPaketLD0153";
            this.labelPaketLD0153.Size = new System.Drawing.Size(101, 19);
            this.labelPaketLD0153.TabIndex = 3;
            this.labelPaketLD0153.Text = "Satuan · 3 item";
            // 
            // buttonAksiLD0153
            // 
            this.buttonAksiLD0153.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0153.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0153.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0153.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0153.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0153.Name = "buttonAksiLD0153";
            this.buttonAksiLD0153.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0153.TabIndex = 4;
            this.buttonAksiLD0153.Text = "Mulai cuci";
            this.buttonAksiLD0153.UseVisualStyleBackColor = false;
            // 
            // panelKolomDicuci
            // 
            this.panelKolomDicuci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelKolomDicuci.Controls.Add(this.labelJudulKolomDicuci);
            this.panelKolomDicuci.Controls.Add(this.labelJumlahKolomDicuci);
            this.panelKolomDicuci.Controls.Add(this.panelKartuLD0151);
            this.panelKolomDicuci.Controls.Add(this.panelKartuLD0149);
            this.panelKolomDicuci.Location = new System.Drawing.Point(480, 288);
            this.panelKolomDicuci.Name = "panelKolomDicuci";
            this.panelKolomDicuci.Size = new System.Drawing.Size(212, 300);
            this.panelKolomDicuci.TabIndex = 2;
            // 
            // labelJudulKolomDicuci
            // 
            this.labelJudulKolomDicuci.AutoSize = true;
            this.labelJudulKolomDicuci.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelJudulKolomDicuci.Location = new System.Drawing.Point(12, 12);
            this.labelJudulKolomDicuci.Name = "labelJudulKolomDicuci";
            this.labelJudulKolomDicuci.Size = new System.Drawing.Size(58, 21);
            this.labelJudulKolomDicuci.TabIndex = 0;
            this.labelJudulKolomDicuci.Text = "Dicuci";
            // 
            // labelJumlahKolomDicuci
            // 
            this.labelJumlahKolomDicuci.BackColor = System.Drawing.Color.White;
            this.labelJumlahKolomDicuci.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelJumlahKolomDicuci.Location = new System.Drawing.Point(176, 11);
            this.labelJumlahKolomDicuci.Name = "labelJumlahKolomDicuci";
            this.labelJumlahKolomDicuci.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahKolomDicuci.TabIndex = 1;
            this.labelJumlahKolomDicuci.Text = "2";
            this.labelJumlahKolomDicuci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKartuLD0151
            // 
            this.panelKartuLD0151.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0151.Controls.Add(this.labelNoLD0151);
            this.panelKartuLD0151.Controls.Add(this.labelEstLD0151);
            this.panelKartuLD0151.Controls.Add(this.labelNamaLD0151);
            this.panelKartuLD0151.Controls.Add(this.labelPaketLD0151);
            this.panelKartuLD0151.Controls.Add(this.buttonAksiLD0151);
            this.panelKartuLD0151.Location = new System.Drawing.Point(10, 44);
            this.panelKartuLD0151.Name = "panelKartuLD0151";
            this.panelKartuLD0151.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0151.TabIndex = 2;
            // 
            // labelNoLD0151
            // 
            this.labelNoLD0151.AutoSize = true;
            this.labelNoLD0151.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0151.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0151.Name = "labelNoLD0151";
            this.labelNoLD0151.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0151.TabIndex = 0;
            this.labelNoLD0151.Text = "LD-0151";
            // 
            // labelEstLD0151
            // 
            this.labelEstLD0151.AutoSize = true;
            this.labelEstLD0151.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0151.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0151.Location = new System.Drawing.Point(90, 10);
            this.labelEstLD0151.Name = "labelEstLD0151";
            this.labelEstLD0151.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0151.TabIndex = 1;
            this.labelEstLD0151.Text = "Estimasi 8 Nov";
            // 
            // labelNamaLD0151
            // 
            this.labelNamaLD0151.AutoSize = true;
            this.labelNamaLD0151.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0151.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0151.Name = "labelNamaLD0151";
            this.labelNamaLD0151.Size = new System.Drawing.Size(116, 20);
            this.labelNamaLD0151.TabIndex = 2;
            this.labelNamaLD0151.Text = "Rina Wulandari";
            // 
            // labelPaketLD0151
            // 
            this.labelPaketLD0151.AutoSize = true;
            this.labelPaketLD0151.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0151.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0151.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0151.Name = "labelPaketLD0151";
            this.labelPaketLD0151.Size = new System.Drawing.Size(140, 19);
            this.labelPaketLD0151.TabIndex = 3;
            this.labelPaketLD0151.Text = "Express 24 Jam · 3 kg";
            // 
            // buttonAksiLD0151
            // 
            this.buttonAksiLD0151.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0151.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0151.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0151.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0151.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0151.Name = "buttonAksiLD0151";
            this.buttonAksiLD0151.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0151.TabIndex = 4;
            this.buttonAksiLD0151.Text = "Pindah ke setrika";
            this.buttonAksiLD0151.UseVisualStyleBackColor = false;
            // 
            // panelKartuLD0149
            // 
            this.panelKartuLD0149.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0149.Controls.Add(this.labelNoLD0149);
            this.panelKartuLD0149.Controls.Add(this.labelEstLD0149);
            this.panelKartuLD0149.Controls.Add(this.labelNamaLD0149);
            this.panelKartuLD0149.Controls.Add(this.labelPaketLD0149);
            this.panelKartuLD0149.Controls.Add(this.buttonAksiLD0149);
            this.panelKartuLD0149.Location = new System.Drawing.Point(10, 166);
            this.panelKartuLD0149.Name = "panelKartuLD0149";
            this.panelKartuLD0149.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0149.TabIndex = 3;
            // 
            // labelNoLD0149
            // 
            this.labelNoLD0149.AutoSize = true;
            this.labelNoLD0149.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0149.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0149.Name = "labelNoLD0149";
            this.labelNoLD0149.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0149.TabIndex = 0;
            this.labelNoLD0149.Text = "LD-0149";
            // 
            // labelEstLD0149
            // 
            this.labelEstLD0149.AutoSize = true;
            this.labelEstLD0149.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0149.Location = new System.Drawing.Point(90, 10);
            this.labelEstLD0149.Name = "labelEstLD0149";
            this.labelEstLD0149.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0149.TabIndex = 1;
            this.labelEstLD0149.Text = "Estimasi 9 Nov";
            // 
            // labelNamaLD0149
            // 
            this.labelNamaLD0149.AutoSize = true;
            this.labelNamaLD0149.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0149.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0149.Name = "labelNamaLD0149";
            this.labelNamaLD0149.Size = new System.Drawing.Size(108, 20);
            this.labelNamaLD0149.TabIndex = 2;
            this.labelNamaLD0149.Text = "Agus Pratama";
            // 
            // labelPaketLD0149
            // 
            this.labelPaketLD0149.AutoSize = true;
            this.labelPaketLD0149.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0149.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0149.Name = "labelPaketLD0149";
            this.labelPaketLD0149.Size = new System.Drawing.Size(132, 19);
            this.labelPaketLD0149.TabIndex = 3;
            this.labelPaketLD0149.Text = "Cuci + Setrika · 8 kg";
            // 
            // buttonAksiLD0149
            // 
            this.buttonAksiLD0149.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0149.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0149.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0149.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0149.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0149.Name = "buttonAksiLD0149";
            this.buttonAksiLD0149.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0149.TabIndex = 4;
            this.buttonAksiLD0149.Text = "Pindah ke setrika";
            this.buttonAksiLD0149.UseVisualStyleBackColor = false;
            // 
            // panelKolomDisetrika
            // 
            this.panelKolomDisetrika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelKolomDisetrika.Controls.Add(this.labelJudulKolomDisetrika);
            this.panelKolomDisetrika.Controls.Add(this.labelJumlahKolomDisetrika);
            this.panelKolomDisetrika.Controls.Add(this.panelKartuLD0142);
            this.panelKolomDisetrika.Controls.Add(this.panelKartuLD0148);
            this.panelKolomDisetrika.Location = new System.Drawing.Point(708, 288);
            this.panelKolomDisetrika.Name = "panelKolomDisetrika";
            this.panelKolomDisetrika.Size = new System.Drawing.Size(212, 300);
            this.panelKolomDisetrika.TabIndex = 1;
            // 
            // labelJudulKolomDisetrika
            // 
            this.labelJudulKolomDisetrika.AutoSize = true;
            this.labelJudulKolomDisetrika.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelJudulKolomDisetrika.Location = new System.Drawing.Point(12, 12);
            this.labelJudulKolomDisetrika.Name = "labelJudulKolomDisetrika";
            this.labelJudulKolomDisetrika.Size = new System.Drawing.Size(78, 21);
            this.labelJudulKolomDisetrika.TabIndex = 0;
            this.labelJudulKolomDisetrika.Text = "Disetrika";
            // 
            // labelJumlahKolomDisetrika
            // 
            this.labelJumlahKolomDisetrika.BackColor = System.Drawing.Color.White;
            this.labelJumlahKolomDisetrika.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelJumlahKolomDisetrika.Location = new System.Drawing.Point(176, 11);
            this.labelJumlahKolomDisetrika.Name = "labelJumlahKolomDisetrika";
            this.labelJumlahKolomDisetrika.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahKolomDisetrika.TabIndex = 1;
            this.labelJumlahKolomDisetrika.Text = "2";
            this.labelJumlahKolomDisetrika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKartuLD0142
            // 
            this.panelKartuLD0142.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0142.Controls.Add(this.labelNoLD0142);
            this.panelKartuLD0142.Controls.Add(this.labelEstLD0142);
            this.panelKartuLD0142.Controls.Add(this.labelNamaLD0142);
            this.panelKartuLD0142.Controls.Add(this.labelPaketLD0142);
            this.panelKartuLD0142.Controls.Add(this.buttonAksiLD0142);
            this.panelKartuLD0142.Location = new System.Drawing.Point(10, 44);
            this.panelKartuLD0142.Name = "panelKartuLD0142";
            this.panelKartuLD0142.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0142.TabIndex = 2;
            // 
            // labelNoLD0142
            // 
            this.labelNoLD0142.AutoSize = true;
            this.labelNoLD0142.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0142.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0142.Name = "labelNoLD0142";
            this.labelNoLD0142.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0142.TabIndex = 0;
            this.labelNoLD0142.Text = "LD-0142";
            // 
            // labelEstLD0142
            // 
            this.labelEstLD0142.AutoSize = true;
            this.labelEstLD0142.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0142.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0142.Location = new System.Drawing.Point(90, 10);
            this.labelEstLD0142.Name = "labelEstLD0142";
            this.labelEstLD0142.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0142.TabIndex = 1;
            this.labelEstLD0142.Text = "Estimasi 9 Nov";
            // 
            // labelNamaLD0142
            // 
            this.labelNamaLD0142.AutoSize = true;
            this.labelNamaLD0142.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0142.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0142.Name = "labelNamaLD0142";
            this.labelNamaLD0142.Size = new System.Drawing.Size(116, 20);
            this.labelNamaLD0142.TabIndex = 2;
            this.labelNamaLD0142.Text = "Rina Wulandari";
            // 
            // labelPaketLD0142
            // 
            this.labelPaketLD0142.AutoSize = true;
            this.labelPaketLD0142.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0142.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0142.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0142.Name = "labelPaketLD0142";
            this.labelPaketLD0142.Size = new System.Drawing.Size(132, 19);
            this.labelPaketLD0142.TabIndex = 3;
            this.labelPaketLD0142.Text = "Cuci + Setrika · 5 kg";
            // 
            // buttonAksiLD0142
            // 
            this.buttonAksiLD0142.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0142.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0142.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0142.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0142.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0142.Name = "buttonAksiLD0142";
            this.buttonAksiLD0142.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0142.TabIndex = 4;
            this.buttonAksiLD0142.Text = "Tandai siap";
            this.buttonAksiLD0142.UseVisualStyleBackColor = false;
            this.panelKartuLD0148.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0148.Controls.Add(this.labelNoLD0148);
            this.panelKartuLD0148.Controls.Add(this.labelEstLD0148);
            this.panelKartuLD0148.Controls.Add(this.labelNamaLD0148);
            this.panelKartuLD0148.Controls.Add(this.labelPaketLD0148);
            this.panelKartuLD0148.Controls.Add(this.buttonAksiLD0148);
            this.panelKartuLD0148.Location = new System.Drawing.Point(10, 166);
            this.panelKartuLD0148.Name = "panelKartuLD0148";
            this.panelKartuLD0148.Size = new System.Drawing.Size(190, 112);
            this.panelKartuLD0148.TabIndex = 3;
            this.labelNoLD0148.AutoSize = true;
            this.labelNoLD0148.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0148.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0148.Name = "labelNoLD0148";
            this.labelNoLD0148.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0148.TabIndex = 0;
            this.labelNoLD0148.Text = "LD-0148";
            this.labelEstLD0148.AutoSize = true;
            this.labelEstLD0148.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0148.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0148.Location = new System.Drawing.Point(90, 10);
            this.labelEstLD0148.Name = "labelEstLD0148";
            this.labelEstLD0148.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0148.TabIndex = 1;
            this.labelEstLD0148.Text = "Estimasi 9 Nov";
            this.labelNamaLD0148.AutoSize = true;
            this.labelNamaLD0148.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0148.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0148.Name = "labelNamaLD0148";
            this.labelNamaLD0148.Size = new System.Drawing.Size(77, 20);
            this.labelNamaLD0148.TabIndex = 2;
            this.labelNamaLD0148.Text = "Maya Sari";
            this.labelPaketLD0148.AutoSize = true;
            this.labelPaketLD0148.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0148.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0148.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0148.Name = "labelPaketLD0148";
            this.labelPaketLD0148.Size = new System.Drawing.Size(132, 19);
            this.labelPaketLD0148.TabIndex = 3;
            this.labelPaketLD0148.Text = "Cuci + Setrika · 4 kg";
            this.buttonAksiLD0148.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0148.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0148.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0148.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0148.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0148.Name = "buttonAksiLD0148";
            this.buttonAksiLD0148.Size = new System.Drawing.Size(168, 28);
            this.buttonAksiLD0148.TabIndex = 4;
            this.buttonAksiLD0148.Text = "Tandai siap";
            this.buttonAksiLD0148.UseVisualStyleBackColor = false;
            this.panelKolomSiap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelKolomSiap.Controls.Add(this.labelJudulKolomSiap);
            this.panelKolomSiap.Controls.Add(this.labelJumlahKolomSiap);
            this.panelKolomSiap.Controls.Add(this.panelKartuLD0146);
            this.panelKolomSiap.Controls.Add(this.panelKartuLD0144);
            this.panelKolomSiap.Location = new System.Drawing.Point(936, 288);
            this.panelKolomSiap.Name = "panelKolomSiap";
            this.panelKolomSiap.Size = new System.Drawing.Size(232, 300);
            this.panelKolomSiap.TabIndex = 0;
            this.labelJudulKolomSiap.AutoSize = true;
            this.labelJudulKolomSiap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelJudulKolomSiap.Location = new System.Drawing.Point(12, 12);
            this.labelJudulKolomSiap.Name = "labelJudulKolomSiap";
            this.labelJudulKolomSiap.Size = new System.Drawing.Size(176, 21);
            this.labelJudulKolomSiap.TabIndex = 0;
            this.labelJudulKolomSiap.Text = "Siap diantar / diambil";
            this.labelJumlahKolomSiap.BackColor = System.Drawing.Color.White;
            this.labelJumlahKolomSiap.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelJumlahKolomSiap.Location = new System.Drawing.Point(194, 12);
            this.labelJumlahKolomSiap.Name = "labelJumlahKolomSiap";
            this.labelJumlahKolomSiap.Size = new System.Drawing.Size(24, 20);
            this.labelJumlahKolomSiap.TabIndex = 1;
            this.labelJumlahKolomSiap.Text = "2";
            this.labelJumlahKolomSiap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelKartuLD0146.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0146.Controls.Add(this.labelNoLD0146);
            this.panelKartuLD0146.Controls.Add(this.labelEstLD0146);
            this.panelKartuLD0146.Controls.Add(this.labelNamaLD0146);
            this.panelKartuLD0146.Controls.Add(this.labelPaketLD0146);
            this.panelKartuLD0146.Controls.Add(this.buttonAksiLD0146);
            this.panelKartuLD0146.Location = new System.Drawing.Point(10, 44);
            this.panelKartuLD0146.Name = "panelKartuLD0146";
            this.panelKartuLD0146.Size = new System.Drawing.Size(208, 112);
            this.panelKartuLD0146.TabIndex = 2;
            this.labelNoLD0146.AutoSize = true;
            this.labelNoLD0146.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0146.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0146.Name = "labelNoLD0146";
            this.labelNoLD0146.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0146.TabIndex = 0;
            this.labelNoLD0146.Text = "LD-0146";
            this.labelEstLD0146.AutoSize = true;
            this.labelEstLD0146.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0146.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0146.Location = new System.Drawing.Point(104, 9);
            this.labelEstLD0146.Name = "labelEstLD0146";
            this.labelEstLD0146.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0146.TabIndex = 1;
            this.labelEstLD0146.Text = "Estimasi 8 Nov";
            this.labelNamaLD0146.AutoSize = true;
            this.labelNamaLD0146.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0146.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0146.Name = "labelNamaLD0146";
            this.labelNamaLD0146.Size = new System.Drawing.Size(90, 20);
            this.labelNamaLD0146.TabIndex = 2;
            this.labelNamaLD0146.Text = "Siti Aminah";
            this.labelPaketLD0146.AutoSize = true;
            this.labelPaketLD0146.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0146.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0146.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0146.Name = "labelPaketLD0146";
            this.labelPaketLD0146.Size = new System.Drawing.Size(140, 19);
            this.labelPaketLD0146.TabIndex = 3;
            this.labelPaketLD0146.Text = "Express 24 Jam · 2 kg";
            this.buttonAksiLD0146.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0146.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0146.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0146.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0146.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0146.Name = "buttonAksiLD0146";
            this.buttonAksiLD0146.Size = new System.Drawing.Size(182, 28);
            this.buttonAksiLD0146.TabIndex = 4;
            this.buttonAksiLD0146.Text = "Tandai selesai";
            this.buttonAksiLD0146.UseVisualStyleBackColor = false;
            this.panelKartuLD0144.BackColor = System.Drawing.Color.White;
            this.panelKartuLD0144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKartuLD0144.Controls.Add(this.labelNoLD0144);
            this.panelKartuLD0144.Controls.Add(this.labelEstLD0144);
            this.panelKartuLD0144.Controls.Add(this.labelNamaLD0144);
            this.panelKartuLD0144.Controls.Add(this.labelPaketLD0144);
            this.panelKartuLD0144.Controls.Add(this.buttonAksiLD0144);
            this.panelKartuLD0144.Location = new System.Drawing.Point(10, 166);
            this.panelKartuLD0144.Name = "panelKartuLD0144";
            this.panelKartuLD0144.Size = new System.Drawing.Size(208, 112);
            this.panelKartuLD0144.TabIndex = 3;
            this.labelNoLD0144.AutoSize = true;
            this.labelNoLD0144.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoLD0144.Location = new System.Drawing.Point(10, 8);
            this.labelNoLD0144.Name = "labelNoLD0144";
            this.labelNoLD0144.Size = new System.Drawing.Size(70, 20);
            this.labelNoLD0144.TabIndex = 0;
            this.labelNoLD0144.Text = "LD-0144";
            this.labelEstLD0144.AutoSize = true;
            this.labelEstLD0144.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstLD0144.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstLD0144.Location = new System.Drawing.Point(104, 10);
            this.labelEstLD0144.Name = "labelEstLD0144";
            this.labelEstLD0144.Size = new System.Drawing.Size(99, 19);
            this.labelEstLD0144.TabIndex = 1;
            this.labelEstLD0144.Text = "Estimasi 8 Nov"; 
            this.labelNamaLD0144.AutoSize = true;
            this.labelNamaLD0144.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNamaLD0144.Location = new System.Drawing.Point(10, 32);
            this.labelNamaLD0144.Name = "labelNamaLD0144";
            this.labelNamaLD0144.Size = new System.Drawing.Size(139, 20);
            this.labelNamaLD0144.TabIndex = 2;
            this.labelNamaLD0144.Text = "Hendra Kurniawan"; 
            this.labelPaketLD0144.AutoSize = true;
            this.labelPaketLD0144.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPaketLD0144.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelPaketLD0144.Location = new System.Drawing.Point(10, 52);
            this.labelPaketLD0144.Name = "labelPaketLD0144";
            this.labelPaketLD0144.Size = new System.Drawing.Size(122, 19);
            this.labelPaketLD0144.TabIndex = 3;
            this.labelPaketLD0144.Text = "Cuci Kiloan · 10 kg";
             
            this.buttonAksiLD0144.BackColor = System.Drawing.Color.White;
            this.buttonAksiLD0144.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.buttonAksiLD0144.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAksiLD0144.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAksiLD0144.Location = new System.Drawing.Point(10, 76);
            this.buttonAksiLD0144.Name = "buttonAksiLD0144";
            this.buttonAksiLD0144.Size = new System.Drawing.Size(182, 28);
            this.buttonAksiLD0144.TabIndex = 4;
            this.buttonAksiLD0144.Text = "Tandai selesai";
            this.buttonAksiLD0144.UseVisualStyleBackColor = false;
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.panelKolomSiap);
            this.Controls.Add(this.panelKolomDisetrika);
            this.Controls.Add(this.panelKolomDicuci);
            this.Controls.Add(this.panelKolomDiterima);
            this.Controls.Add(this.labelPapanStatus);
            this.Controls.Add(this.panelStatSelesai);
            this.Controls.Add(this.panelStatSiap);
            this.Controls.Add(this.panelStatDisetrika);
            this.Controls.Add(this.panelStatDicuci);
            this.Controls.Add(this.panelStatDiterima);
            this.Controls.Add(this.buttonLihatSemuaPesanan);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasbor Monitoring";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelStatDiterima.ResumeLayout(false);
            this.panelStatDiterima.PerformLayout();
            this.panelStatDicuci.ResumeLayout(false);
            this.panelStatDicuci.PerformLayout();
            this.panelStatDisetrika.ResumeLayout(false);
            this.panelStatDisetrika.PerformLayout();
            this.panelStatSiap.ResumeLayout(false);
            this.panelStatSiap.PerformLayout();
            this.panelStatSelesai.ResumeLayout(false);
            this.panelStatSelesai.PerformLayout();
            this.panelKolomDiterima.ResumeLayout(false);
            this.panelKolomDiterima.PerformLayout();
            this.panelKartuLD0152.ResumeLayout(false);
            this.panelKartuLD0152.PerformLayout();
            this.panelKartuLD0153.ResumeLayout(false);
            this.panelKartuLD0153.PerformLayout();
            this.panelKolomDicuci.ResumeLayout(false);
            this.panelKolomDicuci.PerformLayout();
            this.panelKartuLD0151.ResumeLayout(false);
            this.panelKartuLD0151.PerformLayout();
            this.panelKartuLD0149.ResumeLayout(false);
            this.panelKartuLD0149.PerformLayout();
            this.panelKolomDisetrika.ResumeLayout(false);
            this.panelKolomDisetrika.PerformLayout();
            this.panelKartuLD0142.ResumeLayout(false);
            this.panelKartuLD0142.PerformLayout();
            this.panelKartuLD0148.ResumeLayout(false);
            this.panelKartuLD0148.PerformLayout();
            this.panelKolomSiap.ResumeLayout(false);
            this.panelKolomSiap.PerformLayout();
            this.panelKartuLD0146.ResumeLayout(false);
            this.panelKartuLD0146.PerformLayout();
            this.panelKartuLD0144.ResumeLayout(false);
            this.panelKartuLD0144.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelSidebar, panelStatDiterima, panelStatDicuci, panelStatDisetrika, panelStatSiap, panelStatSelesai;
        private Panel panelKolomDiterima, panelKolomDicuci, panelKolomDisetrika, panelKolomSiap;
        private Panel panelKartuLD0152, panelKartuLD0153, panelKartuLD0151, panelKartuLD0149;
        private Panel panelKartuLD0142, panelKartuLD0148, panelKartuLD0146, panelKartuLD0144;
        private Label labelLogo, labelBadgeAdmin, labelMenuDasbor, labelMenuPesanan, labelMenuPaket, labelAdminOutlet;
        private Label labelJudul, labelTanggal, labelPapanStatus;
        private LinkLabel linkLabelKeluar;
        private Button buttonLihatSemuaPesanan;
        private Label labelBadgeDiterima, labelAngkaDiterima, labelKetDiterima;
        private Label labelBadgeDicuci, labelAngkaDicuci, labelKetDicuci;
        private Label labelBadgeDisetrika, labelAngkaDisetrika, labelKetDisetrika;
        private Label labelBadgeSiap, labelAngkaSiap, labelKetSiap;
        private Label labelBadgeSelesai, labelAngkaSelesai, labelKetSelesai;
        private Label labelJudulKolomDiterima, labelJumlahKolomDiterima, labelJudulKolomDicuci, labelJumlahKolomDicuci;
        private Label labelJudulKolomDisetrika, labelJumlahKolomDisetrika, labelJudulKolomSiap, labelJumlahKolomSiap;
        private Label labelNoLD0152, labelEstLD0152, labelNamaLD0152, labelPaketLD0152;
        private Label labelNoLD0153, labelEstLD0153, labelNamaLD0153, labelPaketLD0153;
        private Label labelNoLD0151, labelEstLD0151, labelNamaLD0151, labelPaketLD0151;
        private Label labelNoLD0149, labelEstLD0149, labelNamaLD0149, labelPaketLD0149;
        private Label labelNoLD0142, labelEstLD0142, labelNamaLD0142, labelPaketLD0142;
        private Label labelNoLD0148, labelEstLD0148, labelNamaLD0148, labelPaketLD0148;
        private Label labelNoLD0146, labelEstLD0146, labelNamaLD0146, labelPaketLD0146;
        private Label labelNoLD0144, labelEstLD0144, labelNamaLD0144, labelPaketLD0144;
        private Button buttonAksiLD0152, buttonAksiLD0153, buttonAksiLD0151, buttonAksiLD0149;
        private Button buttonAksiLD0142, buttonAksiLD0148, buttonAksiLD0146, buttonAksiLD0144;
    }
}