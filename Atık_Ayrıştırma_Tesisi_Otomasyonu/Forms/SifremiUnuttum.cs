using Atik_Ayrıştırma_Tesisi_Otomasyonu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Forms
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var girisYapan = context.employees
                    .FirstOrDefault(e => e.Email == txtMail.Text);

                if (girisYapan != null)
                {
                    
                    string yeniSifre = Guid.NewGuid().ToString().Substring(0, 8);
                    
                    girisYapan.Password = yeniSifre;

                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential("d.ali34dinc@gmail.com", "ttolgjfdqqpwmalq");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;

                    MailMessage mail = new MailMessage();
                    mail.To.Add(txtMail.Text);
                    mail.From = new MailAddress("d.ali78dinc@gmail.com", "Şifre Yenileme");
                    mail.IsBodyHtml = true;
                    mail.Subject = "Şifre Sıfırlama";
                    mail.Body = $"Merhaba Sayın {girisYapan.Ad} {girisYapan.Soyad}<br/>" +
                                $"Mail Adresiniz: {girisYapan.Email}<br/>" +
                                $"Yeni Şifreniz: <b>{yeniSifre}</b>";

                    try
                    {
                        client.Send(mail);
                        context.SaveChanges();
                        MessageBox.Show("Yeni şifreniz mail adresinize gönderildi!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mail gönderilirken hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bu mail adresine sahip bir kullanıcı bulunamadı!");
                }
            }
        }


    }
}
