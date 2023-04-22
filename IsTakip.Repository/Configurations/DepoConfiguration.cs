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
    internal class DepoConfiguration : IEntityTypeConfiguration<Depo>
    {
        public void Configure(EntityTypeBuilder<Depo> builder)
        {
            builder.HasOne(d => d.DepoEnvanter)
                .WithOne(d => d.Depo)
                .HasForeignKey<DepoEnvanter>(x => x.DepoId);
        }
    }
}
