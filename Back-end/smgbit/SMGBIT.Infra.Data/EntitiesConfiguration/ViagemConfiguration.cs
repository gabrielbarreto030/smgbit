using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMGBIT.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Infra.Data.EntitiesConfiguration
{
    public class ViagemConfiguration : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Placa).HasMaxLength(100);
            builder.Property(v => v.Motorista).HasMaxLength(200);
          
          
        }
    }
}
