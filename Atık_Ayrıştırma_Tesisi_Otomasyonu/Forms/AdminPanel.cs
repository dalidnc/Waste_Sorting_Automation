using Atik_Ayrıştırma_Tesisi_Otomasyonu.Data;
using Atık_Ayrıştırma_Tesisi_Otomasyonu.Entity;
using Atık_Ayrıştırma_Tesisi_Otomasyonu.Forms;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var girisYapan = context.employees
                    .FirstOrDefault(e => e.Email == txtKullanıcıAd.Text
                                      && e.Password == txtSifre.Text);

                if (girisYapan != null)
                {

                    girisYapan.AktifMi = true;
                    context.SaveChanges();

                    FabrikaAşamaları fabrikaAşamaları = new FabrikaAşamaları();

                    fabrikaAşamaları.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            RegisterEkranı registerEkranı = new RegisterEkranı();
            registerEkranı.Show();

        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
