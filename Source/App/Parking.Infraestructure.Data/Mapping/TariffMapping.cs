using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain.Entities;
using Parking.Infraestructure.Data.Mapping.Base;

namespace Parking.Infraestructure.Data.Mapping
{
    public class TariffMapping : EntityBaseMapping<Tariff, int>
    {
        public override void Configure(EntityTypeBuilder<Tariff> builder)
        {
            //Definição do Nome da Tabela
            builder.ToTable("TabelaPrecosVigente");

            //Definição das propriedades dos campos no banco de dados
            builder.Property(x => x.Id)
                .HasColumnName("PrecoId")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.StartEffectiveDate)
                .HasColumnName("InicioVigencia")
                .IsRequired();

            builder.Property(x => x.LastEffectiveDate)
                .HasColumnName("TerminoVigencia")
                .IsRequired();

            builder.Property(x => x.ValueHour)
                .HasColumnName("ValorHora")
                .HasColumnType("decimal(5, 2)")
                .IsRequired();

            builder.Property(x => x.AdditionalValueHour)
                .HasColumnName("ValorHoraAdicional")
                .HasColumnType("decimal(5, 2)")
                .IsRequired();
            
            //Criação do índice
            builder.HasIndex(x => x.Id)
                .HasName("IX_TabelaPrecosVigente_PrecoId")
                .IsUnique();

            base.Configure(builder);
        }
    }
}
