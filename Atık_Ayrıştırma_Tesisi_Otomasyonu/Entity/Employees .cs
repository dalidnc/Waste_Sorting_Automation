using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Entity
{
    public class Employees
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool AktifMi { get; set; }
        public DateTime UyeOlmaTarihi { get; set; }
        public string GorevAlani { get; set; }



    }
}
