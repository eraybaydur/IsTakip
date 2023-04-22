using IsTakip.Core.Classes.IsClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IsTakip.Repository.Configurations
{
    internal class IsConfiguration : IEntityTypeConfiguration<Is>
    {
        public void Configure(EntityTypeBuilder<Is> builder)
        {
            //Is -- Musteri
            builder.HasOne(i => i.Musteri)
                .WithOne(m => m.Is)
                .HasForeignKey<Is>(i => i.MusteriId)
                .OnDelete(DeleteBehavior.NoAction);

            //Is -- MalzemeTip
            builder.HasOne(i => i.MalzemeTip)
                .WithOne(m => m.Is)
                .HasForeignKey<Is>(i => i.MalzemeTipId)
                .OnDelete(DeleteBehavior.NoAction);

            //Is -- Kalınlık
            builder.HasOne(i => i.Kalinlik)
                .WithOne(m => m.Is)
                .HasForeignKey<Is>(i => i.KalinlikId)
                .OnDelete(DeleteBehavior.NoAction);

            //Is -- IsDosya
            builder.HasOne(i => i.IsDosya)
                .WithOne(m => m.Is)
                .HasForeignKey<IsDosya>(i => i.IsId)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
