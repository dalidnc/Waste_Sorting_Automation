namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    partial class KullanıcıDüzenlemeSayfası
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
            label1 = new Label();
            label2 = new Label();
            BtnKaydet = new Button();
            BtnSil = new Button();
            btnListele = new Button();
            rbYonetimVeİdariYetk = new RadioButton();
            rbKaliteKontrolYtek = new RadioButton();
            rbBakımVeArızaYetk = new RadioButton();
            rbÜretimVeOtomasyonYetk = new RadioButton();
            rbGenelYetkiler = new RadioButton();
            label8 = new Label();
            mskTarih = new MaskedTextBox();
            label7 = new Label();
            txtKullanıcıAd = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label10 = new Label();
            txtId = new TextBox();
            label9 = new Label();
            mskTel = new MaskedTextBox();
            label6 = new Label();
            mskDogumTarihi = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Siemens AD Sans", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 23);
            label1.TabIndex = 1;
            label1.Text = "ATIK AYRIŞTIRMA TESİSİ OTMASYONU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Siemens AD Sans", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(192, 41);
            label2.Name = "label2";
            label2.Size = new Size(228, 23);
            label2.TabIndex = 2;
            label2.Text = "Yönetici Kontrol Paneli";
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = SystemColors.Info;
            BtnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKaydet.Location = new Point(33, 634);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(94, 29);
            BtnKaydet.TabIndex = 14;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Red;
            BtnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSil.Location = new Point(133, 632);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(104, 32);
            BtnSil.TabIndex = 15;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(255, 255, 192);
            btnListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnListele.Location = new Point(539, 632);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(104, 32);
            btnListele.TabIndex = 16;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // rbYonetimVeİdariYetk
            // 
            rbYonetimVeİdariYetk.AutoSize = true;
            rbYonetimVeİdariYetk.Location = new Point(252, 542);
            rbYonetimVeİdariYetk.Name = "rbYonetimVeİdariYetk";
            rbYonetimVeİdariYetk.Size = new Size(189, 24);
            rbYonetimVeİdariYetk.TabIndex = 40;
            rbYonetimVeİdariYetk.TabStop = true;
            rbYonetimVeİdariYetk.Text = "Yönetim ve İdari Yetkiler";
            rbYonetimVeİdariYetk.UseVisualStyleBackColor = true;
            // 
            // rbKaliteKontrolYtek
            // 
            rbKaliteKontrolYtek.AutoSize = true;
            rbKaliteKontrolYtek.Location = new Point(253, 512);
            rbKaliteKontrolYtek.Name = "rbKaliteKontrolYtek";
            rbKaliteKontrolYtek.Size = new Size(177, 24);
            rbKaliteKontrolYtek.TabIndex = 39;
            rbKaliteKontrolYtek.TabStop = true;
            rbKaliteKontrolYtek.Text = "Kalite Kontrol Yetkileri";
            rbKaliteKontrolYtek.UseVisualStyleBackColor = true;
            // 
            // rbBakımVeArızaYetk
            // 
            rbBakımVeArızaYetk.AutoSize = true;
            rbBakımVeArızaYetk.Location = new Point(253, 482);
            rbBakımVeArızaYetk.Name = "rbBakımVeArızaYetk";
            rbBakımVeArızaYetk.Size = new Size(184, 24);
            rbBakımVeArızaYetk.TabIndex = 38;
            rbBakımVeArızaYetk.TabStop = true;
            rbBakımVeArızaYetk.Text = "Bakım ve Arıza Yetkileri";
            rbBakımVeArızaYetk.UseVisualStyleBackColor = true;
            // 
            // rbÜretimVeOtomasyonYetk
            // 
            rbÜretimVeOtomasyonYetk.AutoSize = true;
            rbÜretimVeOtomasyonYetk.Location = new Point(253, 452);
            rbÜretimVeOtomasyonYetk.Name = "rbÜretimVeOtomasyonYetk";
            rbÜretimVeOtomasyonYetk.Size = new Size(225, 24);
            rbÜretimVeOtomasyonYetk.TabIndex = 37;
            rbÜretimVeOtomasyonYetk.TabStop = true;
            rbÜretimVeOtomasyonYetk.Text = "Üretim ve Operasyon Yetkileri";
            rbÜretimVeOtomasyonYetk.UseVisualStyleBackColor = true;
            // 
            // rbGenelYetkiler
            // 
            rbGenelYetkiler.AutoSize = true;
            rbGenelYetkiler.Location = new Point(253, 422);
            rbGenelYetkiler.Name = "rbGenelYetkiler";
            rbGenelYetkiler.Size = new Size(120, 24);
            rbGenelYetkiler.TabIndex = 36;
            rbGenelYetkiler.TabStop = true;
            rbGenelYetkiler.Text = "Genel Yetkiler";
            rbGenelYetkiler.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label8.Location = new Point(60, 422);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 35;
            label8.Text = "Yetkiler : ";
            // 
            // mskTarih
            // 
            mskTarih.Location = new Point(251, 359);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(231, 27);
            mskTarih.TabIndex = 34;
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label7.Location = new Point(60, 359);
            label7.Name = "label7";
            label7.Size = new Size(164, 21);
            label7.TabIndex = 33;
            label7.Text = "İşe Giriş Tarihi : ";
            // 
            // txtKullanıcıAd
            // 
            txtKullanıcıAd.Location = new Point(252, 252);
            txtKullanıcıAd.Name = "txtKullanıcıAd";
            txtKullanıcıAd.Size = new Size(232, 27);
            txtKullanıcıAd.TabIndex = 31;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(253, 169);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(231, 27);
            txtSoyad.TabIndex = 30;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(253, 122);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(231, 27);
            txtAd.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label5.Location = new Point(60, 258);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 27;
            label5.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label4.Location = new Point(60, 175);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 26;
            label4.Text = "Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label3.Location = new Point(64, 124);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 25;
            label3.Text = "Ad : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label10.Location = new Point(64, 86);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 44;
            label10.Text = "ID :";
            // 
            // txtId
            // 
            txtId.Location = new Point(253, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 27);
            txtId.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label9.Location = new Point(60, 304);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 41;
            label9.Text = "Tel :";
            // 
            // mskTel
            // 
            mskTel.Location = new Point(253, 304);
            mskTel.Mask = "(999) 000-0000";
            mskTel.Name = "mskTel";
            mskTel.Size = new Size(231, 27);
            mskTel.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Siemens Serif SC", 10.8F, FontStyle.Bold);
            label6.Location = new Point(60, 220);
            label6.Name = "label6";
            label6.Size = new Size(149, 21);
            label6.TabIndex = 47;
            label6.Text = "Doğum Tarihi : ";
            // 
            // mskDogumTarihi
            // 
            mskDogumTarihi.Location = new Point(253, 214);
            mskDogumTarihi.Mask = "00/00/0000";
            mskDogumTarihi.Name = "mskDogumTarihi";
            mskDogumTarihi.Size = new Size(231, 27);
            mskDogumTarihi.TabIndex = 48;
            mskDogumTarihi.ValidatingType = typeof(DateTime);
            // 
            // KullanıcıDüzenlemeSayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(659, 676);
            Controls.Add(mskDogumTarihi);
            Controls.Add(label6);
            Controls.Add(mskTel);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(rbYonetimVeİdariYetk);
            Controls.Add(rbKaliteKontrolYtek);
            Controls.Add(rbBakımVeArızaYetk);
            Controls.Add(rbÜretimVeOtomasyonYetk);
            Controls.Add(rbGenelYetkiler);
            Controls.Add(label8);
            Controls.Add(mskTarih);
            Controls.Add(label7);
            Controls.Add(txtKullanıcıAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnListele);
            Controls.Add(BtnSil);
            Controls.Add(BtnKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KullanıcıDüzenlemeSayfası";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullanıcıDüzenlemeSayfası";
            Load += KullanıcıDüzenlemeSayfası_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnKaydet;
        private Button BtnSil;
        private Button btnListele;
        private RadioButton rbYonetimVeİdariYetk;
        private RadioButton rbKaliteKontrolYtek;
        private RadioButton rbBakımVeArızaYetk;
        private RadioButton rbÜretimVeOtomasyonYetk;
        private RadioButton rbGenelYetkiler;
        private Label label8;
        private MaskedTextBox mskTarih;
        private Label label7;
        private TextBox txtKullanıcıAd;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private TextBox txtId;
        private Label label9;
        private MaskedTextBox mskTel;
        private Label label6;
        private MaskedTextBox mskDogumTarihi;
    }
}