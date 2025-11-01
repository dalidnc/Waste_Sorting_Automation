using Atık_Ayrıştırma_Tesisi_Otomasyonu.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atik_Ayrıştırma_Tesisi_Otomasyonu.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Employees> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AtikAyrıştırmaOtomasyonDB;Integrated Security=True;Encrypt=False");

        }
    }
}