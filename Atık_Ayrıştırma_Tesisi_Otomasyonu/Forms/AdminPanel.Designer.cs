namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    partial class AdminPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            label1 = new Label();
            label2 = new Label();
            txtKullanıcıAd = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            BtnGirisYap = new Button();
            checkBox1 = new CheckBox();
            btnUyeOl = new Button();
            linkSifremiUnuttum = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(81, 38);
            label1.Name = "label1";
            label1.Size = new Size(449, 31);
            label1.TabIndex = 0;
            label1.Text = "ATIK AYRIŞTIRMA OTOMASYON SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Siemens AD Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 153);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı 👤 : ";
            // 
            // txtKullanıcıAd
            // 
            txtKullanıcıAd.Location = new Point(195, 151);
            txtKullanıcıAd.Name = "txtKullanıcıAd";
            txtKullanıcıAd.Size = new Size(188, 27);
            txtKullanıcıAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Siemens AD Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 211);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 3;
            label3.Text = "Şifre 🔒             : ";
            label3.Click += label3_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(195, 204);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(188, 27);
            txtSifre.TabIndex = 4;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.Chartreuse;
            BtnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGirisYap.ForeColor = Color.Black;
            BtnGirisYap.Location = new Point(234, 309);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(107, 35);
            BtnGirisYap.TabIndex = 5;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(172, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Blue;
            btnUyeOl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUyeOl.ForeColor = Color.Transparent;
            btnUyeOl.Location = new Point(234, 350);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(107, 35);
            btnUyeOl.TabIndex = 8;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // linkSifremiUnuttum
            // 
            linkSifremiUnuttum.AutoSize = true;
            linkSifremiUnuttum.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSifremiUnuttum.LinkColor = Color.Black;
            linkSifremiUnuttum.Location = new Point(297, 256);
            linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            linkSifremiUnuttum.Size = new Size(122, 17);
            linkSifremiUnuttum.TabIndex = 9;
            linkSifremiUnuttum.TabStop = true;
            linkSifremiUnuttum.Text = "Şifremi Unuttum";
            linkSifremiUnuttum.LinkClicked += linkSifremiUnuttum_LinkClicked;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 477);
            Controls.Add(linkSifremiUnuttum);
            Controls.Add(btnUyeOl);
            Controls.Add(checkBox1);
            Controls.Add(BtnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullanıcıAd);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullanıcıAd;
        private Label label3;
        private TextBox txtSifre;
        private Button BtnGirisYap;
        private CheckBox checkBox1;
        private Button btnUyeOl;
        private LinkLabel linkSifremiUnuttum;
    }
}
