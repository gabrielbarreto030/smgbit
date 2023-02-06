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
    public class TabelaFreteConfiguration : IEntityTypeConfiguration<TabelaFrete>
    {
        public void Configure(EntityTypeBuilder<TabelaFrete> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.NomeTabela).HasMaxLength(200);
            builder.Property(v => v.Cliente).HasMaxLength(200);
            builder.HasData(
                new TabelaFrete(1,"table_1",900,"VUC","CDD Ribeirão Preto"),
                new TabelaFrete(2,"table_2",812,"CARRETA","CDD Ribeirão Preto"),
                new TabelaFrete(3,"table_3",687,"VAN","CDD Ribeirão Preto"),
                new TabelaFrete(4,"table_4",702,"TRUCK","CDD Ribeirão Preto"),
                new TabelaFrete(5,"table_5",702,"TRUCK","CDD São Paulo", "Regiao 2"),
                new TabelaFrete(6,"table_6",698,"TRUCK", "CDD São Paulo", "Regiao 10"),
                new TabelaFrete(7,"table_7",900,"TRUCK", "CDD São Paulo", "Regiao 7"),
                new TabelaFrete(8,"table_8",777,"TRUCK", "CDD São Paulo", "Regiao 3"),
                new TabelaFrete(9,"table_9",532,"VUC", "CDD São Paulo", "Regiao 3"),
                new TabelaFrete(10,"table_10",502,"VUC", "CDD São Paulo", "Regiao 2"),
                new TabelaFrete(11,"table_11",478,"VUC", "CDD São Paulo", "Regiao 10"),
                new TabelaFrete(12,"table_12",690,"VUC", "CDD São Paulo", "Regiao 7"),
                new TabelaFrete(13,"table_13",300,"VAN", "CDD São Paulo", "Regiao 7"),
                new TabelaFrete(14,"table_14",412,"VAN", "CDD São Paulo", "Regiao 2"),
                new TabelaFrete(15,"table_15",400,"VAN", "CDD São Paulo", "Regiao 3"),
                new TabelaFrete(16,"table_16",541,"VAN", "CDD São Paulo","Regiao 10")                
                );
          


      
           



        }
    }
}
