using IsTakip.Core.Classes.DepoClasses;
using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Classes.KullaniciClasses;
using IsTakip.Core.Classes.Mail;
using IsTakip.Core.Classes.MusteriClasses;
using IsTakip.Core.Classes.TedarikciClasses;
using IsTakip.Core.Classes.UretimClasses;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IsTakip.Repository
{
    public class DataContext : DbContext
    {
            
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Depo> Depolar { get; set; }
        public DbSet<DepoRaf> DepoRaflar { get; set; }
        public DbSet<Is> Isler { get; set; }
        public DbSet<IsDosya> IsDosyalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriKisitlama> MusteriKisitlamalar { get; set; }
        public DbSet<MusteriSinif> MusteriSiniflar { get; set; }
        public DbSet<MusteriTemsilcisi> MusteriTemsilciler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<UretimDurus> UretimDuruslar { get; set; }
        public DbSet<DurusTip> DurusTipler { get; set; }
        public DbSet<UretimEmri> UretimEmirler { get; set; }
        public DbSet<MailParametre> MailParametreleri { get; set; }
        public DbSet<DepoEnvanter> DepoEnvanterler { get; set; }
        public DbSet<MalzemeTip> MalzemeTipler { get; set; }
        public DbSet<Kalinlik> Kalinliklar { get; set; }
        public DbSet<Ajanda> Ajandalar { get; set; }


    }
}
