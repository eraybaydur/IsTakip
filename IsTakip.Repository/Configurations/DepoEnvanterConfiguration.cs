using IsTakip.Core.Classes.DepoClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Repository.Configurations
{
    internal class DepoEnvanterConfiguration : IEntityTypeConfiguration<DepoEnvanter>
    {
        public void Configure(EntityTypeBuilder<DepoEnvanter> builder)
        {
            //DepoEnvanter -- DepoRaf

            builder.HasOne(de => de.DepoRaf)
                .WithOne(dr => dr.DepoEnvanter)
                .HasForeignKey<DepoEnvanter>(d => d.DepoRafId)
                .OnDelete(DeleteBehavior.NoAction);

            //DepoEnvanter -- MalzemeTip

            builder.HasOne(de => de.MalzemeTip)
                .WithOne(dr => dr.DepoEnvanter)
                .HasForeignKey<DepoEnvanter>(d => d.MalzemeTipId)
                .OnDelete(DeleteBehavior.NoAction);


            //DepoEnvanter -- Kalınlık
            builder.HasOne(de => de.Kalinlik)
                .WithOne(dr => dr.DepoEnvanter)
                .HasForeignKey<DepoEnvanter>(d => d.KalinlikId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
