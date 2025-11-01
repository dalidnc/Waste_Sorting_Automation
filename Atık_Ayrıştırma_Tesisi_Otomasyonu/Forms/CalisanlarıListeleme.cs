using Atik_Ayrıştırma_Tesisi_Otomasyonu.Data;
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
    public partial class CalisanlarıListeleme : Form
    {
        public CalisanlarıListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalisanlarıListeleme_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var employees = context.employees
                                       .Select(e => new
                                       {
                                           e.Id,
                                           e.Ad,
                                           e.Soyad,
                                           e.Email,
                                           e.Telefon,
                                           e.DogumTarihi,
                                           e.UyeOlmaTarihi,
                                           e.GorevAlani
                                       })
                                       .ToList();

                dataGridView1.DataSource = employees;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();    
                string Yetkisi = cmbGörevAlanı.Text.Trim();
                if (!string.IsNullOrEmpty(ad))
                {
                    var employees = context.employees
                                           .Where(e => e.Ad.Contains(ad)) // Ad'a göre filtrele
                                           .Select(e => new
                                           {
                                               e.Id,
                                               e.Ad,
                                               e.Soyad,
                                               e.Email,
                                               e.Telefon,
                                               e.DogumTarihi,
                                               e.UyeOlmaTarihi,
                                               e.GorevAlani
                                           })
                                           .ToList();

                    dataGridView1.DataSource = employees;
                }
                else if (!string.IsNullOrEmpty(ad))
                {
                    var employees = context.employees
                                           .Where(e => e.Soyad.Contains(soyad)) 
                                           .Select(e => new
                                           {
                                               e.Id,
                                               e.Ad,
                                               e.Soyad,
                                               e.Email,
                                               e.Telefon,
                                               e.DogumTarihi,
                                               e.UyeOlmaTarihi,
                                               e.GorevAlani
                                           })
                                           .ToList();

                    dataGridView1.DataSource = employees;

                }
                else if(!string.IsNullOrEmpty(Yetkisi))
                {
                    var employees = context.employees
                                          .Where(e => e.GorevAlani.Contains(Yetkisi))
                                          .Select(e => new
                                          {
                                              e.Id,
                                              e.Ad,
                                              e.Soyad,
                                              e.Email,
                                              e.Telefon,
                                              e.DogumTarihi,
                                              e.UyeOlmaTarihi,
                                              e.GorevAlani
                                          })
                                          .ToList();

                    dataGridView1.DataSource = employees;
                }
                




            }


        }

    }
}
