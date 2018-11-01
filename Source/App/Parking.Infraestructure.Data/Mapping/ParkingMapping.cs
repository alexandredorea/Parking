using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Infraestructure.Data.Mapping.Base;

namespace Parking.Infraestructure.Data.Mapping
{
    public class ParkingMapping : EntityBaseMapping<Domain.Entities.Parking, string>
    {
        public override void Configure(EntityTypeBuilder<Domain.Entities.Parking> builder)
        {
            //Definição do Nome da Tabela
            builder.ToTable("Estacionamento");

            //Definição das propriedades dos campos no banco de dados
            builder.Property(x => x.Id)
                .HasColumnName("Placa")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.CheckIn)
                .HasColumnName("HoraChegada")
                .IsRequired();

            builder.Property(x => x.CheckOut)
                .HasColumnName("HoraSaida");

            builder.Property(x => x.DurationParking)
                .HasColumnName("Duracao");

            builder.Property(x => x.HoursCharged)
                .HasColumnName("TempoCobrado")
                .HasDefaultValueSql("0");

            builder.Property(x => x.Price)
                .HasColumnName("Preco")
                .HasColumnType("decimal(5, 2)")
                .IsRequired();

            builder.Property(x => x.AmountToPay)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ValorPagamento");

            //Criação do índice
            builder.HasIndex(x => x.Id)
                .HasName("IX_Estacionamento_Placa");

            base.Configure(builder);
        }
    }
}
