using Atik_Ayrıştırma_Tesisi_Otomasyonu.Data;
using Atık_Ayrıştırma_Tesisi_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Forms
{
    public partial class RegisterEkranı : Form
    {
        public RegisterEkranı()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var yeniCalisan = new Employees
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = mskMail.Text,
                    Telefon = mskTel.Text,
                    Password=txtSifre.Text,
                    PasswordHash = txtSifreTekrar.Text,
                    DogumTarihi = DateTime.ParseExact(mskDogumTarihi.Text, "dd/MM/yyyy", null),
                    UyeOlmaTarihi = DateTime.Now,
                    GorevAlani = "Belirlenmedi"

                }; 

             
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor, lütfen tekrar deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                context.employees.Add(yeniCalisan);
                context.SaveChanges();

                MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
