using IsTakip.Core.Classes.KullaniciClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Repository.Seeds
{
    internal class KullaniciSeed : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(new Kullanici()
            {
                Id = -1,
                Ad = "Admin",
                Soyad = "Admin",
                KullaniciKodu = "4DM1N",
                KullaniciSifre = "123456",
                Aktif = true,
                MailBildirim = false,
                RolTanim = "Yönetici",
                Silindi = false
            });
        }
    }
}
