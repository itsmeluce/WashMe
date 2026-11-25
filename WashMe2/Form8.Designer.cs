using System.Drawing;
using System.Windows.Forms;

namespace WashMe2
{
    partial class Form8
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelBeranda = new System.Windows.Forms.Label();
            this.labelPesanLaundry = new System.Windows.Forms.Label();
            this.labelLacakCucian = new System.Windows.Forms.Label();
            this.labelPelanggan = new System.Windows.Forms.Label();
            this.linkLabelKeluar = new System.Windows.Forms.LinkLabel();
            this.labelLangkah = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelSubjudul = new System.Windows.Forms.Label();
            this.panelCuciKiloan = new System.Windows.Forms.Panel();
            this.radioButtonCuciKiloan = new System.Windows.Forms.RadioButton();
            this.labelNamaCuciKiloan = new System.Windows.Forms.Label();
            this.labelDeskripsiCuciKiloan = new System.Windows.Forms.Label();
            this.labelEstimasiCuciKiloan = new System.Windows.Forms.Label();
            this.labelHargaCuciKiloan = new System.Windows.Forms.Label();
            this.panelCuciSetrika = new System.Windows.Forms.Panel();
            this.radioButtonCuciSetrika = new System.Windows.Forms.RadioButton();
            this.labelNamaCuciSetrika = new System.Windows.Forms.Label();
            this.labelPalingPopuler = new System.Windows.Forms.Label();
            this.labelDeskripsiCuciSetrika = new System.Windows.Forms.Label();
            this.labelEstimasiCuciSetrika = new System.Windows.Forms.Label();
            this.labelHargaCuciSetrika = new System.Windows.Forms.Label();
            this.panelExpress24Jam = new System.Windows.Forms.Panel();
            this.radioButtonExpress24Jam = new System.Windows.Forms.RadioButton();
            this.labelNamaExpress24Jam = new System.Windows.Forms.Label();
            this.labelDeskripsiExpress24Jam = new System.Windows.Forms.Label();
            this.labelEstimasiExpress24Jam = new System.Windows.Forms.Label();
            this.labelHargaExpress24Jam = new System.Windows.Forms.Label();
            this.panelSatuan = new System.Windows.Forms.Panel();
            this.radioButtonSatuan = new System.Windows.Forms.RadioButton();
            this.labelNamaSatuan = new System.Windows.Forms.Label();
            this.labelDeskripsiSatuan = new System.Windows.Forms.Label();
            this.labelEstimasiSatuan = new System.Windows.Forms.Label();
            this.labelHargaSatuan = new System.Windows.Forms.Label();
            this.labelJudulJumlahCucian = new System.Windows.Forms.Label();
            this.panelJumlahCucian = new System.Windows.Forms.Panel();
            this.labelPerkiraanBerat = new System.Windows.Forms.Label();
            this.labelKeteranganBerat = new System.Windows.Forms.Label();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.labelBeratKilogram = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelJudulLayananTambahan = new System.Windows.Forms.Label();
            this.panelJemputAntar = new System.Windows.Forms.Panel();
            this.checkBoxJemputAntar = new System.Windows.Forms.CheckBox();
            this.labelKeteranganJemputAntar = new System.Windows.Forms.Label();
            this.labelHargaJemputAntar = new System.Windows.Forms.Label();
            this.panelPewangiPremium = new System.Windows.Forms.Panel();
            this.checkBoxPewangiPremium = new System.Windows.Forms.CheckBox();
            this.labelKeteranganPewangiPremium = new System.Windows.Forms.Label();
            this.labelHargaPewangiPremium = new System.Windows.Forms.Label();
            this.panelPisahkanPakaianPutih = new System.Windows.Forms.Panel();
            this.checkBoxPisahkanPakaianPutih = new System.Windows.Forms.CheckBox();
            this.labelKeteranganPisahkanPakaianPutih = new System.Windows.Forms.Label();
            this.labelHargaPisahkanPakaianPutih = new System.Windows.Forms.Label();
            this.panelRingkasanPesanan = new System.Windows.Forms.Panel();
            this.labelJudulRingkasan = new System.Windows.Forms.Label();
            this.labelRingkasanNamaPaket = new System.Windows.Forms.Label();
            this.labelRingkasanRincianPaket = new System.Windows.Forms.Label();
            this.labelRingkasanHargaPaket = new System.Windows.Forms.Label();
            this.labelRingkasanJemputAntar = new System.Windows.Forms.Label();
            this.labelRingkasanHargaJemputAntar = new System.Windows.Forms.Label();
            this.panelGarisPemisah = new System.Windows.Forms.Panel();
            this.labelKeteranganTotal = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelCatatanHarga = new System.Windows.Forms.Label();
            this.buttonLanjutKePenjemputan = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCuciKiloan.SuspendLayout();
            this.panelCuciSetrika.SuspendLayout();
            this.panelExpress24Jam.SuspendLayout();
            this.panelSatuan.SuspendLayout();
            this.panelJumlahCucian.SuspendLayout();
            this.panelJemputAntar.SuspendLayout();
            this.panelPewangiPremium.SuspendLayout();
            this.panelPisahkanPakaianPutih.SuspendLayout();
            this.panelRingkasanPesanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.panelHeader.Controls.Add(this.labelLogo);
            this.panelHeader.Controls.Add(this.labelBeranda);
            this.panelHeader.Controls.Add(this.labelPesanLaundry);
            this.panelHeader.Controls.Add(this.labelLacakCucian);
            this.panelHeader.Controls.Add(this.labelPelanggan);
            this.panelHeader.Controls.Add(this.linkLabelKeluar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1120, 53);
            this.panelHeader.TabIndex = 14;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(27, 15);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(88, 23);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "WashMe";
            // 
            // labelBeranda
            // 
            this.labelBeranda.AutoSize = true;
            this.labelBeranda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBeranda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.labelBeranda.Location = new System.Drawing.Point(377, 18);
            this.labelBeranda.Name = "labelBeranda";
            this.labelBeranda.Size = new System.Drawing.Size(64, 20);
            this.labelBeranda.TabIndex = 1;
            this.labelBeranda.Text = "Beranda";
            // 
            // labelPesanLaundry
            // 
            this.labelPesanLaundry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.labelPesanLaundry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPesanLaundry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.labelPesanLaundry.Location = new System.Drawing.Point(457, 13);
            this.labelPesanLaundry.Name = "labelPesanLaundry";
            this.labelPesanLaundry.Size = new System.Drawing.Size(114, 28);
            this.labelPesanLaundry.TabIndex = 2;
            this.labelPesanLaundry.Text = "Pesan Laundry";
            this.labelPesanLaundry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLacakCucian
            // 
            this.labelLacakCucian.AutoSize = true;
            this.labelLacakCucian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLacakCucian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.labelLacakCucian.Location = new System.Drawing.Point(594, 18);
            this.labelLacakCucian.Name = "labelLacakCucian";
            this.labelLacakCucian.Size = new System.Drawing.Size(94, 20);
            this.labelLacakCucian.TabIndex = 3;
            this.labelLacakCucian.Text = "Lacak Cucian";
            // 
            // labelPelanggan
            // 
            this.labelPelanggan.AutoSize = true;
            this.labelPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPelanggan.ForeColor = System.Drawing.Color.White;
            this.labelPelanggan.Location = new System.Drawing.Point(949, 18);
            this.labelPelanggan.Name = "labelPelanggan";
            this.labelPelanggan.Size = new System.Drawing.Size(78, 20);
            this.labelPelanggan.TabIndex = 4;
            this.labelPelanggan.Text = "Pelanggan";
            // 
            // linkLabelKeluar
            // 
            this.linkLabelKeluar.AutoSize = true;
            this.linkLabelKeluar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabelKeluar.LinkColor = System.Drawing.Color.White;
            this.linkLabelKeluar.Location = new System.Drawing.Point(1040, 18);
            this.linkLabelKeluar.Name = "linkLabelKeluar";
            this.linkLabelKeluar.Size = new System.Drawing.Size(51, 20);
            this.linkLabelKeluar.TabIndex = 5;
            this.linkLabelKeluar.TabStop = true;
            this.linkLabelKeluar.Text = "Keluar";
            // 
            // labelLangkah
            // 
            this.labelLangkah.AutoSize = true;
            this.labelLangkah.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelLangkah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.labelLangkah.Location = new System.Drawing.Point(34, 70);
            this.labelLangkah.Name = "labelLangkah";
            this.labelLangkah.Size = new System.Drawing.Size(192, 19);
            this.labelLangkah.TabIndex = 13;
            this.labelLangkah.Text = "LANGKAH 1 DARI 3 · PAKET";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold);
            this.labelJudul.ForeColor = System.Drawing.Color.Black;
            this.labelJudul.Location = new System.Drawing.Point(30, 87);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(371, 46);
            this.labelJudul.TabIndex = 12;
            this.labelJudul.Text = "Pilih paket laundry";
            // 
            // labelSubjudul
            // 
            this.labelSubjudul.AutoSize = true;
            this.labelSubjudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubjudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSubjudul.Location = new System.Drawing.Point(34, 137);
            this.labelSubjudul.Name = "labelSubjudul";
            this.labelSubjudul.Size = new System.Drawing.Size(478, 20);
            this.labelSubjudul.TabIndex = 11;
            this.labelSubjudul.Text = "Pilih satu paket sesuai jenis cucian dan kecepatan yang kamu butuhkan.";
            // 
            // panelCuciKiloan
            // 
            this.panelCuciKiloan.BackColor = System.Drawing.Color.White;
            this.panelCuciKiloan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCuciKiloan.Controls.Add(this.radioButtonCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelNamaCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelDeskripsiCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelEstimasiCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelHargaCuciKiloan);
            this.panelCuciKiloan.Location = new System.Drawing.Point(34, 171);
            this.panelCuciKiloan.Name = "panelCuciKiloan";
            this.panelCuciKiloan.Size = new System.Drawing.Size(347, 124);
            this.panelCuciKiloan.TabIndex = 10;
            // 
            // radioButtonCuciKiloan
            // 
            this.radioButtonCuciKiloan.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCuciKiloan.Location = new System.Drawing.Point(313, 9);
            this.radioButtonCuciKiloan.Name = "radioButtonCuciKiloan";
            this.radioButtonCuciKiloan.Size = new System.Drawing.Size(23, 21);
            this.radioButtonCuciKiloan.TabIndex = 0;
            this.radioButtonCuciKiloan.UseVisualStyleBackColor = false;
            // 
            // labelNamaCuciKiloan
            // 
            this.labelNamaCuciKiloan.AutoSize = true;
            this.labelNamaCuciKiloan.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaCuciKiloan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNamaCuciKiloan.Location = new System.Drawing.Point(14, 9);
            this.labelNamaCuciKiloan.Name = "labelNamaCuciKiloan";
            this.labelNamaCuciKiloan.Size = new System.Drawing.Size(99, 23);
            this.labelNamaCuciKiloan.TabIndex = 1;
            this.labelNamaCuciKiloan.Text = "Cuci Kiloan";
            // 
            // labelDeskripsiCuciKiloan
            // 
            this.labelDeskripsiCuciKiloan.BackColor = System.Drawing.Color.Transparent;
            this.labelDeskripsiCuciKiloan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDeskripsiCuciKiloan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelDeskripsiCuciKiloan.Location = new System.Drawing.Point(14, 34);
            this.labelDeskripsiCuciKiloan.Name = "labelDeskripsiCuciKiloan";
            this.labelDeskripsiCuciKiloan.Size = new System.Drawing.Size(309, 30);
            this.labelDeskripsiCuciKiloan.TabIndex = 2;
            this.labelDeskripsiCuciKiloan.Text = "Cuci, kering, dan lipat rapi.";
            // 
            // labelEstimasiCuciKiloan
            // 
            this.labelEstimasiCuciKiloan.AutoSize = true;
            this.labelEstimasiCuciKiloan.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimasiCuciKiloan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstimasiCuciKiloan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstimasiCuciKiloan.Location = new System.Drawing.Point(14, 68);
            this.labelEstimasiCuciKiloan.Name = "labelEstimasiCuciKiloan";
            this.labelEstimasiCuciKiloan.Size = new System.Drawing.Size(112, 19);
            this.labelEstimasiCuciKiloan.TabIndex = 3;
            this.labelEstimasiCuciKiloan.Text = "Estimasi 2–3 hari";
            // 
            // labelHargaCuciKiloan
            // 
            this.labelHargaCuciKiloan.AutoSize = true;
            this.labelHargaCuciKiloan.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaCuciKiloan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelHargaCuciKiloan.Location = new System.Drawing.Point(14, 92);
            this.labelHargaCuciKiloan.Name = "labelHargaCuciKiloan";
            this.labelHargaCuciKiloan.Size = new System.Drawing.Size(131, 25);
            this.labelHargaCuciKiloan.TabIndex = 4;
            this.labelHargaCuciKiloan.Text = "Rp 7.000 / kg";
            // 
            // panelCuciSetrika
            // 
            this.panelCuciSetrika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.panelCuciSetrika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCuciSetrika.Controls.Add(this.radioButtonCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelNamaCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelPalingPopuler);
            this.panelCuciSetrika.Controls.Add(this.labelDeskripsiCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelEstimasiCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelHargaCuciSetrika);
            this.panelCuciSetrika.Location = new System.Drawing.Point(395, 171);
            this.panelCuciSetrika.Name = "panelCuciSetrika";
            this.panelCuciSetrika.Size = new System.Drawing.Size(347, 124);
            this.panelCuciSetrika.TabIndex = 9;
            // 
            // radioButtonCuciSetrika
            // 
            this.radioButtonCuciSetrika.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCuciSetrika.Checked = true;
            this.radioButtonCuciSetrika.Location = new System.Drawing.Point(313, 9);
            this.radioButtonCuciSetrika.Name = "radioButtonCuciSetrika";
            this.radioButtonCuciSetrika.Size = new System.Drawing.Size(23, 21);
            this.radioButtonCuciSetrika.TabIndex = 0;
            this.radioButtonCuciSetrika.TabStop = true;
            this.radioButtonCuciSetrika.UseVisualStyleBackColor = false;
            // 
            // labelNamaCuciSetrika
            // 
            this.labelNamaCuciSetrika.AutoSize = true;
            this.labelNamaCuciSetrika.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaCuciSetrika.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNamaCuciSetrika.Location = new System.Drawing.Point(14, 9);
            this.labelNamaCuciSetrika.Name = "labelNamaCuciSetrika";
            this.labelNamaCuciSetrika.Size = new System.Drawing.Size(123, 23);
            this.labelNamaCuciSetrika.TabIndex = 1;
            this.labelNamaCuciSetrika.Text = "Cuci + Setrika";
            // 
            // labelPalingPopuler
            // 
            this.labelPalingPopuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.labelPalingPopuler.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelPalingPopuler.ForeColor = System.Drawing.Color.White;
            this.labelPalingPopuler.Location = new System.Drawing.Point(14, 32);
            this.labelPalingPopuler.Name = "labelPalingPopuler";
            this.labelPalingPopuler.Size = new System.Drawing.Size(101, 18);
            this.labelPalingPopuler.TabIndex = 2;
            this.labelPalingPopuler.Text = "Paling populer";
            this.labelPalingPopuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeskripsiCuciSetrika
            // 
            this.labelDeskripsiCuciSetrika.BackColor = System.Drawing.Color.Transparent;
            this.labelDeskripsiCuciSetrika.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDeskripsiCuciSetrika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelDeskripsiCuciSetrika.Location = new System.Drawing.Point(14, 53);
            this.labelDeskripsiCuciSetrika.Name = "labelDeskripsiCuciSetrika";
            this.labelDeskripsiCuciSetrika.Size = new System.Drawing.Size(309, 30);
            this.labelDeskripsiCuciSetrika.TabIndex = 3;
            this.labelDeskripsiCuciSetrika.Text = "Cuci, kering, lalu dilipat atau digantung.";
            // 
            // labelEstimasiCuciSetrika
            // 
            this.labelEstimasiCuciSetrika.AutoSize = true;
            this.labelEstimasiCuciSetrika.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimasiCuciSetrika.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstimasiCuciSetrika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstimasiCuciSetrika.Location = new System.Drawing.Point(14, 77);
            this.labelEstimasiCuciSetrika.Name = "labelEstimasiCuciSetrika";
            this.labelEstimasiCuciSetrika.Size = new System.Drawing.Size(112, 19);
            this.labelEstimasiCuciSetrika.TabIndex = 4;
            this.labelEstimasiCuciSetrika.Text = "Estimasi 2–3 hari";
            // 
            // labelHargaCuciSetrika
            // 
            this.labelHargaCuciSetrika.AutoSize = true;
            this.labelHargaCuciSetrika.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaCuciSetrika.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelHargaCuciSetrika.Location = new System.Drawing.Point(14, 96);
            this.labelHargaCuciSetrika.Name = "labelHargaCuciSetrika";
            this.labelHargaCuciSetrika.Size = new System.Drawing.Size(131, 25);
            this.labelHargaCuciSetrika.TabIndex = 5;
            this.labelHargaCuciSetrika.Text = "Rp 9.000 / kg";
            // 
            // panelExpress24Jam
            // 
            this.panelExpress24Jam.BackColor = System.Drawing.Color.White;
            this.panelExpress24Jam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpress24Jam.Controls.Add(this.radioButtonExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelNamaExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelDeskripsiExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelEstimasiExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelHargaExpress24Jam);
            this.panelExpress24Jam.Location = new System.Drawing.Point(34, 309);
            this.panelExpress24Jam.Name = "panelExpress24Jam";
            this.panelExpress24Jam.Size = new System.Drawing.Size(347, 124);
            this.panelExpress24Jam.TabIndex = 8;
            // 
            // radioButtonExpress24Jam
            // 
            this.radioButtonExpress24Jam.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonExpress24Jam.Location = new System.Drawing.Point(313, 9);
            this.radioButtonExpress24Jam.Name = "radioButtonExpress24Jam";
            this.radioButtonExpress24Jam.Size = new System.Drawing.Size(23, 21);
            this.radioButtonExpress24Jam.TabIndex = 0;
            this.radioButtonExpress24Jam.UseVisualStyleBackColor = false;
            // 
            // labelNamaExpress24Jam
            // 
            this.labelNamaExpress24Jam.AutoSize = true;
            this.labelNamaExpress24Jam.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaExpress24Jam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNamaExpress24Jam.Location = new System.Drawing.Point(14, 9);
            this.labelNamaExpress24Jam.Name = "labelNamaExpress24Jam";
            this.labelNamaExpress24Jam.Size = new System.Drawing.Size(132, 23);
            this.labelNamaExpress24Jam.TabIndex = 1;
            this.labelNamaExpress24Jam.Text = "Express 24 Jam";
            // 
            // labelDeskripsiExpress24Jam
            // 
            this.labelDeskripsiExpress24Jam.BackColor = System.Drawing.Color.Transparent;
            this.labelDeskripsiExpress24Jam.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDeskripsiExpress24Jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelDeskripsiExpress24Jam.Location = new System.Drawing.Point(14, 34);
            this.labelDeskripsiExpress24Jam.Name = "labelDeskripsiExpress24Jam";
            this.labelDeskripsiExpress24Jam.Size = new System.Drawing.Size(309, 30);
            this.labelDeskripsiExpress24Jam.TabIndex = 2;
            this.labelDeskripsiExpress24Jam.Text = "Cuci kering prioritas, selesai dalam satu hari.";
            // 
            // labelEstimasiExpress24Jam
            // 
            this.labelEstimasiExpress24Jam.AutoSize = true;
            this.labelEstimasiExpress24Jam.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimasiExpress24Jam.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstimasiExpress24Jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstimasiExpress24Jam.Location = new System.Drawing.Point(14, 68);
            this.labelEstimasiExpress24Jam.Name = "labelEstimasiExpress24Jam";
            this.labelEstimasiExpress24Jam.Size = new System.Drawing.Size(97, 19);
            this.labelEstimasiExpress24Jam.TabIndex = 3;
            this.labelEstimasiExpress24Jam.Text = "Estimasi 1 hari";
            // 
            // labelHargaExpress24Jam
            // 
            this.labelHargaExpress24Jam.AutoSize = true;
            this.labelHargaExpress24Jam.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaExpress24Jam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelHargaExpress24Jam.Location = new System.Drawing.Point(14, 92);
            this.labelHargaExpress24Jam.Name = "labelHargaExpress24Jam";
            this.labelHargaExpress24Jam.Size = new System.Drawing.Size(142, 25);
            this.labelHargaExpress24Jam.TabIndex = 4;
            this.labelHargaExpress24Jam.Text = "Rp 14.000 / kg";
            // 
            // panelSatuan
            // 
            this.panelSatuan.BackColor = System.Drawing.Color.White;
            this.panelSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSatuan.Controls.Add(this.radioButtonSatuan);
            this.panelSatuan.Controls.Add(this.labelNamaSatuan);
            this.panelSatuan.Controls.Add(this.labelDeskripsiSatuan);
            this.panelSatuan.Controls.Add(this.labelEstimasiSatuan);
            this.panelSatuan.Controls.Add(this.labelHargaSatuan);
            this.panelSatuan.Location = new System.Drawing.Point(395, 309);
            this.panelSatuan.Name = "panelSatuan";
            this.panelSatuan.Size = new System.Drawing.Size(347, 124);
            this.panelSatuan.TabIndex = 7;
            // 
            // radioButtonSatuan
            // 
            this.radioButtonSatuan.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSatuan.Location = new System.Drawing.Point(313, 9);
            this.radioButtonSatuan.Name = "radioButtonSatuan";
            this.radioButtonSatuan.Size = new System.Drawing.Size(23, 21);
            this.radioButtonSatuan.TabIndex = 0;
            this.radioButtonSatuan.UseVisualStyleBackColor = false;
            // 
            // labelNamaSatuan
            // 
            this.labelNamaSatuan.AutoSize = true;
            this.labelNamaSatuan.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaSatuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNamaSatuan.Location = new System.Drawing.Point(14, 9);
            this.labelNamaSatuan.Name = "labelNamaSatuan";
            this.labelNamaSatuan.Size = new System.Drawing.Size(65, 23);
            this.labelNamaSatuan.TabIndex = 1;
            this.labelNamaSatuan.Text = "Satuan";
            // 
            // labelDeskripsiSatuan
            // 
            this.labelDeskripsiSatuan.BackColor = System.Drawing.Color.Transparent;
            this.labelDeskripsiSatuan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDeskripsiSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelDeskripsiSatuan.Location = new System.Drawing.Point(14, 34);
            this.labelDeskripsiSatuan.Name = "labelDeskripsiSatuan";
            this.labelDeskripsiSatuan.Size = new System.Drawing.Size(309, 30);
            this.labelDeskripsiSatuan.TabIndex = 2;
            this.labelDeskripsiSatuan.Text = "Bedcover, selimut, jaket, dan pakaian khusus.";
            // 
            // labelEstimasiSatuan
            // 
            this.labelEstimasiSatuan.AutoSize = true;
            this.labelEstimasiSatuan.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimasiSatuan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEstimasiSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelEstimasiSatuan.Location = new System.Drawing.Point(14, 68);
            this.labelEstimasiSatuan.Name = "labelEstimasiSatuan";
            this.labelEstimasiSatuan.Size = new System.Drawing.Size(112, 19);
            this.labelEstimasiSatuan.TabIndex = 3;
            this.labelEstimasiSatuan.Text = "Estimasi 2–3 hari";
            // 
            // labelHargaSatuan
            // 
            this.labelHargaSatuan.AutoSize = true;
            this.labelHargaSatuan.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaSatuan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelHargaSatuan.Location = new System.Drawing.Point(14, 92);
            this.labelHargaSatuan.Name = "labelHargaSatuan";
            this.labelHargaSatuan.Size = new System.Drawing.Size(158, 25);
            this.labelHargaSatuan.TabIndex = 4;
            this.labelHargaSatuan.Text = "Rp 25.000 / item";
            // 
            // labelJudulJumlahCucian
            // 
            this.labelJudulJumlahCucian.AutoSize = true;
            this.labelJudulJumlahCucian.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelJudulJumlahCucian.Location = new System.Drawing.Point(34, 452);
            this.labelJudulJumlahCucian.Name = "labelJudulJumlahCucian";
            this.labelJudulJumlahCucian.Size = new System.Drawing.Size(137, 25);
            this.labelJudulJumlahCucian.TabIndex = 6;
            this.labelJudulJumlahCucian.Text = "Jumlah cucian";
            // 
            // panelJumlahCucian
            // 
            this.panelJumlahCucian.BackColor = System.Drawing.Color.White;
            this.panelJumlahCucian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJumlahCucian.Controls.Add(this.labelPerkiraanBerat);
            this.panelJumlahCucian.Controls.Add(this.labelKeteranganBerat);
            this.panelJumlahCucian.Controls.Add(this.buttonKurang);
            this.panelJumlahCucian.Controls.Add(this.labelBeratKilogram);
            this.panelJumlahCucian.Controls.Add(this.buttonTambah);
            this.panelJumlahCucian.Location = new System.Drawing.Point(34, 482);
            this.panelJumlahCucian.Name = "panelJumlahCucian";
            this.panelJumlahCucian.Size = new System.Drawing.Size(708, 68);
            this.panelJumlahCucian.TabIndex = 5;
            // 
            // labelPerkiraanBerat
            // 
            this.labelPerkiraanBerat.AutoSize = true;
            this.labelPerkiraanBerat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPerkiraanBerat.Location = new System.Drawing.Point(16, 13);
            this.labelPerkiraanBerat.Name = "labelPerkiraanBerat";
            this.labelPerkiraanBerat.Size = new System.Drawing.Size(116, 20);
            this.labelPerkiraanBerat.TabIndex = 0;
            this.labelPerkiraanBerat.Text = "Perkiraan berat";
            // 
            // labelKeteranganBerat
            // 
            this.labelKeteranganBerat.AutoSize = true;
            this.labelKeteranganBerat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKeteranganBerat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKeteranganBerat.Location = new System.Drawing.Point(16, 36);
            this.labelKeteranganBerat.Name = "labelKeteranganBerat";
            this.labelKeteranganBerat.Size = new System.Drawing.Size(289, 19);
            this.labelKeteranganBerat.TabIndex = 1;
            this.labelKeteranganBerat.Text = "Perkiraan saja, berat akhir ditimbang di outlet.";
            // 
            // buttonKurang
            // 
            this.buttonKurang.BackColor = System.Drawing.Color.White;
            this.buttonKurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKurang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonKurang.Location = new System.Drawing.Point(526, 15);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(39, 36);
            this.buttonKurang.TabIndex = 2;
            this.buttonKurang.Text = "−";
            this.buttonKurang.UseVisualStyleBackColor = false;
            // 
            // labelBeratKilogram
            // 
            this.labelBeratKilogram.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelBeratKilogram.Location = new System.Drawing.Point(569, 15);
            this.labelBeratKilogram.Name = "labelBeratKilogram";
            this.labelBeratKilogram.Size = new System.Drawing.Size(69, 36);
            this.labelBeratKilogram.TabIndex = 3;
            this.labelBeratKilogram.Text = "5 kg";
            this.labelBeratKilogram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.White;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTambah.Location = new System.Drawing.Point(642, 15);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(39, 36);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // labelJudulLayananTambahan
            // 
            this.labelJudulLayananTambahan.AutoSize = true;
            this.labelJudulLayananTambahan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelJudulLayananTambahan.Location = new System.Drawing.Point(34, 570);
            this.labelJudulLayananTambahan.Name = "labelJudulLayananTambahan";
            this.labelJudulLayananTambahan.Size = new System.Drawing.Size(180, 25);
            this.labelJudulLayananTambahan.TabIndex = 4;
            this.labelJudulLayananTambahan.Text = "Layanan tambahan";
            // 
            // panelJemputAntar
            // 
            this.panelJemputAntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.panelJemputAntar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJemputAntar.Controls.Add(this.checkBoxJemputAntar);
            this.panelJemputAntar.Controls.Add(this.labelKeteranganJemputAntar);
            this.panelJemputAntar.Controls.Add(this.labelHargaJemputAntar);
            this.panelJemputAntar.Location = new System.Drawing.Point(34, 599);
            this.panelJemputAntar.Name = "panelJemputAntar";
            this.panelJemputAntar.Size = new System.Drawing.Size(708, 53);
            this.panelJemputAntar.TabIndex = 3;
            // 
            // checkBoxJemputAntar
            // 
            this.checkBoxJemputAntar.AutoSize = true;
            this.checkBoxJemputAntar.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxJemputAntar.Checked = true;
            this.checkBoxJemputAntar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxJemputAntar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxJemputAntar.Location = new System.Drawing.Point(14, 6);
            this.checkBoxJemputAntar.Name = "checkBoxJemputAntar";
            this.checkBoxJemputAntar.Size = new System.Drawing.Size(155, 24);
            this.checkBoxJemputAntar.TabIndex = 0;
            this.checkBoxJemputAntar.Text = "Jemput dan antar";
            this.checkBoxJemputAntar.UseVisualStyleBackColor = false;
            // 
            // labelKeteranganJemputAntar
            // 
            this.labelKeteranganJemputAntar.AutoSize = true;
            this.labelKeteranganJemputAntar.BackColor = System.Drawing.Color.Transparent;
            this.labelKeteranganJemputAntar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKeteranganJemputAntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKeteranganJemputAntar.Location = new System.Drawing.Point(37, 30);
            this.labelKeteranganJemputAntar.Name = "labelKeteranganJemputAntar";
            this.labelKeteranganJemputAntar.Size = new System.Drawing.Size(338, 19);
            this.labelKeteranganJemputAntar.TabIndex = 1;
            this.labelKeteranganJemputAntar.Text = "Kurir menjemput dan mengantar cucian ke alamatmu.";
            // 
            // labelHargaJemputAntar
            // 
            this.labelHargaJemputAntar.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaJemputAntar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelHargaJemputAntar.Location = new System.Drawing.Point(549, 9);
            this.labelHargaJemputAntar.Name = "labelHargaJemputAntar";
            this.labelHargaJemputAntar.Size = new System.Drawing.Size(144, 21);
            this.labelHargaJemputAntar.TabIndex = 2;
            this.labelHargaJemputAntar.Text = "+ Rp 5.000";
            this.labelHargaJemputAntar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPewangiPremium
            // 
            this.panelPewangiPremium.BackColor = System.Drawing.Color.White;
            this.panelPewangiPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPewangiPremium.Controls.Add(this.checkBoxPewangiPremium);
            this.panelPewangiPremium.Controls.Add(this.labelKeteranganPewangiPremium);
            this.panelPewangiPremium.Controls.Add(this.labelHargaPewangiPremium);
            this.panelPewangiPremium.Location = new System.Drawing.Point(34, 659);
            this.panelPewangiPremium.Name = "panelPewangiPremium";
            this.panelPewangiPremium.Size = new System.Drawing.Size(708, 53);
            this.panelPewangiPremium.TabIndex = 2;
            // 
            // checkBoxPewangiPremium
            // 
            this.checkBoxPewangiPremium.AutoSize = true;
            this.checkBoxPewangiPremium.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPewangiPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxPewangiPremium.Location = new System.Drawing.Point(14, 6);
            this.checkBoxPewangiPremium.Name = "checkBoxPewangiPremium";
            this.checkBoxPewangiPremium.Size = new System.Drawing.Size(158, 24);
            this.checkBoxPewangiPremium.TabIndex = 0;
            this.checkBoxPewangiPremium.Text = "Pewangi premium";
            this.checkBoxPewangiPremium.UseVisualStyleBackColor = false;
            // 
            // labelKeteranganPewangiPremium
            // 
            this.labelKeteranganPewangiPremium.AutoSize = true;
            this.labelKeteranganPewangiPremium.BackColor = System.Drawing.Color.Transparent;
            this.labelKeteranganPewangiPremium.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKeteranganPewangiPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKeteranganPewangiPremium.Location = new System.Drawing.Point(37, 30);
            this.labelKeteranganPewangiPremium.Name = "labelKeteranganPewangiPremium";
            this.labelKeteranganPewangiPremium.Size = new System.Drawing.Size(200, 19);
            this.labelKeteranganPewangiPremium.TabIndex = 1;
            this.labelKeteranganPewangiPremium.Text = "Pilihan aroma lebih tahan lama.";
            // 
            // labelHargaPewangiPremium
            // 
            this.labelHargaPewangiPremium.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaPewangiPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelHargaPewangiPremium.Location = new System.Drawing.Point(549, 9);
            this.labelHargaPewangiPremium.Name = "labelHargaPewangiPremium";
            this.labelHargaPewangiPremium.Size = new System.Drawing.Size(144, 21);
            this.labelHargaPewangiPremium.TabIndex = 2;
            this.labelHargaPewangiPremium.Text = "+ Rp 3.000";
            this.labelHargaPewangiPremium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPisahkanPakaianPutih
            // 
            this.panelPisahkanPakaianPutih.BackColor = System.Drawing.Color.White;
            this.panelPisahkanPakaianPutih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPisahkanPakaianPutih.Controls.Add(this.checkBoxPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Controls.Add(this.labelKeteranganPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Controls.Add(this.labelHargaPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Location = new System.Drawing.Point(34, 719);
            this.panelPisahkanPakaianPutih.Name = "panelPisahkanPakaianPutih";
            this.panelPisahkanPakaianPutih.Size = new System.Drawing.Size(708, 53);
            this.panelPisahkanPakaianPutih.TabIndex = 1;
            // 
            // checkBoxPisahkanPakaianPutih
            // 
            this.checkBoxPisahkanPakaianPutih.AutoSize = true;
            this.checkBoxPisahkanPakaianPutih.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPisahkanPakaianPutih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxPisahkanPakaianPutih.Location = new System.Drawing.Point(14, 6);
            this.checkBoxPisahkanPakaianPutih.Name = "checkBoxPisahkanPakaianPutih";
            this.checkBoxPisahkanPakaianPutih.Size = new System.Drawing.Size(192, 24);
            this.checkBoxPisahkanPakaianPutih.TabIndex = 0;
            this.checkBoxPisahkanPakaianPutih.Text = "Pisahkan pakaian putih";
            this.checkBoxPisahkanPakaianPutih.UseVisualStyleBackColor = false;
            // 
            // labelKeteranganPisahkanPakaianPutih
            // 
            this.labelKeteranganPisahkanPakaianPutih.AutoSize = true;
            this.labelKeteranganPisahkanPakaianPutih.BackColor = System.Drawing.Color.Transparent;
            this.labelKeteranganPisahkanPakaianPutih.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelKeteranganPisahkanPakaianPutih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelKeteranganPisahkanPakaianPutih.Location = new System.Drawing.Point(37, 30);
            this.labelKeteranganPisahkanPakaianPutih.Name = "labelKeteranganPisahkanPakaianPutih";
            this.labelKeteranganPisahkanPakaianPutih.Size = new System.Drawing.Size(248, 19);
            this.labelKeteranganPisahkanPakaianPutih.TabIndex = 1;
            this.labelKeteranganPisahkanPakaianPutih.Text = "Dicuci terpisah agar warna tidak luntur.";
            // 
            // labelHargaPisahkanPakaianPutih
            // 
            this.labelHargaPisahkanPakaianPutih.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaPisahkanPakaianPutih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelHargaPisahkanPakaianPutih.Location = new System.Drawing.Point(549, 9);
            this.labelHargaPisahkanPakaianPutih.Name = "labelHargaPisahkanPakaianPutih";
            this.labelHargaPisahkanPakaianPutih.Size = new System.Drawing.Size(144, 21);
            this.labelHargaPisahkanPakaianPutih.TabIndex = 2;
            this.labelHargaPisahkanPakaianPutih.Text = "Gratis";
            this.labelHargaPisahkanPakaianPutih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRingkasanPesanan
            // 
            this.panelRingkasanPesanan.BackColor = System.Drawing.Color.White;
            this.panelRingkasanPesanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRingkasanPesanan.Controls.Add(this.labelJudulRingkasan);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanNamaPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanRincianPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanHargaPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanJemputAntar);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanHargaJemputAntar);
            this.panelRingkasanPesanan.Controls.Add(this.panelGarisPemisah);
            this.panelRingkasanPesanan.Controls.Add(this.labelKeteranganTotal);
            this.panelRingkasanPesanan.Controls.Add(this.labelTotalHarga);
            this.panelRingkasanPesanan.Controls.Add(this.labelCatatanHarga);
            this.panelRingkasanPesanan.Controls.Add(this.buttonLanjutKePenjemputan);
            this.panelRingkasanPesanan.Location = new System.Drawing.Point(777, 96);
            this.panelRingkasanPesanan.Name = "panelRingkasanPesanan";
            this.panelRingkasanPesanan.Size = new System.Drawing.Size(320, 320);
            this.panelRingkasanPesanan.TabIndex = 0;
            // 
            // labelJudulRingkasan
            // 
            this.labelJudulRingkasan.AutoSize = true;
            this.labelJudulRingkasan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelJudulRingkasan.Location = new System.Drawing.Point(18, 15);
            this.labelJudulRingkasan.Name = "labelJudulRingkasan";
            this.labelJudulRingkasan.Size = new System.Drawing.Size(193, 28);
            this.labelJudulRingkasan.TabIndex = 0;
            this.labelJudulRingkasan.Text = "Ringkasan pesanan";
            // 
            // labelRingkasanNamaPaket
            // 
            this.labelRingkasanNamaPaket.AutoSize = true;
            this.labelRingkasanNamaPaket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelRingkasanNamaPaket.Location = new System.Drawing.Point(18, 55);
            this.labelRingkasanNamaPaket.Name = "labelRingkasanNamaPaket";
            this.labelRingkasanNamaPaket.Size = new System.Drawing.Size(105, 20);
            this.labelRingkasanNamaPaket.TabIndex = 1;
            this.labelRingkasanNamaPaket.Text = "Cuci + Setrika";
            // 
            // labelRingkasanRincianPaket
            // 
            this.labelRingkasanRincianPaket.AutoSize = true;
            this.labelRingkasanRincianPaket.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelRingkasanRincianPaket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelRingkasanRincianPaket.Location = new System.Drawing.Point(18, 77);
            this.labelRingkasanRincianPaket.Name = "labelRingkasanRincianPaket";
            this.labelRingkasanRincianPaket.Size = new System.Drawing.Size(109, 19);
            this.labelRingkasanRincianPaket.TabIndex = 2;
            this.labelRingkasanRincianPaket.Text = "5 kg × Rp 9.000";
            // 
            // labelRingkasanHargaPaket
            // 
            this.labelRingkasanHargaPaket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelRingkasanHargaPaket.Location = new System.Drawing.Point(171, 55);
            this.labelRingkasanHargaPaket.Name = "labelRingkasanHargaPaket";
            this.labelRingkasanHargaPaket.Size = new System.Drawing.Size(128, 21);
            this.labelRingkasanHargaPaket.TabIndex = 3;
            this.labelRingkasanHargaPaket.Text = "Rp 45.000";
            this.labelRingkasanHargaPaket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRingkasanJemputAntar
            // 
            this.labelRingkasanJemputAntar.AutoSize = true;
            this.labelRingkasanJemputAntar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelRingkasanJemputAntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelRingkasanJemputAntar.Location = new System.Drawing.Point(18, 109);
            this.labelRingkasanJemputAntar.Name = "labelRingkasanJemputAntar";
            this.labelRingkasanJemputAntar.Size = new System.Drawing.Size(124, 20);
            this.labelRingkasanJemputAntar.TabIndex = 4;
            this.labelRingkasanJemputAntar.Text = "Jemput dan antar";
            // 
            // labelRingkasanHargaJemputAntar
            // 
            this.labelRingkasanHargaJemputAntar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelRingkasanHargaJemputAntar.Location = new System.Drawing.Point(171, 109);
            this.labelRingkasanHargaJemputAntar.Name = "labelRingkasanHargaJemputAntar";
            this.labelRingkasanHargaJemputAntar.Size = new System.Drawing.Size(128, 21);
            this.labelRingkasanHargaJemputAntar.TabIndex = 5;
            this.labelRingkasanHargaJemputAntar.Text = "Rp 5.000";
            this.labelRingkasanHargaJemputAntar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelGarisPemisah
            // 
            this.panelGarisPemisah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.panelGarisPemisah.Location = new System.Drawing.Point(18, 143);
            this.panelGarisPemisah.Name = "panelGarisPemisah";
            this.panelGarisPemisah.Size = new System.Drawing.Size(281, 1);
            this.panelGarisPemisah.TabIndex = 6;
            // 
            // labelKeteranganTotal
            // 
            this.labelKeteranganTotal.AutoSize = true;
            this.labelKeteranganTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelKeteranganTotal.Location = new System.Drawing.Point(18, 166);
            this.labelKeteranganTotal.Name = "labelKeteranganTotal";
            this.labelKeteranganTotal.Size = new System.Drawing.Size(104, 20);
            this.labelKeteranganTotal.TabIndex = 7;
            this.labelKeteranganTotal.Text = "Perkiraan total";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTotalHarga.Location = new System.Drawing.Point(126, 156);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(174, 34);
            this.labelTotalHarga.TabIndex = 8;
            this.labelTotalHarga.Text = "Rp 50.000";
            this.labelTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCatatanHarga
            // 
            this.labelCatatanHarga.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelCatatanHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelCatatanHarga.Location = new System.Drawing.Point(18, 201);
            this.labelCatatanHarga.Name = "labelCatatanHarga";
            this.labelCatatanHarga.Size = new System.Drawing.Size(281, 47);
            this.labelCatatanHarga.TabIndex = 9;
            this.labelCatatanHarga.Text = "Harga di halaman ini hanya contoh. Berat akhir ditimbang saat cucian diterima, ja" +
    "di total bisa berubah.";
            // 
            // buttonLanjutKePenjemputan
            // 
            this.buttonLanjutKePenjemputan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.buttonLanjutKePenjemputan.FlatAppearance.BorderSize = 0;
            this.buttonLanjutKePenjemputan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanjutKePenjemputan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLanjutKePenjemputan.ForeColor = System.Drawing.Color.White;
            this.buttonLanjutKePenjemputan.Location = new System.Drawing.Point(18, 260);
            this.buttonLanjutKePenjemputan.Name = "buttonLanjutKePenjemputan";
            this.buttonLanjutKePenjemputan.Size = new System.Drawing.Size(281, 45);
            this.buttonLanjutKePenjemputan.TabIndex = 10;
            this.buttonLanjutKePenjemputan.Text = "Lanjut ke Penjemputan";
            this.buttonLanjutKePenjemputan.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1120, 800);
            this.Controls.Add(this.panelRingkasanPesanan);
            this.Controls.Add(this.panelPisahkanPakaianPutih);
            this.Controls.Add(this.panelPewangiPremium);
            this.Controls.Add(this.panelJemputAntar);
            this.Controls.Add(this.labelJudulLayananTambahan);
            this.Controls.Add(this.panelJumlahCucian);
            this.Controls.Add(this.labelJudulJumlahCucian);
            this.Controls.Add(this.panelSatuan);
            this.Controls.Add(this.panelExpress24Jam);
            this.Controls.Add(this.panelCuciSetrika);
            this.Controls.Add(this.panelCuciKiloan);
            this.Controls.Add(this.labelSubjudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.labelLangkah);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilih Paket Laundry";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCuciKiloan.ResumeLayout(false);
            this.panelCuciKiloan.PerformLayout();
            this.panelCuciSetrika.ResumeLayout(false);
            this.panelCuciSetrika.PerformLayout();
            this.panelExpress24Jam.ResumeLayout(false);
            this.panelExpress24Jam.PerformLayout();
            this.panelSatuan.ResumeLayout(false);
            this.panelSatuan.PerformLayout();
            this.panelJumlahCucian.ResumeLayout(false);
            this.panelJumlahCucian.PerformLayout();
            this.panelJemputAntar.ResumeLayout(false);
            this.panelJemputAntar.PerformLayout();
            this.panelPewangiPremium.ResumeLayout(false);
            this.panelPewangiPremium.PerformLayout();
            this.panelPisahkanPakaianPutih.ResumeLayout(false);
            this.panelPisahkanPakaianPutih.PerformLayout();
            this.panelRingkasanPesanan.ResumeLayout(false);
            this.panelRingkasanPesanan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private Label labelLogo;
        private Label labelBeranda;
        private Label labelPesanLaundry;
        private Label labelLacakCucian;
        private Label labelPelanggan;
        private LinkLabel linkLabelKeluar;
        private Label labelLangkah;
        private Label labelJudul;
        private Label labelSubjudul;
        private Panel panelCuciKiloan;
        private RadioButton radioButtonCuciKiloan;
        private Label labelNamaCuciKiloan;
        private Label labelDeskripsiCuciKiloan;
        private Label labelEstimasiCuciKiloan;
        private Label labelHargaCuciKiloan;
        private Panel panelCuciSetrika;
        private RadioButton radioButtonCuciSetrika;
        private Label labelNamaCuciSetrika;
        private Label labelPalingPopuler;
        private Label labelDeskripsiCuciSetrika;
        private Label labelEstimasiCuciSetrika;
        private Label labelHargaCuciSetrika;
        private Panel panelExpress24Jam;
        private RadioButton radioButtonExpress24Jam;
        private Label labelNamaExpress24Jam;
        private Label labelDeskripsiExpress24Jam;
        private Label labelEstimasiExpress24Jam;
        private Label labelHargaExpress24Jam;
        private Panel panelSatuan;
        private RadioButton radioButtonSatuan;
        private Label labelNamaSatuan;
        private Label labelDeskripsiSatuan;
        private Label labelEstimasiSatuan;
        private Label labelHargaSatuan;
        private Label labelJudulJumlahCucian;
        private Panel panelJumlahCucian;
        private Label labelPerkiraanBerat;
        private Label labelKeteranganBerat;
        private Button buttonKurang;
        private Label labelBeratKilogram;
        private Button buttonTambah;
        private Label labelJudulLayananTambahan;
        private Panel panelJemputAntar;
        private CheckBox checkBoxJemputAntar;
        private Label labelKeteranganJemputAntar;
        private Label labelHargaJemputAntar;
        private Panel panelPewangiPremium;
        private CheckBox checkBoxPewangiPremium;
        private Label labelKeteranganPewangiPremium;
        private Label labelHargaPewangiPremium;
        private Panel panelPisahkanPakaianPutih;
        private CheckBox checkBoxPisahkanPakaianPutih;
        private Label labelKeteranganPisahkanPakaianPutih;
        private Label labelHargaPisahkanPakaianPutih;
        private Panel panelRingkasanPesanan;
        private Label labelJudulRingkasan;
        private Label labelRingkasanNamaPaket;
        private Label labelRingkasanRincianPaket;
        private Label labelRingkasanHargaPaket;
        private Label labelRingkasanJemputAntar;
        private Label labelRingkasanHargaJemputAntar;
        private Panel panelGarisPemisah;
        private Label labelKeteranganTotal;
        private Label labelTotalHarga;
        private Label labelCatatanHarga;
        private Button buttonLanjutKePenjemputan;
    }
}