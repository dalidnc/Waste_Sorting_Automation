using Atik_Ayrıştırma_Tesisi_Otomasyonu.Data;
using Atık_Ayrıştırma_Tesisi_Otomasyonu.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    public partial class KullanıcıDüzenlemeSayfası : Form
    {
        public KullanıcıDüzenlemeSayfası()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıDüzenlemeSayfası_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var user = context.employees.FirstOrDefault(e => e.Id == id);


                    txtAd.Text = user.Ad;
                    txtSoyad.Text = user.Soyad;
                    txtKullanıcıAd.Text = user.Email;
                    mskTel.Text = user.Telefon;
                    mskTarih.Text = user.UyeOlmaTarihi.ToString("dd.MM.yyyy");
                    mskDogumTarihi.Text = user.DogumTarihi.ToString("dd.MM.yyyy");

              
                    if (user.GorevAlani == rbBakımVeArızaYetk.Text)
                        rbBakımVeArızaYetk.Checked = true;
                    else if (user.GorevAlani == rbGenelYetkiler.Text)
                        rbGenelYetkiler.Checked = true;
                    else if (user.GorevAlani == rbKaliteKontrolYtek.Text)
                        rbKaliteKontrolYtek.Checked = true;
                    else if (user.GorevAlani == rbYonetimVeİdariYetk.Text)
                        rbYonetimVeİdariYetk.Checked = true;
                    else if (user.GorevAlani == rbÜretimVeOtomasyonYetk.Text)
                        rbÜretimVeOtomasyonYetk.Checked = true;

                    MessageBox.Show("Kullanıcı bulundu.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var user = context.employees.FirstOrDefault(e => e.Id == id);

                    if (user != null)
                    {
                        user.Ad = txtAd.Text;
                        user.Soyad = txtSoyad.Text;
                        user.Email = txtKullanıcıAd.Text;
                        user.Telefon = mskTel.Text;


                        if (!string.IsNullOrWhiteSpace(mskTarih.Text))
                        {
                            if (DateTime.TryParseExact(mskTarih.Text, "dd.MM.yyyy", null,
                                System.Globalization.DateTimeStyles.None, out DateTime uyeOlma))
                            {
                                user.UyeOlmaTarihi = uyeOlma;
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(mskDogumTarihi.Text))
                        {
                            if (DateTime.TryParseExact(mskDogumTarihi.Text, "dd.MM.yyyy", null,
                                System.Globalization.DateTimeStyles.None, out DateTime dogum))
                            {
                                user.DogumTarihi = dogum;
                            }
                        }


                        if (rbBakımVeArızaYetk.Checked)
                            user.GorevAlani = rbBakımVeArızaYetk.Text;
                        else if (rbGenelYetkiler.Checked)
                            user.GorevAlani = rbGenelYetkiler.Text;
                        else if (rbKaliteKontrolYtek.Checked)
                            user.GorevAlani = rbKaliteKontrolYtek.Text;
                        else if (rbYonetimVeİdariYetk.Checked)
                            user.GorevAlani = rbYonetimVeİdariYetk.Text;
                        else if (rbÜretimVeOtomasyonYetk.Checked)
                            user.GorevAlani = rbÜretimVeOtomasyonYetk.Text;


                        context.SaveChanges();
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ID giriniz.");
                }
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var user = context.employees.FirstOrDefault(e => e.Id == id);

                    context.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla sistemden silindi");

                }
                else
                {
                    MessageBox.Show("Geçerli bir ID giriniz.");
                }

            }

        }
    }
}
