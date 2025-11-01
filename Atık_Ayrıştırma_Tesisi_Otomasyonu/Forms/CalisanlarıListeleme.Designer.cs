namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    partial class CalisanlarıListeleme
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            cmbGörevAlanı = new ComboBox();
            txtId = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1216, 443);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 11);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(444, -5);
            label1.Name = "label1";
            label1.Size = new Size(408, 42);
            label1.TabIndex = 2;
            label1.Text = "Atık Ayrıştırma Fabrikası ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(554, 28);
            label2.Name = "label2";
            label2.Size = new Size(195, 34);
            label2.TabIndex = 3;
            label2.Text = "Çalışan Listesi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admin;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Designcontest_Ecommerce_Business_Admin_256;
            pictureBox2.Location = new Point(1110, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(255, 559);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(186, 27);
            txtAd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(192, 560);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 7;
            label3.Text = "Ad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(488, 559);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 8;
            label4.Text = "Soyad : ";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(592, 560);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(186, 27);
            txtSoyad.TabIndex = 9;
            // 
            // cmbGörevAlanı
            // 
            cmbGörevAlanı.FormattingEnabled = true;
            cmbGörevAlanı.Items.AddRange(new object[] { "Bakım ve Arıza Yetkileri" });
            cmbGörevAlanı.Location = new Point(945, 559);
            cmbGörevAlanı.Name = "cmbGörevAlanı";
            cmbGörevAlanı.Size = new Size(141, 28);
            cmbGörevAlanı.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 561);
            txtId.Name = "txtId";
            txtId.Size = new Size(56, 27);
            txtId.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(24, 560);
            label5.Name = "label5";
            label5.Size = new Size(36, 25);
            label5.TabIndex = 12;
            label5.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(812, 560);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 13;
            label6.Text = "Görev Alanı : ";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(0, 0, 192);
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.ForeColor = SystemColors.ButtonHighlight;
            btnAra.Location = new Point(1134, 551);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(74, 42);
            btnAra.TabIndex = 14;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // CalisanlarıListeleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 608);
            Controls.Add(btnAra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(cmbGörevAlanı);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalisanlarıListeleme";
            Text = "Liste";
            Load += CalisanlarıListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtAd;
        private Label label3;
        private Label label4;
        private TextBox txtSoyad;
        private ComboBox cmbGörevAlanı;
        private TextBox txtId;
        private Label label5;
        private Label label6;
        private Button btnAra;
    }
}