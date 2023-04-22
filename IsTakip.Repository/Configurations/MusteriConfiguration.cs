using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Classes.MusteriClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IsTakip.Repository.Configurations
{
    internal class MusteriConfiguration : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            //Musteri -- MusteriSinif
            builder.HasOne(m => m.MusteriSinif)
                .WithMany(ms => ms.Musteriler)
                .OnDelete(DeleteBehavior.NoAction);

            //Musteri -- MusteriKisitlama
            builder.HasOne(m => m.MusteriKisitlama)
                .WithOne(mk => mk.Musteri)
                .HasForeignKey<MusteriKisitlama>(mk => mk.MusteriId)
                .OnDelete(DeleteBehavior.NoAction);

            //Musteri -- MusteriTemsilci
            builder.HasOne(mt => mt.MusteriTemsilcisi)
                .WithMany(m => m.Musteriler)
                .HasForeignKey(m => m.MusteriTemsilcisiId)
                .OnDelete(DeleteBehavior.NoAction);

            //Musteri -- Ajanda
            builder.HasOne(x => x.Ajanda)
                .WithOne(x => x.Musteri)
                .HasForeignKey<Ajanda>(x => x.MusteriId)
                .OnDelete(DeleteBehavior.Cascade);

            //Musteri -- Is
            builder.HasOne(m => m.Is)
                .WithOne(i => i.Musteri)
                .HasForeignKey<Is>(i => i.MusteriId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
